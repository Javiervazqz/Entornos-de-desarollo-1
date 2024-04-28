using System.Security.Cryptography;

namespace PictureSort
{
    public class Archivo
    {
        string path;
        byte[] hashBytes;
        int hashInt;
        byte[] content;
        public int Size => content.Length;
        public static void CopyFiles(string[] directories)
        {
            string targetDirectory = directories[directories.Length - 1];
            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory); // Si el directorio no existe, lo creara
            }
            Dictionary<string, string> copiedFiles = new Dictionary<string, string>();
            for (int i = 0; i < directories.Length - 1; i++)
            {
                string sourceDirectory = directories[i];
                string[] files = Directory.GetFiles(sourceDirectory, "*.*", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    string hash = CalculateSHA256(file);
                    if (copiedFiles.ContainsKey(hash))
                    {
                        Console.WriteLine($"Archivo '{file}' ignorado. Ya existe en el directorio.");
                        continue;
                    }
                    string relativePath = file.Substring(sourceDirectory.Length + 1);
                    string destFile = Path.Combine(targetDirectory, relativePath);
                    Directory.CreateDirectory(Path.GetDirectoryName(destFile));
                    try
                    {
                        File.Copy(file, destFile);
                        Console.WriteLine($"Archivo '{relativePath}' copiado correctamente.");
                        copiedFiles.Add(hash, destFile);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al copiar el archivo '{relativePath}': {ex.Message}");
                    }
                }
            }
        }

        static string CalculateSHA256(string filePath)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    byte[] hashBytes = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
                }
            }
        }
        static bool AreFilesIdentical(string file1, string file2)
        {
            using (var stream1 = File.OpenRead(file1))
            using (var stream2 = File.OpenRead(file2))
            {
                if (stream1.Length != stream2.Length)
                    return false;

                int bufferLength = 4096 * 4096; // 4 MB buffer
                byte[] buffer1 = new byte[bufferLength];
                byte[] buffer2 = new byte[bufferLength];

                while (true)
                {
                    int bytesRead1 = stream1.Read(buffer1, 0, bufferLength);
                    int bytesRead2 = stream2.Read(buffer2, 0, bufferLength);

                    if (bytesRead1 != bytesRead2)
                        return false;

                    if (bytesRead1 == 0)
                        return true;

                    for (int i = 0; i < bytesRead1; i++)
                    {
                        if (buffer1[i] != buffer2[i])
                            return false;
                    }
                }
            }
        }
    }
}

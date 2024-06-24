using System.Security.Cryptography;

namespace NDUPcopy
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static void CopyFile(Archivo archivo, string directorioSalida)
        {
            File.WriteAllBytes(directorioSalida, archivo.bytes);
        }
        static string CalculateSHA256(string filePath)
        {
            using (FileStream stream = File.OpenRead(filePath))
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashBytes = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hashBytes);
                }
            }
        }
        static bool IsFileInDirectory(string directoryPath, string fileNameToFind)
        {
            // Verificar si el archivo está en el directorio actual
            string[] files = Directory.GetFiles(directoryPath, fileNameToFind);
            if (files.Length > 0)
            {
                return true;
            }

            // Verificar en los subdirectorios recursivamente
            string[] subdirectories = Directory.GetDirectories(directoryPath);
            foreach (string subdirectory in subdirectories)
            {
                if (IsFileInDirectory(subdirectory, fileNameToFind))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
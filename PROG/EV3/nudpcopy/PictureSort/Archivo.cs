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
            // El último argumento es el directorio de destino
            string targetDirectory = directories[directories.Length - 1];

            // Si el directorio de destino no existe, lo creamos
            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
            }

            // Diccionario para almacenar los hashes y las rutas de los archivos copiados
            Dictionary<string, string> copiedFiles = new Dictionary<string, string>();

            // Recorremos los directorios de origen
            for (int i = 0; i < directories.Length - 1; i++)
            {
                string sourceDirectory = directories[i];

                // Obtenemos la lista de archivos del directorio de origen y sus subdirectorios
                string[] files = Directory.GetFiles(sourceDirectory, "*.*", SearchOption.AllDirectories);

                // Copiamos cada archivo al directorio de destino
                foreach (string file in files)
                {
                    // Calculamos el hash SHA-256 del archivo
                    string hash = CalculateSHA256(file);

                    // Si el archivo con el mismo hash ya se ha copiado, omitimos la copia
                    if (copiedFiles.ContainsKey(hash))
                    {
                        Console.WriteLine($"Archivo '{file}' ignorado. Ya existe una copia con el mismo hash.");
                        continue;
                    }

                    // Construimos la ruta relativa del archivo de origen
                    string relativePath = file.Substring(sourceDirectory.Length + 1);

                    // Construimos la ruta completa del archivo de destino
                    string destFile = Path.Combine(targetDirectory, relativePath);

                    // Creamos los directorios necesarios en la ruta de destino
                    Directory.CreateDirectory(Path.GetDirectoryName(destFile));

                    try
                    {
                        // Copiamos el archivo
                        File.Copy(file, destFile);
                        Console.WriteLine($"Archivo '{relativePath}' copiado correctamente.");
                        // Añadimos el hash y la ruta del archivo copiado al diccionario
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
    }
}

namespace PictureSort
{
    public class Archivo
    {
        string path;
        byte[] hashBytes;
        int hashInt;
        byte[] content;
        public int Size => content.Length;
    }
}

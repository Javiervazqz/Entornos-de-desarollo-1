namespace TPVLib
{
    public class Product
    {
        public enum Availability
        {
            AVAILABLE,
            NOTAVAILABLEs
        }
        public string name;
        public string description;
        public double precio;
        public int stock;
        public long id;
        public double IVA;
        public Availability availability;
    }
}

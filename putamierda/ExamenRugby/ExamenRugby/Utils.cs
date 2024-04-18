namespace ExamenRugby
{
    public class Utils
    {
        Random r;
        public double GenerateDouble()
        {
            r = new Random();
            return r.NextDouble();
        }
        public int GenerateIntBetween(int v1, int v2)
        {
            r = new Random();
            return r.Next(v1, v2);
        }
    }
}

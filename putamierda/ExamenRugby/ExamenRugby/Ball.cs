namespace ExamenRugby
{
    public class Ball
    {
        public int x {  get; set; }
        public int y { get; set; }
        public void RandomPosition()
        {
            Utils utils = new Utils();
            x = utils.GenerateIntBetween(1, 11);
            y = utils.GenerateIntBetween(1, 21);
        }
    }
}

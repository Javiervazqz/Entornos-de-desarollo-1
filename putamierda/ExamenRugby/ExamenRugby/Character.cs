namespace ExamenRugby
{
    public class Character
    {
        public int x { get; set; }
        public int y { get; set; }
        public bool HasBall { get; set; }
        public string? Team { get; set; }
        public string? Name { get; set; }
        public double Skill { get; set; }
        public Utils utils;
        public Team team;
        public Character(string equipo, string nombre)
        {
            Team = equipo;
            Name = nombre;
        }
        public virtual void ExecuteAction(Game game, Ball ball)
        {

        }
    }
}

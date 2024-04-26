namespace ExamenRugby
{
    public class Defense : Character
    {
        public Defense(string equipo, string nombre) : base(equipo, nombre)
        {
        }
        public override void ExecuteAction(Game game, Ball ball)
        {
            List<Character> list = game.characters;
            List<Character> allies = new List<Character>();
            for (int i = 0; i < list.Count; i++)
            {
                if (this.team == list[i].team)
                {
                    allies.Add(list[i]);
                }
            }
            if (HasBall)
            {
                utils = new Utils();
                double decision = utils.GenerateDouble();
                if (decision <= 0.50) //moverse
                {
                    (int v1, int v2) targetBox = (utils.GenerateIntBetween(0, 2), utils.GenerateIntBetween(0, 2));
                    bool validBox = true;
                    foreach (Character character in allies)
                    {
                        if (character.x == targetBox.v1 && character.y == targetBox.v2)
                        {
                            validBox = false;
                        }
                    }
                    if (validBox)
                    {
                        this.x = targetBox.v1;
                        this.y = targetBox.v2;
                    }
                }
                else //pasar
                {
                    Character passTarget = allies[utils.GenerateIntBetween(0, allies.Count)];
                    bool missedPass = true;
                    double value = utils.GenerateDouble();
                    if (0.20 <= value || value <= 0.80) //consigue pasar y se recibe el pase
                    {
                        missedPass = false;
                        this.HasBall = false;
                        passTarget.HasBall = true;
                    }
                    else //falla el pase
                    {
                        int x = passTarget.x;
                        int y = passTarget.y;
                        ball.x = utils.GenerateIntBetween(x, x + 2);
                        ball.y = utils.GenerateIntBetween(y, y + 2);
                    }
                }
            }
        }
    }
}

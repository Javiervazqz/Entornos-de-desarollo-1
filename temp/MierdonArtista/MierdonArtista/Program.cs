using UDK;

namespace MierdonArtista
{
    internal class Program
    {
        public class Character
        {
            public double x;
            public double y;
            public double velocity = 0.005;
            public double red = utils.GetRandom();
            public double green = utils.GetRandom();
            public double blue = utils.GetRandom();
        }

        public class MyGame : UDK.IGameDelegate
        {
            List<Character> l;
            
            public void OnLoad(GameDelegateEvent gameEvent)
            {
               l = new List<Character>();
            }

            public void OnAnimate(GameDelegateEvent gameEvent)
            {
                pj1.x = pj1.x + utils.GetRandomized(-0.01, 0.01);
                pj1.x = pj1.x - utils.GetRandomized(-0.01, 0.01);
                pj1.y = pj1.y + utils.GetRandomized(-0.01, 0.01);
                pj1.y = pj1.y - utils.GetRandomized(-0.01, 0.01);
            }

            public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
            {
                canvas.Clear(0, 0, 0, 0);
                canvas.Camera.SetRectangle(0, 0, 10, 10);
                canvas.FillShader.SetColor(red, green, blue, 1);
                canvas.DrawRectangle(0, 1, 2, 2);
            }

            public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
            {
                if (keyboard.IsKeyDown(Keys.W))
                    pj1.y = pj1.y + pj1.velocity;
                if (keyboard.IsKeyDown(Keys.D))
                    pj1.x = pj1.x + pj1.velocity;
                if (keyboard.IsKeyDown(Keys.A))
                    pj1.x = pj1.x - pj1.velocity;
                if (keyboard.IsKeyDown(Keys.S))
                    pj1.y = pj1.y - pj1.velocity;
            }

            public void OnUnload(GameDelegateEvent gameEvent)
            {
            }
            
        }
        static void Main(string[] args)
        {
            MyGame game = new MyGame();
            UDK.Game.Launch(game);
        }
    }
}
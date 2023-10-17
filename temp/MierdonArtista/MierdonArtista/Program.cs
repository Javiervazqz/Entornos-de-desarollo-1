using UDK;

namespace MierdonArtista
{
    internal class Program
    {
        public class MyGame : UDK.IGameDelegate
        {
            double u = 0;
            public void OnLoad(GameDelegateEvent gameEvent)
            {
            }

            public void OnAnimate(GameDelegateEvent gameEvent)
            {
            }

            public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
            {
                canvas.Clear(0, 0, 0, 0);
                canvas.Camera.SetRectangle(0, 0, 10, 10);
                canvas.FillShader.SetColor(1, 0, 1, 1);
                canvas.DrawRectangle(1, 1, 2, 2);
            }

            public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
            {
            }

            public void OnUnload(GameDelegateEvent gameEvent)
            {
            }
            
        }
        public class Character
        {

        }
        static void Main(string[] args)
        {
            MyGame game = new MyGame();
            UDK.Game.Launch(game);
        }
    }
}
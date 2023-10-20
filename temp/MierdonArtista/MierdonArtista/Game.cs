using UDK;

namespace MierdonArtista
{
    internal class Game
    {
        public class MyGame : UDK.IGameDelegate
        {
            public void OnLoad(GameDelegateEvent gameEvent)
            {
                world world1;
                world1 = new world();
            }

            public void OnAnimate(GameDelegateEvent gameEvent)
            {

            }
            public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
            {
                canvas.Clear(0, 0, 0, 0);
                canvas.Camera.SetRectangle(0, 0, 10, 10);
                canvas.FillShader.SetColor(1, 0, 1, 1);
                canvas.DrawRectangle(0, 1, 2, 2);
            }

            public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
            {
                
            }

            public void OnUnload(GameDelegateEvent gameEvent)
            {

            }
        }
    }
}
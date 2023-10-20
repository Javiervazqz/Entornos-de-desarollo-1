using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDK;

namespace MierdonArtista
{

    public class world
    {
        double width;
        double height;
        private List<Character> l;
        public void Draw(ICanvas canvas)
        {
            canvas.Clear(0, 0, 0, 0);
            canvas.Camera.SetRectangle(0, 0, 10, 10);
            canvas.FillShader.SetColor(1, 0, 1, 1);
            canvas.DrawRectangle(0, 1, 2, 2);
        }
        public List<Character> CreatePJ()
        {
            l = new List<Character>();
            for (int i = 0; i < 200; i++)
            {
                Character p;
                l.Add(p);
                p.red = utils.GetRandomized(0.0, 1.0);
                p.green = utils.GetRandomized(0.0, 1.0);
                p.blue = utils.GetRandomized(0.0, 1.0);
                p.alpha= 1.0;
    }
            return l;
        }
        public int GetCharacterCount()
        {
            return l.Count;
        }
        public Character? GetCharacterAt(int n1)
        {
            if (n1 < 0 || n1 >= l.Count)
                return null;
            return l[n1];
        }
        public void Movement(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse, Character p)
        {
            if (keyboard.IsKeyDown(Keys.W))
                p.y = p.y + p.velocity;
            if (keyboard.IsKeyDown(Keys.D))
                p.x = p.x + p.velocity;
            if (keyboard.IsKeyDown(Keys.A))
                p.x = p.x - p.velocity;
            if (keyboard.IsKeyDown(Keys.S))
                p.y = p.y - p.velocity;
        }
        public void Animate(GameDelegateEvent gameEvent, Character p)
        {
            p.x = p.x + utils.GetRandomized(-0.01, 0.01);
            p.x = p.x - utils.GetRandomized(-0.01, 0.01);
            p.y = p.y + utils.GetRandomized(-0.01, 0.01);
            p.y = p.y - utils.GetRandomized(-0.01, 0.01);
        }
    }
}

using System.Diagnostics;

namespace Objetos_y_todo_eso
{
    internal class Class1
    {
        public enum ColorType
        {
            blue,
            white,
            black
        }
        public class Dolphin
        {
            public double size;
            public double hp;
            public string name;
            public ColorType color;
            public double maxhp;
            public void sethp(double hp)
            {
                this.hp = hp;
            }
            public double GetHpPercent()
            {
                return ((hp / maxhp) * 100);
            }
            public bool IsAlive()
            {
                if ( hp > 0 )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

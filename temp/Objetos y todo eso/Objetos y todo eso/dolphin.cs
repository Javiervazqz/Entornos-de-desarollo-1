using System.Diagnostics;

namespace Objetos
{
    public enum ColorType
    {
        blue,
        white,
        black,
        red,
        gold
    }
    internal class Class1
    {
        public class Dolphin
        {
            public double size;
            private double hp = 100.0;
            public string name;
            public ColorType color;
            public double maxhp;
            public Dolphin(double currentHp, double maximumHp)
            {
                hp = currentHp;
                maxhp = maximumHp;
            }
            public void SetHp(double hp)
            {
                this.hp = hp;
            }
            public double GetHp()
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

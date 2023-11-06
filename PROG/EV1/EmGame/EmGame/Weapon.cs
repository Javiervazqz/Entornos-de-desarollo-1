using System;

namespace EmGame
{
    public enum WeaponType
    {
        FIST,
        SWORD,
        BOW,
        DAGGERS
    }
    public class Weapon
    {
        WeaponType weapon;
        public WeaponType GetType()
        {
            return weapon;
        }
        public int GetDamage()
        {
            if (weapon == WeaponType.FIST)
                return 10;
            if (weapon == WeaponType.SWORD)
                return 50;
            if (weapon == WeaponType.BOW)
                return 40;
            return 20;
        }
        public double GetCD()
        {
            if (weapon == WeaponType.FIST)
                return 1;
            if (weapon == WeaponType.SWORD)
                return 1.5;
            if (weapon == WeaponType.BOW)
                return 3.5;
            return 0.5;
        }
    }
}

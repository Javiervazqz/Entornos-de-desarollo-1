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
        int _damage;
        double _cd;
        int _range;
        WeaponType weapon;
        public WeaponType GetType()
        {
            return weapon;
        }
        public int GetDamage()
        {
            if (weapon == WeaponType.FIST)
                return _damage = 10;
            if (weapon == WeaponType.SWORD)
                return _damage = 50;
            if (weapon == WeaponType.BOW)
                return _damage = 40;
            else
                return _damage = 20;
        }
        public double GetCD()
        {
            if (weapon == WeaponType.FIST)
                return _cd = 1;
            if (weapon == WeaponType.SWORD)
                return _cd = 1.5;
            if (weapon == WeaponType.BOW)
                return _cd = 3.5;
            else
                return _cd = 0.5;
        }
        public int GetRange()
        {
            if (weapon == WeaponType.FIST)
                return _range = 1;
            if (weapon == WeaponType.SWORD)
                return _range = 5;
            if (weapon == WeaponType.BOW)
                return _range = 10;
            else
                return _range = 2;
        }
    }
}

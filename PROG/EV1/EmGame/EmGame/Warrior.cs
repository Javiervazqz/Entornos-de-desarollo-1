using System;

namespace EmGame
{
    public enum Faction
    {
        HUMAN,
        DWARF,
        ORC,
        ELF,
        TIE
    }
    public class Warrior
    {
        int _x;
        int _y;
        int _hp = 100;
        double _accuracy = utils.GetRandom(0,1);
        int _armor = 50;
        Faction _faction;
        WeaponType _weapon = WeaponType.DAGGERS;
        public Faction GetFaction(Warrior w)
        {
            return w._faction;
        }
        public int GetX()
        {
            return _x;
        }
        public int GetY()
        {
            return _y;
        }
        public int GetArmor()
        {
            return _armor;
        }
        public double GetAcc()
        {
            return _accuracy;
        }
        public int GetHP()
        {
            return _hp;
        }
        public int SetX(int n1)
        {
            return _x = n1;
        }
        public int SetY(int n1)
        {
            return _y = n1;
        }
        public int SetArmor(int n1)
        {
            return _armor = n1;
        }
        public double SetAcc(int n1)
        {
            return _accuracy = n1;
        }
        public int SetHP(int n1)
        {
            return _hp = n1;
        }
    }
    public void ExecuteTurn(Warzone wz)
    {

    }
}

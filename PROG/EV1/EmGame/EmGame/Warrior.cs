using System;

namespace EmGame
{
    public enum Faction
    {
        HUMAN,
        DWARF,
        ORC,
        ELF
    }
    public class Warrior
    {
        int x, y;
        int hp = 100;
        double accuracy;
        int armor = 50;
        Faction faction;
    }
}

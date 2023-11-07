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
        public int _x;
        public int _y;
        int hp = 100;
        double accuracy;
        int armor = 50;
        public Faction faction;
    }
    public Faction GetFaction(Warrior warrior)
    {
        return warrior.faction;
    }
    public Warrior ExecuteTurn(Warzone)
    {

    }
}

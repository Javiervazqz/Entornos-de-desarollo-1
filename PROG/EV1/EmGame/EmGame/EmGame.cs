using System;

namespace EmGame
{
    public class EmGame
    {
        public void Start()
        {

        }
        public Faction GetWinner()
        {
            if (Warzone.GetWarriors(Faction.HUMAN) > 0)
                return Faction.HUMAN;
            if (Warzone.GetWarriors(Faction.DWARF) > 0)
                return Faction.DWARF;
            if (Warzone.GetWarriors(Faction.ORC) > 0)
                return Faction.ORC;
            return Faction.ELF;
        }
    }
}

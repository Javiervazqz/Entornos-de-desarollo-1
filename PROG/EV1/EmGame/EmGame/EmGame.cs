using System;

namespace EmGame
{
    public class EmGame
    {
        public void Start()
        {

        }
        public Faction GetWinner(Warzone wz)
        {
            if (wz.GetWarriorCount(Faction.HUMAN) > 0)
                return Faction.HUMAN;
            if (wz.GetWarriorCount(Faction.DWARF) > 0)
                return Faction.DWARF;
            if (wz.GetWarriorCount(Faction.ORC) > 0)
                return Faction.ORC;
            return Faction.ELF;
        }
    }
}

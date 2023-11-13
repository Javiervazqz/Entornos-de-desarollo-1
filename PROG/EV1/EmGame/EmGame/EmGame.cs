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
            int humancount = 0, dwarfcount = 0, orccount = 0, elfcount = 0;
            for (int i = 0; i <= wz.warriorlist.Count - 1; i++)
            {
                Warrior warrior = wz.warriorlist[i];
                if (warrior.GetFaction() == Faction.HUMAN)
                    humancount++;
                if (warrior.GetFaction() == Faction.DWARF)
                    dwarfcount++;
                if (warrior.GetFaction() == Faction.ORC)
                    orccount++;
                else
                    elfcount++;
            }
            int winint = utils.MinorThanFour(humancount, dwarfcount, orccount, elfcount);
            if (winint == humancount)
                return Faction.HUMAN;
            if (winint == dwarfcount)
                return Faction.DWARF;
            if (winint == orccount)
                return Faction.ORC;
            if (winint == elfcount)
                return Faction.ELF;
            else
                return Faction.TIE;
        }
    }
}

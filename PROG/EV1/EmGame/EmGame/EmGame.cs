using System;

namespace EmGame
{
    public class EmGame
    {
        public void Start()
        {

        }
        public Faction GetWinner(Warzone wz, Warrior w)
        {
            int humancount = 0, dwarfcount = 0, orccount = 0, elfcount = 0;
            for (int i = 0; i <= wz.warriorlist.Count - 1; i++)
            {
                if (w.GetFaction(wz.warriorlist[i]) == Faction.HUMAN)
                    humancount++;
                if (w.GetFaction(wz.warriorlist[i]) == Faction.DWARF)
                    dwarfcount++;
                if (w.GetFaction(wz.warriorlist[i]) == Faction.ORC)
                    orccount++;
                else
                    elfcount++;
            }
            int winint = utils.GreaterThanFour(humancount, dwarfcount, orccount, elfcount);
            if (winint == humancount)
                return Faction.HUMAN;
            if (winint == dwarfcount)
                return Faction.DWARF;
            if (winint == orccount)
                return Faction.ORC;
            else
                return Faction.ELF;
        }
    }
}

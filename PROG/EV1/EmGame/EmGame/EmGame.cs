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
            int winner = utils.GreaterThanFour(humancount, dwarfcount, orccount, elfcount);
            if (winner == humancount)
                return Faction.HUMAN;
            if (winner == dwarfcount)
                return Faction.DWARF;
            if (winner == orccount)
                return Faction.ORC;
            else
                return Faction.ELF;
        }
    }
}

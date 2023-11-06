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
            if (GetWarriors(Faction.HUMAN) > 0)
                return Faction.HUMAN;
            if (GetWarriors(Faction.DWARF) > 0)
                return Faction.DWARF;
            if (GetWarriors(Faction.ORC) > 0)
                return Faction.ORC;
            return Faction.ELF;


        }
        public int GetWarriors(Faction team, List<Warrior> HumanWarriors, List<Warrior> DwarfWarriors, List<Warrior> OrcWarriors, List<Warrior> ElfWarriors)
        {
            if (team == Faction.HUMAN)
                return HumanWarriors.Count();
            if (team == Faction.DWARF)
                return DwarfWarriors.Count();
            if (team == Faction.ORC)
                return OrcWarriors.Count();
            return ElfWarriors.Count();
        }
    }
}

using System;

namespace EmGame
{
    public class Warzone
    {
        public List<Warrior> HumanWarriors = new List<Warrior>();
        public List<Warrior> DwarfWarriors = new List<Warrior>();
        public List<Warrior> OrcWarriors = new List<Warrior>();
        public List<Warrior> ElfWarriors = new List<Warrior>();
        int width, height;
        public void CreateWarrior(int count, Faction team)
        {
            for (int i = 0; i < count; i++)
            {
                if (team == Faction.HUMAN)
                    HumanWarriors.Add(new Warrior());
                if (team == Faction.DWARF)
                    DwarfWarriors.Add(new Warrior());
                if (team == Faction.ORC)
                    OrcWarriors.Add(new Warrior());
                ElfWarriors.Add(new Warrior());
            }
        }
        public int GetWarriors(Faction team)
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

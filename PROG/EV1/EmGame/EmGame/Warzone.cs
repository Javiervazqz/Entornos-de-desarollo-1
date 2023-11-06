using System;

namespace EmGame
{
    public class Warzone
    {
        int width, height;
        public void CreateWarrior(int count, Faction team, List<Warrior> HumanWarriors, List<Warrior> DwarfWarriors, List<Warrior> OrcWarriors, List<Warrior> ElfWarriors)
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
    }
}

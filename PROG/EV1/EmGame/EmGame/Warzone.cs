using System;
using System.Reflection.Metadata.Ecma335;

namespace EmGame
{
    public class Warzone
    {
        private List<Warrior> HumanWarriors = new List<Warrior>();
        private List<Warrior> DwarfWarriors = new List<Warrior>();
        private List<Warrior> OrcWarriors = new List<Warrior>();
        private List<Warrior> ElfWarriors = new List<Warrior>();
        int width = 10, height = 10;
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
        public int GetWarriorCount(Faction team)
        {
            if (team == Faction.HUMAN)
                return HumanWarriors.Count();
            if (team == Faction.DWARF)
                return DwarfWarriors.Count();
            if (team == Faction.ORC)
                return OrcWarriors.Count();
            return ElfWarriors.Count();
        }
        public Warrior? GetWarriorAt(int x, int y, Warrior warrior)
        {
            if (warrior._x == x && warrior._y == y)
                return warrior;
            return null;
        }
        public static double GetDistance(Warrior w1, Warrior w2)
        {
            return GetDistance(w1._x, w1._y, w2._x,w2._y);
        }
        public static double GetDistance (int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;
            return Math.Sqrt((dx * dx) + (dy * dy));
        }
        public ExecuteRound()
        {
            for (int i = 0, i < )
            ExecuteTurn()
        }
    }
}

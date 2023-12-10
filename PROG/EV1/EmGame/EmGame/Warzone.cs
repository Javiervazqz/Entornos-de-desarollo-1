using System;

namespace EmGame
{
    public class Warzone
    {
        public List<Warrior> warriorlist = new List<Warrior>();
        int width = 10, height = 10;
        public void CreateWarrior(int limit)
        {
            for (int i = 0; i <= limit; i++)
            {
                warriorlist.Add(new Warrior());
            }
        }
        public int GetWarriorCount(Faction faction)
        {
            int count = 0;
            for (int i = 0; i <= warriorlist.Count - 1; i++)
            {
                Warrior w = warriorlist[i];
                if (w.GetFaction() == faction)
                    count++;
            }
            return count;
        }
        // Javi: Mal nombre, mal return
        public Warrior? GetWarriorAt(int x, int y, Warrior warrior)
        {
            if (warrior.GetX() == x && warrior.GetY() == y)
                return warrior;
            return null;
        }
        public static double GetDistance(Warrior w1, Warrior w2)
        {
            return GetDistance(w1.GetX(), w1.GetY(), w2.GetX(), w2.GetY());
        }
        public static double GetDistance(int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;
            return Math.Sqrt((dx * dx) + (dy * dy));
        }
        public void Attack(Warrior attacker, Warrior receiver, Weapon weapon)
        {
            receiver.SetHP(receiver.GetHP() - weapon.GetDamage(weapon.GetWeaponType()));
        }
        public int GetEnemiesAroundCount(Warrior warrior)
        {

        }
        public void ExecuteRound()
        {
            for (int i = 0; i < warriorlist.Count; i++)
            {
                warriorlist[i].ExecuteTurn();
            }
        }
    }
}

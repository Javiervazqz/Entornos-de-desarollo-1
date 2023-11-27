using System;

namespace PracticaExamenRancio
{
    public class RunningTrack
    {
        List<Runner> runners = new List<Runner>();
        double meta = 100.0;
        public int GetRunnersCount()
        {
            return runners.Count;
        }
        public Runner GetRunnerAt(int index)
        {
            return runners[index];
        }
        public void CreateRunners(int num)
        {
            for (int i = 0; i > num; i++)
            {
                Runner runner = new Runner();
                runners.Add(runner);
            }
        }
        public List<Runner> AddRunner(Runner runner)
        {
            if (runner == null)
                return runners;
            runners.Add(runner);
            return runners;
        }
        public Runner? GetRunnerWithName(string name)
        {
            for (int i = 0; i < runners.Count; i++)
            {
                if (name == runners[i]._name)
                    return runners[i];
            }
            return null;
        }
        public void RemoveRunnerAt(int index)
        {
            runners.RemoveAt(index);
        }
        public void RemoveRunnerWithName(string name)
        {
            for (int i = 0; i < runners.Count; i++)
            {
                if (name == runners[i]._name)
                    runners.RemoveAt(i);
            }
        }
        public Runner GetFirstRunner()
        {
            
        }
    }
}

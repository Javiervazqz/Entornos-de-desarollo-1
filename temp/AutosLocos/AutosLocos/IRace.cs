using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocos
{
    public interface IRace
    {
        public void AddObject(RaceObject obj, double position);
        public void Init(double distance);
        public void SimulateStep();
        public void VisitDrivers();
        public void VisitCars();
        public void VisitObstacles();
        public void VisitObjects();
        public int GetObjectCount();
        public Object GetObjectAt(int index);
    }
}

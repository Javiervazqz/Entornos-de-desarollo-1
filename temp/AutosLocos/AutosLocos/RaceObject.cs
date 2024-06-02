using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocos
{
    public abstract class RaceObject
    {
        string _name;
        double _position;
        int _disabledTurns;
        bool _isDisabled;

        public string Name => _name;
        public double Position => _position;
        public abstract bool IsAlive { get; set; }

        public abstract Object GetObjectType();
        public void Disable(int turns)
        {
            _disabledTurns += turns;
        }
        public virtual void Simulate(IRace race)
        {

        }
    }
}

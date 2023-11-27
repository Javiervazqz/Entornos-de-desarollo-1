using System;

namespace PracticaExamenRancio
{
    public class Runner
    {
        public enum Team
        {
            US,
            ESP
        }
        double _speed = utils.GetRandomDouble();
        int _age = 19;
        string _name = "Jose Mari";
        int _bibnumber = utils.GetRandomInt(0, 8);
        double _position;
        double _x;
        public double GetPosition()
        {
            return _position;
        }
        public void SetPosition(double value)
        {
            _position = value;
        }
        public double GetSpeed()
        {
            return _speed;
        }
        public void Step(Runner runner)
        {
            SetPosition(_position + (GetSpeed() * utils.GetRandomInt(0, 10)));
        }
        public void Simulate()
        {

        }
    }
}

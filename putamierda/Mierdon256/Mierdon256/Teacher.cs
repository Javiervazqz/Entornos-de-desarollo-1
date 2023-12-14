using System;

namespace Mierdon256
{
    public class Teacher : Person, IPerro
    {
        public double bloodlust;
        public Teacher(double bloodlust)
        {
            this.bloodlust = bloodlust;
        }
        public Teacher(string name, double bloodlust) : base(name, Gender.OTHER)
        {
            this.Name = name;
            this.bloodlust = bloodlust;
            this.gender = Gender.OTHER;
        }
        public Teacher()
        {

        }
        public override string GetFullName()
        {
            return "<PROFESOR>" + Name + "</PROFESOR>";
        }
        public override void ExecuteTurn()
        {
        }
    }
}

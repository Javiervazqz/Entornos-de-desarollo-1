using System;

namespace Mierdon256
{
    public class Teacher : Person
    {
        public double bloodlust;
        public Teacher(double bloodlust)
        {
            this.bloodlust = bloodlust;
        }
        public Teacher(string name, double bloodlust) : base(name, Gender.OTHER)
        {
            this.name = name;
            this.bloodlust = bloodlust;
            this.gender = Gender.OTHER;
        }
        public Teacher()
        {

        }
    }
}

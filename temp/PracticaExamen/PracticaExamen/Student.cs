using System;

namespace PracticaExamen
{
    public enum Gender
    {
        MALE,
        FEMALE, 
        OTHER
    }
    public class Student
    {
        private string _name;
        private double _ageMonth;
        private double _heightCm;
        private double _weightKg;
        private List<Grades> _grades = new List<Grades>();
        public Student()
        {

        }
        public Student(string nombre, double edad)
        {
            _name = nombre;
            _ageMonth = edad;
        }
        public double GetIMC()
        {
            if (_weightKg < 0 || _heightCm < 0)
                return -1;
            return _weightKg / (_heightCm * 2);
        }
        public double GetMedia()
        {
            double result;
            for (int i = 0; i < _grades.Count; i++)
            {
                
            }
        }
        public string GetName() => _name;
    }
}

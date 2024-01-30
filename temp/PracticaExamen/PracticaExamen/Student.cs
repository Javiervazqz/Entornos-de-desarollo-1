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
        private Grades _notas;
        public string GetName() => _name;
        public Student()
        {

        }
        public Student(string nombre, double edad)
        {
            _name = nombre;
            _ageMonth = edad;
        }
        public Grades GetGrades => _notas;
        public double GetIMC()
        {
            if (_weightKg < 0 || _heightCm < 0)
                return -1;
            return _weightKg / (_heightCm * 2);
        }
        public double GetMedia()
        {
            double res = 0.0;
            int count = 0;
            List<Signature> notas = _notas.GetList();
            for (int i = 0; i < notas.Count; i++, count++)
            {
                res = res + notas[i].GetMark();
            }
            return res/count;
        }
        public bool IsLegalAge() => _ageMonth >= 216;
        public void Clone(Student student)
        {
            student = new Student();
            student._name = _name;
            student._ageMonth = _ageMonth;
            student._weightKg = _weightKg;
            student._heightCm = _heightCm;
            student._notas.Equals(_notas);
        }
    }
}

using System;

namespace PracticaExamen
{
    public class Grades
    {
        private List<Signature> _grades;
        public Grades()
        {
            _grades = new List<Signature>();
        }
        public int ListCount => _grades.Count();
        public List<Signature> GetList() => _grades;
        public double GetQualificationForSignature(Signature asignatura)
        {
            for (int i = 0; i < ListCount; i++)
            {
                if (asignatura.GetSignature() == _grades[i].GetSignature())
                    return asignatura.GetMark();
            }
            return -1;
        }
        public void SetQualificationForSignature(Signature asignatura, double nota)
        {
            for (int i = 0; i < ListCount; i++)
            {
                if (asignatura.GetSignature() == _grades[i].GetSignature())
                    _grades[i].SetMark(nota);
            }
        }
        public double GetTotalMedia()
        {
            double res = 0.0;
            for (int i = 0; i < ListCount; i++)
            {
                res = res + _grades[i].GetMark();
            }
            return res;
        }
        public Signature GetHighestMarkSignature()
        {
            Signature highest = new Signature();
            for (int i = 1; i < ListCount; i++)
            {
                double v1 = _grades[i - 1].GetMark();
                double v2 = _grades[i].GetMark();
                if (v1 >= v2)
                    highest = _grades[i - 1];
                else
                    highest = _grades[i];
            }
            return highest;
        }
        public Signature GetLowestMarkSignature()
        {
            Signature lowest = new Signature();
            for (int i = 1; i < ListCount; i++)
            {
                double v1 = _grades[i - 1].GetMark();
                double v2 = _grades[i].GetMark();
                if (v1 <= v2)
                    lowest = _grades[i - 1];
                else
                    lowest = _grades[i];
            }
            return lowest;
        }
        public double GetLowestMark()
        {
            double res = 0.0;
            for (int i = 0; i < ListCount; i++)
            {
                double v1 = _grades[i - 1].GetMark();
                double v2 = _grades[i].GetMark();
                if (v1 <= v2)
                    res = v1;
                else
                    res = v2;
            }
            return res;
        }
        public double GetHighestMark()
        {
            double res = 0.0;
            for (int i = 0; i < ListCount; i++)
            {
                double v1 = _grades[i - 1].GetMark();
                double v2 = _grades[i].GetMark();
                if (v1 >= v2)
                    res = v1;
                else
                    res = v2;
            }
            return res;
        }
    }
}
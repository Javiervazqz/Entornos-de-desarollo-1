using System;
using System.Reflection.Metadata;

namespace PracticaExamen
{
    public class Grades
    {
        private Signature _grades;
        public Grades()
        {
            _grades = new Signature();
        }
        public double GetQualificationForSignature(Signature asignatura)
        {
            for (int i = 0; i < asignatura.GetSignatureCount(); i++)
            {
                if (asignatura.GetSignature() == _grades.GetSignature())
                    return _grades.GetMark();
            }
            return -1;
        }
    }
}

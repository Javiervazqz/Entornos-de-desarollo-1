using System;

namespace PracticaExamen
{
    public enum Notes
    {
        MATH,
        SCIENCE,
        HISTORY,
        LANGUAGE
    }
    public class Grades
    {
        private List<double> _grades = new List<double>();
        private double mathGrade;
        private double scienceGrade;
        private double historyGrade;
        private double languageGrade;
        public List<double> GetList() => _grades;
        public Grades()
        {

        }
        public double GetQualificationForSignature()
        {

        }
    }
}

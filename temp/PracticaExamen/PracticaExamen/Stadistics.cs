using System;

namespace PracticaExamen
{
    public class Stadistics
    {
        public double GetAverageIMC(Classroom clase)
        {
            List<Student> students = clase.GetList();
            double res = 0.0;
            int count = 0;
            for (int i = 0; i < students.Count; i++, count++)
            {
                res = res + students[i].GetIMC();
            }
            return res/count;
        }
        public Student GetBestStudent(Classroom clase, Signature asignatura)
        {
            List<Student> students = clase.GetList();
            Student bestStudent = new Student();
            for (int i = 0; i < students.Count; i++)
            {
                Student std = students[i];
                for (int j = 0; j < std.GetGrades.ListCount; j++)
                {
                    if (std.GetGrades.GetList()[j] == asignatura)

                }
            }
            return bestStudent;
        }
    }
}

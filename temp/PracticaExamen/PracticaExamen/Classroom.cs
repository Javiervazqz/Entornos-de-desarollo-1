using System;

namespace PracticaExamen
{
    public class Classroom
    {
        private List<Student> _students;
        private string _name;
        public Classroom()
        {
            _students = new List<Student>();
        }
        public Classroom(List<Student> lista)
        {
            _students = lista;
        }
        public List<Student> GetList() => _students;
        public string GetName() => _name;
        public void SetName(string value) => _name = value;
        public void AddStudent(Student std)
        {
            _students.Add(std);
        }
        public void RemoveStudentAt(int index)
        {
            _students.RemoveAt(index);
        }
        public bool ContainsStudentWithName(string nombre)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (nombre == _students[i].GetName())
                    return true;
            }
            return false;
        }
        public void RemoveStudentsWithName(string nombre)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (nombre == _students[i].GetName())
                    RemoveStudentAt(i);
            }
        }
    }
}

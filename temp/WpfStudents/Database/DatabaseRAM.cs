namespace Database
{
    public class DatabaseRAM : IDatabase
    {
        List<Student> _students = new List<Student>();
        public int Count => _students.Count;
        public long AddStudent(Student student)
        {
            if (student == null)
                return -1; // Id cannot be less than zero
            _students.Add(student);
            return student.Id;
        }

        public Student GetStudentAt(int index)
        {
            if (index < 0 || index >= Count)
                return default;
            return _students[index];
        }

        public Student GetStudentWithId(long id)
        {
            if (id < 0)
                return default;
            for(int i = 0; i < Count; i++)
            {
                if (_students[i].Id == id)
                    return _students[i];
            }
            return default;
        }

        public void RemoveStudent(Student student)
        {
            RemoveStudentWithId(student.Id);
        }

        public void RemoveStudentWithId(long id)
        {
            var student = GetStudentWithId(id);
            for(int i = 0; i < Count; i++)
            {
                if (id == _students[i].Id)
                    _students.RemoveAt(i);
            }
        }

        public void UpdateStudent(long id, Student student)
        {
            var std = GetStudentWithId(id);
            std.Id = student.Id;
            std.Name = student.Name;
            std.Description = student.Description;
            std.Age = student.Age;
        }
    }
}

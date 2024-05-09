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
            try
            {
                if (index < 0 || index == null)
                    throw new ArgumentOutOfRangeException("index");
                return _students[index];
            }
            catch(Exception ex) 
            {
                
            }
        }

        public Student GetStudentWithId(long id)
        {
            throw new NotImplementedException();
        }

        public void RemoveStudent(Student student)
        {
            RemoveStudentWithId(student.Id);
        }

        public void RemoveStudentWithId(long id)
        {
            for (int i = 0; i < Count; i++)
            {

            }
        }

        public void UpdateStudent(long id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}

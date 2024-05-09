namespace Database
{
    public interface IDatabase
    {
        public long AddStudent(Student student);
        public Student GetStudentWithId(long id);
        public Student GetStudentAt(int index);
        public void UpdateStudent(long id, Student student);
        public void RemoveStudent(Student student);
        public void RemoveStudentWithId(long id);
    }
}

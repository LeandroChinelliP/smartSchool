namespace SmartSchool.Models
{
    public class Subject
    {
        public Subject() { }
        public int Id { get; set; }
        public int Name { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public IEnumerable<StudentSubject> Student{ get; set; }
    }
}
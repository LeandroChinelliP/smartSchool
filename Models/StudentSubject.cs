namespace SmartSchool.Models
{
    public class StudentSubject
    {
        public StudentSubject() { }
        public StudentSubject(int studentId, string subjectId)
        {
            this.StudentId = studentId;
            this.SubjectId = subjectId;   
        }

        public int StudentId{ get; set;}
        public Student Student{ get; set;}
        public string SubjectId{ get; set;}
        public Subject Subject { get; set;}
    }
}
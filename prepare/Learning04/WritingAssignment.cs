public class WritingAssignment : Assignment
{
    private string _titleAssignment;

    public WritingAssignment(string studentName, string topic, string titleAssignment) : base(studentName, topic)
    {
        _titleAssignment = titleAssignment;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_titleAssignment} by {studentName}";
    }

    
}
namespace OO_Review.Models;

public class Subject
{
    public string SubjectCode { get; set; }
    public string Name { get; set; }

    public Lecturer Lecturer { get; set; }
    public double Score { get; set; }
}
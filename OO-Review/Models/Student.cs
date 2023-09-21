namespace OO_Review.Models;

public class Student : Person
{
    public Student()
    {
    }

    public Student(string idCard, string name, DateOnly birthday, Gender gender, string studentCode, Major major) :
        base(idCard, name, birthday, gender)
    {
        StudentCode = studentCode;
        Major = major;
    }

    public string StudentCode { get; set; }
    public Major Major { get; set; }
    public ICollection<Subject> Subjects { get; set; } = new List<Subject>();

    public double GPA
    {
        get { return Subjects.Average(subject => subject.Score); }
    }
    
    public ICollection<Subject> CompleteSubject(Subject subject)
    {
        Subjects.Add(subject);
        return Subjects;
    }

    public Rank Ranking()
    {
        if (GPA is > 10 or < 0)
        {
            throw new Exception("GPA invalid");
        }

        return GPA switch
        {
            >= 8.5 => Rank.Excellent,
            >= 7.0 => Rank.Good,
            >= 5.5 => Rank.Average,
            >= 4 => Rank.BelowAverage,
            _ => Rank.Weak
        };
    }

    public override string ToString()
    {
        return $@"Student information:
- Code  {StudentCode}
- Name  {Name}
- Major {Major.Name}
- Rank  {Ranking()};";
    }
}

public enum Rank
{
    Weak,
    BelowAverage,
    Average,
    Good,
    Excellent
}
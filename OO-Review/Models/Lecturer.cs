namespace OO_Review.Models;

public class Lecturer : Person
{
    public Lecturer(string idCard, string name, DateOnly birthday, Gender gender,
        int lecturerCode, double baseSalary, double coefficientsSalary)
        : base(idCard, name, birthday, gender)
    {
        LecturerCode = lecturerCode;
        BaseSalary = baseSalary;
        CoefficientsSalary = coefficientsSalary;
    }

    public Lecturer()
    {
    }

    public int LecturerCode { get; set; }
    public double BaseSalary { get; set; }
    public double CoefficientsSalary { get; set; }
    public double? Bonus { get; set; }

    public double CalculateSalary()
    {
        var salary = BaseSalary * CoefficientsSalary;

        return Bonus != null ? salary + (double)Bonus : salary;
    }
    
    public override string ToString()
    {
        return $@"Lecturer information:
- Code   {LecturerCode}
- Name   {Name}
- Salary {CalculateSalary()};";
    }
}
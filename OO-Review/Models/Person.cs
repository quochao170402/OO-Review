namespace OO_Review.Models;

public class Person
{
    public Person(string idCard, string name, DateOnly birthday, Gender gender)
    {
        IDCard = idCard;
        Name = name;
        Birthday = birthday;
        Gender = gender;
    }

    public Person()
    {
    }

    public string IDCard { get; set; }
    public string Name { get; set; }
    public DateOnly Birthday { get; set; }
    public Gender Gender { get; set; }
}

public enum Gender
{
    Male,
    Female,
    Other
}
// See https://aka.ms/new-console-template for more information

using OO_Review.Models;

Console.WriteLine("Hello, World!");

var lecturer = new Lecturer
{
    IDCard = "123456789",
    Name = "Vu Dinh Long",
    Birthday = new DateOnly(1975, 1,1),
    Gender = Gender.Male,
    LecturerCode = 5672,
    BaseSalary = 4000000,
    CoefficientsSalary = 8,
    Bonus = 10000000
};

var major = new Major
{
    MajorCode = 112,
    Name = "Information technology",
    Description = "Information technology"
};

var student = new Student
{
    IDCard = "205110110",
    Name = "Bui Quoc Hao",
    Birthday = new DateOnly(2002, 4, 17),
    Gender = Gender.Male,
    StudentCode = "2020202020",
    Major = major,
    Subjects = new List<Subject>
    {
        new()
        {
            SubjectCode = "205111111",
            Name = "Software Architecture",
            Lecturer = lecturer,
            Score = 9
        },
        new()
        {
            SubjectCode = "205111112",
            Name = "Cloud Computing",
            Lecturer = lecturer,
            Score = 7
        },
        new()
        {
            SubjectCode = "205111113",
            Name = "Database Design and application",
            Lecturer = lecturer,
            Score = 10
        }
    }
};

Console.WriteLine(student);
Console.WriteLine(lecturer);
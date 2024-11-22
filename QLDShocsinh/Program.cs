using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
       
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Khoa", Age = 14 },
            new Student { Id = 2, Name = "Hung", Age = 15 },
            new Student { Id = 3, Name = "vu", Age = 18 },
            new Student { Id = 4, Name = "Anh", Age = 13 },
            new Student { Id = 5, Name = "Cam", Age = 16 }
        };

        
        Console.WriteLine("Danh sach hoc sinh:");
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

       
        var ageRangeStudents = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
        Console.WriteLine("\nHoc sinh co tuoi tu 15 den 18:");
        foreach (var student in ageRangeStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        var studentsStartingWithA = students.Where(s => s.Name.StartsWith("A")).ToList();
        Console.WriteLine("\nHoc sinh co ten bat đau bang chu 'A':");
        foreach (var student in studentsStartingWithA)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        var totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

        var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
        Console.WriteLine("\nHoc sinh co tuoi lon nhat:");
        if (oldestStudent != null)
        {
            Console.WriteLine($"Id: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");
        }

        var sortedStudents = students.OrderBy(s => s.Age).ToList();
        Console.WriteLine("\nDanh sach hoc sinh sau khi sap xep theo tuoi tang dan:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }
}

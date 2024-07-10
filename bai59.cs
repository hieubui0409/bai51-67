using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public double Gpa { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> list1 = new List<Student>
        {
            new Student { Name = "Alice", Gpa = 3.5 },
            new Student { Name = "Bob", Gpa = 3.7 },
            new Student { Name = "Charlie", Gpa = 3.9 }
        };

        Dictionary<string, double> dict1 = new Dictionary<string, double>();

        foreach (var student in list1)
        {
            dict1[student.Name] = student.Gpa;
        }

        // Hiển thị kết quả
        foreach (var kvp in dict1)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}

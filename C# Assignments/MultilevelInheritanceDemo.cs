/* Assume that the test results of a batch of students are stored in three different
 classes. Class Students are stores the roll number. Class Test stores the marks obtained in two subjects and class result contains the total marks obtained in the test. The class result can inherit the details of the marks obtained in the test and roll number of students.
 (Multilevel Inheritance) */

using System;
public class Student
{
    protected int rollNumber;
    public Student(int rollNumber)
    {
        this.rollNumber = rollNumber;
    }
    public virtual void DisplayStudentInfo()
    {
        Console.WriteLine($"Roll Number: {rollNumber}");
    }
}
public class Test : Student
{
    protected int marksSubject1;
    protected int marksSubject2;
    public Test(int rollNumber, int marksSubject1, int marksSubject2) 
        : base(rollNumber)
    {
        this.marksSubject1 = marksSubject1;
        this.marksSubject2 = marksSubject2;
    }
    public override void DisplayStudentInfo()
    {
        base.DisplayStudentInfo();
        Console.WriteLine($"Marks in Subject 1: {marksSubject1}");
        Console.WriteLine($"Marks in Subject 2: {marksSubject2}");
    }
}
public class Result : Test
{
    private int totalMarks;
    public Result(int rollNumber, int marksSubject1, int marksSubject2) 
        : base(rollNumber, marksSubject1, marksSubject2)
    {
        this.totalMarks = marksSubject1 + marksSubject2;
    }

    public override void DisplayStudentInfo()
    {
        base.DisplayStudentInfo();
        Console.WriteLine($"Total Marks: {totalMarks}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Result result = new Result(1, 80, 90);
        result.DisplayStudentInfo();
    }
}

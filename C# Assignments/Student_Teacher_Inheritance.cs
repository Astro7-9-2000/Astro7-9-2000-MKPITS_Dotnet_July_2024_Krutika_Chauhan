/*
C# program for Single inheritance 
*/

using System;

class Teacher
{
    public void Teach()
    {
        Console.WriteLine("Teach");
    }
}

class Student : Teacher
{
    public void Learn()
    {
        Console.WriteLine("Learn");
    }
}
class program
{
    static void Main(string[] args)
    {
    Teacher d = new Teacher();
    Student s = new Student();
    d.Teach();
    s.Teach();
    s.Learn();
    }
}
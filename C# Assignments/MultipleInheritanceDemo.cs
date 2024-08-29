/* Create a class person having members name and age. Derive a class student having member percentage. Derive another class teacher having member salary.Write necessary member function to initialize, read and write data. Write also Main function (Multiple Inheritance) */

using System;
public class Person
{
    public string Name;
    public int Age;
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public virtual void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}
public class Student : Person
{
    public decimal Percentage;
    public Student(string name, int age, decimal percentage) : base(name, age)
    {
        Percentage = percentage;
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Percentage: " + Percentage);
    }
}
public class Teacher : Person
{
    public decimal Salary;
    public Teacher(string name, int age, decimal salary) : base(name, age)
    {
        Salary = salary;
    }
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Salary: " + Salary);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Arya", 20, 85.5m);
        student.Display();
        Console.WriteLine();

        Teacher teacher = new Teacher("Harry", 35, 20.0m);
        teacher.Display();
    }
}

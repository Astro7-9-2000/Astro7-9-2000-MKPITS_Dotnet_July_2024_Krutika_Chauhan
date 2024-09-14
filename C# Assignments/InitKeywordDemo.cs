/*
1. In simple words we can say that Immutable means object cannot be changed once iy=t is created.
2. If you want to change you have to create new object / assign new memory.
3. We can use init keyword to make properties immutable.
4. Init keyword was launched in C#9.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Student std = new Student(24);
        //std.Id = 24;           //Restricting modification of certain properties (like Id) to ensure data integrity.              
        std.Name = "Pratiksha";
        std.Standard = 6;

        Console.WriteLine(std.Id + " " +std.Name+ " " +std.Standard);
    }
}

class Student
{
    public int Id 
    {
    // The init accessor for the Id property restricts its modification to the constructor or object initializer.
        get; 
        init; 
    //{
    //    get;
        //set;
    }
    public string Name
    {
        get;
        set;
    }

    public int Standard
    {
        get;
        set;
    }
    public Student(int Id)
    {
        this.Id = Id;
    }
}

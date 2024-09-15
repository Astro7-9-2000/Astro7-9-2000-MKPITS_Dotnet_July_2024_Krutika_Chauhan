/*
A Date and Time format specifier is a special character that enables you to display the date 
and time values in different formats.
d - Short date
D - Long Date
f - Full date/time(short time)
F - Full date/time(long time)
g - General date/time (short time)
*/
class Program
{
    static void Main(string[] args)
    {
        DateTime dt = DateTime.Now;
        Console.WriteLine("{0:d}" , dt);   // Short date
        Console.WriteLine("{0:D}" , dt);     // Long date
        Console.WriteLine("{0:f}" , dt);     // full date
        Console.WriteLine("{0:F}" , dt);   // Full date
        Console.WriteLine("{0:g}" , dt);  // General date time
        Console.WriteLine("{0:d} {1:D}" , dt , dt);
        Console.WriteLine("{0:G}" , dt);
        Console.WriteLine("{0:M}", dt); // Month day
        Console.WriteLine("{0:m}", dt);  // Month day
        Console.WriteLine("{0:t}", dt);  // Short time
        Console.WriteLine("{0:T}", dt);   // Long time
        Console.WriteLine("{0:y}", dt);  // year month pattern
        Console.WriteLine("{0:yy}", dt);  // prints last 2 numbers of the year i.e 2019 = 19
        Console.WriteLine("{0:ddd}" , dt);  //Represents the abbreviated name of the day of the week
        Console.WriteLine("{0:dddd}", dt);  // Represents the full name of the day of the week
        Console.WriteLine("{0:FF}", dt);  // Represents the 2 digits of the seconds fraction
        Console.WriteLine("{0:HH}" , dt); // Represents the hour from 00 to 23
        Console.WriteLine("{0:MM}" , dt); // Represents the month as a number from 0 to 12
        Console.WriteLine("{0:MMM}" , dt); // Represents the abbreviated name of the month
        Console.WriteLine("{0:ss}" , dt); // Represents the seconds as a number from 0 to 59
        Console.WriteLine("{0:HH:mm:ss}" , dt);
        Console.ReadLine();
    }
}
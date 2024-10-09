/*
Sort a List: Write a method that sorts a list of integers in ascending and descending order.
*/

public static void SortList(List<int> list)
{
    // Sort the list in ascending order
    list.Sort();

    // Print the elements in ascending order
    Console.WriteLine("Ascending Order:");
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }

    // Reverse the list to get descending order
    list.Reverse();

    // Print the elements in descending order
    Console.WriteLine("Descending Order:");
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}
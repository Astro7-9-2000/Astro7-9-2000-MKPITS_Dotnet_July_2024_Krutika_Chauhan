// Clear StringBuilder Content: Write a method that demonstrates how to clear the content of a StringBuilder object after appending some text.

using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        
        // Append some text
        sb.Append("Happy, ");
        sb.Append("Dusshera!");
        
        Console.WriteLine("Before clearing: " + sb.ToString());
        
        // Clear the StringBuilder content
        ClearStringBuilderContent(sb);
        
        Console.WriteLine("After clearing: " + sb.ToString());
    }
    
    // call the ClearStringBuilderContent method, which takes the StringBuilder object as a parameter. 
    // Inside this method, we use the Clear method to remove all characters from the StringBuilder object.
    static void ClearStringBuilderContent(StringBuilder sb)
    {
        sb.Clear();
    }
}
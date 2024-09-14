using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1. A Hash Table is used when you need to access elements by using key , 
    and you can identify a useful key value.
 2. Each item in the hash atble has a key/value pair. The key is used to
    access the items in the collection.
 * Add - Adds an item with a key and value into the hashtable.
 * Remove - Removes the item with the specified key from the hashtable.
 * Clear - Removes all the items from the hashtable.
 * Contains - Checks whether the hashtable contains a specific key.
 * ContainsKey - Checks whether the hashtable contains a specific key
 * GethashCode - Returns the hashcode for the specified key
 */
namespace HashTableMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Id", 1123);
            ht.Add("Name", "krutika");
            ht.Add("Salary", 25000.00);
            ht.Add("Designation", "Manager");
            ht.Add("IsMarried", false);

            Console.WriteLine(ht.ContainsValue("krutika"));

            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + " : " +ht[key]);
            }
            ht.Remove("Salary");
            Console.WriteLine("-------------------");
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + " : " + ht[key]);
            }
            //foreach(object value in ht.Values)
            //{
            //    Console.WriteLine(value); 
            //}
            Console.ReadLine();
        }
    }
}

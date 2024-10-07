using System.Data.SqlTypes;

namespace StringHandling12D24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aString = "String handling";
            string bString = "operations";
            //• length
            Console.WriteLine(aString.Length);
            //• position
            Console.WriteLine(aString[0]);
            Console.WriteLine(aString[aString.Length - 1]);
            //   Console.WriteLine(aString[aString.Length]); outside bounds of the array

            //• substring
            Console.WriteLine(aString.Substring(3,5));//starts index 3 and has a length of 5 characters
            Console.WriteLine(aString.Substring(10)); // starts at index 10 and goes to the end
            // how would you output the last 3 characters of any string
            Console.WriteLine(aString.Substring(aString.Length-3));
            Console.WriteLine(bString.Substring(bString.Length-3));

            //• concatenation
            Console.WriteLine(aString + " " + bString);
            // String builders
            Console.WriteLine($"this is the first string {aString} and this is the second string {bString}");
            //• character → character code

            //• character code → character
            //• string conversion operations
        }
    }
}

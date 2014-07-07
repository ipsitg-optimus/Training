using System;
namespace Induction
{
    /// <summary>
    /// Class for testing string methods.
    /// </summary>
    public class TestStrings
    {

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="ar">Command line arguments</param>
        static void Main(string[] ar)
        {
            String newstring="This is a String!!!";
            String anotherstring;
            Console.WriteLine("String is:" + newstring);
            anotherstring = newstring.Clone().ToString();
            Console.WriteLine("Clone of the string:"+anotherstring);
            Console.WriteLine(newstring+" contains 'String' in it:"+newstring.Contains("String"));
            Console.WriteLine(newstring + " is equal to 'This is a String!!!' :" + newstring.Equals("This is a String!!!"));
            Console.WriteLine("First Index of a in String is:" + newstring.IndexOf('a'));
            Console.WriteLine("Length of the String is:" + newstring.Length);
            Console.WriteLine(newstring+" starts with 'This':"+newstring.StartsWith("This"));
            Console.WriteLine("Substring of " + newstring + " from 6th character is:" + newstring.Substring(5));
            Console.WriteLine("Lowercase of "+newstring+" is:"+ newstring.ToLower());
            Console.WriteLine("Uppercase of " + newstring + " is:" + newstring.ToUpper());
            Console.ReadLine();
        }
    }
}

using System;
namespace Induction
{
    /// <summary>
    /// Class for testing string array
    /// </summary>
    public class TestStringArray
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="ar">Command line arguments</param>
        static void Main(string[] ar)
        {
            int iterator;
            string[] getarray = GetStringArray();
            for (iterator = 0; iterator < getarray.Length; iterator++)
            {
                Console.WriteLine("String number " + (iterator + 1) + " is:" + getarray[iterator]);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// method for getting string array.
        /// </summary>
        /// <returns></returns>
        static string[] GetStringArray()
        {
            string[] newarray = new string[5];
            newarray[0] = "String 1.";
            newarray[1] = "String 2.";
            newarray[2] = "String 3.";
            newarray[3] = "String 4.";
            newarray[4] = "String 5.";
            return newarray;
        }
    }
}
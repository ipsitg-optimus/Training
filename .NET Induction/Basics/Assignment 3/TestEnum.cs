using System;
namespace Induction
{

    /// <summary>
    /// Class for testing enum.
    /// </summary>
    public class TestEnum
    {
        /// <summary>
        /// enum for weekdays.
        /// </summary>
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        };

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="ar">command line arguments</param>
        static void Main(string[] ar)
        {
            Console.WriteLine(WeekDays.Monday);
            Console.WriteLine(WeekDays.Tuesday);
            Console.WriteLine(WeekDays.Wednesday);
            Console.WriteLine(WeekDays.Thursday);
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine(WeekDays.Saturday); 
            Console.WriteLine(WeekDays.Sunday);
            Console.ReadLine();
        }
    }
}
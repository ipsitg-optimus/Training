using System;
namespace Induction
{
    /// <summary>
    /// Class for testing if.
    /// </summary>
    public class TestIf
    {

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your Language");
            Console.WriteLine("Press 1 for C#");
            Console.WriteLine("Press 2 for Visual Basic");
            Console.WriteLine("Press 3 for other");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                    Console.WriteLine("Good choice, C# is a fine language.");
                else if (number == 2)
                    Console.WriteLine("VB .NET: OOP, multi threading and more!");
                else if (number == 3)
                    Console.WriteLine("Well...good luck with that!");
                else
                    Console.WriteLine("Oops!! please enter valid number");
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops!! please enter valid number");
            }
            Console.ReadLine();
        }

    }
}
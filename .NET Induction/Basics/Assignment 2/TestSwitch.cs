using System;
namespace Induction
{

    /// <summary>
    /// Class for testing switch.
    /// </summary>
    public class TestSwitch
    {

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="ar">Command line arguments</param>
        static void Main(string[] ar)
        {
            Console.WriteLine("Choose your Language");
            Console.WriteLine("Press 1 for C#");
            Console.WriteLine("Press 2 for Visual Basic");
            Console.WriteLine("Press 3 for other");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Good choice, C# is a fine language.");
                        break;
                    case 2:
                        Console.WriteLine("VB .NET: OOP, multi threading and more!");
                        break;
                    case 3:
                        Console.WriteLine("Well...good luck with that!");
                        break;
                    default:
                        Console.WriteLine("Oops!! please enter valid number");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops!! please enter valid number");
            }
            Console.ReadLine();
        }

    }
}
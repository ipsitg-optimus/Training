using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int roll_number = Convert.ToInt32(Console.ReadLine());
                localhost.Service1 myservice = new localhost.Service1();
                string str = myservice.GetDetails(roll_number);
                if (str != null)
                {
                    string[] details = str.Split(':');
                    Console.WriteLine("Name of the student: {0}\nAge of the student: {1}", details[0], details[1]);
                }
                else
                {
                    Console.WriteLine("No record was found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid roll number");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp
{
    public class Student
    {
        /// <summary>
        /// Prints marks of the student.
        /// </summary>
        /// <param name="marks">marks of the student.</param>
        public void PrintMarks(string marks)
        {
            try
            {
                int numbers = Convert.ToInt32(marks);
                if (numbers > 0 && numbers <= 100)
                {
                    Console.WriteLine("Correct marks");
                }
            }
            catch (FormatException ex)
            {

            }
        }
    }
}
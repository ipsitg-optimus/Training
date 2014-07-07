using System;

namespace University
{

    /// <summary>
    /// Class for storing details of a School Student.
    /// </summary>
    class SchoolStudent : Student
    {

        #region private members
        private string current_class; 
        #endregion

        /// <summary>
        /// Initializes a new SchoolStudent instance.
        /// </summary>
        /// <param name="_age">Age</param>
        /// <param name="full_name">Full Name</param>
        /// <param name="gender">Gender</param>
        /// <param name="current_class">Current Class</param>
        public SchoolStudent(int _age, string full_name, string gender, string current_class)
            : base(_age, full_name, gender)
        {

            this.current_class = current_class;
        }

        /// <summary>
        /// Prints details of current Student.
        /// </summary>
        public override void ShowDetails()
        {
            Console.WriteLine("Name of Student: {0}", full_name);
            Console.WriteLine("Age of Student: {0}", _age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Current Class: {0}", current_class);
        }
    }
}

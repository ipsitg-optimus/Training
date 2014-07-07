using System;

namespace University
{

    /// <summary>
    /// Class for storing details of a College Student.
    /// </summary>
    class CollegeStudent : Student
    {
        #region private members
        private string degree_name;
        private int course_duration;
        private int current_year;
        #endregion

        /// <summary>
        /// Initializes a new CollegeStudent instance
        /// </summary>
        /// <param name="_age">Age</param>
        /// <param name="full_name">Full Name</param>
        /// <param name="gender">Gender</param>
        /// <param name="degree_name">Degree's Name</param>
        /// <param name="course_duration">Duratio of course</param>
        /// <param name="current_year">Current year of course</param>
        public CollegeStudent(int _age, string full_name, string gender, string degree_name, int course_duration, int current_year)
            : base(_age, full_name, gender)
        {
            this.degree_name = degree_name;
            this.course_duration = course_duration;
            this.current_year = current_year;
        }

        /// <summary>
        /// Prints details of current CollegeStudent.
        /// </summary>
        public override void ShowDetails()
        {
            Console.WriteLine("Name of Student: {0}", full_name);
            Console.WriteLine("Age of Student: {0}", _age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Degree Pursuing: {0}", degree_name);
            Console.WriteLine("Course Duration: {0}", course_duration);
            Console.WriteLine("Current Year of Course: {0}", current_year);
        }
    }
}

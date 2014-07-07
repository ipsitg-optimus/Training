using System;


namespace University
{
    /// <summary>
    /// Class for storing details of a Student.
    /// </summary>
    class Student
    {
        #region private members
        protected internal int _age;
        protected string full_name;
        protected string gender;
        #endregion

        #region Properties
        public int Age
        {
            get
            {
                return _age;
            }
        }
        public string FullName
        {
            get
            {
                return full_name;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
        }
        #endregion

        /// <summary>
        /// Initializes a new Student class instance.
        /// </summary>
        /// <param name="_age">Age</param>
        /// <param name="full_name">Full name</param>
        /// <param name="gender">Gender</param>
        public Student(int _age, string full_name, string gender)
        {
            this._age = _age;
            this.full_name = full_name;
            this.gender = gender;
        }

        /// <summary>
        /// Prints details of the student.
        /// </summary>
        public virtual void ShowDetails()
        {
            Console.WriteLine("Name of Student: {0}", full_name);
            Console.WriteLine("Age of Student: {0}", _age);
            Console.WriteLine("Gender: {0}", gender);
        }
    }
}

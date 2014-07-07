using System;
namespace Induction
{
    /// <summary>
    /// enum for storing student's attributes.
    /// </summary>
    enum StudentAttribute
    {
        RollNumber,
        Name,
        Age,
        Gender,
        FatherName
    };

    /// <summary>
    /// Class for storing student's information
    /// </summary>
    public class Student
    {
        #region private members
        private int roll_number;
        private string name;
        private int age;
        private string gender;
        private string father_name;

        #endregion

        #region properties

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public string FatherName
        {
            get
            {
                return father_name;
            }
            set
            {
                father_name = value;
            }
        }
        #endregion

        /// <summary>
        /// Initializes a new Student instance
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="age">Age</param>
        /// <param name="gender">Gender</param>
        /// <param name="father_name">Father's name</param>
        public Student(string name, int age, string gender, string father_name)
        {
            //randomly allots a roll number to student.
            roll_number = new Random().Next(10000000) + 1;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.father_name = father_name;
        }

        /// <summary>
        /// Prints details of the student.
        /// </summary>
        public void ShowDetails()
        {
            Console.WriteLine("Roll Number: " + roll_number);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Father's Name: " + father_name);
        }
        //Overloaded method with choice.

        /// <summary>
        /// Prints details of the student according to choice. 
        /// </summary>
        /// <param name="choice">Choice of parameter.</param>
        public void ShowDetails(int choice)
        {
            switch (choice)
            {
                case (int)StudentAttribute.RollNumber:
                    Console.WriteLine("Roll Number: " + roll_number);
                    break;
                case (int)StudentAttribute.Name:
                    Console.WriteLine("Name: " + name);
                    break;
                case (int)StudentAttribute.Age:
                    Console.WriteLine("Age: " + age);
                    break;
                case (int)StudentAttribute.Gender:
                    Console.WriteLine("Gender: " + gender);
                    break;
                case (int)StudentAttribute.FatherName:
                    Console.WriteLine("Father's Name: " + father_name);
                    break;
                default:
                    Console.WriteLine("Please select valid option.");
                    break;
            }
        }

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="ar">command line arguments.</param>
        static void Main(string[] ar)
        {
            Student student1 = new Student("Akshay", 19, "Male", "Mr. Rupeah");
            student1.ShowDetails();
            Console.WriteLine("\nEnter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            student1.ShowDetails(choice);
            Console.ReadLine();
        }
    }
}
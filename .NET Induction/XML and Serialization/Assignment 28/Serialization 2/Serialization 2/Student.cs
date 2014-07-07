using System;
using System.Runtime.Serialization;

namespace Serialization_2
{
    /// <summary>
    /// Class for storing student's information.
    /// </summary>
    [Serializable()]
    public class Student : ISerializable
    {
        #region members
        public int roll_number;
        public string name;
        public int totalmarks;
        private char grade;
        #endregion

        #region properties
        public char Grade
        {
            get
            {
                if (totalmarks > 60)
                    return 'D';
                else if (totalmarks >= 60 && totalmarks < 80)
                    return 'C';
                else if (totalmarks >= 80 && totalmarks < 90)
                    return 'B';
                else if (totalmarks >= 90 && totalmarks < 100)
                    return 'A';
                else
                    return 'F';
            }
        }
        #endregion

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Student()
        {
            roll_number = 0;
            name = null;
            totalmarks = 0;
        }

        /// <summary>
        /// Constructor for deserializing object of Student class.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public Student(SerializationInfo info, StreamingContext context)
        {
            roll_number = (int)info.GetValue("RollNumber", typeof(int));
            name = (string)info.GetValue("Name", typeof(string));
            totalmarks = (int)info.GetValue("TotalMarks", typeof(int));
        }

        /// <summary>
        /// method for serializing the instance of student class.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("RollNumber", roll_number);
            info.AddValue("Name", name);
            info.AddValue("TotalMarks", totalmarks);
        }
    }
}

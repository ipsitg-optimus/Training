using System;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace CSV
{
    /// <summary>
    /// Class for entering student's details into database.
    /// </summary>
    public class Student
    {
        #region private members
        private int roll_number;
        private string name;
        private string father_name;
        private string gender;
        private int age;
        private string stream;
        private string state;
        private SqlConnection connection;
        private SqlDataReader reader;
        private SqlCommand command;
        #endregion

        #region properties
        public int RollNumber
        {
            get
            {
                return roll_number;
            }
            set
            {
                roll_number = value;
            }
        }
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
        public string Stream
        {
            get
            {
                return stream;
            }
            set
            {
                stream = value;
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        #endregion

        /// <summary>
        /// initializes a new student instance.
        /// </summary>
        public Student()
        {
            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["constring"].ToString();
                connection.Open();
            }
            catch (SqlException exception)
            {
                Console.Error.WriteLine("Connection not created.\n" + exception.Message);
            }
        }

        /// <summary>
        /// gets details of student for particular Roll number.
        /// </summary>
        /// <param name="roll_number">Roll number of the student.</param>
        /// <returns>instance of student class if found else null.</returns>
        public Student GetStudent(int roll_number)
        {
            Student student = null;
            string query = "select roll_number,name,father_name,gender,age,stream_name,state_name from student_details sd join stream str on sd.stream_id=str.stream_id join state st on sd.state_id=st.state_id where roll_number=" + roll_number;
            try
            {
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    student = new Student();
                    student.RollNumber = Convert.ToInt32(reader["roll_number"]);
                    student.Name = reader["name"].ToString();
                    student.FatherName = reader["father_name"].ToString();
                    student.Gender = reader["gender"].ToString();
                    student.Age = Convert.ToInt32(reader["age"]);
                    student.Stream = reader["stream_name"].ToString();
                    student.State = reader["state_name"].ToString();
                    return student;
                }
                else
                    return null;
            }
            catch (SqlException exception)
            {
                return null;
            }
            finally
            {
                reader.Close();
            }
        }

        /// <summary>
        /// adds details of the student in the database.
        /// </summary>
        /// <returns>True if entry is successful else False is returned.</returns>
        public bool AddStudent()
        {
            string query = "insert into student_details values(" + roll_number + ",'" + name + "','" + father_name + "','" + gender + "'," + age + ",(select stream_id from stream where stream_name='" + stream + "'),(select state_id from state where state_name='" + state + "'))";
            try
            {
                command = new SqlCommand(query, connection);
                if (command.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException exception)
            {
                return false;
            }
        }

        /// <summary>
        /// updates Details of the student.
        /// </summary>
        /// <returns>True if successfully updated else False</returns>
        public bool UpdateStudent()
        {
            string query = "update student_details set name='" + name + "',father_name='" + father_name + "',gender='" + gender + "',age=" + age + ",stream_id=(select stream_id from stream where stream_name='" + stream + "'),state_id=(select state_id from state where state_name='" + state + "') where roll_number=" + roll_number;
            try
            {
                command = new SqlCommand(query, connection);
                if (command.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Gets list of the student of particular Stream
        /// </summary>
        /// <param name="streamID">Stream Id of the Stream</param>
        /// <returns>List of students.</returns>
        public List<Student> GetAllStudents(int streamID)
        {
            List<Student> students = new List<Student>();
            Student newstudent;
            string query = "select roll_number,name,father_name,gender,age,stream_name,state_name from student_details sd join stream str on sd.stream_id=str.stream_id join state st on sd.state_id=st.state_id where str.stream_id=" + streamID;
            try
            {
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    newstudent = new Student();
                    newstudent.RollNumber = Convert.ToInt32(reader["roll_number"]);
                    newstudent.Name = reader["name"].ToString();
                    newstudent.FatherName = reader["father_name"].ToString();
                    newstudent.Gender = reader["gender"].ToString();
                    newstudent.Age = Convert.ToInt32(reader["age"]);
                    newstudent.Stream = reader["stream_name"].ToString();
                    newstudent.State = reader["state_name"].ToString();
                    //add object to the list.
                    students.Add(newstudent);
                }
                return students;
            }
            catch (SqlException exception)
            {
                return null;
            }
            finally
            {
                reader.Close();
            }
        }

        /// <summary>
        /// Deletes students with particular roll numbers
        /// </summary>
        /// <param name="rollNOs">roll numbers of students to be deleted separated by comma. </param>
        /// <returns>true if deleted successfully else false.</returns>
        public bool DeleteStudents(string rollNumbers)
        {
            string query = "delete from student_details where roll_number in(" + rollNumbers + ")";
            try
            {
                command = new SqlCommand(query, connection);
                if (command.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException exception)
            {
                return false;
            }
        }

        /// <summary>
        /// this method inserts data into student_details table from a list.
        /// </summary>
        /// <param name="studentData">list from which data is to be inserted.</param>
        /// <returns>true if data is been successfully inserted else false.</returns>
        public bool InsertStudents(List<Student> studentData)
        {
            foreach (Student student in studentData)
            {
                string query = "insert into student_details values(" + student.RollNumber + ",'" + student.Name + "','" + student.FatherName + "','" + student.Gender + "'," + student.Age + ",(select stream_id from stream where stream_name='" + student.Stream + "'),(select state_id from state where state_name='" + student.State + "'))";
                try
                {
                    command = new SqlCommand(query, connection);
                    if (command.ExecuteNonQuery() == 0)
                        return false;
                }
                catch (SqlException exception)
                {

                    return false;
                }
            }
            return true;
        }
    }
}
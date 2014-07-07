using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
namespace GetStudentDetails
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "Student")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        
        [WebMethod]
        /// <summary>
        /// checks for a valid student in database.
        /// </summary>
        /// <param name="roll_number">roll number of the student to be searched.</param>
        /// <returns>name, age separated by colon if record is found else null</returns>
        public string GetDetails(int roll_number)
        {
            SqlConnection connection = null;
            SqlDataReader reader = null;
            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = "Data Source=ANKITA-PC;Initial Catalog=student;Integrated Security=true;";
                connection.Open();
                string query = "select name, age from student_details where roll_number=" + roll_number;
                SqlCommand command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                if (reader.Read())
                    return reader["name"] + ":" + reader["age"];
                else
                    return null;
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                reader.Close();
                connection.Close();
            }
        }
    }
}
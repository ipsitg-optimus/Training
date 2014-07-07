using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Xml;
namespace XML_3
{
    /// <summary>
    /// Class for some utility functions.
    /// </summary>
    public static class UtilityFunctions
    {
        #region private members
        private static SqlConnection connection;
        private static SqlDataReader reader;
        private static SqlCommand command;
        #endregion

        /// <summary>
        /// Establishes connection to the database.
        /// </summary>
        public static void EstablishConnection()
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
        /// method for getting all streams from database.
        /// </summary>
        /// <returns>returns a dictionary object which contains all streams in the database</returns>
        public static Dictionary<int, string> GetAllStreams()
        {
            EstablishConnection();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            string query = "select * from stream order by stream_name";
            try
            {
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dictionary.Add(Convert.ToInt32(reader["stream_id"]), reader["stream_name"].ToString());
                }
                return dictionary;
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
        /// method for getting all states from database.
        /// </summary>
        /// <returns>returns a dictionary object which contains all states in the database</returns>
        public static Dictionary<int, string> GetAllStates()
        {
            EstablishConnection();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            string query = "select * from state order by state_name";
            try
            {
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dictionary.Add(Convert.ToInt32(reader["state_id"]), reader["state_name"].ToString());
                }
                return dictionary;
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                reader.Close();
            }
        }

        /// <summary>
        /// method for fetching name of the stream for particular stream id.
        /// </summary>
        /// <param name="streamID">streamId of the stream.</param>
        /// <returns>name of the stream if stream exists else null.</returns>
        public static string GetStreamName(int streamID)
        {
            EstablishConnection();
            string query = "select stream_name from stream where stream_id=" + streamID;
            try
            {
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader["stream_name"].ToString();
                }
            }
            catch (SqlException exception)
            {
                return null;
            }
            finally
            {
                reader.Close();
            }
            return null;
        }

        /// <summary>
        /// method for fetching name of the state for particular state id.
        /// </summary>
        /// <param name="stateID">stateId of the state.</param>
        /// <returns>name of the state  if state exists else null.</returns>
        public static string GetStateName(int stateID)
        {
            EstablishConnection();
            string query = "select state_name from state where state_id=" + stateID;
            try
            {
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader["state_name"].ToString();
                }
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                reader.Close();
            }
            return null;
        }

        /// <summary>
        /// Logs the exception to event log.
        /// </summary>
        /// <param name="e">instance of the exception</param>
        public static void LogToEventLog(Exception e)
        {
            EventLog log = new EventLog();
            log.WriteEntry(e.Message, EventLogEntryType.Error);
        }

        /// <summary>
        /// Loads data from XML file of students.
        /// </summary>
        /// <param name="fileName">name of the XML file.</param>
        /// <returns>true if data is loaded successfully else false.</returns>
        public static bool LoadStudentsFromXMLFile(string fileName)
        {
            List<Student> students = new List<Student>();
            Student newstudent;
            bool flag = false;
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode root = doc.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                flag = true;
                newstudent = new Student();
                newstudent.RollNumber = Convert.ToInt32(node.Attributes.Item(0).Value);
                newstudent.Name = node.ChildNodes.Item(0).InnerText;
                newstudent.FatherName = node.ChildNodes.Item(1).InnerText;
                newstudent.Gender = node.ChildNodes.Item(2).InnerText;
                newstudent.Age = Convert.ToInt32(node.ChildNodes.Item(3).InnerText);
                newstudent.Stream = node.ChildNodes.Item(4).InnerText;
                newstudent.State = node.ChildNodes.Item(5).InnerText;
                students.Add(newstudent);
            }
            new Student().InsertStudents(students);
            return flag;
        }
    }
}
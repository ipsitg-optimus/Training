using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System;
namespace Serialization_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student;
            //Creates a new instance of student class.
            student = new Student();
            Student newstudent;
            student.roll_number = 12345;
            student.name = "Ipsit Gaur";
            student.totalmarks = 80;

            DirectoryInfo newdirectory = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\SerializationData");
            if (!newdirectory.Exists)
                newdirectory.Create();

            Console.WriteLine("Student's Details before serialization:");
            Console.WriteLine("Roll Number: {0}", student.roll_number);
            Console.WriteLine("Name: {0}", student.name);
            Console.WriteLine("Total Marks: {0}", student.totalmarks);

            BinarySerialization(student);
            XMLSerialization(student);
            SoapSerialization(student);
            Console.ReadLine();
        }

        /// <summary>
        /// Method for serializing student's instance using Binary serialization.
        /// </summary>
        static void BinarySerialization(Student student)
        {
            Student newstudent;
            //Serializing using Binary Serialization.
            Stream stream = File.Open("SerializationData\\iCalibrator.dat", FileMode.Create);
            BinaryFormatter binaryformatter = new BinaryFormatter();
            binaryformatter.Serialize(stream, student);
            stream.Close();

            //Deserializing using Binary Serialization.
            stream = File.Open("SerializationData\\iCalibrator.dat", FileMode.Open);
            binaryformatter = new BinaryFormatter();
            newstudent = (Student)binaryformatter.Deserialize(stream);
            Console.WriteLine("Student's Details after deserialization from Binary Serialization:");
            Console.WriteLine("Roll Number: {0}", newstudent.roll_number);
            Console.WriteLine("Name: {0}", newstudent.name);
            Console.WriteLine("Total Marks: {0}", newstudent.totalmarks);
        }

        /// <summary>
        /// Method for serializing student's instance using XML serialization.
        /// </summary>
        static void XMLSerialization(Student student)
        {
            Student newstudent;
            //Serializing using XML Serialization.
            Stream stream = File.Open("SerializationData\\iCalibrator.xml", FileMode.Create);
            XmlSerializer xml = new XmlSerializer(student.GetType());
            xml.Serialize(stream, student);
            stream.Close();

            //Deserializing using XML Serialization.
            stream = File.Open("SerializationData\\iCalibrator.xml", FileMode.Open);
            xml = new XmlSerializer(student.GetType());
            newstudent = (Student)xml.Deserialize(stream);
            Console.WriteLine("Student's Details after deserialization from XML Serialization:");
            Console.WriteLine("Roll Number: {0}", newstudent.roll_number);
            Console.WriteLine("Name: {0}", newstudent.name);
            Console.WriteLine("Total Marks: {0}", newstudent.totalmarks);
        }

        /// <summary>
        /// Method for serializing student's instance using Soap serialization.
        /// </summary>
        /// <param name="student"></param>
        static void SoapSerialization(Student student)
        {
            Student newstudent;
            //Serializing using Soap Serialization.
            Stream stream = File.Open("SerializationData\\iCalibrator.soap", FileMode.Create);
            SoapFormatter soap = new SoapFormatter();
            soap.Serialize(stream, student);
            stream.Close();

            //Deserializing using Soap Serialization.
            stream = File.Open("SerializationData\\iCalibrator.soap", FileMode.Open);
            soap = new SoapFormatter();
            newstudent = (Student)soap.Deserialize(stream);
            Console.WriteLine("Student's Details after deserialization from Soap Serialization:");
            Console.WriteLine("Roll Number: {0}", newstudent.roll_number);
            Console.WriteLine("Name: {0}", newstudent.name);
            Console.WriteLine("Total Marks: {0}", newstudent.totalmarks);
        }
    }
}

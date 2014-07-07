using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace Serialization_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student student = new Student();
            student.roll_number = 12345;
            student.name = "Ipsit Gaur";
            student.totalmarks = 80;
            students.Add(student);
            student = new Student();
            student.roll_number = 1234;
            student.name = "ABCD";
            student.totalmarks = 70;
            students.Add(student);
            student = new Student();
            student.roll_number = 123;
            student.name = "XYZ";
            student.totalmarks = 60;
            students.Add(student);
            student = new Student();
            student.roll_number = 12;
            student.name = "PQR";
            student.totalmarks = 90;
            students.Add(student);

            DirectoryInfo newdirectory = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\SerializationData");
            if (!newdirectory.Exists)
                newdirectory.Create();

            BinarySerialization(students);
            XMLSerialization(students);
            //SoapSerialization(students);
            Console.ReadLine();
        }

        /// <summary>
        /// Method for serializing student's instance using Binary serialization.
        /// </summary>
        static void BinarySerialization(List<Student> students)
        {
            List<Student> newlist;
            //Serializing using Binary Serialization.
            Stream stream = File.Open("SerializationData\\iCalibrator.dat", FileMode.Create);
            BinaryFormatter binaryformatter = new BinaryFormatter();
            binaryformatter.Serialize(stream, students);
            stream.Close();

            //Deserializing using Binary Serialization.
            stream = File.Open("SerializationData\\iCalibrator.dat", FileMode.Open);
            binaryformatter = new BinaryFormatter();
            newlist = (List<Student>)binaryformatter.Deserialize(stream);
            Console.WriteLine("Student's Details after deserialization from Binary Serialization:");
            foreach (Student newstudent in newlist)
            {
                Console.WriteLine("Roll Number: {0}", newstudent.roll_number);
                Console.WriteLine("Name: {0}", newstudent.name);
                Console.WriteLine("Total Marks: {0}", newstudent.totalmarks);
            }
        }

        /// <summary>
        /// Method for serializing student's instance using XML serialization.
        /// </summary>
        static void XMLSerialization(List<Student> students)
        {
            List<Student> newlist = new List<Student>();
            //Serializing using XML Serialization.
            Stream stream = File.Open("SerializationData\\iCalibrator.xml", FileMode.Create);
            XmlSerializer xml = new XmlSerializer(students.GetType());
            xml.Serialize(stream, students);
            stream.Close();

            //Deserializing using XML Serialization.
            stream = File.Open("SerializationData\\iCalibrator.xml", FileMode.Open);
            xml = new XmlSerializer(newlist.GetType());
            newlist = (List<Student>)xml.Deserialize(stream);
            Console.WriteLine("Student's Details after deserialization from XML Serialization:");
            foreach (Student newstudent in newlist)
            {
                Console.WriteLine("Roll Number: {0}", newstudent.roll_number);
                Console.WriteLine("Name: {0}", newstudent.name);
                Console.WriteLine("Total Marks: {0}", newstudent.totalmarks);
            }
        }

        /// <summary>
        /// Method for serializing student's instance using Soap serialization.
        /// </summary>
        /// <param name="student"></param>
        static void SoapSerialization(List<Student> students)
        {
            List<Student> newlist = new List<Student>();
            //Serializing using Soap Serialization.
            Stream stream = File.Open("SerializationData\\iCalibrator.soap", FileMode.Create);
            SoapFormatter soap = new SoapFormatter();
            soap.Serialize(stream, students);
            stream.Close();

            //Deserializing using Soap Serialization.
            stream = File.Open("SerializationData\\iCalibrator.soap", FileMode.Open);
            soap = new SoapFormatter();
            newlist = (List<Student>)soap.Deserialize(stream);
            Console.WriteLine("Student's Details after deserialization from Soap Serialization:");
            foreach (Student newstudent in newlist)
            {
                Console.WriteLine("Roll Number: {0}", newstudent.roll_number);
                Console.WriteLine("Name: {0}", newstudent.name);
                Console.WriteLine("Total Marks: {0}", newstudent.totalmarks);
            }
        }
    }
}

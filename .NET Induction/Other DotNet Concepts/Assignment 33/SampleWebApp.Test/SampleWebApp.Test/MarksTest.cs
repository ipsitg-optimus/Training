using System;
using SampleWebApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleWebApp.Test
{
    [TestClass]
    public class MarksTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int boundarymarks_lower = 0;
            int boundarymarks_upper = 100;
            int positivemarks = 130;
            int negativemarks = -80;

            Student student = new Student();
            student.PrintMarks(boundarymarks_lower.ToString());
            student.PrintMarks(boundarymarks_upper.ToString());
            student.PrintMarks(positivemarks.ToString());
            student.PrintMarks(negativemarks.ToString());
        }
    }
}

using _2.Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test
{
    [TestClass]
    public class GradeBookTest // Has to be public as Test runner would be able to execute the code outside the test class
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(20);

            GradeStatisitcs results = book.ComputeStatistics();
            Assert.AreEqual(20, results.HighestGrade);

        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(20);

            GradeStatisitcs results = book.ComputeStatistics();
            Assert.AreEqual(10, results.LowestGrade);

        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(20);
            book.AddGrade(15.50f);

            GradeStatisitcs results = book.ComputeStatistics();
            Assert.AreEqual(15.167, results.AverageGrade, 0.001);

        }
    }
}

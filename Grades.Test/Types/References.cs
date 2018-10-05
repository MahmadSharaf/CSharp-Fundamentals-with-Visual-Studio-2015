using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Grades.Types
{
    
    [TestClass]
    public class References
    {
        [TestMethod] /*Struct and enum*/
        public void StringComparisons()
        {   // string is a class so it is a pointer, F12 can navigate to the origin defination
            string name1 = "Sharaf";
            string name2 = "sharaf";
            // StringComparison.InvariantCultureIgnoreCase is an enumaration 
            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod] // Value
        public void IntVariableHoldsValue()
        {
            int x1 = 4;
            int x2 = x1;

            x1 = 3;

            Assert.AreNotEqual(x1, x2);
        }
        [TestMethod] // Reference
        public void VariableHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1; // g2 hold the reference of g1, so whatever value g1 has, g2 will be the same.s

            g1.Name = "Sharaf's Grade Book";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}

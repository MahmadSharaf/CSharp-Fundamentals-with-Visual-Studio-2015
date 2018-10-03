using System;
using System.Collections.Generic; /* This name space full of collections classes that allows to store multiole things such as list collection*/
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Grades
{
    class GradeBook
    {/*Members can be Behavior which are the actions, and can be states that holdes the contents*/
        public void AddGrade(float grade) /* Behavior Member*/
        {
            grades.Add(grade); /* Adds the value in grade variable to member grades*/
        }
        List<float> grades; /*State Member that holds float number; it can hold 0 or 1000*/ 
    }
}

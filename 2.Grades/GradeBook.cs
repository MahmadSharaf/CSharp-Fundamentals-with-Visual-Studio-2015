using System;
using System.Collections.Generic; /* This name space full of collections classes that allows to store multiole things such as list collection*/
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Grades
{
    class GradeBook
    {/*Members can be Behavior which are the actions, and can be states that holdes the contents*/
        public GradeBook()
        { /* This an explicit constructor that is used to initialize objects or variables*/
            grades = new List<float>(); /*This initialize variable grades at the instantiate stage*/
        }

        public void AddGrade(float grade) /* Behavior Member*/
        {
            grades.Add(grade); /* Adds the value in grade variable to member grades*/
        }
        List<float> grades; /*State Member that holds float number; it can hold 0 or 1000
                            No need for initializing this as it is already initialized in the constructor*/ 
    }
}

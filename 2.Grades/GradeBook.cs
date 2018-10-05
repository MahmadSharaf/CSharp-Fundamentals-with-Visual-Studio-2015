using System;
using System.Collections.Generic; /* This name space full of collections classes that allows to store multiole things such as list collection*/
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Grades
{
    public class GradeBook // The class access modifier changed from 
                            // implicity internal"scope inside class only" to explicity public "its scope is everywhere" 
    {/*Members can be Behavior which are the actions, and can be states that holdes the contents*/
        public GradeBook()
        { /* This an explicit constructor that is used to initialize objects or variables*/
            grades = new List<float>(); /*This initialize variable grades at the instantiate stage*/
        }

        public GradeStatisitcs ComputeStatistics()
        {/* This member method calculates  Avg, Min, and Max Grade 
            It returns a variable of type GradeStatistics*/
            GradeStatisitcs stats = new GradeStatisitcs(); /* A variable of GradeStatistics type*/

            float sum = 0;

            foreach(float grade in grades) 
            {
                sum += grade;
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);/*Math.Max returns the highest between two given values*/
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
            }
            stats.AverageGrade = sum/grades.Count;/*grades.Count returns the number of items inside grades list*/
            return stats;
        }

        public void AddGrade(float grade) /* Behavior Member*/
        {
            grades.Add(grade); /* Adds the value in grade variable to member grades*/
        }
        // Properties all about state while methods all about behaviors
        public string Name // this a property
        {
            // get; set; //auto implemented accessors
            get //do computations or retrieve some field value and return it
            {
                return _name;
            }
            set //it can preform validations and protect the internal state of the object
            {
                if(!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }
        private string _name;
        public List<float> grades; /*State Member that holds float numbers; it can hold 0 or 100
                            No need for initializing this as it is already initialized in the constructor*/ 
    }
}

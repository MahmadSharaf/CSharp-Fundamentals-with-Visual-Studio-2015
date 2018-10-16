using System;
using System.Collections;
using System.Collections.Generic; /* This name space full of collections classes that allows to store multiple things such as list collection*/
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Grades
{
    public class GradeBook : GradeTracker
    // The class access modifier changed from implicitly internal"scope inside class only" to explicitly public "its scope is everywhere" 

    {
        public GradeBook()  /* This an explicit constructor that is used to initialize objects or variables*/
        { 
            grades = new List<float>();     // This initialize variable grades at the instantiate stage
            _name = "Empty";                // initialize _name as not to be null
        }

        /*Members can be Behavior which are the actions "AddGrade", and can be states that holds the contents "grades"*/
        // Properties all about state while methods are all about behaviors

        public override void AddGrade(float grade) /* Behavior Member*/
        {
            grades.Add(grade); /* Adds the value in grade variable to member grades*/
        }

        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }

        /* State Member that holds float numbers; it can hold 0 or 100 No need 
         * for initializing this as it is already initialized in the constructor*/
        protected List<float> grades; 
        
        public bool ThrowAwayLowest { get; set; }

        public override GradeStatisitcs ComputeStatistics()
        {/* This member method calculates  Avg, Min, and Max Grade 
            It returns a variable of type GradeStatistics*/
            GradeStatisitcs stats = new GradeStatisitcs(); /* A variable of GradeStatistics type*/

            float sum = 0;

            foreach (float grade in grades)
            {
                sum += grade;
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);/*Math.Max returns the highest between two given values*/
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);  /*Math.Min returns the lowest  between two given values*/
            }
            stats.AverageGrade = sum / grades.Count;/*grades.Count returns the number of items inside grades list*/
            return stats;
        }

        public override void WriteGrade(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }
                
        
        
    }
}
/* Access Modifiers:
 * Public: The type or member can be accessed by any other code in the same assembly or another assembly that references it.
 * Private: The type or member can be accessed only by code in the same class or struct.
 * Internal: The type or member can be accessed by any code in the same assembly, but not from another assembly.
 * Protected: The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
 * Protected Internal: The type or member can be accessed by any code in the assembly in which it is declared, or from within a derived class in another assembly.
 * Private Protected: The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class.
 * Static: The type or member can be accessed only directly, no initialization needed. The value assigned to it, is static no matter where or when it is accessed to.
 * Virtual: The member type in base class that has a member with the same name in derived class. This allows the compiler to decide which method to invoke depending on the type of the object calling the method.
 * Override: The member type in derived class that has a member with the same name in base class. This allows the compiler to decide which method to invoke depending on the type of the object calling the method.
 * Abstract: It is a class that is used as the base class for the derived classes. It may has abstract methods"has no implementation" or partially implemented methods.
 * Interface: It is a class that defines only the signature (name and parameters) of the methods, properties, and events. But can never has implementations.
 */

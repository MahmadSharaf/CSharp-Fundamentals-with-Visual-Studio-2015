using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook(); /*Instances of classes is not defined as defining variables, a method new has to be invoked*/
            book.AddGrade(20); /* Add 20 into grades field using AddGrade Member*/
            book.AddGrade(8.5f); /*8.5 is considered as precision of double so an f has to used to tell it is a float number*/
            book.AddGrade(75);
            GradeStatisitcs stats = book.ComputeStatistics();
            Console.WriteLine("Highest Grade= "+stats.HighestGrade);
            Console.WriteLine("Lowest Grade= "+stats.LowestGrade);
            Console.WriteLine("Average Grade= " + stats.AverageGrade);
        }
    }
}

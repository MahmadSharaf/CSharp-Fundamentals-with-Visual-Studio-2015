using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis; /* Add this by Reference Manager*/

namespace _2.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This class speaks out the string*/
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello! This is program made by Mohamed Sharaf.");


            GradeBook book = new GradeBook(); /*Instances of classes is not defined as defining variables, a method new has to be invoked*/

            book.NameChanged = new NameChangedDelegate(OnNameChanged);

            book.Name = "Sharaf's GradeBook";
            book.AddGrade(20); /* Add 20 into grades field using AddGrade Member*/
            book.AddGrade(8.5f); /*8.5 is considered as precision of double so an f has to used to tell it is a float number*/
            book.AddGrade(75);
            GradeStatisitcs stats = book.ComputeStatistics();

            Console.WriteLine(book.Name);
            WriteResult("Highest Grade",(int)stats.HighestGrade); //First method used
            WriteResult("Lowest Grade",stats.LowestGrade);        //Second method used  
            WriteResult("Average Grade",stats.AverageGrade);      //Third method used  
        }
        static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Grade Book Name Changed From {existingName} to {newName}");
        }
        // Two methods(functions) with same name but different params type
        // one takes integers as input and the other takes float
        // the compiler choose the one that make sense
        static void WriteResult(string Description, int Result)
        {   //Instead of using concatenation, a place holder is used
            Console.WriteLine("{0}: {1}", Description, Result);
        }

        static void WriteResult(string Description, float Result)
        {   // In C# v.6 instead of using place holder the below formatis used instead
            Console.WriteLine($"{Description}: {Result}");
        }
    }
}

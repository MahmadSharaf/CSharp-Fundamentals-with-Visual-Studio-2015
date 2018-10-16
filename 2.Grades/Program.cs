using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis; /* Add this by Reference Manager*/
using System.IO;

namespace _2.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
         // SynthesizedSpeaking("Hello! This is program made by Mohamed Sharaf.");
            GradeBook book = new ThrowAwayLowestGrade(); /*Instances of classes is not defined as defining variables, a method new has to be invoked*/
            CheckNameChange(book);
         // GetBookName(book);
            Console.WriteLine(book.Name);
            AddGrades(book);
            SaveGrades(book);
            WriteResults(book);
        }

        private static void SynthesizedSpeaking(string text)
        {
            /* This class speaks out the string*/
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak(text);
        }

        private static void CheckNameChange(GradeBook book)
        {
            book.NameChanged += new NameChangedDelegate(OnNameChanged); //subscriber // NameChanged is now an event, so += or -= has to be used
            book.NameChanged += OnNameChanged; // event can be defined by the name of the method only no need for new keyword or the delegate method name
            book.NameChanged -= new NameChangedDelegate(OnNameChanged);//unsubscriber // -= removes one instance 
        }

        private static void WriteResults(GradeBook book)
        {
            GradeStatisitcs stats = book.ComputeStatistics();
            WriteResult("Highest Grade", (int)stats.HighestGrade); //First method is used
            WriteResult("Lowest Grade", stats.LowestGrade);        //Second method is used  
            WriteResult("Average Grade", stats.AverageGrade);      //Second method is used
            WriteResult(stats.Description, stats.LetterGrade);     //Third method is used
        }

        private static void SaveGrades(GradeBook book)
        {
            // using is used to dispose unneeded data if an unhandled error occurred.
            using (StreamWriter output = File.CreateText("Grades.txt"))// Create an empty text file with File.createText which returns data with StreamWriter type
            {
                //The WriteGrade method in GradeBook class expects data of StreamWriter type
                book.WriteGrade(output);
                // output.Close(); // This has to be used to save the data, as any type of Stream whether it is a FileStream or NetworkStream, 
                // Streams has tendency for buffering
            }
        }

        private static void AddGrades(GradeBook book)
        {
            book.AddGrade(20); /* Add 20 into grades field using AddGrade Member*/
            book.AddGrade(8.5f); /*8.5 is considered as precision of double so an f has to used to tell it is a float number*/
            book.AddGrade(75);
        }

        private static void GetBookName(GradeBook book)
        {
            // This block make sure no null name is entered and continuously prompt until a not Null name entered
            do
            {
                try // This try and catch block is used when an error is expected to happen if specific sequence run
                {// here is the code to be run
                    Console.WriteLine("Enter a name: ");
                    book.Name = Console.ReadLine();
                }
                catch (ArgumentException ex)
                {// here the code to be run when the expected error occurs
                    Console.WriteLine(ex.Message);
                }
            } while (book.Name == null);
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
        {   // In C# v.6 instead of using place holder the below format used instead
            Console.WriteLine($"{Description}: {Result}");
        }

        static void WriteResult(string Description, string Result)
        { 
            Console.WriteLine($"{Description}: {Result}");
        }
    }
}

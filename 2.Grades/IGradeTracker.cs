using System.Collections;
using System.IO;

namespace _2.Grades
{
    internal interface IGradeTracker : IEnumerable
    {
        void AddGrade(float grade);
        GradeStatisitcs ComputeStatistics();
        void WriteGrade(TextWriter destination);
        string Name { get; set; }
        event NameChangedDelegate NameChanged;

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Grades
{ /* This class encapsulates the algorithm for computing Avg, Min, and Max Grade*/
    class GradeStatisitcs
    {
        public GradeStatisitcs()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public float HighestGrade;
        public float LowestGrade;
        public float AverageGrade;

    }
}

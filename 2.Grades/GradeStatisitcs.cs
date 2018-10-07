using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Grades
{ /* This class encapsulates the algorithm for computing Avg, Min, and Max Grade*/
    public class GradeStatisitcs
    {
        public GradeStatisitcs()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public string Description
        {
            get
            {
                string result;
                switch(LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Very Good";
                        break;
                    case "C":
                        result = "Good";
                        break;
                    case "D":
                        result = "Fair";
                        break;
                    default :
                        result = "Failed";
                        break;
                }
                return result;
            }
        }

        public string LetterGrade
        {
            get
            {
                string result;
                if (AverageGrade >= 90)
                    result = "A";
                else if (AverageGrade >= 80)
                    result = "B";
                else if (AverageGrade >= 70)
                    result = "C";
                else if (AverageGrade >= 60)
                    result = "D";
                else result = "F";
                return result;
            }
        }
        public float HighestGrade;
        public float LowestGrade;
        public float AverageGrade;

    }
}

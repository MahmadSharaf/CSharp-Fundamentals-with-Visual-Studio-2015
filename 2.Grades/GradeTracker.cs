using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Grades
{
    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatisitcs ComputeStatistics();
        public abstract void WriteGrade(TextWriter destination);
        public string Name // this a property
        {
            // get; set; //auto implemented accessors
            get //do computations or retrieve some field value and return it
            {
                return _name;
            }
            set //it can preform validations and protect the internal state of the object
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name can not be Null or empty");
                }

                if (_name != value)
                {
                    NameChanged(_name, value);
                }
                _name = value;

            }
        }

        public event NameChangedDelegate NameChanged; //An instance of the delegate

        protected string _name;

        public abstract IEnumerator GetEnumerator();
    }
}

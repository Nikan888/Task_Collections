using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Collections
{
    public class Worker : IComparable<Worker>
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string WorkPosition { get; set; }

        public int CompareTo(Worker other)
        {
            return WorkPosition.CompareTo(other.WorkPosition);
        }

        public override string ToString()
        {
            return (FirstName + ";" + Age + ";" + WorkPosition);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Collections
{
    public class Crew : List<Worker>
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Worker w in this)
            {
                sb.AppendFormat("{0};{1};{2}", w.FirstName, w.Age, w.WorkPosition);
            }
            return sb.ToString();
        }
    }
}

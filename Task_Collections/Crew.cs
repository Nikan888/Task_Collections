using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Collections
{
    public class Crew<T> : List<Worker>, IComparer<T> where T : Worker
    {
        public int Compare(T x, T y)
        {
            if (String.Compare(x.WorkPosition, y.WorkPosition) < 0)
                return 1;
            if (String.Compare(x.WorkPosition, y.WorkPosition) > 0)
                return -1;
            else return 0;
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (Worker w in this)
        //    {
        //        sb.AppendFormat("{0};{1};{2}", w.FirstName, w.Age, w.WorkPosition);
        //    }
        //    return sb.ToString();
        //}
    }
}

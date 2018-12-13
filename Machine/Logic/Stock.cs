using Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
   public class Stock
    {
        public List<IDetail> Details  { get; set; }

        public Stock ()
        {
            Details = new List<IDetail>();
        }

        public void Add (IDetail detail)
        {
            Details.Add(detail);
        }

        public bool IsEmpty()
        {
            return Details.Count != 0;
        }

        public void RemoveDetail ()
        {
            Details.RemoveAt(0);          

        }
    }
}

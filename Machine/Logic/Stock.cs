using Logic.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
   public class Stock
    {
        public BindingList<IDetail> Details  { get; set; }

        public Stock ()
        {
            Details = new BindingList<IDetail>();
        }

        public void Add (IDetail detail)
        {
            lock (Details)
            {
                Details.Add(detail);
            }
        }

        public bool IsEmpty()
        {
            return Details.Count == 0;
        }

        public void RemoveDetail ()
        {
            lock (Details)
            {
                if (!IsEmpty())
                    Details.Remove(Details.First());
            }

        }
    }
}

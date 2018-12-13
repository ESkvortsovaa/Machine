using Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logic
{
   public class Loader
    {
        public Stock Stock = new Stock();

        public void Start()
        {
            while (true)
            {
                Thread.Sleep(5000);
                PutOut();
            }
        }

        public void PutOut()
        {
            if (!Stock.IsEmpty())
            {
                Stock.RemoveDetail();   
            }
        }

        public void RegisterObject(IDetail detail)
        {
            //lock (this)
            {
                Stock.Add(detail);
            }
        }
    }
}

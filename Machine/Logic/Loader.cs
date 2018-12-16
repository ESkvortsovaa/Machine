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

        public void Start()
        {
            while (true)
            {
                Thread.Sleep(5000);
                TakeDetail();
            }
        }       

        public event Action TakeDetail;
    }
}

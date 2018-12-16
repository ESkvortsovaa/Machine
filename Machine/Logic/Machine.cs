using Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logic
{
   public class Machine
    {
        public void Start()
        {
            while (true)
            {
                Thread.Sleep(3000);
                CreateDetail();
            }
        }


        public void CreateDetail ()
        {

            Random random = new Random();
            int randomid = random.Next(3);
            if (randomid == 0)
            {
                Detail1 detail1 = new Detail1();
                DetailCreated(detail1);
            }
            else if (randomid == 1)
            {
                Detail2 detail2 = new Detail2();
                DetailCreated(detail2);
            }
            else
            {
                Detail3 detail3 = new Detail3();
                DetailCreated(detail3);
            }
        }

        public event Action<IDetail> DetailCreated;
    }
}

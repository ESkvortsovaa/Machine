using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logic
{
    public class Worker
    {
        Loader Loader = new Loader();
        Machine Machine = new Machine();
        
        public void Work()
        {
            Machine.DetailCreated += Loader.RegisterObject;
            Thread MachineThread = new Thread(new ThreadStart(Machine.Start));
            MachineThread.Start();

            Thread LoaderThread = new Thread(new ThreadStart(Loader.Start));
            LoaderThread.Start();
        }
    }
}

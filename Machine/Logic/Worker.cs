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
        public Stock Stock = new Stock();
        /// <summary>
        /// для создания
        /// </summary>
        public event Action DetailCreated;

        /// <summary>
        /// Для удаления
        /// </summary>
        public event Action DetailRemoved;
        
        public void Work()
        {
            Machine.DetailCreated += Stock.Add;
            Thread MachineThread = new Thread(new ThreadStart(Machine.Start));
            MachineThread.Start();

            Loader.TakeDetail += Stock.RemoveDetail;
            Thread LoaderThread = new Thread(new ThreadStart(Loader.Start));
            LoaderThread.Start();
        }
    }
}

using Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Detail2 : IDetail
    {
        private static int _last = 0;

        public int Id
        {
            get
            {
                _last++;
                return _last;
            }
        }

        public override string ToString()
        {
            return "Деталь2 " + Id;
        }
    }
}

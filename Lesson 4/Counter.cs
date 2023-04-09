using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    internal class Counter
    {
        public delegate void AccountHandler();
        public event AccountHandler? Notify;
        const int max = 100;
        public void Count()
        {
            for (int i = 1; i <= max; i++)
            {
                if(i == 77)
                {
                    Notify?.Invoke();
                }
            }
        }
        
    }
}

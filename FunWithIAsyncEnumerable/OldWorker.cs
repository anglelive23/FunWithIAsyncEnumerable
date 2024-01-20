using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithIAsyncEnumerable
{
    public class OldWorker
    {
        public OldWorker()
        {
            Work();
        }

        public void Work()
        {
            PrintResults();
        }

        public void PrintResults()
        {
            var list = GetListOfInts();
            foreach (int item in list)
            {
                Task.Delay(1000);
                Console.WriteLine(item);
            }
        }

        public List<int> GetListOfInts()
        {
            // generate numbers from 0, 1500
            return Enumerable.Range(0, 1500).Select(i => i).ToList();
        }
    }
}

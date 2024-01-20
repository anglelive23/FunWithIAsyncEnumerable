using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithIAsyncEnumerable
{
    public class IAsyncEnumerableWorker
    {
        public IAsyncEnumerableWorker()
        {
            Work();
        }

        public async void Work()
        {
            await PrintResults();
        }

        public async Task PrintResults()
        {
            var list = GetListOfInts();
            await foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        public async IAsyncEnumerable<int> GetListOfInts()
        {
            for (int i = 0; i < 1500; i++)
            {
                await Task.Delay(5000);
                yield return i;
            }
        }
    }
}

using AsyncAwaitBestPractices;

namespace FunWithIAsyncEnumerable
{
    public class IAsyncEnumerableWorker
    {
        public IAsyncEnumerableWorker()
        {
            PrintResults().SafeFireAndForget();
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
                // Simulate server call
                await Task.Delay(1000);
                yield return i;
            }
        }
    }
}

namespace FunWithIAsyncEnumerable
{
    public class OldWorker
    {
        public OldWorker()
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
            return Enumerable.Range(0, 1500).ToList();
        }
    }
}

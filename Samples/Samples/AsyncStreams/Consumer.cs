using System.Threading.Tasks;

namespace Samples.AsyncStreams
{
    internal class Consumer
    {
        public async Task<int> CountNamesWithN()
        {
            var nameContainingN = 0;
            await foreach (var name in Producer.GetAllNames())
            {
                if (name.Contains("n"))
                {
                    nameContainingN++;
                }
            }

            return nameContainingN;
        }
    }
}
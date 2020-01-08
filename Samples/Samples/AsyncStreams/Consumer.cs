using System.Threading.Tasks;

namespace Samples.AsyncStreams
{
    internal class Consumer
    {
        public async Task<int> CountNamesWithN()
        {
            var namesContainingN = 0;
            await foreach (var name in Producer.GetAllNames())
            {
                if (name.Contains("n"))
                {
                    namesContainingN++;
                }
            }

            return namesContainingN;
        }
    }
}
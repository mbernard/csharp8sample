using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Samples.AsyncStreams
{
    class Consumer
    {
        public async Task Consume()
        {
            await foreach (var name in Producer.GetAllNames())
            {
                Console.WriteLine(name);
            }
        }
    }
}

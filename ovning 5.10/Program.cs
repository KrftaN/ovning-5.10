using System;
using System.Collections.Generic;
using System.Linq;

namespace övning_5._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] talArray = { 1, 2, 2, 3 };

            Dictionary<int, int> frekvenser = new Dictionary<int, int>();

            foreach (int tal in talArray)
            {
                if (frekvenser.ContainsKey(tal))
                {
                    frekvenser[tal]++;
                }
                else
                {
                    frekvenser[tal] = 1;
                }
            }

            int maxFrekvens = frekvenser.Values.Max();

            List<int> vanligasteTal = frekvenser.Where(kv => kv.Value == maxFrekvens).Select(kv => kv.Key).ToList();

            Console.Write("Följande tal är vanligast: ");
            for (int i = 0; i < vanligasteTal.Count; i++)
            {
                Console.Write(vanligasteTal[i]);
                if (i < vanligasteTal.Count - 1)
                {
                    Console.Write(" och ");
                }
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IveBeenEverywhereMan
{
    class Program
    {
        static void Main(string[] args)
        {            
            int t = int.Parse(Console.ReadLine());
            int[] outputs = new int[t];

            for (int i = 0; i < t; i++)
            {
                HashSet<string> inputs = new HashSet<string>();

                int n = int.Parse(Console.ReadLine());

                for (int ii = 0; ii < n; ii++)
                {

                    inputs.Add(Console.ReadLine());
                }
                outputs[i] = inputs.Count;
            }

            foreach (var i in outputs)
            {
                Console.WriteLine(i);
            }
        }
    }
}

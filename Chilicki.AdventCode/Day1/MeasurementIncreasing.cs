using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.AdventCode.Day1
{
    public class MeasurementIncreasing
    {
        private readonly NumbersLoader numbersLoader;
        private readonly string dataPath = "Day1/Data/day1.txt";

        public MeasurementIncreasing()
        {
            numbersLoader = new NumbersLoader();
        }

        public int CountThriples()
        {
            IList<int> data = numbersLoader.LoadFromFile(dataPath);
            IList<int> thriplesSums = GetThriplesSums(data);
            return CountInternal(thriplesSums);
        }

        public int Count()
        {
            IList<int> data = numbersLoader.LoadFromFile(dataPath);
            return CountInternal(data);
        }

        private int CountInternal(IList<int> data)
        {
            List<(int, int)> pairs = GetPairs(data);
            int result = pairs.Count(p => p.Item2 > p.Item1);
            return result;
        }

        private List<(int, int)> GetPairs(IList<int> list)
        {
            var pairs = new List<(int, int)>();
            for (int index = 0; index < list.Count() - 1; index++)
            {
                pairs.Add((list[index], list[index + 1]));
            }
            return pairs;
        }

        private List<int> GetThriplesSums(IList<int> list)
        {
            var sums = new List<int>();
            for (int index = 2; index < list.Count(); index++)
            {
                int sum = list[index] + list[index - 1] + list[index - 2];
                sums.Add(sum);
            }
            return sums;
        }
    }
}

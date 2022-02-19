using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.AdventCode.Day1
{
    public class NumbersLoader
    {
        public IList<int> LoadFromFile(string path)
        {
            IList<string> lines = File.ReadAllLines(path);
            IList<int> numbers = new List<int>();
            foreach (var line in lines)
            {
                int number = Convert.ToInt32(line);
                numbers.Add(number);
            }
            return numbers;
        }
    }
}

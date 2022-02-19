using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.AdventCode.Day2
{
    public class OperationLoader
    {
        public IList<Operation> LoadOperations(string dataPath)
        {
            IList<Operation> operations = new List<Operation>();
            IList<string> allLines = File.ReadAllLines(dataPath);
            foreach (string line in allLines)
            {
                IList<string> tokens = line.Split(" ");
                Operation operation = new Operation(tokens[0], int.Parse(tokens[1]));
                operations.Add(operation);
            }
            return operations;
        }
    }
}

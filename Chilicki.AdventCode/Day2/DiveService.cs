using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.AdventCode.Day2
{
    public class DiveService
    {
        private readonly string dataPath = "Day2/Data/day2.txt";
        private readonly OperationLoader operationLoader;

        public DiveService()
        {
            operationLoader = new OperationLoader();
        }

        public Position CalculatePosition()
        {
            var position = new Position();
            IList<Operation> operations = operationLoader.LoadOperations(dataPath);
            Position resultPosition = RunAllOperations(position, operations);
            return resultPosition;
        }

        private Position RunAllOperations(Position position, IList<Operation> operations)
        {
            foreach (Operation operation in operations)
            {
                position = operation.ChangePosition(position);
            }
            return position;
        }
    }
}

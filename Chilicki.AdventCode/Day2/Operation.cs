using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.AdventCode.Day2
{
    public class Operation
    {
        public Command Command { get; set; }
        public int Units { get; set; }

        public Operation(string command, int units)
        {
            if (command == "forward")
            {
                Command = Command.Forward;
            }
            if (command == "up")
            {
                Command = Command.Up;
            }
            if (command == "down")
            {
                Command = Command.Down;
            }
            Units = units;
        }

        public Position ChangePosition(Position position)
        {
            if (Command == Command.Forward)
            {
                IncreaseHorizontal(position, Units);
            }
            if (Command == Command.Up)
            {
                DeacreaseDepth(position, Units);
            }
            if (Command == Command.Down)
            {
                IncreaseDepth(position, Units);
            }
            return position;
        }

        private void IncreaseHorizontal(Position position, int units)
        {
            position.Horizontal += units;
        }

        private void IncreaseDepth(Position position, int units)
        {
            position.Depth += units;
        }

        private void DeacreaseDepth(Position position, int units)
        {
            IncreaseDepth(position, units * (-1));
        }
    }
}

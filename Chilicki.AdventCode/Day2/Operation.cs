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
                IncreaseDepthWithAim(position, Units);
            }
            if (Command == Command.Up)
            {
                DeacreaseAim(position, Units);
            }
            if (Command == Command.Down)
            {
                IncreaseAim(position, Units);
            }
            return position;
        }

        private void IncreaseHorizontal(Position position, int units)
        {
            position.Horizontal += units;
        }

        private void IncreaseDepthWithAim(Position position, int units)
        {
            position.Depth += units * position.Aim;
        }

        private void IncreaseAim(Position position, int units)
        {
            position.Aim += units;
        }

        private void DeacreaseAim(Position position, int units)
        {
            IncreaseAim(position, units * (-1));
        }
    }
}

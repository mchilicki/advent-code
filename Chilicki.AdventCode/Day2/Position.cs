using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.AdventCode.Day2
{
    public class Position
    {
        public int Horizontal { get; set; } = 0;
        public int Depth { get; set; } = 0;
        public int Aim { get; set; } = 0;

        public int GetFinalResult()
        {
            return Horizontal * Depth;
        }
    }
}

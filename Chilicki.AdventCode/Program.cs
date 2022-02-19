
using Chilicki.AdventCode.Day1;
using Chilicki.AdventCode.Day2;

bool shouldEnd = false;

while (!shouldEnd)
{
    Console.WriteLine("https://adventofcode.com");
    var service = new DiveService();
    Position position = service.CalculatePosition();
    Console.WriteLine(position.GetFinalResult());
    Console.ReadKey();
}


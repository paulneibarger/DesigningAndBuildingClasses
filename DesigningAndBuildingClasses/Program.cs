using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningAndBuildingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Color tennisGreen = new Color(233, 255, 79);
            Color handBallBlue = new Color(0, 47, 149);
            Color white = new Color();
            Ball tennisBall = new Ball(size: 2, color: tennisGreen);
            Ball handBall = new Ball(size: 2, color: handBallBlue);
            Ball pingPong = new Ball(size: 1, color: white);

            tennisBall.Throw();
            handBall.Throw(NumberOfTimes: 13);
            handBall.Throw(NumberOfTimes: -3);
            pingPong.Throw(NumberOfTimes: 2);
            pingPong.Pop();
            pingPong.Throw(NumberOfTimes: 40);
            Console.WriteLine($"Tennis ball was thrown {tennisBall.NumberOfTimesThrown()} times.");
            Console.WriteLine($"Hand ball was thrown {handBall.NumberOfTimesThrown()} times.");
            Console.WriteLine($"Ping pong ball was thrown {pingPong.NumberOfTimesThrown()} times.");

            Console.ReadLine();
        }
    }
}

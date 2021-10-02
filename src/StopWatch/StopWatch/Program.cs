using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {

            var stopwatch = new Stopwatch();

            while (true)
            {
                Console.WriteLine("If you want to start the Stopwatch type 'Start'");
                while (true)
                {
                    var input = Console.ReadLine().ToLower();
                    if (input == "start")
                    {
                        stopwatch.Start();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("If you want to start the Stopwatch type 'Start'");
                    }
                }

                Console.WriteLine("Now type 'Stop' any time you want to stop");

                while (true)
                {
                    var input = Console.ReadLine().ToLower();
                    if (input == "start")
                        throw new InvalidOperationException("You cannot start the Stopwatch twice");

                    if (input == "stop")
                    {
                        stopwatch.Stop();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("If you want to stop the Stopwatch type stop");
                    }
                }

                var elapsedTime = stopwatch.GetElapsedTime();
                Console.WriteLine("Elapsed time: " + elapsedTime);
            }
        }
    }
}

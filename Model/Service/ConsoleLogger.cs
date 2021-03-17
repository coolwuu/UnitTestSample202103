using System;

namespace Model.Service
{
    class ConsoleLogger : ILogger
    {
        public void Error(string message)
        {
            Console.WriteLine(message);
        }
    }
}
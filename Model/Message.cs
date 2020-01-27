using System;

namespace blockbuster.Models
{
    class Message
    {
        public ConsoleColor Color { get; set; }
        public string Body { get; set; }

        public void Print()
        {
            Console.ForegroundColor = Color;
            System.Console.WriteLine(Body);
        }
        public Message(string body, ConsoleColor color)
        {
            Body = body;
            Color = color;
        }
    }
}
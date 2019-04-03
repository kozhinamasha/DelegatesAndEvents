using System;

namespace DelegatesAndEvents.SimpleDelegate
{
    delegate void Printer(string text);
    delegate void PrintWithLambdaSimple(string text);

    public class SimpleDelegate
    {
        public static void PrintText(string text)
        {
            Console.WriteLine("The printed text is: " + text);
        }
    }
}

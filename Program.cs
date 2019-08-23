using Qiwi.Classes;
using System;

namespace Qiwi
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();

            Console.WriteLine("Введите список номер тел.:");
            string input = Console.ReadLine();
            Console.WriteLine("Сколько номеров вывести на экран?");
            string inputtwo = Console.ReadLine();



            try
            {
                queue.enqueue(input.Split(' '));
                queue.getResult(Int32.Parse(inputtwo));
            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine("{0}, {1}",ex.StackTrace, ex.Message);
            }

            Console.ReadKey();

        }

        






    }
}

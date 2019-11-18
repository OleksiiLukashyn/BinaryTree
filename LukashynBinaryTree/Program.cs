using System;
using System.Diagnostics;

namespace LukashynBinaryTree
{
    internal class Program
    {
        private static void Main()
        {
            var rand = new Random();
            var tree = new BinaryTree<int>();
            for (var i = 0; i < 100000; i++)
            {
                tree.AddElement(rand.Next(-10000, 10000));
            }

            var stopWatch = new Stopwatch();

            try
            {
                stopWatch.Start();
                var res = tree.FindElement(50);
                stopWatch.Stop();
                Console.WriteLine("Runtime: " + stopWatch.Elapsed);
                Console.WriteLine($"Element was found. Value: {res};\nPrevious element: {res.PrevElement};\nNext element: {res.NextElement}.");
            }
            catch (ArgumentException e)
            {
                stopWatch.Stop();
                Console.WriteLine("Runtime: " + stopWatch.Elapsed);
                Console.WriteLine(e.Message);
            }
        }
    }
}

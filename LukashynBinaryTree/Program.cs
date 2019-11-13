using System;
using System.Diagnostics;

namespace LukashynBinaryTree
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            BinaryTree<int> tree = new BinaryTree<int>();
            for (int i = 0; i < 100000; i++)
            {
                tree.AddElement(rand.Next(-10000, 10000));
            }

            Stopwatch stopWatch = new Stopwatch();

            try
            {
                stopWatch.Start();
                var res = tree.FindElement(50);
                stopWatch.Stop();
                Console.WriteLine("Runtime: " + stopWatch.Elapsed);
                Console.WriteLine($"Element was found. Value: {res.Value};\nPrevious element: {res.PrevElement};\nNext element: {res.NextElement}.");
            }
            catch (Exception e)
            {
                stopWatch.Stop();
                Console.WriteLine("Runtime: " + stopWatch.Elapsed);
                Console.WriteLine(e.Message);
            }
        }
    }
}

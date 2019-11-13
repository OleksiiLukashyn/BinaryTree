using System;

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
                tree.AddElement(rand.Next(-1000,1000));
            }

            try
            {
                var res = BinaryTree<int>.FindElement(tree, 50);
                Console.WriteLine($"Element was found. Value: {res.Value};\nPrevious element: {res.PrevElement};\nNext element: {res.NextElement}.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

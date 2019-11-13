namespace LukashynBinaryTree
{
    class Program
    {
        static void Main()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.AddElement(1);
            tree.AddElement(2);
            tree.AddElement(2);
            tree.AddElement(0);
        }
    }
}

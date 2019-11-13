using System;

namespace LukashynBinaryTree
{
    public class BinaryTreeElement<T> where T : IComparable
    {
        public T Data { get; set; }
        public BinaryTreeElement<T> ParentElement { get; internal set; }
        public BinaryTreeElement<T> LeftChildElement { get; internal set; }
        public BinaryTreeElement<T> RightChildElement { get; internal set; }

        public BinaryTreeElement(T input)
        {
            Data = input;
        }

        public Side? GetNodeSide()
        {
            if (ParentElement == null)
            {
                return null;
            }
            else if (ParentElement.LeftChildElement == this)
            {
                return Side.Left;
            }
            else
            {
                return Side.Right;
            }
        }
        public override string ToString()
        {
            return Data.ToString();
        }
        public void Print()
        {
            Console.WriteLine(Data);
        }

    }
}

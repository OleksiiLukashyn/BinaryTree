using System;

namespace LukashynBinaryTree
{
    public class BinaryTreeElement<T> where T : IComparable
    {
        public T Value { get; set; }
        public BinaryTreeElement<T> PrevElement { get; internal set; }
        public BinaryTreeElement<T> NextElement { get; internal set; }

        public BinaryTreeElement(T input)
        {
            Value = input;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}

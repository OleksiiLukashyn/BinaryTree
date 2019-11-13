using System;

namespace LukashynBinaryTree
{
    public class BinaryTreeElement<T> where T : IComparable
    {
        public T Value { get; set; }
        /// <summary>
        /// A reference to a child node whose value is less than the parent
        /// </summary>
        public BinaryTreeElement<T> PrevElement { get; internal set; }
        /// <summary>
        /// A reference to a child node whose value is equal to or greater than the parent
        /// </summary>
        public BinaryTreeElement<T> NextElement { get; internal set; }

        public BinaryTreeElement(T input)
        {
            Value = input;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
        public void Print()
        {
            Console.WriteLine(Value);
        }

    }
}

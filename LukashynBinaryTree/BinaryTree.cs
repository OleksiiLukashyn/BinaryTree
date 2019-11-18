using System;
using System.Collections.Generic;

namespace LukashynBinaryTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public BinaryTreeElement<T> RootElement { get; private set; }

        public BinaryTree()
        {
        }
        public BinaryTree(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                AddElement(item);
            }
        }

        public void AddElement(BinaryTreeElement<T> newElement)
        {
            if (RootElement == null)
            {
                RootElement = newElement;
            }
            else
            {
                var currentElement = RootElement;
                while (true)
                {
                    if (newElement.Value.CompareTo(currentElement.Value) < 0)
                    {
                        if (currentElement.PrevElement == null)
                        {
                            currentElement.PrevElement = newElement;
                            return;
                        }

                        currentElement = currentElement.PrevElement;
                    }
                    else
                    {
                        if (currentElement.NextElement == null)
                        {
                            currentElement.NextElement = newElement;
                            return;
                        }

                        currentElement = currentElement.NextElement;
                    }
                }
            }
        }

        public void AddElement(T value)
        {
            AddElement(new BinaryTreeElement<T>(value));
        }

        public BinaryTreeElement<T> FindElement(T value)
        {
            var currentElement = RootElement;
            while (true)
            {
                if (currentElement.Value.CompareTo(value) == 0)
                {
                    return currentElement;
                }

                if (currentElement.Value.CompareTo(value) > 0 && currentElement.PrevElement != null)
                {
                    currentElement = currentElement.PrevElement;
                }
                else if (currentElement.Value.CompareTo(value) < 0 && currentElement.NextElement != null)
                {
                    currentElement = currentElement.NextElement;
                }
                else
                {
                    throw new ArgumentException("Search for this object in the binary tree did not return any results.");
                }
            }
        }
    }
}

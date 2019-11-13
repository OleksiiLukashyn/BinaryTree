using System;

namespace LukashynBinaryTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public BinaryTreeElement<T> RootElement { get; private set; }

        public void AddElement(BinaryTreeElement<T> newElement)
        {
            if (RootElement == null)
            {
                RootElement = newElement;
                return;
            }
            else
            {
                var currentElement = RootElement;
                while (true)
                {
                    if (newElement.Value.CompareTo(currentElement.Value)<0)
                    {
                        if (currentElement.PrevElement == null)
                        {
                            currentElement.PrevElement = newElement;                            
                            return;
                        }
                        else
                        {
                            currentElement = currentElement.PrevElement;
                        }
                    }
                    else
                    {
                        if (currentElement.NextElement == null)
                        {
                            currentElement.NextElement = newElement;                            
                            return;
                        }
                        else
                        {
                            currentElement = currentElement.NextElement;
                        }

                    }
                }
            }
        }
        public void AddElement(T data)
        {
            AddElement(new BinaryTreeElement<T>(data));
        }
    }

}

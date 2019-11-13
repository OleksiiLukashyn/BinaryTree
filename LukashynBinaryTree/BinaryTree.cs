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
                    if (newElement.Data.CompareTo(currentElement.Data)<0)
                    {
                        if (currentElement.LeftChildElement == null)
                        {
                            newElement.ParentElement = currentElement;
                            currentElement.LeftChildElement = newElement;                            
                            return;
                        }
                        else
                        {
                            currentElement = currentElement.LeftChildElement;
                        }
                    }
                    else
                    {
                        if (currentElement.RightChildElement == null)
                        {
                            newElement.ParentElement = currentElement;
                            currentElement.RightChildElement = newElement;                            
                            return;
                        }
                        else
                        {
                            currentElement = currentElement.RightChildElement;
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

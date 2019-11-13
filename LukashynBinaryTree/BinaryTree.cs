﻿using System;
using System.Diagnostics;

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
                    if (newElement.Value.CompareTo(currentElement.Value) < 0)
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
        public void AddElement(T value)
        {
            AddElement(new BinaryTreeElement<T>(value));
        }
        public BinaryTreeElement<T> FindElement(T value)
        {
            Console.WriteLine("Start of binary search");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var currentElement = RootElement;
            while (true)
            {
                if (currentElement.Value.CompareTo(value) == 0)
                {
                    stopWatch.Stop();
                    TimeSpan ts = stopWatch.Elapsed;
                    Console.WriteLine("Binary search completed successfully. RunTime: " + ts);
                    return currentElement;
                }
                else if (currentElement.Value.CompareTo(value) > 0 && currentElement.PrevElement != null)
                {
                    currentElement = currentElement.PrevElement;
                }
                else if (currentElement.NextElement != null)
                {
                    currentElement = currentElement.NextElement;
                }
                else
                {
                    stopWatch.Stop();
                    TimeSpan ts = stopWatch.Elapsed;
                    Console.WriteLine("Element not found. RunTime: " + ts);
                    throw new NullReferenceException("Search for this object in the binary tree did not return any results.");
                }
            }
        }
    }
}

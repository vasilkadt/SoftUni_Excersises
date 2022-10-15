﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private class ListNode
        {
            public int Value { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }

            public ListNode(int value)
            {
                this.Value = value;
            }
        }

        private ListNode Head { get; set; }
        private ListNode Tail { get; set; }

        public int Count { get; private set; }

        public void AddFirst(int element)
        {
            if (this.Count == 0)
            {
                this.Head = this.Tail = new ListNode(element);
            }
            else
            {
                var newHead = new ListNode(element);
                newHead.NextNode = this.Head;
                this.Head.PreviousNode = newHead;
                this.Head = newHead;
            }
            this.Count++;
        }
        public void AddLast(int element)
        {
            if (this.Count == 0)
            {
                this.Head = this.Tail = new ListNode(element);
            }
            else
            {
                var newTail = new ListNode(element);
                newTail.PreviousNode = this.Tail;
                this.Tail.NextNode = newTail;
                this.Tail = newTail;
            }
            this.Count++;
        }
        public int RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            var firstElement = this.Head.Value;
            this.Head = this.Head.NextNode;
            if (this.Head != null)
            {
                this.Head.PreviousNode = null;
            }
            else
            {
                this.Tail = null;
            }
            this.Count--;
            return firstElement;
        }
        public int RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            var lastElement = this.Tail.Value;
            this.Tail = this.Tail.PreviousNode;
            if (this.Tail != null)
            {
                this.Tail.NextNode = null;
            }
            else
            {
                this.Head = null;
            }
            this.Count--;
            return lastElement;
        }
        public void ForEach(Action<int> action)
        {
            var currentNode = this.Head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }
        public int[] ToArray()
        {
            int[] array = new int[this.Count];
            int counter = 0;
            var currentNode = this.Head;
            while (currentNode != null)
            {
                array[counter] = currentNode.Value;
                currentNode = currentNode.NextNode;
                counter++;
            }
            return array;
        }
    }
}

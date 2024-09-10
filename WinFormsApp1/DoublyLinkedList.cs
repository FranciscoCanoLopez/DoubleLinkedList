using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DoublyLinkedList
    {
        private Node head;

        public DoublyLinkedList()
        {
            head = null!;
        }

        public void InsertAtStart(int data)
        {
            Node newNode = new Node(data);
            if (head != null)
            {
                newNode.Next = head;
                head.Prev = newNode;
            }
            head = newNode;
        }

        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Prev = temp;
            }
        }

        public void InsertAtMiddle(int data, int position)
        {
            if (position == 1)
            {
                InsertAtStart(data);
                return;
            }

            Node newNode = new Node(data);
            Node temp = head;

            for (int i = 1; temp != null && i < position - 1; i++)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                InsertAtEnd(data);
                return;
            }

            newNode.Next = temp.Next;
            newNode.Prev = temp;

            if (temp.Next != null)
            {
                temp.Next.Prev = newNode;
            }
            temp.Next = newNode;
        }

        public void DeleteFromStart()
        {
            if (head == null)
            {
                return;
            }

            if (head.Next != null)
            {
                head = head.Next;
                head.Prev = null!;
            }
            else
            {
                head = null!;
            }
        }

        public void DeleteFromEnd()
        {
            if (head == null)
            {
                return;
            }

            if (head.Next == null)
            {
                head = null!;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Prev.Next = null!;
            }
        }

        public void DeleteFromMiddle(int position)
        {
            if (head == null)
            {
                return;
            }

            if (position == 1)
            {
                DeleteFromStart();
                return;
            }

            Node temp = head;

            for (int i = 1; temp != null && i < position; i++)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                return;
            }

            if (temp.Next != null)
            {
                temp.Next.Prev = temp.Prev;
            }

            if (temp.Prev != null)
            {
                temp.Prev.Next = temp.Next!;
            }
        }
        public Node GetHead()
        {
            return head;
        }
        public string Display()
        {
            Node temp = head;
            string result = "";
            while (temp != null)
            {
                result += temp.Data + " <-> ";
                temp = temp.Next;
            }
            return result.TrimEnd(new char[] { '<', '-', ' ' });
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MyLinkedList<T>: IEnumerable<T>
    {
        public Node<T> Head { get; set; }
        public int Length { get; private set; }

        //AddFirst()
        public void AddFirst(T data)
        {
            var headNode = new Node<T>(data);

            if(Head == null)
            {
                Head = headNode;
                Length = 1;
            }                
            else
            {
                var temp = Head;
                Head = headNode;
                Head.Next = temp;
                Length++;
            }
            
        }

        //AddLast()
        public void AddLast(T data)
        {
            if (Head == null)
                AddFirst(data);
            else
            {
                var temp = Head;
                while(temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new Node<T>(data);
                Length++;
            }
        }

        //GetLast()

        //InsertBefore()
        public void InsertBefore(T key, T data)
        {
            if (Head == null)
                throw new ArgumentNullException("List does not contain any value");
            var temp = Head;
            if (temp.Data.Equals(key)) //If head is the key
            {
                Head = new Node<T>(data);
                Head.Next = temp;
                Length++;
            }
            else
            {
                while (!temp.Next.Data.Equals(key))
                {
                    temp = temp.Next;
                }

                var shiftElement = temp.Next;
                temp.Next = new Node<T>(data);
                temp.Next.Next = shiftElement;
                Length++;
            }                        
        }

        //InsertAfter()
        public void InsertAfter(T key, T data)
        {
            if (Head == null)
                throw new ArgumentNullException("");
            var temp = Head;
            while(!temp.Data.Equals(key))
            {
                temp = temp.Next;
            }

            var shiftElement = temp.Next;
            temp.Next = new Node<T>(data);
            temp.Next.Next = shiftElement;
            Length++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (Head == null)
                throw new Exception();
            if (Head.Next == null)
            {
                yield return Head.Data;
            }
            else
            {
                var temp = Head;
                while (temp != null)
                {
                    yield return temp.Data;
                    temp = temp.Next;
                }
            }                            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //Delete()

    }

    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            this.Data = data;
        }
    }
}

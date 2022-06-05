using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class LinkedList
    {
        class Node
        {
            public Node Next;
            public object data;
        }

        class DataStructure
        {
            public Node Head = new Node();

            public void AddAtStart(string input)
            {
                Node ToAdd = new Node();
                ToAdd.data = input;
                ToAdd.Next = Head;
                Head = ToAdd;
            }

            public void AddAtEnd(string input)
            {
                if (Head == null)
                {
                    Head.data = input;
                    Head.Next = null;
                }

                else
                {
                    Node current = Head;
                    Node ToAdd = new Node();
                    ToAdd.data = input;
                    while (current.Next!=null)
                    {
                        current = current.Next;
                    }
                    current.Next = ToAdd;

                }
            }

            public void GetData()
            {
                Node current = Head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.Next;
                }
            }

           public void RemoveAtStart()
            {

                Head = Head.Next.Next;
               
            }

           public void RemoveAtEnd()
           {

               Node Prev = new Node();
               Node Current = Head;
               while (Current.Next != null)
               {
                   Prev = Current;
                   Current = Current.Next;
               }
               Prev.Next = null;



           }

           public void RemoveAt(int i)
           {
               int count = 0;
               Node Prev = new Node();
               if(i==0)
                   Head = Head.Next.Next;
               else
               {
               
               Node Current = Head;
               while (Current.Next != null)
               {
                   if (count == i)
                   {
                       Prev = Current;
                       break;
                   }
                   Current = Current.Next;
                   count++;
               }
               Prev.Next = Current.Next.Next;
               
           }
               }

           public void AddAt(int i, string data)
           {
               int count = 0;
               Node Current = Head;
               Node Prev = new Node();
               /*while (Current.Next != null)
               {
                   if (count == i )
                   {
                       Prev = Current;
                       break;
                   }
                   count++;
                   Current = Current.Next;
               }

               Node ToAdd = new Node();
               ToAdd.data = data;
               ToAdd.Next = Current.Next;
               Prev.Next = ToAdd;*/
               while (Current.Next != null)
               {
                   Prev = Current;
                   Current = Current.Next;
                   if (count == i )
                   {
                       break;
                   }
                   count = count + 1;
               }
               Node ToAdd = new Node();
               ToAdd.data = data;
               ToAdd.Next = Current;
               Prev.Next = ToAdd;
           
           }

        }

        /*static void Main(string[] args)
        {
            DataStructure d = new DataStructure();
            
            d.AddAtEnd("data = 1");
            d.AddAtEnd("data = 2");
            d.AddAtEnd("data = 3");
            d.AddAtEnd("data = 4");
            d.AddAt(1, "data = 22");
            d.GetData();
            Console.ReadLine();
        }*/
    }
}

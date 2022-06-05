using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HashTable 
    {
        class Node
        {
            public Node Next;
            public object key;
            public object value; 
        }

        class DataStructure
        {
            public Node Head =new Node();

            public void AddAtEnd(object key, object value)
            {
                if (Head == null)
                {
                    Head.key = key;
                    Head.value = value;
                    Head.Next = null;
                }

                else
                {
                    Node current = Head;
                    Node ToAdd = new Node();
                    ToAdd.key = key;
                    ToAdd.value = value;
                    while (current.Next != null)
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
                    Console.WriteLine("Key: {0} and value: {1}",current.key,current.value);
                    current = current.Next;
                }
            }


           
            public void GetAt(object k) 
            {
                Node current = Head;

                while (current != null)
                {
                    object o ;
                    
                   
                    if (Convert.ToString(current.key)==Convert.ToString(k))
                    {
                        Console.WriteLine(current.value);
                        break;
                    }
                    current = current.Next;
                }

            }

        }

       /* static void Main(string[] args)
        {
            DataStructure d = new DataStructure();
           
            d.AddAtEnd(1, "1st value");
            d.AddAtEnd(2, "2nd value");
            d.AddAtEnd(3, "3rd value");
            //d.GetData();
            d.GetAt(3);
            Console.ReadLine();
        }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BinaryTree_Practice
    {
        public class Node
        {
           public Node Left;
          public   Node Right;
           public int data;
            public  Node(int d)
            {
                this.data = d;
            }
        }

        class BST
        {
            private Node root = null;
            public void insert(int d)
            {
                Node ToAdd = new Node(d);
               // insert(ToAdd, root);
                if (root == null)
                {
                    root = new Node(d);
                    return;
                }
                // 2. Otherwise, recur down the tree 
                insert(new Node(d), root);

            }

            public void insert(Node r, Node root)
        {
            if (root == null)
                root = r; 
            else
            {
                if (Convert.ToInt32(r.data) < Convert.ToInt32(root.data))
                {
                    if (root.Left == null)
                        root.Left = r;
                    else
                        insert(r, root.Left);

                }
                if (Convert.ToInt32(r.data) > Convert.ToInt32(root.data))
                {
                    if (root.Right == null)
                        root.Right = r;
                    else
                        insert(r, root.Right);

                }

            }
        }
            public void InOrder()
            { 
             GetData(root);
            }

            public void GetData(Node root)
            {
                if (root == null)
                    return;
                GetData(root.Left);
                Console.WriteLine(root.data + " ");
                GetData(root.Right);

            }

        
        }

        /*class Run
        {
            static void Main(string[] args)
            {
               
                int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };

                int temp = 0;

              //  for (int write = 0; write < arr.Length; write++)
                //{
                    for (int sort = 0; sort < arr.Length-1 ; sort++)
                    {
                        if (arr[sort] > arr[sort + 1])
                        {
                            temp = arr[sort + 1];
                            arr[sort + 1] = arr[sort];
                            arr[sort] = temp;
                        }
                    }
               // }

                for (int i = 0; i < arr.Length; i++)
                    Console.Write(arr[i] + " ");

                Console.ReadKey();
            }
        }*/
        

    }
    
}

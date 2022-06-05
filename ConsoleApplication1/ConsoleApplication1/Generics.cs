using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Generics
    {
        static int i;
        void method(int i)
        {
            Generics.i = i + Generics.i;
            Console.WriteLine(Generics.i);
            
        }

         int i2;
        void method2(int i2)
        {
            this.i2 = i2 + this.i2;
            Console.WriteLine(this.i2);

        }

        static void Main()
        {

           // Generics g1 = new Generics() { i=10};
            Generics g1 = new Generics();
            Generics g2 = new Generics();
            Generics.i = 10;
           // g1.method(1);
            //g1.method(1);
            g1.i2 = 10;
            g2.i2 = 10;
            g1.method2(1);
            g1.method2(1);
            g2.method2(1);
          
            Console.ReadKey();
        }
    }

}

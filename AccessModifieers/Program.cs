using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifieers
{
    /*
     * ACCESS MODIFIERS (OR) ACCESS SPECIFIERS:-
     *                                           Used to provide accessibility of the code.
     *                                           By using different access modifiers we can access our code.
     * 
     * Types of Access Modifiers:-
     *                              1.Public
     *                              2.Private
     *                              3.Protected
     *                              4.Internal
     *                              5.Protected Internal
     *  
     *  1.Public Access Mofifier:-+
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */
    internal class Program
    {
        class AccessModifier1 //class-1
        {
            public int a = 10;

            public void MyMethod()
            {
                Console.WriteLine("Value of A is" + a);
            }
        }

        class publicclass // class-2
        {
            public void publicmethod()
            {
                AccessModifier1 obj = new AccessModifier1();
                Console.WriteLine("Value of A under Public Method is" + obj.a);
            }
        }

        class privateclass // Class-3
        {
            public void privatemethod()
            {
                AccessModifier1 ob7 = new AccessModifier1();
                Console.WriteLine("Value of A Under Private Method is" + ob7.a);
            }
        }
        static void Main(string[] args)
        {
            AccessModifier1 obj1 = new AccessModifier1();
            obj1.MyMethod();

            Console.WriteLine("Value of A under Main Method is" + obj1.a);

            publicclass obj2 = new publicclass();
            obj2.publicmethod();
            
            privateclass obj3 = new privateclass();
            obj3.privatemethod();
            
        }
    }
}

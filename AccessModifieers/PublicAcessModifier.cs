//////////////////using System;
//////////////////using System.Collections.Generic;
//////////////////using System.Linq;
//////////////////using System.Text;
//////////////////using System.Threading.Tasks;


//////////////////namespace accessmodifieers
//////////////////{
//////////////////    /*
//////////////////     * access modifiers (or) access specifiers:-
//////////////////     *                                           used to provide accessibility of the code.
//////////////////     *                                           by using different access modifiers we can access our code.
//////////////////     * 
//////////////////     * types of access modifiers (or) access specifiers:-
//////////////////     *                                                      1.public
//////////////////     *                                                      2.private
//////////////////     *                                                      3.protected
//////////////////     *                                                      4.internal
//////////////////     *                                                      5.protected internal
//////////////////     *  
//////////////////     *  1.public access mofifier:- 
//////////////////     *                              it can be accessed througthout the project and application.
//////////////////     *                              
//////////////////     *  2.private access modifier:-
//////////////////     *                              It can be accessed only within a class.
//////////////////     *                              Prevent instantation of a class.
//////////////////     *                              Private Access Modifier is the most restrictive of access.
//////////////////     *                              It means that a member(Variable,Method,Constructor etc) can be accessed
//////////////////     *                              within the same class.
//////////////////     *                              It is implemented under Encapsulation.
//////////////////     *                              Data Hiding means prevents direct access to fields (or) method from outside of the class.
//////////////////     *                              Encapsulation by using public methods and properities to interact with private members.
//////////////////     *                              
//////////////////     * 3.Internal Access Modifier:-
//////////////////     *                              It can be accessed throughout the project.
//////////////////     *                              If we declare class (or) class members access modifier as internal we can access
//////////////////     *                              within the current project and all the classess of the current project.
//////////////////     *                              
//////////////////     *  4.Protected Access Modifier:-                           
//////////////////     *                                If we declare class (or) class members access modifier  as protected means we can
//////////////////     *                                access in current class and derived class.
//////////////////     *                                It shows how class members(Fields,Methods,Constructors) are accessed.
//////////////////     *                                It is a private and public by allowing access within the class itself and derived 
//////////////////     *                                classes but not from outside
//////////////////     *   
//////////////////     * 
//////////////////     * 
//////////////////     * 
//////////////////     * 
//////////////////     * 
//////////////////     * 
//////////////////     * 
//////////////////     * 
//////////////////     * 
//////////////////     * 
//////////////////     * 
//////////////////     * 
//////////////////     * 
//////////////////     */


//////////////////    /*
//////////////////     *  public access modifier
//////////////////     */
//////////////////    class accessmodifier1 //class-1
//////////////////    {
//////////////////        public int a = 10;

//////////////////        public void mymethod()
//////////////////        {
//////////////////            Console.WriteLine("value of a is" + a);
//////////////////        }
//////////////////    }

//////////////////    class publicclass // class-2
//////////////////    {
//////////////////        public void publicmethod()
//////////////////        {
//////////////////            accessmodifier1 obj = new accessmodifier1();
//////////////////            Console.WriteLine("value of a under public method is" + obj.a);
//////////////////        }
//////////////////    }

//////////////////    class privateclass // class-3
//////////////////    {
//////////////////        public void privatemethod()
//////////////////        {
//////////////////            accessmodifier1 ob7 = new accessmodifier1();
//////////////////            Console.WriteLine("value of a under private method is" + ob7.a);
//////////////////        }
//////////////////    }
//////////////////    internal class program
//////////////////    {
//////////////////        static void main(string[] args)
//////////////////        {
//////////////////            accessmodifier1 obj2 = new accessmodifier1();
//////////////////            obj2.mymethod();

//////////////////            Console.WriteLine("value of a under main method is" + obj2.a);

//////////////////            publicclass obj1 = new publicclass();
//////////////////            obj1.publicmethod();

//////////////////            privateclass obj3 = new privateclass();
//////////////////            obj3.privatemethod();

//////////////////        }
//////////////////    }
//////////////////}

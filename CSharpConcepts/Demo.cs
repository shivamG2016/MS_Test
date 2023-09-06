using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{

    class A
    {


        int a; 
        public void Display()
        {

            Console.WriteLine("I am inside A");
        }

    }


    class B : A
    
    {
    
             public void Show()
        {

            Console.WriteLine(" I am inside method B");
        }
    
    }




    public  class Demo
    {
       public static void Main(string[] args)
        {

            Console.WriteLine("");

            // Creation of the Object of class A 

           A a = new A();
            B b = new B();
            a.Display();
            b.Show();
            

        }
    }
}

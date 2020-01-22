using System;

namespace ConsoleApp1
{
    class classa
    {
        public void addition()
        {
            int a = 2;
            int b = 4;
            double sum = a + b;
            Console.WriteLine(sum);
        }

        public void myMethod2()
        {
            Console.WriteLine("Hello from mymethod2");
        }

        
    }

    class classb
    {
        public void mymethod3()
        {
            Console.WriteLine("Hello from mymethod3");
        }

        public void final()
        {
            classb b1 = new classb();
            b1.mymethod3();
        }
    }

    class classc
    {
        public static void welcome()
        {
            Console.WriteLine("Welcome");
        }

        public  void output()
        {
            welcome();
        }

    }


    class Program
    {
       
        static void Main(string[] args)
        {
            classa a = new classa();
            a.addition();

            classa a1 = new classa();
            a1.myMethod2();

            classb b = new classb();
            b.final();

            classc c1 = new classc();
            c1.output();

            newclass n = new newclass();
            n.mymethodnew();
            
        }
    }
}

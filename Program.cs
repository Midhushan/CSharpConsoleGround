using System;

namespace CSharpConsoleGround
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("print 5 natural numbers using for loop");
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
           

            //Find sum of 10 numbers
            Console.WriteLine("First 10 numbers are : ");
            int j;
            int sum = 0;
            for(j = 0; j < 10; j++)
            {
                sum += j;
                Console.WriteLine("{0}",j);

            }
            Console.WriteLine("Sum of 10 numbers : {0}",sum);



            Console.ReadKey();


        }
    }
}

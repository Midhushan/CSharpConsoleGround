using System;

namespace CSharpConsoleGround
{
    class Program
    {

        
        static void Main(string[] args)
        {
            //print natural numbers
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

            //add two numbers and multiply by 3 those numbers if they are same
            int a = 2;
            int b = 3;
            int sum1 = 0;
            if (a == b)
            {
                sum1 = (a + b) * 3;
                Console.WriteLine("two numbers are same, total : {0}", sum1);
            }
            else
            {
                sum1 = a + b;
                Console.WriteLine("two numbers are not same, total : {0}", sum1);
            }


            string s = "if else";
            if(s.Length > 2 && s.Substring(0, 2).Equals("if"))
            {

            }

            Console.WriteLine(test("if else"));
            Console.WriteLine(test("else"));
            Console.WriteLine();

            Console.WriteLine(testone("csharp"));
          




            Console.ReadKey();
        }

        //add new string method
        private static string test(string s)
        {
            if (s.Length > 2 && s.Substring(0, 2).Equals("if"))
            {
                return s;
            }
            return "if " + s;
        }

        //add substring 
        private static string testone(string str)
        {
            if(str.Length < 3)
            {
                return str + str + str;
            }
            else
            {
                string front = str.Substring(0, 3);
                return front + str + front;
            }
        }





    }
   
}

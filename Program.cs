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

            Console.WriteLine();


            //check odd or even
            //int num1, rem1;

            //Console.Write("Enter the number : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //rem1 = num1 % 2;
            //if(rem1 == 0)
            //{
            //    Console.WriteLine("{0} is even",num1);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is odd",num1);
            //}

            //CHECK Leap year

            //int year;

            //Console.Write("Enter a year : ");
            //year = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            //if((year % 400) == 0)
            //{
            //    Console.WriteLine("{0} is a leap year",year);
            //}else if((year % 100) == 0)
            //{
            //    Console.WriteLine("{0} is a not leap year",year);
            //}else if((year % 4) == 0)
            //{
            //    Console.WriteLine("{0} is a leap year",year);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is a not leap year",year);
            //}

            //Calculate electricity bill

            //int cusid, cusui;
            //string cusname;
            //double chg, surchg=0, gramt;
            //double netamt = 0;
            

            //Console.Write("\n\n");
            //Console.Write("Calculate Electricity Bill :");
            //Console.Write("_____________________________");
            //Console.Write("\n\n");

            //Console.Write("Enter cutomer id : ");
            //cusid = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter customer name :");
            //cusname = Console.ReadLine();

            //Console.Write("Enter units : ");
            //cusui = Convert.ToInt32(Console.ReadLine());

            //if(cusui < 200)
            //{
            //    chg = 1.20;
            //}else if(cusui > 200 && cusui < 400)
            //{
            //    chg = 1.50;
            //}else if(cusui > 400 && cusui < 600)
            //{
            //    chg = 1.80;

            //}
            //else
            //{
            //    chg = 2.00;
            //}

            //gramt = cusui * chg;
            //if(gramt > 300)
            //{
            //    surchg = gramt * 15 / 100.0;
            //    netamt = surchg + gramt;
               
            //}

            //if (netamt < 100.0)
            //{
            //    netamt = 100;
            //}

            //Console.Write("\n\n");
            //Console.Write("Customer Id                              :      {0}\n",cusid);
            //Console.Write("Customer Name                            :      {0}\n", cusname);
            //Console.Write("Customer used units                      :      {0}\n", cusui);
            //Console.Write("Amount charges @Rs.{0} per unit          :      {1}\n", chg, gramt);
            //Console.Write("Surcharge Amount                         :      {0}\n", surchg);
            //Console.Write("Net amount paid paid by the customer     :      {0}\n", netamt);



            int[] arr = new int[10];
            int c;
            Console.Write("Read and print in array");
            Console.WriteLine();
            Console.Write("Input 10 numbers in array");
            Console.WriteLine();

            for(c = 0; c < 10; c++)
            {
                Console.Write("Element - {0} : ", c);
                arr[c] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Elements in array - ");
            for(c = 0; c < 10; c++)
            {
                Console.Write("{0} ", arr[c]);
            }

            Console.ReadKey();
        }


        //end main

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

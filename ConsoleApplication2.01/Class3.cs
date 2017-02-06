using System;

namespace Day2
{
    class Class3
    {
        public static void Main()
        {
            Console.Write("Please enter your name: ");
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}!", input);



            //About Tix
            //About Tix
            Console.WriteLine("Entrance Ticket: $25.");
            Console.Write("Please enter the number of tix that you want: ");

            string input = Console.ReadLine(); // assume that input is a valid number

            int numTix = Convert.ToInt32(input);

            // bool isOK = Int32.TryParse(input, out numTix);

            //Display the total cost
            Console.WriteLine("Total cost = {0}", numTix * 25);

            int numTix2 = Convert.ToInt32(Console.ReadLine());



            //About Math
            //About Math
            int a = 1;
            Console.WriteLine(a); //1

            a++; // a++ means a = a+1; => 2
            Console.WriteLine(a); //2

            a--; // a-- means a = a-1; => 1
            Console.WriteLine(a); //1

            ++a; // ++a means a = a+1; => 2
            Console.WriteLine(a); //2

            int b = a; //at this point b = 2

            Console.WriteLine(a++); //2 ; a is incremented after WriteLine

            Console.WriteLine(b); b = b + 1; //2

            Console.WriteLine(++a); //4 ; a is incremented before WriteLine

            b = b + 1; Console.WriteLine(b); //4

            a += 5; //a = a + 5;
            a -= 5; //a = a - 5;
            a *= 5;
            a /= 5;
            a += 1;

            
            //
            double a = 100;
            double b = 3;
            Console.WriteLine(a / b); //33.3333333

            int c = 100;
            int d = 3;
            Console.WriteLine(c / d); //33

            int e = 23;
            int f = 5;
            Console.WriteLine(e / f); //4
            Console.WriteLine(e % f); //3 - remainder


            //
            Console.WriteLine(System.Math.Ceiling(14.1)); //15
            Console.WriteLine(System.Math.Floor(20.9)); //20
            Console.WriteLine(Math.Round(3.5)); //4

            Console.WriteLine(Math.Round(3.8543, 2)); //3.85
                                                      //Console.WriteLine(Math.Ceiling(3.8543, 2)); //3.86 doesn't work!
        }
    }
}
using System.Security.Cryptography.X509Certificates;

namespace Loop_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 1 and 100");
            int input = int.Parse(Console.ReadLine());


                    Console.WriteLine("Even or Odd series?");
            string series_name = Console.ReadLine();

           
            try
            {



                if ((input > 0) && (input <= 100))

                {


                    if ((series_name == "even") && (input > 0) && (input <= 100))
                    {
                        Console.WriteLine("You have selected the even series");
                        int i = 1;
                        int even = 0;
                        while (even <= input)
                        {
                            Console.WriteLine(even.ToString() + " is an even number");
                            even = 2 * i;
                            i++;
                        }
                    }
                }

                if ((series_name == "odd") && (input > 0) && (input <= 100))



                {
                    Console.WriteLine("You have selected the odd series");
                    int j = 1;
                    int odd = 0;
                    while (odd <= input)
                    {
                        Console.WriteLine(odd.ToString() + " is an odd number");
                        odd = 2 * j + 1;
                        j++;
                    }
                }


            }
            catch
            {
                Console.WriteLine(" Oops try again and be sure to add an integer between 1 and 100");
                Console.ReadKey(false);
            }


        }
    }

}


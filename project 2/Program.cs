using System.Security.Cryptography.X509Certificates;

namespace project_dr_sameer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the frist number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            int i;
            for (i =num1; i <= num2; i++)
            {
                int result = FindFactor(i);
                if (i == result)
                {
                    Console.WriteLine(i + " is the perfect number");
                }

            }

        }
        public static int FindFactor(int num2)
        {
            int sum = 0;
            for (int i = 1 ; i < num2; i++)
            {
                if (num2 % i == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
        
       

    }
}    
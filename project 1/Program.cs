namespace project_dr_samir_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the frist num...");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second num..");
            int num2 = int.Parse(Console.ReadLine());
            int i, j;

            for (i = num; i <= num2; i++)
            {
                bool prime = true;

                for (j = 2; j <= i - 1; j++)

                {
                    if (i % j == 0)
                    {
                        prime = false;
                    }
                  



                }

                if (prime == true)
                {
                    Console.WriteLine(i);

                }

            }
        }
    }
}
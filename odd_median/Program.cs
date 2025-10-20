using System.Diagnostics.CodeAnalysis;

namespace odd_median
{
    internal class Program
    {
        static double median(int n1,int n2)
        {
            int sum = 0,switcher = 0, ncounter = 0; 
                if (n1 > n2)
                {
                    switcher = n2;
                    n2 = n1;
                    n1 = switcher;
                }
                    for(int i = n1-1; i <= n2; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sum = sum + i;
                            ncounter++;
                        }

                    }
            return sum / ncounter;
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("insert the two interval values");
            int v1 = Convert.ToInt32(Console.ReadLine());
            int v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(median(v1, v2));
            Console.WriteLine("SDIYBT");
        }
    }
}

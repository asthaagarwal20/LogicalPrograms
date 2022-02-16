using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n");
            int n=Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    count++;
                }
            }
            if (count==2)
                Console.WriteLine("Prime No");
            else
                Console.WriteLine("Not Prime No");
        }
    }
}

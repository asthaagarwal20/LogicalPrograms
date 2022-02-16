﻿using System;
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
            int reverseNo = 0;
             while(n>0)
            {
                int d = n % 10;
                reverseNo = reverseNo * 10 + d;
                n = n / 10;
            }
                Console.WriteLine(reverseNo);
        }
    }
}

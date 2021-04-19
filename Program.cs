using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_1_3
{
    class Program
    {
        public class TestCase
        {
            public int X;
            public int Y;
            public int Expected;
            public Exception ExpectedException;

        }
        static void Main(string[] args) //Требуется реализовать рекурсивную версию и версию без рекурсии (через цикл) чисел Фибоначчи.
        {
            var testCase1 = new TestCase()
            {
                X = 0,
                Y = 1,
                Expected = 11,
                ExpectedException = null,
            };
            TestFibCyc(testCase1);
            
            
        }
        static void TestFibCyc(TestCase testCase)
        {
            try
            {
                var actual = FibCyc(testCase.X, testCase.Y);
                if (actual==testCase.Expected)
                {
                    Console.WriteLine("valid test");
                }
                else
                {
                    Console.WriteLine("invalid test");
                }
            }
            catch(Exception ex)
            {
                if (testCase.ExpectedException != null) 
                {
                    Console.WriteLine("valid test");
                }
                else
                {
                    Console.WriteLine("invalid test");
                }

            }
        }

        static int FibReq(int n)
        {
            if (n == 1 || n == 0)
            {
                return n;
            }
            return (FibReq(n - 1) + (FibReq(n - 2)));
        }

        static int FibCyc(int x, int y)
        {
            x = 0;
            y = 1;
            int temp = 0;
            int n = 2;

            for (int i = 0; i < n; i++)
            {
                temp = x;
                x = y;
                y += temp;
            }
            return x;
        }
    }
}


    


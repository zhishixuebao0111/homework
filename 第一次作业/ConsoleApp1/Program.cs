using System;
namespace ConsoleApp1
{
    class primenumber
    {
        int m;
        int n;
        public primenumber(int m,int n)
        {
            this.m = m;
            this.n = n;
        }
        public void Isprime()
        {
            if (m > n) 
            {
                int t = m;
                m = n;
                n = t; 
            }
            int mod10 = 0;
            for(int i = m; i <= n; i++)
            {
                bool isprimed = true;
                for(int j = 2; j <= i / 2; j++) {
                    if (i % j == 0)
                    {
                        isprimed = false;
                        break;
                    }
                }
                if (isprimed&&i!=1)
                {
                    Console.Write(i+" ");
                    mod10++;
                    if (mod10 == 10)
                    Console.WriteLine();
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string m, n;
            m=Console.ReadLine();
            n=Console.ReadLine();
            primenumber pn = new primenumber(int.Parse(m),int.Parse(n));
            pn.Isprime();
            Console.WriteLine("你好，我是XXX");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingInCSharp
{
    public class ThreadingClass
    {
       private string data;
        public void Thread1()
        {
            Console.WriteLine("i m Thread 1");

        }
        public void Thread2()
        {
            Console.WriteLine("i m Thread 2");

        }
       
        public void TreadingWithForLoop1()
        {
            for(int i = 0; i <= 100; i+=2)
            {
                Console.WriteLine("i m Even: "+i);
            }
            Thread.Sleep(1000);

        }
        public void TreadingWithForLoop2()
        {
            for (int i = 1; i <= 100; i+=3)
            {
                Console.WriteLine("i m odd: "+i);
            }
            Thread.Sleep(5000);

        }


        public void LockWithTread1()
        {
            while(true)
            {
                lock (this)
                {
                    Console.WriteLine("Display Thread 1");
                    data = "Hello Thread1";
                    Thread.Sleep(1000);    
                    Console.WriteLine("Thread 1 Output --> {0}", data);
                }
            }

        }
        public void LockWithTread2()
        {
            while (true)
            {
                lock (this)
                {
                    Console.WriteLine("Display Thread 2");
                    data = "Hello Thread2";
                    Thread.Sleep(1000);
                    Console.WriteLine("Thread 1 Output --> {0}" , data);
                }
            }

        }

    }
}

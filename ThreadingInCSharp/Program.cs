using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ThreadingInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadingClass threadingClass = new ThreadingClass();

            Thread Thread1 = new Thread(new ThreadStart(threadingClass.Thread1));
            Thread Thread2 = new Thread(new ThreadStart(threadingClass.Thread2));
            Thread1.Start();
            Thread2.Start();
            Console.WriteLine("-------------------------------------");
            Thread Thread3 = new Thread(new ThreadStart(threadingClass.TreadingWithForLoop1));
            Thread Thread4 = new Thread(new ThreadStart(threadingClass.TreadingWithForLoop2));
            Thread3.Start();
            Thread4.Start();
            Console.WriteLine("-----------------------------------");
            Thread Thread5 = new Thread(new ThreadStart(threadingClass.LockWithTread1));
            Thread Thread6 = new Thread(new ThreadStart(threadingClass.LockWithTread2));
            Thread5.Start();
            Thread6.Start();
            Console.ReadKey();  

        }
    }
}

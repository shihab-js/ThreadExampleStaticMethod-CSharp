using System;
using System.Threading;

public class MyThread
{
    public static void Thread1()
    {
        for(int i=0; i<10; i++)
        {
            Console.WriteLine(i);
        }
    }
}


namespace ThreadExampleStaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}

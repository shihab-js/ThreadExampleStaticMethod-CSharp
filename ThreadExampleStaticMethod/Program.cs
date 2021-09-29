using System;
using System.Threading;

public class MyThread
{
    public static void Thread1()
    {
        //create a for loop
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
            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));

            t1.Start();
            t2.Start();
        }
    }
}

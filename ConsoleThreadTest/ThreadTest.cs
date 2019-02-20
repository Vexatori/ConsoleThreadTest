using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleThreadTest
{
    public static class ThreadTest
    {
        public static void Test()
        {
            var thread_sum = new Thread( () => Console.WriteLine( MathClasses.SumTo( 10 ) ) );
            thread_sum.Priority = ThreadPriority.BelowNormal;
            thread_sum.IsBackground = true;
            thread_sum.Start();

            var thread_factorial = new Thread( () => Console.WriteLine( MathClasses.RecursiveFactorial( 10 ) ) );
            thread_factorial.Priority = ThreadPriority.BelowNormal;
            thread_factorial.IsBackground = true;
            thread_factorial.Start();

            var thread_csv_to_txt = new Thread( () => CSVtoTXT.DoConvert( @"D:\students.csv" ) );
            thread_csv_to_txt.IsBackground = true;
            thread_csv_to_txt.Start();
        }
    }
}
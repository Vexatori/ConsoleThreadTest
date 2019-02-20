using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleThreadTest
{
    public static class MathClasses
    {
        public static int RecursiveFactorial( int i )
        {
            if ( i > 0 ) { return i * RecursiveFactorial( --i ); }
            else { return 1; }
        }

        public static int SumTo( int n )
        {
            int sum = 0;
            for ( int i = 0; i <= n; sum += i++ ) ;
            return sum;
        }
    }
}
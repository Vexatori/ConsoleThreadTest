using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Matrix.lib;

namespace ConsoleThreadTest
{
    public static class TPLTest
    {
        public static void Test()
        {
            IntMatrixClass matrixA = new IntMatrixClass( 3, 4 );
            IntMatrixClass matrixB = new IntMatrixClass( 4, 4 );

            matrixA.SetRandomMatrix(1, 10);
            matrixB.SetRandomMatrix(1, 10);

            IntMatrixClass temp = matrixA.MultiMatrix( matrixB );

            //temp.Show();

            Parallel.Invoke( () => matrixA.MultiMatrix( matrixB ) );
        }
    }
}

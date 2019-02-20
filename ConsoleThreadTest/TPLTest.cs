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
            // Две матрицы можно перемножить между собой тогда и только тогда, когда количество столбцов первой матрицы равно количеству строк второй матрицы.

            #region Для проверки правильности результата перемножения матриц

            //IntMatrixClass matrixA = new IntMatrixClass(3, 4);
            //IntMatrixClass matrixB = new IntMatrixClass(4, 4);

            #endregion

            #region Для проверки самой задачи

            IntMatrixClass matrixA = new IntMatrixClass(100, 100);
            IntMatrixClass matrixB = new IntMatrixClass(100, 100);

            #endregion

            matrixA.SetRandomMatrix(1, 10);
            matrixB.SetRandomMatrix(1, 10);

            Parallel.Invoke( () =>
            {
                IntMatrixClass temp = matrixA.MultiMatrix( matrixB );
                temp.Show();
            } );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix<T>
    {
        public T[,] table = new T[4, 4];
        public Matrix() { }  //
        public Matrix(T nb)   // overloaded
        {
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    table[i, j] = nb;
                }
            }
        }
        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)  // soustraction
        {
            Matrix<T> result = new Matrix<T>();
            for(int i = 0; i< m1.table.GetLength(0); ++i)
            {
               for(int j = 0; j<m1.table.GetLength(1); ++j)
               {
                   result.table[i, j] = (dynamic)m1.table[i, j] - (dynamic)m2.table[i, j];
               }
            }
            return result;
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)  // addition
        {
            Matrix<T> result = new Matrix<T>();
            for (int i = 0; i < m1.table.GetLength(0); ++i)
            {
                for (int j = 0; i < m1.table.GetLength(1); ++j)
                {
                    result.table[i, j] = (dynamic)m1.table[i, j] + (dynamic)m2.table[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)  // multiplication
        {
            Matrix<T> result = new Matrix<T>();
            for (int i = 0; i < m1.table.GetLength(0); ++i)
            {
                for (int j = 0; j < m1.table.GetLength(1); ++j)
                {
                    for (int k = 0; k < 4; ++k)
                    {
                        result.table[i, j] = result.table[i, j] + (dynamic)m1.table[i, k] * (dynamic)m2.table[k, j];
                    }
                }
            }
            return result;
        }

        public void print()
        {
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

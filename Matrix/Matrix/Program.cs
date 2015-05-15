using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<float> matrix1 = new Matrix<float>(5f);
            matrix1.print();
            Matrix<float> matrix2 = new Matrix<float>(1f);

            (matrix1 * matrix2).print();
            Console.Read();
        }
    }
    
}

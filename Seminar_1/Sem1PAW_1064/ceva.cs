using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1PAW_1064
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Introduceti numele dvs.!");
            string nume = Console.ReadLine();
            int varsta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numele introdus este {0} si varsta {1}", 
                nume, varsta);*/

            int[] v1 = new int[3] { 10, 20, 30 };
            int[] v2 = v1; //shallow copy
            v1[1] = 100;
            Console.WriteLine();
            for (int i = 0; i < v2.Length; i++)
                Console.Write("{0} ", v2[i]);

            //deep copy - var 1
            int[] v3 = new int[v1.Length];
            for (int i = 0; i < v1.Length; i++)
                v3[i] = v1[i];

            //deep copy - var 2
            int[] v4 = (int[])v1.Clone();

            int[,] mat1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                    Console.Write("{0} ", mat1[i, j]);
                Console.WriteLine();
            }

            int[][] mat2 = new int[2][];
            mat2[0] = new int[3] { 10, 20, 30 };
            mat2[1] = new int[4] { 40, 50, 60, 70 };
            for (int i = 0; i < mat2.Length; i++)
            {
                for (int j = 0; j < mat2[i].Length; j++)
                    Console.Write("{0} ", mat2[i][j]);
                Console.WriteLine();
            }

            Student s1 = new Student();
            Student s2 = new Student(21, "Dorel", 9.5f);
            Student s3 = s2;
            Student s4 = new Student(s2);
            s4.afisare();
            Console.WriteLine(s4);
        }
    }
}

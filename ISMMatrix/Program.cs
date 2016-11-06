using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMMatrix
{
    class Program
    {
        public static int[,] Input_Matrix(int n, int m)
        {
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    
                    Console.Write("A[{0},{1}] = ", i + 1, j + 1);
                     matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j].ToString() + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return matrix;
        }
        public static int Find_Rows_Without_Zero(int[,] matrix, int n, int m)
        {
            int count = 0, count2 = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        count2++;
                    }
                }
                if (count2 == m)
                {
                    count++;
                }
                count2 = 0;
            }
            return count;
        }
        public static int Find_Max_Num(int[,] matrix, int n, int m)
        {

            int  x = 0;
            int[] arr = new int[m];
            int[] arr2 = new int[n];
            int[] arr4 = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int z = 0; z < m; z++)
                {
                    for (int j = 1; j < m - 1; j++)
                    {
                        if (matrix[i, z] == matrix[i, j])
                        {
                            x = matrix[i, z];
                        }
                    }
                    
                    arr[z] = x;
                    
                    x = 0;
                }
                arr2[i] = arr.Max();
                
            }
            return arr2.Max() ;
        }
        public static int Find_Col_With_Zero(int[,] matrix, int n, int m)
        {
            int count = 0;
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        count++;
                        break;
                    }

                }
            }
            return count;
        }
        public static int Find_Row_With_Max_Similar_Elements(int[,] matrix, int n, int m)
        {
            
            int c = 0;
            int[] arr = new int[n];
            int[] arr2 = new int[m];
            for (int i = 0; i < n; i++)
            {
                for (int z = 0; z < m; z++)
                { 
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i,z] == matrix[i,j])
                    {
                        c++;
                    }
                }
                    arr2[z] = c;
                    c = 0;
                }
                arr[i] = arr2.Max();
            }
            int res = Array.IndexOf(arr, arr.Max());

            return res + 1;
        }
        public static void Dob(int[,] matrix, int n, int m)
        {
            int[] dob = new int[n];
            int c = 0, z = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i,j] >= 0)
                    {
                        c++;
                    }
                }
                if (c == m)
                {
                    dob[z] = 1;
                    for (int j = 0; j < m; j++)
                    {
                        
                        dob[z] *= matrix[i, j];
                    }
                    z++;
                }
                
                c = 0;
            }
            Console.Write("Произведение елементов в строках без отрицательных чисел - ");

            for (int i = 0; i < z; i++)
            {
                Console.Write(dob[i] + "  ");
            }
            Console.WriteLine();
        }
        public static int Max_Paralel_Diagonal(int[,] matrix, int n, int m)
        {
            int[] sum = new int[(n - 1) * 2];
            int z = 0, a = 0, b = 0, x = n, y = m;
            while (x > n - 2) { 
            for (int i = 1 + a, j = 0; i < n; i++, j++)
            {
                sum[z] += matrix[i, j];
            }
                a++;
                z++;
                x--;
            }
            while (y > m - 2)
            {
                for (int i = 0, j = 1 + b; j < m; i++, j++)
                {
                    sum[z] += matrix[i, j];
                }
                b++;
                z++;
                y--;
            }

            return sum.Max();
        }
        public static void Sum_Without_Negative(int[,] matrix, int n, int m)
        {
            int[] sum = new int[m];
            int c = 0, z = 0;
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] >= 0)
                    {
                        c++;
                    }
                }
                if (c == m)
                {
                    sum[z] = 0;
                    for (int i = 0; i < n; i++)
                    {

                        sum[z] += matrix[i, j];
                    }
                    z++;
                }

                c = 0;
            }
            Console.Write("Сумма елементов в столбцах без отрицательных чисел - ");

            for (int i = 0; i < z; i++)
            {
                Console.Write(sum[i] + "  ");
            }
            Console.WriteLine();
        }
        public static void Sum_With_Negative(int[,] matrix, int n, int m)
        {
            int[] sum = new int[m];
            int c = 0, z = 0;
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] >= 0)
                    {
                        c++;
                    }
                }
                if (c < m)
                {
                    sum[z] = 0;
                    for (int i = 0; i < n; i++)
                    {

                        sum[z] += matrix[i, j];
                    }
                    z++;
                }

                c = 0;
            }
            Console.Write("Сумма елементов в столбцах с отрицательными числами - ");

            for (int i = 0; i < z; i++)
            {
                Console.Write(sum[i] + "  ");
            }
            Console.WriteLine();
        }
        public static int Min_Paralel_Second_Diagonal(int[,] matrix, int n, int m)
        {
            int[] sum = new int[(n - 1) * 2];
            int z = 0, a = 0, b = 0, x = n, y = m;
            while (x > m - 2)
            {
                for (int i = 0, j = m - 2 - a; j >= 0; i++, j--)
                {
                    sum[z] += Math.Abs(matrix[i, j]);
                }
                a++;
                z++;
                x--;
            }
            while (y > n - 2)
            {
                for (int i = 1 + b, j = n - 1; i < m; i++, j--)
                {
                    sum[z] += Math.Abs(matrix[i, j]);
                }
                b++;
                z++;
                y--;
            }

            return sum.Min();
        }
        public static void Transp_Matrix(int[,] matrix, int n, int m)
        {
            Console.WriteLine("Транспонированная матрица : ");
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(matrix[i,j] + "   ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите колличество строк - ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите колличество столбцов - ");
            int m = int.Parse(Console.ReadLine());
            int[,] mat = new int[n,m];
            try
            {
                mat = Input_Matrix(n, m);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка!! Вводите только целые числа!!");
                return;
            }
            int x = Find_Rows_Without_Zero(mat, n, m);
            Console.WriteLine("Колличество строк без 0 - " + x);
            int y = Find_Col_With_Zero(mat, n, m);
            Console.WriteLine("Колличество столбцов с 0 - " + y);
            int z = Find_Row_With_Max_Similar_Elements(mat, n, m);
            Console.WriteLine("Номер строки с наибольшим количеством одинаковых елементов - " + z);
            int v = Find_Max_Num(mat, n, m);
            Console.WriteLine("Максимальное число которое встречается > 1 раза - " + v);
            Dob(mat, n, m);
            int w = Max_Paralel_Diagonal(mat, n, m);
            Console.WriteLine("Максимальная сумма диагоналей - " + w);
            int q = Min_Paralel_Second_Diagonal(mat, n, m);
            Console.WriteLine("Минимальная сумма обратных диагоналей - " + q);
            Sum_Without_Negative(mat, n, m);
            Sum_With_Negative(mat, n, m);
            Transp_Matrix(mat, n, m);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static int[] SortingArray(int[] A)
        {
            int swap;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6 - i - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        swap = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = swap;
                    }
                }
            }
            return A;
        }


        static int[] ArraySorting(int[] Array)
        {
            int swap;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i - 1; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        swap = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = swap;
                    }
                }
            }
            return Array;



            ////for (int i = 0; i < 5; i++)
            ////{
            ////    //поиск минимального числа
            ////    int min = i;
            ////    for (int j = i + 1; j < 5; j++)
            ////    {
            ////        if (Array[j] < Array[min])
            ////        {
            ////            min = j;
            ////        }
            ////    }
            ////    //обмен элементов
            ////    int temp = Array[min];
            ////    Array[min] = Array[i];
            ////    Array[i] = temp;
            ////}
            ////return Array;
        }


        static void Main(string[] args)
            {
                int[] Array1 = new int[] { 23, 98, 14, 90, 38 };
                //Console.WriteLine("Mассив:");
                //for (int i = 0; i < 5; i++)
                //{
                //    Console.Write("{0} ", Array1[i]);
                //}
                //Console.WriteLine();

                for (int i = 0; i < 5; i++)

                ArraySorting(Array1);
                //Console.WriteLine("Отсортированный массив:");
                //for (int i = 0; i < 5; i++)
                //{
                //    Console.Write("{0} ", Array1[i]);
                //}
                //Console.ReadLine();
            }

            ////// int n;
            //////int[] A = new int[6];
            ////int [] A=new int [6] { 8, 15, 75, 45, 62, 52 };
            //////int k;
            //////int n;
            ////B[]=SortingArray(A[]);



            ////Console.WriteLine("Array :");
            ////for ( int k = 0; k < 6; k++)
            ////{
            ////    Console.Write( " " + A[k]);
            ////}
            ////    Console.ReadKey();


        }
    }



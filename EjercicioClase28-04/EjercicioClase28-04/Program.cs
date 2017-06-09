using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase28_04
{
    class Program
    {
        static void Main(string[] args)
        {
            approachOne();
            Console.WriteLine();
            approachTwo();

            Console.ReadKey();

        }

        static void approachOne()
        {
            int[] arr = { 1, 4, 5 };
            Console.WriteLine("Inside Main, before calling the method, the first element is: {0} ", arr[0]);
            Console.WriteLine("Array elements: " + ShowElements(arr));

            Change(arr);
            Console.WriteLine("Inside Main, after calling the method, the first element is: {0} ", arr[0]);
            Console.WriteLine("Array elements: " + ShowElements(arr));
        }

        static void approachTwo()
        {
            int[] arr = { 1, 4, 5 };
            Console.WriteLine("Inside Main, before calling the method, the first element is: {0} ", arr[0]);
            Console.WriteLine("Array elements: " + ShowElements(arr));

            ChangeRef(ref arr);
            Console.WriteLine("Inside Main, after calling the method, the first element is: {0} ", arr[0]);
            Console.WriteLine("Array elements: " + ShowElements(arr));
        }

        static void ChangeRef(ref int[] pArray)
        {
            pArray[0] = 888;
            pArray = new int[5] { -3, -1, -2, -3, -4 };
            Console.WriteLine("Inside the method, the first element is: {0} ", pArray[0]);
            Console.WriteLine("Array elements: "+ShowElements(pArray));

        }

        static void Change(int[] pArray)
        {
            pArray[0] = 888;
            pArray = new int[5] { -3, -1, -2, -3, -4 };
            Console.WriteLine("Inside the method, the first element is: {0} ", pArray[0]);
            Console.WriteLine("Array elements: " + ShowElements(pArray));

        }

        static string ShowElements(int[] pArray)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < pArray.Length; i++ )
            {
                if (i != pArray.Length-1)
                {
                    sb.Append(pArray[i] + ",");
                }
                else {
                    sb.Append(pArray[i] + "]");
                }
            }
            return sb.ToString();
        }
    }
}

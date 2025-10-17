using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace hafta2._2
{
    class myArray 
    {
        double getAvarage(int[] arr, int size) 
        {
            int i;
            double avg;
            int sum = 0;

            for (i = 0; i < size; i++) 
            { 
                sum += arr[i];
            }
            avg = sum / size;
            return avg;
        
        }

        static void Main(string[] args) 
        {
            /* int[] n = new int[10];
            int i, j;

            for (i = 0; i < 10; i++) 
            {
                n[i] = i+100;
            }

            for (j = 0; j < 10; j++) 
            {
                Console.WriteLine("Element[{0}] = {1}",j,n[j]);
        } */

            /*myArray app = new myArray();

            int[] numbers = { 1, 2, 3, 4, 5 };
            double avarage = app.getAvarage(numbers, numbers.Length);
            Console.WriteLine("Dizinin ortalaması " + avarage);
            Console.ReadLine(); */

            /*int [] numbers2 = { 67,21,83,45,97,12 };
            int[] temp = numbers2;
            Console.WriteLine("Original Array:");
            foreach (int i in numbers2) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Array.Reverse(temp);
            foreach (int i in numbers2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Array.Sort(temp);
            foreach (int i in numbers2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(); */

            int[] numbers = { 1, 2, 3, 4, 5 };

            ArrayList list1 = new ArrayList();

            list1.Add(1);
            list1.Add(2);
            list1.Add(3.7);
            list1.Add(false);
            list1.Add(" ");
            list1.AddRange(numbers);

            foreach (var item in list1)
                Console.WriteLine(item + ", ");

            list1.Insert()
            list1.InsertRange() //sınavda hazır fonksiyon sorar 


        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
  Klavyeden girilen bir cümle içerisindeki boşlukların sayısını SpaceCount() fonksiyonunu kullanarak hesaplayıp, 
  boşluk sayısını ana fonksiyon içerisinde yazdıran programı yazınız
 */

namespace SpaceCount
{
    internal class Program
    {
        public static int spaceCount(string sentence)
        {
            int spaceCount = 0;
            for (int i = 0; i < sentence.Length; i++) 
            {
                if (sentence[i] == ' ')
                {
                    spaceCount++;
                }
            }
            return spaceCount;

        }
        static void Main(string[] args)
        {
            string sentence;
            Console.WriteLine("Please input a sentence!");
            sentence = Console.ReadLine();
            int count = spaceCount(sentence);
            Console.WriteLine($"This sentence contains {count} spaces.");
        }
    }
}

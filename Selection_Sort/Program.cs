using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20]; //Dizi nesnesini oluşturur.
            Random rnd = new Random(); //Random nesnesini oluşturur.

            for (int i = 0; i < numbers.Length; i++) //Dizi nesnesinin uzunluğu kadar döngüye girer.
                numbers[i] = rnd.Next(1, 100); //İndislere rastgele değerler atar.

            int temp, small;

            for (int i = 0; i < numbers.Length; i++) //Üst döngü, Sırası ile tüm indisleri dolaşır.
            {
                small = i;
                for (int j = i; j < numbers.Length; j++) //Alt döngü, üst döngüde dönen elemanı tüm indislerle karşılaştırır.
                {
                    if (numbers[small] >= numbers[j])
                    {
                        small = j;
                    }
                }

                temp = numbers[i];
                numbers[i] = numbers[small];
                numbers[small] = temp;
            }

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

            Console.Read();
        }
    }
}

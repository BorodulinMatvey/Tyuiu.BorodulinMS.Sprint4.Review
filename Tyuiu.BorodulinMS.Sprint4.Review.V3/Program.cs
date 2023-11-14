using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BorodulinMS.Sprint4.Review.V3.Lib;
namespace Tyuiu.BorodulinMS.Sprint4.Review.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int n = 4;
            int m = 2;
            int[,] mtrx = new int[n, m];
            string value = "27182818";
            Console.Title = "СпринтRevitw #4 | Выполнил: Бородулин М.С | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант 3                                                              *");
            Console.WriteLine("* Выполнил: Бородулин Матвей Сергеевич | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Дана строка из одноразрядных цифр 27182818. Преобразуйте ее в матрицу    *");
            Console.WriteLine("* 4 на 2 и подсчитайте количество нечетных чисел в матрице.              * ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


           

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(n, m, value);

            Console.WriteLine("Колличество всех нечетных элементов массива равна: " + res);
            Console.ReadKey();
        }
    }
}

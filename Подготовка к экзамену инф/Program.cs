using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подготовка_к_экзамену_инф
{
    class Program
    {
        static void Main(string[] args)
        {
            //9.Вычисление периметра квадрата
            //Console.WriteLine("Введите сторону квадрата:");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double P = 4 * a;
            //Console.WriteLine($"Периметр квадрата: {P}");
            //10.Вычисление периметра прямоугольника
            //Console.WriteLine("Введите длину стороны a прямоугольника:");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите длину стороны b прямоугольника:");
            //double b = Convert.ToDouble(Console.ReadLine());
            //double P = 2 * (a + b);
            //Console.WriteLine($"Периметр прямоугольника: {P}");
            //11.Вычисление длины окружности
            //Console.WriteLine("Введите радиус окружности:");
            //double R = Convert.ToDouble(Console.ReadLine());
            //double L = 2 * Math.PI * R;
            //Console.WriteLine($"Длина окружности: {L}");
            //12.Расчет количества файлов, помещающихся на флэшку
            //Console.WriteLine("Введите объем флэшки в Гб:");
            //double flashDriveSizeGB = Convert.ToDouble(Console.ReadLine());
            //double flashDriveSizeMB = flashDriveSizeGB * 1024;
            //int fileSizeMB = 820;
            //int fileCount = (int)(flashDriveSizeMB / fileSizeMB);
            //Console.WriteLine($"На флэшку помещается {fileCount} файлов размером 820 Мб.");
            //13.Вывод цифр двухзначного числа
            //Console.WriteLine("Введите двухзначное число:");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number < 10 || number > 99)
            //{
            //    Console.WriteLine("Ошибка: Введено не двухзначное число.");
            //}
            //else
            //{
            //    int tens = number / 10;
            //    int units = number % 10;
            //    Console.WriteLine($"Десятки: {tens}, Единицы: {units}");
            //18.Увеличить или уменьшить число
            //Console.WriteLine("Введите целое число:");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number > 0)
            //{
            //    number += 1;
            //}
            //else
            //{
            //    number -= 2;
            //}

            //Console.WriteLine($"Результат: {number}");
            //19.Изменить число в зависимости от его значения
            //Console.WriteLine("Введите целое число:");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number > 0)
            //{
            //    number += 1;
            //}
            //else if (number < 0)
            //{
            //    number -= 2;
            //}
            //else
            //{
            //    number = 10;
            //}

            //Console.WriteLine($"Результат: {number}");
            //20.Определить знак числа
            //Console.WriteLine("Введите целое число:");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number > 0)
            //{
            //    Console.WriteLine("Число положительное.");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine("Число отрицательное.");
            //}
            //else
            //{
            //    Console.WriteLine("Число равно нулю.");
            //}
            //21.Проверка равностороннего треугольника
            //Console.WriteLine("Введите стороны треугольника a, b, c:");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double c = Convert.ToDouble(Console.ReadLine());

            //if (a == b && b == c)
            //{
            //    Console.WriteLine("Треугольник равносторонний.");
            //}
            //else
            //{
            //    Console.WriteLine("Треугольник не равносторонний.");
            //}
            //22.Проверка делимости числа на 3
            //Console.WriteLine("Введите целое число:");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 3 == 0)
            //{
            //    Console.WriteLine("Число является делителем числа 3.");
            //}
            //else
            //{
            //    Console.WriteLine("Число не является делителем числа 3.");
            //}
            //23.Генерация случайных чисел и определение их знака
            //Random random = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    int number = random.Next(-30, 31);
            //    string sign = number > 0 ? "положительное" : "отрицательное";
            //    Console.WriteLine($"{number} - {sign}");
            //}
            //24.Генерация случайных чисел и определение четности
            //Random random = new Random();

            //for (int i = 0; i < 8; i++)
            //{
            //    int number = random.Next(-20, 31);
            //    string parity = number % 2 == 0 ? "чётное" : "нечётное";
            //    Console.WriteLine($"{number} - {parity}");
            //}
            //25.Генерация положительных чисел и определение четности
            //Random random = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    int number = random.Next(-20, 21);

            //    if (number > 0)
            //    {
            //        string parity = number % 2 == 0 ? "четное" : "нечетное";
            //        Console.WriteLine($"{number} - {parity}");
            //    }
            //}
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №1: Структура консольного приложения");
            Console.WriteLine("Выполнил: Гребенкин Егор Андреевич");
            Console.WriteLine("Группа: ПИЖ-б-о-21-1");
            Console.WriteLine("Дата рождения: 13.08.2002");
            Console.WriteLine("г. Ставрополь");
            Console.WriteLine("Информатика");
            Console.WriteLine("Хобби: играть в игры");

            // Individual work (7)
            float U;

            int a, z, E, t;

            Console.Write("Enter a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.Write("Enter z: ");
            z = Int32.Parse(Console.ReadLine());

            Console.Write("Enter E: ");
            E = Int32.Parse(Console.ReadLine());

            Console.Write("Enter t: ");
            t = Int32.Parse(Console.ReadLine());

            U = (35 / a) * z + z * a - (a + E * t) / 4;

            Console.WriteLine("U = {0}", U);

            Console.ReadKey();
        }
    }
}
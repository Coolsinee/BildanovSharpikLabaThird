using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BildanovSharpikLabaThird
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем новый вектор с 3-мя элементами
            Vector v1 = new Vector(3);

            // Заполняем вектор случайными числами из диапазона [-1, 1)
            v1.FillRandom(-1, 1);

            // Выводим вектор в консоль
            Console.WriteLine("Вектор v1 = " + v1.ToString());

            // Создаем второй новый вектор с 3-мя элементами
            Vector v2 = new Vector(3);

            // Заполняем вектор случайными числами из диапазона [-1, 1)
            v2.FillRandom(-1, 1);

            // Выводим вектор в консоль
            Console.WriteLine("Вектор v2 = " + v2.ToString());

            // Вычислим сумму v1 и v2
            Vector v3 = Vector.Add(v1, v2);

            // Выводим сумму в консоль
            Console.WriteLine("Вектор полученный суммированием значений векторов v1, v2 = " + v3.ToString());

            // Вычислим скалярное произведение v1 и v2 
            double dotProduct = Vector.Dot(v1, v2);

            // Выводим скалярное произведение в консоль
            Console.WriteLine("Скалярное произведение векторов v1, v2 = " + dotProduct);

            // Проверим, равны ли v1 и v2
            bool equal = Vector.Equals(v1, v2);

            // Выводим результат в консоль
            Console.WriteLine("Равны ли v1 и v2? " + equal);

            // Получаем модуль v1
            double modulus = v1.Modulus();

            // Выводим модуль v1 в консоль
            Console.WriteLine("Значение |v1| = " + modulus);

            // Находим наибольший элемент v1
            double largest = v1.Max();

            // Выводим наибольший элемент v1
            Console.WriteLine("Наибольший элемент v1 = " + largest);

            // Получаем индекс наименьшего элемента из v1
            int smallestIndex = v1.MinIndex();

            // Выводим индекс в консоль
            Console.WriteLine("Индекс наименьшего элемента из v1 = " + smallestIndex);

            // Создаем новый вектор, состоящий только из положительных элементов v1
            Vector v4 = v1.PositiveOnly();

            // Выводим новый вектор в консоль
            Console.WriteLine("Вектор v4(состоящий только из положительных элементов v1) = " + v4.ToString());

            // Получаем элемент с индексом 1 из v1
            double element = v1.Get(1);

            // Выводим элемент в консоль
            Console.WriteLine("Выводим элемент с индексом 1 из v1 = " + element);

            // Изменяем элемент с индексом 1 в v1 на 0,5
            v1.Set(1, 0.5);

            // Выводим измененный вектор в консоль
            Console.WriteLine("Измененный вектор v1(элемент с индексом 1 заменили на 0,5) = " + v1.ToString());

            // Проверяем, все ли элементы v1 неотрицательны
            bool nonNegative = v1.AllNonNegative();

            // Выводим результат в консоль
            Console.WriteLine("Все ли элементы v1 неотрицательны? " + nonNegative);

            // Проверяем, отсортирован ли v1 в порядке возрастания
            bool sorted = v1.IsSorted();

            // Выводим результат в консоль
            Console.WriteLine("Отсортирован ли v1 в порядке возрастания? " + sorted);

            // Выполнить линейный поиск значения 0,5 в v1
            int searchIndex = v1.LinearSearch(0.5);

            // Выводим результат в консоль
            Console.WriteLine("Индекс 0,5 в v1 = " + searchIndex);

            // Пирамидальная сортировка
            Vector v5 = new Vector(5);
            v5.FillRandom(1.0, 5);
            Console.WriteLine("Заданный вектор: " + v5);
            v5.HeapSort();
            Console.WriteLine("Пирамидально отсортированный вектор: " + v5);
            // Сдвиг элементов вектора на заданное число позиций влево, освободившиеся элементы заполняются нулями
            Vector v6 = new Vector(5);
            v6.FillRandom(1.0, 5);
            Console.WriteLine("Заданный вектор:");
            Console.WriteLine(v6.ToString());
            // Перемещаем элементы
            v6.ShiftRight();
            // output the shifted vector
            Console.WriteLine("Сдвинутый вектор: ");
            Console.WriteLine(v6.ToString());
        }
    }
}

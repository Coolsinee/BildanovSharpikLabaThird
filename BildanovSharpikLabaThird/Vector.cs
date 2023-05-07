using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BildanovSharpikLabaThird
{
    class Vector
    {
        private double[] values; // Маасив

        // Конструкторы
        public Vector(int size)
        {
            values = new double[size];
        }

        public Vector(params double[] values)
        {
            this.values = values;
        }

        public Vector(Vector vector)
        {
            this.values = vector.values;
        }

        // Метод ввода с консоли
        public static Vector Read()
        {
            Console.WriteLine("Введите векторные значения, разделенные пробелами:");
            string input = Console.ReadLine();
            double[] values = input.Split().Select(Double.Parse).ToArray();
            return new Vector(values);
        }

        // ToString метод
        public override string ToString()
        {
            return "[" + string.Join(", ", values) + "]";
        }

        // Экземплярные методы
        public double Modulus()
        {
            return Math.Sqrt(values.Sum(x => x * x));
        }

        public double Max()
        {
            return values.Max();
        }

        public int MinIndex()
        {
            return Array.IndexOf(values, values.Min());
        }

        public Vector PositiveOnly()
        {
            return new Vector(values.Where(x => x > 0).ToArray());
        }

        // Статичные методы
        public static Vector Add(Vector v1, Vector v2)
        {
            if (v1.values.Length != v2.values.Length)
            {
                throw new ArgumentException("Векторы должны иметь одинаковый размер");
            }
            return new Vector(v1.values.Zip(v2.values, (x, y) => x + y).ToArray());
        }

        public static double Dot(Vector v1, Vector v2)
        {
            if (v1.values.Length != v2.values.Length)
            {
                throw new ArgumentException("Векторы должны иметь одинаковый размер");
            }
            return v1.values.Zip(v2.values, (x, y) => x * y).Sum();
        }

        public static bool Equals(Vector v1, Vector v2)
        {
            if (v1.values.Length != v2.values.Length)
            {
                return false;
            }
            return v1.values.SequenceEqual(v2.values);
        }

        // Добавляем сеттеры, геттеры, методы для заполнения векторов и т.д
        public double Get(int index)
        {
            return values[index];
        }

        public void Set(int index, double value)
        {
            values[index] = value;
        }

        public void FillRandom(double a, double b)
        {
            Random random = new Random();
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.NextDouble() * (b - a) + a;
            }
        }

        public int LinearSearch(double value)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool IsSorted()
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                if (values[i] > values[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int BinarySearch(double value)
        {
            int left = 0;
            int right = values.Length - 1;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (values[middle] == value)
                {
                    return middle;
                }
                else if (values[middle] < value)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return -1;
        }

        public void TimSort()
        {
            Array.Sort(values);
        }

        public void ShiftRight()
        {
            Console.WriteLine("Введите кол-во позиций для сдвига влево: ");
            int positions = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < positions; i++)
            {
                double temp = values[0];
                for (int j = 1; j < values.Length; j++)
                {
                    values[j - 1] = values[j];
                }
                values[values.Length - 1] = temp;
            }
            for (int i = 0; i < positions; i++)
            {
                values[i] = 0;
            }
        }

        public bool AllNonNegative()
        {
            return values.All(x => x >= 0);
        }

        public void HeapSort()
        {
            int n = values.Length;

            // Создаем максимальную кучу
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(n, i);
            }

            // Извлекаем элементы из кучи один за другим
            for (int i = n - 1; i >= 0; i--)
            {
                double temp = values[0];
                values[0] = values[i];
                values[i] = temp;

                Heapify(i, 0);
            }
        }
        // Метод помощник для пирамидальной сортировки
        private void Heapify(int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && values[left] > values[largest])
            {
                largest = left;
            }

            if (right < n && values[right] > values[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                double temp = values[i];
                values[i] = values[largest];
                values[largest] = temp;

                Heapify(n, largest);
            }
        }
    }
}

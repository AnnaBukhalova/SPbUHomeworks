using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public class Exceptions
    {
        public int DivideByZeroException(int a, int b) // Обработка деления на ноль. Возвращаем 0 при попытке поделить на 0.
        {
            Console.WriteLine("Деление на ноль");
            Console.WriteLine("Делим a на b");
            int c;
            Console.WriteLine("Делимое = {0} , делитель = {1} ", a, b);


            try
            {
                c = a / b;
            }


            catch (DivideByZeroException ex) 
            {
               
                Console.WriteLine("Исключение: {0} ", ex.Message);
                Console.WriteLine("Метод: {0}", ex.TargetSite);
                c = 0;


            }

            
            
           Console.WriteLine("Результат деления = {0}", c);
           return c;
            
        }



        public int[] IndexOutOfRangeException(int[] array, int i) // Обработка выхода за пределы массива. Изменяем количество элементов массива при попытке выйти за границы массива.
        {
            Console.WriteLine("Выход за пределы массива");
            Console.WriteLine("array[{0}]", i);
            for (var n = 0; n < array.Length; n++)
            {
                array[n] = n;
                Console.WriteLine($"{n} => {array[n]}");

            }
            Console.WriteLine($"array[{i}] => Исключение? ");

            try
            {
                array[i] = i;
            }


            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Исключение: {0}", ex.Message);
                Console.WriteLine("Метод: {0}", ex.TargetSite);
                Array.Resize(ref array, i + 1);
                array[i] = i;
                Console.WriteLine("Изменяем размер массива: ");
            }


            Console.WriteLine($"array[{i}] = {array[i]} ");
            Console.WriteLine();
            return array;
        }



        


        public void FormatException(string a) // Обработка строки. Выводим целое число. В ином случае исключение.
        {
            Console.WriteLine("Конвертация строки в число");


            try
            {
                int.Parse(a);
            }


            catch (FormatException ex)
            {
                Console.WriteLine("Исключение: {0}", ex.Message);
                Console.WriteLine("Метод: {0}", ex.TargetSite);
                Console.WriteLine("Не удалось преобразовать строку в число, так как в строке не было числа или оно не являлось целым.");
                return;
            }

            int r = Convert.ToInt32(a);
            Console.WriteLine("Число: {0}", r);

        }



        public void OverflowException(int a) // Возводим целое число во вторую степень и если после вычисления этого квадрата результат выходит за предел допустимых значений инта, получаем исключение. 
        {

            Console.WriteLine("Проверка выхода за предел допустимых значений");

            try
            {
                int tryResult = checked(a * a);
            }
            catch (OverflowException ex)
            {

                Console.WriteLine("Исключение: {0}", ex.Message);
                Console.WriteLine("Метод: {0}", ex.TargetSite);
                Console.WriteLine("Случился выход за предел допустимых значений");
                return;
            }

            int result  = a * a;
            Console.WriteLine("Квадрат числа {0}: {1}", a, result);

        }

        public class Animals
        {
            public int Number;
        }

        public class Kitten : Animals
        {
            public int Paws;
        }

        public int InvalidCastException() // Обработка недопустимых преобразований типов, присваивая переменные полям объекта.
        {
            Console.WriteLine("Попытка недопустимого преобразования типов");

            var animal = new Animals
            {
                Number = 1
            };
            var cat = new Kitten
            {
                Number = 3,
                Paws = 4
            };
            Console.WriteLine("animal: number = {0}.",animal.Number);
            Console.WriteLine("cat: cat.Number = {0}, cat.Paws = {1}.", cat.Number, cat.Paws);

            try
            {
                cat = (Kitten)animal;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                Console.WriteLine("Метод: {0}", ex.TargetSite);
                cat.Number = 1;
                Console.WriteLine("cat: cat.Number = {0}, cat.Paws= {1}.",cat.Number, cat.Paws);
            }
            Console.WriteLine();
            return 1; 
        }


        public Animals NullReferenceException(Animals animal) // Обработка попытки обращения к объекту, равному null, производя инициализацию.
        {
            Console.WriteLine("Пытаемся присвоить полю Number объекта animal значение 5.");
            try
            {
                animal.Number = 5;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
                Console.WriteLine("Метод: {0}", ex.TargetSite);
                animal = new Animals
                {
                    Number = 5
                };
            }
            Console.WriteLine("animal.Number = {0}", animal.Number);
            Console.WriteLine();
            return animal;
        }


        public FileStream ArgumentException(string path) //  Обрабатка некорректного открытия файла, создавая новый файл.
        {
            Console.WriteLine("Попытка открытия не существующего файла");
            FileStream text;
            try
            {
                text = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
                Console.WriteLine("Метод: {0}", ex.TargetSite);
                Console.WriteLine("Такого файла не существует. Попытка создать новый.");
                text = File.Create(Path.GetTempFileName());
                Console.WriteLine();
                return text;
            }
            Console.WriteLine("Файл успешно открыт.");
            Console.WriteLine();
            return text;
        }


        public void DirectoryNotFoundException(string direction) // Обработка попытки перейти в какую-то директорию, если такой не существует - исключение.
        {
            

            try
            {
                Directory.SetCurrentDirectory(direction);
            }
            catch (DirectoryNotFoundException ex)
            {
               
                Console.WriteLine("Исключение: {0}",ex.Message);
                Console.WriteLine("Попытка перехода в несуществующую директорию.");
                return;
            }

            Directory.SetCurrentDirectory(direction);
        }

        public void KeyNotFoundException(Dictionary<int, string> d, int k) // Обработка значения из словаря по указанному ключу. Если такого ключа нет - исключение.
        {
            try
            {
                string try = d[k];
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine("Ошибка: {0}",ex.Message);
                Console.WriteLine("Попытка получения значения используя не существующий ключ.");
                return;
            }

            string v = d[k];
            Console.WriteLine(v);
        }


















    }
}

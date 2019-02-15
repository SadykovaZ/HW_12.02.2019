using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12._02._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите номер задания: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("Напечатать весь массив целых чисел");
                int[] arr = { 4, 5, 6, 7, 8 };
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            else if (number == 2)
            {
                Console.WriteLine("Найти индекс максимального значения в массиве");
                int[] arr = { 4, 5, 6, 7, 8 };
                int max = arr.Max();
                int index = Array.IndexOf(arr, max);
                Console.WriteLine(index);
            }
            else if (number == 3)
            {
                Console.WriteLine("Найти индекс максимального четного значения в массиве");
                int[] arr = { 13, 10, 5, 5, 8 };
                int max = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if ((arr[i] > max) && (arr[i] % 2 == 0))
                    {
                        max = arr[i];
                        Console.WriteLine(max);
                        int index = Array.IndexOf(arr, max);
                        Console.WriteLine(index);
                    }
                }

            }
            else if (number == 4)
            {
                Console.WriteLine("Удалить элемент из массива по индексу");
                string[] myArray = { "a", "b", "c", "d", "e" };
                int indexToRemove = 1;
                myArray = myArray.Where((source, index) => index != indexToRemove).ToArray();
                foreach (string str in myArray)
                    Console.WriteLine(str);
            }
            else if (number == 5)
            {
                Console.WriteLine("Удаление элементов из массива по значению");
                int[] arr = { 13, 10, 5, 5, 8 };
                int numToRemove = 10;
                arr = arr.Where(val => val != numToRemove).ToArray();
                foreach (int a in arr)
                    Console.WriteLine(a);
            }
            else if (number == 6)
            {
                Console.WriteLine("Вставить элемент в массив по индексу");

                String str = "Hello world";

                Console.WriteLine("Current string: " + str);


                Console.WriteLine("New string: " + str.Insert(5, " friend this is my"));

            }
            else if (number == 7)
            {
                Console.WriteLine("Составьте программу, которая в слове «класс» две одинаковые буквы заменяет цифрой «1»");
                string str = "класс";
                string str1 = str.Replace('с', '1');
                Console.WriteLine(str1);
            }
            else if (number == 8)
            {
                Console.WriteLine("Дан текст. Определить, есть ли в тексте слово one");
                string str = "Дан текст. Определить, есть ли в тексте слово one";
                if (str.Contains("one"))
                {
                    Console.WriteLine("Yes");

                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else if (number == 9)
            {
                Console.WriteLine("•	Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. Программа должна сосчитать количество введенных пользователем пробелов");
                Console.WriteLine("Enter some symbols: ");
                char input;
                int spaceCount = 0;
                do
                {
                    input = Console.ReadKey().KeyChar;
                    if (input == ' ')
                        spaceCount++;
                }
                while (input != '.');

                Console.WriteLine("Quantity of spaces: " + spaceCount);

            }
            else if (number == 10)
            {
                Console.WriteLine("Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот");

                
                ConsoleKeyInfo symbol;
                do
                {
                    Console.WriteLine("Введите символ для конвертации регистра");
                    Console.WriteLine("Для окончания ввода нажмите ESC ");
                    symbol = Console.ReadKey();
                    Console.WriteLine();
                  
                    Console.WriteLine("Введенный символ " + symbol.KeyChar);
                    if (char.IsLetter(Convert.ToChar(symbol.KeyChar)))
                    {
                        if (char.IsUpper(Convert.ToChar(symbol.KeyChar)))
                        {
                            Console.WriteLine("Конвертируемый символ " + char.ToLower(Convert.ToChar(symbol.KeyChar)));
                        }
                        else
                        {
                            Console.WriteLine("Конвертируемый символ " + char.ToUpper(Convert.ToChar(symbol.KeyChar)));
                        }
                    }               


                    if (Convert.ToInt32(symbol.KeyChar) == 27)
                    {
                        break;
                    }
                } while (true);

            }

        }
    }
}

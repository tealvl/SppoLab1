using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SppoLab1
{
    class UI
    {
        public static void Print(string str) 
        {
            Console.WriteLine(str);
        }
        public static void PrintWarning(string str) 
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(str);
            Console.ResetColor();
        }

        public static void Clear()
        {
            Console.Clear();
        }

        public static void SpaceLine(int countSpaceLine)
        {
            for (int i = 0; i < countSpaceLine; i++)
            {
                Console.WriteLine();
            }
        }

        public static int InputSecurityRangeInt(int left, int right, string message = "") 
        {
            if (right <= left) 
            {
                UI.PrintWarning("Аргументы переданы не правильно");
                return left;
            }

            List<int> listInt = new List<int>();

            for (int i = left; i <= right; i++)
            {
                listInt.Add(i);
            }

            return InputSecurityInt(listInt, message);
        }

        public static string InputeString() 
        {
            string inputUser = Console.ReadLine();
            return inputUser;
        }

        /// <summary>
        /// Защищенный ввод числа с клавиатуры
        /// </summary>
        /// <param name="listInt">Лист, в котором находятся варианты чисел, которые должен ввести пользователь</param>
        /// <param name="message">Сообщение которое будет выводиться при неудачном вводе</param>
        /// <returns>Число, которое находится в listInt</returns>
        public static int InputSecurityInt(IReadOnlyList<int> listInt, string message) 
        {
            int inputUser;

            while (true) 
            {
                try
                {
                    SpaceLine(1);
                    Print(message);

                    inputUser = int.Parse(Console.ReadLine());

                    if (listInt.Contains(inputUser))
                    {
                        break;
                    }
                    else 
                    {
                        Print("Такого числа нет в списке, попробуйте еще раз");
                    }
                }
                catch 
                {
                    Print("Ошибка, попробуйте еще раз!");
                }

            }

            SpaceLine(1);
            return inputUser;
        }

    }
}

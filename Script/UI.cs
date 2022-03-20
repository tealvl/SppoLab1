﻿using System;
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

        public static int InputSecurityInt(IReadOnlyList<int> listInt, string message) 
        {
            int inputUser;

            while (true) 
            {
                try
                {
                    SpaceLine(4);
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
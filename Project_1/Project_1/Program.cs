using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_1
{
    class Program
    {
        //--------------------------Output elements of menu
        static void MenuElement(int active, int current, string text)
        {
            if (current == active)
            {
                ConsoleColor oldColor = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(text);
                Console.BackgroundColor = oldColor;
            }
            else
            {
                Console.WriteLine(text);
            }
        }

        


        //----------------------------Train-Menu
        static void TaskTrain(int active)
        {
            Console.Clear();
            switch (active)
            {
                case 0:
                    
                    break;

                default:
                    break;

            }
        }


        static void TrainMenu()
        {
            
            int active = 0;
            string[] tasks = {
               "Случайное слово" };
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Тренировка\n__________");
                for (int i = 0; i < tasks.Length; i++)
                {
                    MenuElement(active, i, tasks[i]);
                }


                var KP = Console.ReadKey();
                switch (KP.Key)
                {
                    case ConsoleKey.Escape:
                        return;
                        break;
                    case ConsoleKey.DownArrow:
                        if (active != (tasks.Length - 1))
                        {
                            active++;
                            continue;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (active != 0)
                        {
                            active--;
                            continue;
                        }
                        break;
                    case ConsoleKey.Enter:
                        TaskTrain(active);
                        Console.ReadKey();
                        continue;
                        break;
                }


            }
        }



        //--------------------------Dictionary-Menu

        static void TaskDictionary(int active)
        {
            Console.Clear();
            switch (active)
            {
                case 0:
                    Console.WriteLine("Введите слово");
                    string EnterWord = Console.ReadLine();
                    Console.WriteLine("Введите перевод/значение");
                    string EnterMeaning = Console.ReadLine();
                    File.AppendAllText("words.txt", EnterWord + "|" + EnterMeaning + "|\n");
                    break;

                default:
                    break;

            }
        }


        static void DictionaryMenu()
        {

            int active = 0;
            string[] tasks = {
               "Добавить слово" };
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Словарь\n__________");
                for (int i = 0; i < tasks.Length; i++)
                {
                    MenuElement(active, i, tasks[i]);
                }


                var KP = Console.ReadKey();
                switch (KP.Key)
                {
                    case ConsoleKey.Escape:
                        return;
                        break;
                    case ConsoleKey.DownArrow:
                        if (active != (tasks.Length - 1))
                        {
                            active++;
                            continue;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (active != 0)
                        {
                            active--;
                            continue;
                        }
                        break;
                    case ConsoleKey.Enter:
                        TaskDictionary(active);
                        continue;
                        break;
                }


            }
        }
        //-------------------------Main Menu


        static void Task(int active)
        {
            Console.Clear();
            switch (active)
            {
                case 0:
                    TrainMenu();
                    break;
                case 1:
                    DictionaryMenu();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;

                default:
                    break;

            }
        }


        static void Menu()
        {
            int active = 0;
            string[] tasks = {
               "Тренировка", "Личный словарь", "Выход" };
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Главное меню\n__________");
                for (int i = 0; i < tasks.Length; i++)
                {
                    MenuElement(active, i, tasks[i]);
                }


                var KP = Console.ReadKey();
                switch (KP.Key)
                {
                    case ConsoleKey.Escape:
                        return;
                        break;
                    case ConsoleKey.DownArrow:
                        if (active != (tasks.Length - 1))
                        {
                            active++;
                            continue;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (active != 0)
                        {
                            active--;
                            continue;
                        }
                        break;
                    case ConsoleKey.Enter:
                        Task(active);
                        
                        continue;
                        break;
                }


            }


        }



        //-----------------------------------Initialization
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Menu();



        }
    }
}

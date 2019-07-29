using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Remindertask
{
    class Program
   
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();

            }
        }

        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Congratulation! You are on your way to organize your life.");
            Console.WriteLine("----------------------------------------------------------");
            //Console.WriteLine("Option 1 = Press 1 to add  tasks to list");
            Console.WriteLine("1. Add to List ||2. View List ||3. Skip the item ||4. Complete Tasks ||0.Exit");
            Console.WriteLine("Enter your selection:");
            //Console.WriteLine("Option 2 = Press 2 to view the list");
            //Console.WriteLine("Option 3 = Press 3 to skip the item");
            //Console.WriteLine("Option 4 = Press 0 to exit the menu");


            string result = Console.ReadLine();

            if (result == "1")
            {
                AddTask();
                return true;
            }

            else if (result == "2")
            {
                ViewList();
                return true;
            }
            else if (result == "3")
            {
                SkipTask();
                return true;

            }
            else if (result == "4")
            {
                CompleteTask();
                return true;

            }
            else if (result == "0")
            {
                return false;

            }
            else
            {
                return true;
            }


        }
        static void AddTask()
        {
            Console.Clear();
            Console.WriteLine(" Please add any task that you like to complete : Press esc to return to main menu");
            //string [] lines = Console.ReadLine();
            string Things = @"Testttt.txt";
            ConsoleKeyInfo cki;

            try
            {
                do
                {
                    string appendtext = Console.ReadLine();
                    cki = Console.ReadKey(true);
                    File.AppendAllText(Things, "\n" + appendtext);
                } while (cki.Key != ConsoleKey.Escape);
                //foreach (string line in File.ReadAllLines(Things))
                //{
                //    Console.WriteLine(line);
                //    Console.ReadLine();
                //}
                //sw.WriteLine("Things TO Do");
                //sw.WriteLine("Things TO Do");
                //sw.WriteLine("Things TO Do");
                //sw.WriteLine("Things TO Do");
                //sw.WriteLine("Things TO Do");
                //sw.WriteLine("Things TO Do");
                // var input = Console.ReadLine();
                // sw.Close();

            }
            catch (Exception e)
            {
                //Console.WriteLine("Exception:" + e.Message);
                string rrr = Console.ReadLine();
                File.WriteAllText(Things, rrr);
            }
            // finally
            //{
            //    Console.WriteLine("Executing finally block.");
            //}

            //Console.ReadLine();
        }
        static void ViewList()
        {
            Console.Clear();
            Console.WriteLine("ViewList");
            List<string> Things = File.ReadAllLines(@"Testttt.txt").ToList();
            List<string> page = Things.Take(20).ToList();   ///skip (5). take(5)

            foreach (string line in page)
            {
                Console.WriteLine(line);
                //Console.ReadLine();
            }
            Console.WriteLine("Page 1");
            Console.ReadLine();
        }

        static void SkipTask()
        {
            Console.Clear();
            Console.WriteLine("Press up arrow to skiptask");
            Console.ReadLine();
        }

        static void CompleteTask()
        {
            Console.Clear();
            Console.WriteLine("Press C arrow to CompleteTask");
            Console.ReadLine();
        }

        /*
        private List<string> tasks;
        private List<bool> isActioned;

        public App()
        {

            ReadListFromFile();
        }
        public void Run()
        {
            bool quit;
            do
            {
                PrintTaskList();
                var key = RunInputCycle();
                quit = HandleUserInput(key);

            } while (!quit);

            WriteListToFile();
            Console.WriteLine(); //Ensure "Press any key to quit..." is on its own line

        }

        private ConsoleKey RunInputCycle()
        {
            ConsoleKey key;

            PrintUsageOption();
            key = GetInputFromUser();

            return key;
        }

        private bool HandleUserInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.A:
                    InputTaskToList();
                    break;
                case ConsoleKey.D:
                    break;
                case ConsoleKey.N:
                    break;
                case ConsoleKey.DownArrow:
                    break;
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.Q:
                    return true;

            }

            return false;
        }

        private ConsoleKey GetInputFromUser()
        {
            return Console.ReadKey().Key;
        }

        private void PrintUsageOption()
        {
            Console.WriteLine("a: add | d:delete | n: next page | downarrow: select | enter: action | q: quit");
            Console.Write("Input");
        }

        private void InputTaskToList()
        {
            Console.Clear();
            Console.Write("Add a new task:(empty to cancel):");

            var input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {

                tasks.Add(input);

            }
        }

        private void PrintTaskList()
        {
            Console.Clear();
            foreach (var t in tasks)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine();
        }


        private void ReadListFromFile()
        {

            try
            {
                using (StreamReader sr = new StreamReader(@"D:\TaskList.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        var input = sr.ReadLine();
                        tasks.Add(input);
                        isActioned.Add(false);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                ;
            }


        }
        private void WriteListToFile()
        {
            using (StreamWriter sw = new StreamWriter(@"D:\TaskList.txt"))
            {
                foreach (var t in tasks)
                {
                    sw.WriteLine(t);
                }
            }
        }
        */
    }
}
    














#region ALL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleRPG
{
    class Human
    {
        #region encapsulate
        public static string Stat = "Статус параметра ";
        public static int _hunger, _iq, _entertainment;
        static int hunger { get { return _hunger; } set { _hunger = value; } }
        int iq { get { return _iq; } set { _iq = value; } }
        int entertainment { get { return _entertainment; } set { _entertainment = value; } }
        #endregion

        #region Methods

        #region ActionMethods

        public static void Eat()
        {
            _hunger += 2;
            _entertainment -= 1;
        }

        public static void DoHW()
        {
            _iq += 2;
            _entertainment -= 1;
            _hunger -= 1;
        }

        public static void PlayPC()
        {
            _entertainment += 2;
            _hunger -= 2;

            Random r = new Random();
            int Chance = r.Next(0, 10);
            if (Chance > 3)
            {
                _iq -= 1;
            }
        }

        public static void DoNothing()
        {
            _iq -= 2;
            _hunger -= 2;
            _entertainment -= 2;
        }

        public static void AUTO()
        {
            StatsMaxEntertaiment();
            StatsMaxHunger();
            StatsMaxIq();
            ShowStats();
        }
        #endregion

        #region Maxregion

        public static void ShowStats()
        {
            Console.WriteLine(" Голод: " + _hunger + "\n Ум: " + _iq + "\n Развлечение: " + _entertainment + "\n");
            Console.WriteLine("1) Похавать \n2) Сделать ДЗ \n3) Поиграть в компьютер \n4) Ничего не делать.");

        }

        public void Choice()
        {
            int Action = 0;
            try
            {
                Action = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Не дави так часто на enter");
                System.Threading.Thread.Sleep(300);
            }
            finally
            {
                switch (Action)
                {
                    case 1:
                        Console.Clear();
                        Eat();
                        AUTO();
                        break;

                    case 2:
                        Console.Clear();
                        DoHW();
                        AUTO();
                        break;

                    case 3:
                        Console.Clear();
                        PlayPC();
                        AUTO();
                        break;

                    case 4:
                        Console.Clear();
                        DoNothing();
                        AUTO();
                        break;

                    default:
                        Console.WriteLine("U STUPID!");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        AUTO();
                        break;
                }
            }
        }

        public static void StatsMaxHunger()
        {
            #region _hunger

            if (_hunger >= 350)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Вы выиграли!");
                Console.ReadLine();
                Environment.Exit(1);
            }

            else if (_hunger <= 0)
            {
                Console.Clear();
                Console.WriteLine(Stat+"голод: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("ТЫ УМЕР! Reason: Hunger\n");
                Console.ReadLine();
                Environment.Exit(1);
            }

            else if (_hunger >= 120)
            {
                Console.WriteLine(Stat + "голод: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Все хорошо.\n");
                Console.ResetColor();
            }

            else if (_hunger > 20 && _hunger < 120)
            {
                Console.WriteLine(Stat + "голод: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Голодание!\n");
                Console.ResetColor();
            }

            else if (_hunger <= 20)
            {
                Console.WriteLine(Stat + "голод: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ГОЛОД!\n");
                Console.ResetColor();
            }

            

            #endregion
        }

        public static void StatsMaxIq()
        {
            
            #region _iq

             if (_iq >= 250)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Вы выиграли!");
                Console.ReadLine();
                Environment.Exit(1);
            }

            else if(_iq <= 0)
            {
                Console.Clear();
                Console.WriteLine(Stat+"ум: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("ТЫ УМЕР! Reason: Iq\n");
                Console.ReadLine();
                Environment.Exit(1);
            }

            else if (_iq >= 80)
            {
                Console.WriteLine(Stat + "ум: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Все хорошо.\n");
                Console.ResetColor();
            }

            else if (_iq > 20 && _iq < 80)
            {
                Console.WriteLine(Stat + "ум: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Стримительная деградация!\n");
                Console.ResetColor();
            }

            else if (_iq <= 20)
            {
                Console.WriteLine(Stat + "ум: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ДАУН\n");
                Console.ResetColor();
            }

            

            #endregion
        }

        public static  void StatsMaxEntertaiment()
        {
            #region _entertaiment

            if (_entertainment >= 450)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Вы выиграли!");

                Console.ResetColor();

                Console.ReadLine();
                Environment.Exit(1);
            } 

            else if (_entertainment <= 0)
            {
                Console.Clear();
                Console.WriteLine(Stat);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("ТЫ УМЕР! Reason: Entertainment\n");
                Console.ReadLine();
                Environment.Exit(1);
            }

            
            else if (_entertainment > 80)
            {
                Console.WriteLine(Stat + "развлечение: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Все нормально.\n");
                Console.ResetColor();
            }
            else if ( _entertainment >= 20 && _entertainment <= 80)
            {
                Console.WriteLine(Stat + "развлечение: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Задумайтесь о жизни!\n");
                Console.ResetColor();
            }

            else if (_entertainment < 20)
            {
                Console.WriteLine(Stat + "развлечение: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ВАМ НУЖНО ОТДОХНУТЬ!\n");
                Console.ResetColor();
            }
            #endregion
        }

        #endregion

        #region TODOregion
       
        #endregion

        #endregion

        public Human(int h, int i, int e)
        {
            _hunger = h;
            _iq = i;
            _entertainment = e;
        }

        public static void Minus(object Objectt)
        {
            hunger -= 2;
            Console.Clear();
            AUTO();
            //ShowStats();
        }

        public void INTRO()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("####@@@@@@@@@@@@##########@@@@@@@@@@############");
            System.Threading.Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("####@@@@@@@@@@@@##########@@@@@@@@@@############");
            System.Threading.Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("########@@@#########################@@@#########");
            System.Threading.Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("########@@@#########################@@@#########");
            System.Threading.Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("########@@@###############@@@@@@@@@@############");
            System.Threading.Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("########@@@###############@@@@@@@@@@############");
            System.Threading.Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("########@@@############@@@######################");
            System.Threading.Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("########@@@############@@@######################");
            System.Threading.Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("########@@@###############@@@@@@@@@@############");
            System.Threading.Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("########@@@###############@@@@@@@@@@############");
            System.Threading.Thread.Sleep(1200);

            Console.ResetColor();

        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Human Daniel = new Human(120, 120, 210);

            Daniel.INTRO();

            #region TODO

            TimerCallback tm = new TimerCallback(Human.Minus);
            Timer time = new Timer(tm, null, 2, 5000);

            #endregion
            
            while (true)
            {
                Daniel.Choice();
            }
        }
    }
}

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool k = true;
            int kol = 0;
            int win = 0;
            int lose = 0;
            int rock = 0;
            int scissors = 0;
            int paper = 0;
            int draw = 0;
            int LoRock = 0;
            int LoScissors = 0;
            int LosPaper = 0;

            try
            {
                do
                {
                    Console.WriteLine("Ваш ход: 1-Камень; 2-Ножницы; 3-Бумага");
                    Random rnd = new Random();
                    int PC = rnd.Next(3);
                    int run = int.Parse(Console.ReadLine());
                    switch (run)
                    {
                        case 1: //Камень
                            switch (PC)
                            {
                                case 0:
                                    Console.WriteLine("Камень");
                                    Console.WriteLine();
                                    Console.WriteLine("Ничья");
                                    draw++;
                                    rock++;
                                    kol++;
                                    break;
                                case 1:
                                    Console.WriteLine("Ножницы");
                                    Console.WriteLine();
                                    Console.WriteLine("Вы выиграли");
                                    LoRock++;
                                    rock++;
                                    win++;
                                    kol++;
                                    break;
                                case 2:
                                    Console.WriteLine("Бумага");
                                    Console.WriteLine();
                                    Console.WriteLine("Вы проиграли");
                                    rock++;
                                    lose++;
                                    kol++;
                                    break;


                            }

                            break;
                        case 2: // Ножницы
                            switch (PC)
                            {
                                case 0:
                                    Console.WriteLine("Камень");
                                    Console.WriteLine();
                                    Console.WriteLine("Вы проиграли");
                                    LoScissors++;
                                    scissors++;
                                    lose++;
                                    kol++;
                                    break;
                                case 1:
                                    Console.WriteLine("Ножницы");
                                    Console.WriteLine();
                                    Console.WriteLine("Ничья");
                                    draw++;
                                    scissors++;
                                    kol++;
                                    break;
                                case 2:
                                    Console.WriteLine("Бумага");
                                    Console.WriteLine();
                                    Console.WriteLine("Вы выиграли");
                                    scissors++;
                                    win++;
                                    kol++;
                                    break;
                            }

                            break;
                        case 3: //Бумага
                            switch (PC)
                            {
                                case 0:
                                    Console.WriteLine("Камень");
                                    Console.WriteLine();
                                    Console.WriteLine("Вы выиграли");
                                    paper++;
                                    win++;
                                    kol++;
                                    break;
                                case 1:
                                    Console.WriteLine("Ножницы");
                                    Console.WriteLine();
                                    Console.WriteLine("Вы проиграли");
                                    LosPaper++;
                                    paper++;
                                    lose++;
                                    kol++;
                                    break;
                                case 2:
                                    Console.WriteLine("Бумага");
                                    Console.WriteLine();
                                    Console.WriteLine("Ничья");
                                    draw++;
                                    paper++;
                                    kol++;
                                    break;
                            }

                            break;
                        default:
                            Console.WriteLine("Вы выбрали не существующую коамнду");
                            break;
                    }

                    Console.WriteLine("Хотите сыграть ещё раз? 1-Да, 2-нет");
                    int x = int.Parse(Console.ReadLine());
                    if (x == 1)
                    {
                        k = true;
                        Console.Clear();
                    }
                    else if (x == 2)
                    {
                        k = false;
                    }
                    else
                    {
                        Console.WriteLine("Такого варианта не существует");
                    }


                } while (k);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Вы сыграли: " + kol + " игры.");
            Console.WriteLine("Из них было: " + win + " выиграных " + draw + " ничьи и " + lose + " проиграных.");

            Console.WriteLine("За время игры вы использовали: ");
            Console.Write("Камень: " + rock + " раз(а); ");
            Console.Write(" Ножницы: " + scissors + " раз(а); ");
            Console.Write(" Бумагу: " + paper + " раз(а); ");

            Console.WriteLine();
            if (LoRock > LoScissors && LoRock > LosPaper)
            {
                Console.WriteLine("Самым эффективаное оружие против вас был камень. Компьютер исползовал его: " + LoRock + " раз.");
            }
            else if (LoScissors > LoRock && LoScissors > LosPaper)
            {
                Console.WriteLine("Самым эффективаное оружие против вас были ножницы. Компьютер исползовал их: " + LoScissors + " раз.");
            }
            else if (LosPaper > LoScissors && LosPaper > LoRock)
            {
                Console.WriteLine("Самым эффективаное оружие против вас была бумага. Компьютер исползовал её: " + LosPaper + " раз.");
            }
            else
            {
                Console.WriteLine("Вы очень сообразительны, компьютеру пришлось применять различное оружие чтобы выиграть у вас ");
            }

            Console.ReadKey();
        }
    }
}
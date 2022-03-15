using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_HearthStone
{
    class Program
    {
        static void Main(string[] args)
        {
            var newGame = new Game();
            Console.WriteLine(""); 
            Console.WriteLine();
            Console.WriteLine("Выберите того, кто будет на месте первого игрока.");
            Console.WriteLine("Введите 1, если хотите, чтобы на месте первого игрока был человек.");
            Console.WriteLine("Введите 2, если хотите, чтобы на месте первого игрока был искусственный интеллект.");
            var indicator_1 = newGame.Input1Or2();
            indicator_1 -= 1;
            Console.WriteLine();
            

            Console.WriteLine();
            Console.WriteLine("Выберите того, кто будет на месте второго игрока.");
            Console.WriteLine("Введите 1, если хотите, чтобы на месте второго игрока был человек.");
            Console.WriteLine("Введите 2, если хотите, чтобы на месте второго игрока был искусственный интеллект.");
            Console.WriteLine();
            var indicator_2 = newGame.Input1Or2();
            indicator_2 -= 1;
            Console.WriteLine();

            var player_1 = ChooseHero(1, indicator_1, newGame);
            player_1.Number = 1;
            player_1.Artificial_intelligence = indicator_1;
            var player_2 = ChooseHero(2, indicator_2, newGame);
            player_2.Artificial_intelligence = indicator_2;
            player_2.Number = 2;
            newGame.BeginGame(player_1, player_2);
            

        }

        static public Heroes ChooseHero(int number, int Artificial_intelligence, Game newGame)
        {
            //Выбор класса
            Console.WriteLine("Игрок {0}", number);
            Console.WriteLine("Выберите класс, за который хотите играть.");
            Console.WriteLine("Введите 1, если хотите играть за чернокнижника.");
            Console.WriteLine("Введите 2, если хотите играть за мага.");
            int output = 0;
            if (Artificial_intelligence == 0)
            {
                output = newGame.Input1Or2();
            }
            else
            {
                var random = new Random();
                output = random.Next(1, 3);
            }
            
            if (output == 1)
            {
                Console.WriteLine("Выбран класс чернокнижник");
                Console.WriteLine("Выберите героя, за которого хотите играть.");
                Console.WriteLine("Введите 1, если хотите играть за Gul_dan.");
                Console.WriteLine("Введите 2, если хотите играть за Nemsy_Necrofizzle.");
                if (Artificial_intelligence == 0)
                {
                    output = newGame.Input1Or2();
                }
                else
                {
                    var random = new Random();
                    output = random.Next(1, 3);
                }
                if (output == 1)
                {
                    Console.WriteLine("Выбран Gul_dan");
                    return new Gul_dan();
                }
                else
                {
                    Console.WriteLine("Выбрана Nemsy_Necrofizzle");
                    return new Nemsy_Necrofizzle();
                }
            }
            else
            {
                Console.WriteLine("Выбран класс маг");
                Console.WriteLine("Выберите героя, за которого хотите играть.");
                Console.WriteLine("Введите 1, если хотите играть за Jaina_Proudmoore.");
                Console.WriteLine("Введите 2, если хотите играть за Medivh.");
                if (Artificial_intelligence == 0)
                {
                    output = newGame.Input1Or2();
                }
                else
                {
                    var random = new Random();
                    output = random.Next(1, 3);
                }
                if (output == 1)
                {
                    Console.WriteLine("Выбрана Jaina_Proudmoore");
                    return new Jaina_Proudmoore();
                }
                else
                {
                    Console.WriteLine("Выбран Medivh");
                    return new Medivh();
                }
            }
        }
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_HearthStone
{
    class Game
    {

        public void BeginGame(Heroes player_1, Heroes player_2)  // метод, который начинает игру, раздавая карты игрокам.
        {
            Console.WriteLine("Битва началась");
            for (int i = 0; i < 3; i++)
            {
                GiveCard(player_1);
                Console.WriteLine();
                GiveCard(player_2);
                Console.WriteLine();
            }
            var k = 0;
            while (true)
            {
                if (k % 2 == 0)
                {
                    PlayerTurn(player_1, player_2);
                }
                else
                {
                    PlayerTurn(player_2, player_1);
                }
                k += 1;
            }

        }
        
        public void GiveCard(Heroes player) // метод, который выдаёт карту игроку.
        {
            {
                for (int i = 0; i < 10; i++) 
                {
                    if (player.Inventory[i] == null)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            if (player.deck[j] != null)
                            {
                                player.Inventory[i] = player.deck[j];
                                player.deck[j] = null;
                                player.deck[j] = null;
                                Console.WriteLine("Игрок {0} вытянул из колоды карту", player.Number);
                                Console.WriteLine();
                                player.Inventory[i].PrintInfoAboutCard();
                                return;
                            }
                        }
                        Console.WriteLine("Карты в колоде закончились");
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine("Ваш инвентарь полон (вы не получите новую карту на этом ходу)");
                Console.WriteLine();
                return;
            }
        }

        public void PlayerTurn(Heroes player_1, Heroes player_2) // ход игрока
        {
            Console.WriteLine("Игрок {0} делает ход //////////////////////////////////////////////////////////////", player_1.Number);
            Console.WriteLine();
            PrintCurrSituation(player_1, player_2);
            GiveCard(player_1);
            player_1.Skill(player_1, player_2);
            CardOnTheTable(player_1);
            PlayCards(player_1, player_2);
            Console.WriteLine("Ваш ход закончен.");
            Console.WriteLine();
        }

        public void PrintCurrSituation(Heroes player_1, Heroes player_2) // выводит текущую информацию о картах 
        {
            if (player_1.Number == 1)
            {
                player_2.PrintPlayerInfo();
                player_2.PrintTable();
                player_2.PrintInventory();
                player_1.PrintPlayerInfo();
                player_1.PrintTable();
                player_1.PrintInventory();
            }
            else
            {
                player_1.PrintPlayerInfo();
                player_1.PrintTable();
                player_1.PrintInventory();
                player_2.PrintPlayerInfo();
                player_2.PrintTable();
                player_2.PrintInventory();
            }
        }

        public void CardOnTheTable(Heroes player) // метод, который проверяет можно ли выложить карту на стол
        {
            player.PrintInventory();
            bool areCardsInInventory = false;
            bool tableIsFull = true;

            for (int i = 0; i < 10; i++)
            {
                if (player.Inventory[i] != null)
                {
                    areCardsInInventory = true;
                    break;
                }
            }

            for (int i = 0; i < 7; i++)
            {
                if (player.OnTable[i] == null)
                {
                    tableIsFull = false;
                }
            }

            if (areCardsInInventory == false)
            {
                Console.WriteLine("Ваш инвентарь полностью пуст. Вы не можете выложить карту на стол.");
                Console.WriteLine();
                return;
            }
            else if (tableIsFull == true)
            {
                Console.WriteLine("Ваш стол заполнен. Вы не можете выложить сюда карту.");
                Console.WriteLine();
                return;
            }
            else
            {
                Console.WriteLine("Выберите карту, которую хотите разместить на стол.");

                var output = InputCardOnTable(player);

                for (int i = 0; i < 7; i++)
                {
                    if (player.OnTable[i] == null)
                    {
                        player.OnTable[i] = player.Inventory[output - 1];
                        player.Inventory[output - 1] = null;
                        return;
                    }
                }
            }
            

        }

        public void PlayCards(Heroes player_1, Heroes player_2) // метод, который реализует атаку карты
        {
            for (int i = 0; i < 7; i++)
            {
                if (player_1.OnTable[i] != null)
                {
                    Console.WriteLine("На слоте {0} вашего стола находится карта", i + 1);
                    player_1.OnTable[i].PrintInfoAboutCard();
                    Console.WriteLine("Хотите ли вы атаковать этой картой врага? Введите 0, если нет, 1, если да");

                    int output = 0;
                    if (player_1.Artificial_intelligence == 0)
                    {
                        output = Input0Or1();
                    }
                    else
                    {
                        var random = new Random();
                        output = random.Next(0, 2);
                    }
                    bool flagDamage = false;
                    if (output == 1)
                    {
                        player_2.HealthDamage(player_1.OnTable[i].Atk);
                        flagDamage = true;
                        Console.WriteLine("Вы атаковали врага. Его хп {0}", player_2.Health);
                        continue;
                    }
                    else
                    {
                        
                        for (int j = 0; j < 7; j++)
                        {
                            if (player_2.OnTable[j] != null)
                            {
                                Console.WriteLine("Хотите ли вы атаковать этой картой карту врага? Введите 0, если нет, 1, если да");
                                player_2.OnTable[j].PrintInfoAboutCard();
                                output = 0;
                                if (player_1.Artificial_intelligence == 0)
                                {
                                    output = Input1Or2();
                                }
                                else
                                {
                                    var random = new Random();
                                    output = random.Next(1, 3);
                                }
                                if (output == 1)
                                {
                                    bool IsPlayer2CardDestroyed = false;
                                    bool IsPlayer1CardDestroyed = false;
                                    
                                    player_2.OnTable[j].Hp -= player_1.OnTable[i].Atk;
                                    Console.WriteLine("Карта получает урон");
                                    player_2.OnTable[j].PrintInfoAboutCard();
                                    if (player_2.OnTable[j].Hp <= 0)
                                    {
                                        
                                        IsPlayer2CardDestroyed = true;
                                        Console.WriteLine("Карта уничтожена");
                                    }
                                    Console.WriteLine();

                                    
                                    player_1.OnTable[i].Hp -= player_2.OnTable[j].Atk;
                                    Console.WriteLine("Карта получает урон");
                                    player_1.OnTable[i].PrintInfoAboutCard();
                                    if (player_1.OnTable[i].Hp <= 0)
                                    {
                                        
                                        IsPlayer1CardDestroyed = true;
                                        Console.WriteLine("Карта уничтожена");
                                    }
                                    Console.WriteLine();
                                    if (IsPlayer2CardDestroyed == true)
                                    {
                                        player_2.OnTable[j] = null;
                                    }
                                    if (IsPlayer1CardDestroyed == true)
                                    {
                                        player_1.OnTable[i] = null;
                                    }

                                    flagDamage = true;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                    }
                    if (flagDamage == false)
                    {
                        Console.WriteLine("Вы никому не нанесли урона. Урон автоматически нанесен врагу");
                        player_2.HealthDamage(player_1.OnTable[i].Atk);
                    }
                }
       
            }
        }
        

        public int Input1Or2() // проверка на то, ввёл ли пользователь 1 или 2
        {
        Start:
            string strOutput = Console.ReadLine();
            int intOutput = 0;
            var isOutputAnInt = Int32.TryParse(strOutput, out intOutput);
            if (isOutputAnInt == false)
            {
                Console.WriteLine("Ошибка ввода");
                goto Start;
            }
            else if (intOutput != 1 && intOutput != 2)
            {
                Console.WriteLine("Введите 1 или 2!");
                goto Start;
            }
            return intOutput;
        }

        public int Input0Or1() // проверка на то, ввёл ли пользователь 0 или 1
        {
        Start:
            string strOutput = Console.ReadLine();
            int intOutput = 0;
            var isOutputAnInt = Int32.TryParse(strOutput, out intOutput);
            if (isOutputAnInt == false)
            {
                Console.WriteLine("Ошибка ввода");
                goto Start;
            }
            else if (intOutput != 1 && intOutput != 0)
            {
                Console.WriteLine("Введите 0 или 1!");
                goto Start;
            }
            return intOutput;
        }
        public int InputCardOnTable(Heroes player_1)
        {
        Start:
            string strOutP = "";
            int intOutP = 0;
            if (player_1.Artificial_intelligence == 0)
            {
                strOutP = Console.ReadLine();
            }
            else
            {
                var random = new Random();
                intOutP = random.Next(1, 11);
                strOutP = (intOutP).ToString();
            }
            
            var IsOutPAnInt = Int32.TryParse(strOutP, out intOutP);
            if (IsOutPAnInt == false)
            {
                Console.WriteLine("Ошибка ввода");
                goto Start;
            }
            else if (intOutP < 1 || intOutP > 10)
            {
                Console.WriteLine("Введите число от 1 до 10");
                goto Start;
            }
            else if (player_1.Inventory[intOutP - 1] == null)
            {
                Console.WriteLine("Слот инвентаря пуст.");
                goto Start;
            }
            return intOutP;

        }
    }

    
}

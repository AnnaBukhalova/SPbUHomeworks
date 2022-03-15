using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_HearthStone
{
    public abstract class Heroes
    {
        public int Artificial_intelligence = 0;
        public int Number = 0;
        public int Health = 30;
        public Card[] deck; // массив классов который называется deck
        public Card[] Inventory = new Card[10]; // максимальное количество карт, которые могут находится в инвентаре у одного игрока.
        public Card[] OnTable = new Card[7]; // максимальное количество карт, которые могут находится на столе у одного игрока.

        public abstract void Skill(Heroes gamer, Heroes enemy); // метод, который реализует способность, индивидуальную для каждого класса.
        public bool SkillOnCooldown = false; 
        public void PrintInventory() // выводит инвентарь игрока
        {
            Console.WriteLine("Инвентарь игрока {0}", Number);
            for (int i = 0; i < 10; i++)
            {
                if (Inventory[i] == null)
                {
                    Console.Write(i + 1);
                    Console.Write(" ");
                    Console.WriteLine("Слот инвентаря");
                    Console.WriteLine("пуст");
                }
                else
                {
                    Console.Write(i + 1);
                    Console.Write(" ");
                    Inventory[i].PrintInfoAboutCard();
                }
            }
            Console.WriteLine();
        }
        
        public void PrintTable() // показывает текущую ситуацию на столе игрока.
        {
            Console.WriteLine("Стол игрока {0}", Number);
            for (int i = 0; i < 7; i++)
            {
                if (OnTable[i] == null)
                {
                    Console.Write(i + 1);
                    Console.Write(" ");
                    Console.WriteLine("Слот на столе пуст");
                }
                else
                {
                    Console.Write(i + 1);
                    Console.Write(" ");
                    OnTable[i].PrintInfoAboutCard();
                }
            }
            Console.WriteLine();
        }

        public abstract void PrintPlayerInfo(); 

        public void HealthDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Console.WriteLine("Игра окончена.");
                Environment.Exit(0);
            }
        }

        public void HealthHeal(int heal)
        {
            Health += heal;
            if (Health > 30)
            {
                Health = 30;
            }
        }
    }

    public class Warlock : Heroes
    {

        public override void Skill(Heroes gamer, Heroes enemy)
        {
            enemy.HealthDamage(1);
            Console.WriteLine("Игрок {0} использует свой скилл, нанося врагу 1 урона.", gamer.Number);
            Console.WriteLine("Хп врага {0}", enemy.Health);
            Console.WriteLine();
            SkillOnCooldown = true;
            
        }

        public Warlock()
        {
            deck = new Card[20];
            var randomDeck = new RandomDeck();
            randomDeck.Put_cards_in_deck(deck);
        }
        public override void PrintPlayerInfo()
        {
            Console.WriteLine("Игрок {0}, Класс: Warlock, Здоровье: {1}", Number, Health);
        }

    }

    public class Mage : Heroes
    {

        public override void Skill(Heroes gamer, Heroes enemy)
        {
            gamer.HealthHeal(1);
            Console.WriteLine("Игрок {0} использует свой скилл, восстанавливая себе 1 хп (не может быть больше 30).", gamer.Number);
            Console.WriteLine("Ваш хп {0}", gamer.Health);
            Console.WriteLine();
            SkillOnCooldown = true;
            
        }

        public Mage()
        {

            deck = new Card[20];
            var randomDeck = new RandomDeck();
            randomDeck.Put_cards_in_deck(deck);

        }
        public override void PrintPlayerInfo()
        {
            Console.WriteLine("Игрок {0}, Класс: Mage, Здоровье: {1}", Number, Health);
        }
    }

    public class Gul_dan : Warlock // персонаж, наследуемый от класса чернокнижник.
    {

    }

    public class Nemsy_Necrofizzle : Warlock 
    {

    }

    public class Jaina_Proudmoore : Mage // персонаж, наследуемый от класса маг.
    {

    }

    public class Medivh : Mage
    {

    }
}
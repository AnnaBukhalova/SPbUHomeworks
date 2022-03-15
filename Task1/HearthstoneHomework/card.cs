using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_HearthStone
{
    public abstract class Card // класс, от которого наследуются карты, которыми ходят игроки.
    {
        public Card(int atk, int hp) 
        {
            Atk = atk;
            Hp = hp;
        } 
        public int Atk;
        public int Hp;
        public abstract void PrintInfoAboutCard(); // вынуждает наследуемые классы реализовывать этот метод и печтатать информацию о карте.
    }

    public class Murloc_Raider : Card
    {
        public Murloc_Raider() : base(2, 1) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Murloc_Raider");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }


    }

    public class Stonetush_Boar : Card
    {
        public Stonetush_Boar() : base(1, 1) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Stonetush_Boar");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Bloodfen_Raptor : Card
    {
        public Bloodfen_Raptor() : base(3, 2) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Bloodfen_Raptor");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Stormwind_Knight : Card
    {
        public Stormwind_Knight() : base(2, 5) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Stormwind_Knight");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Novice_Engineer : Card
    {
        public Novice_Engineer() : base(1, 1) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Novice_Engineer");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Wild_Pyromancer : Card
    {
        public Wild_Pyromancer() : base(3, 2) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Wild_Pyromancer");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Sunfury_Protector : Card
    {
        public Sunfury_Protector() : base(2, 3) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Sunfury_Protector");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class River_Crockolisk : Card
    {
        public River_Crockolisk() : base(2, 3) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("River_Crockolisk");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Dalaran_Mage : Card
    {
        public Dalaran_Mage() : base(1, 4) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Dalarane_Mage");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Jungle_Panther : Card
    {
        public Jungle_Panther() : base(4, 2) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Jungle_Panther");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Wolfrider : Card
    {
        public Wolfrider() : base(3, 1) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Wolfrider");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Booty_Bay_Bodyguard : Card
    {
        public Booty_Bay_Bodyguard() : base(5, 4) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Booty_Bay_Bodyguard");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Nightblade : Card
    {
        public Nightblade() : base(4, 4) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Nightblade");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Cairne_Bloodhoof : Card
    {
        public Cairne_Bloodhoof() : base(4, 5) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Cairne_Bloodhoof");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Frostwolf_Warlord : Card
    {
        public Frostwolf_Warlord() : base(4, 4) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Frostwolf_Warlord");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Shattered_Sun_Cleric : Card
    {
        public Shattered_Sun_Cleric() : base(3, 2) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Shattered_Sun_Cleric");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Frostwolf_Grunt : Card
    {
        public Frostwolf_Grunt() : base(2, 2) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Frostwolf_Grunt");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Stormpike_Commando : Card
    {
        public Stormpike_Commando() : base(4, 2) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Stormpike_Commando");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Thrallmar_Farseer : Card
    {
        public Thrallmar_Farseer() : base(2, 3) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Thrallmar_Farseer");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }

    public class Arcane_Golem : Card
    {
        public Arcane_Golem() : base(4, 2) { }
        public override void PrintInfoAboutCard()
        {
            Console.WriteLine("Arcane_Golem");
            Console.WriteLine("Atk {0}, Hp {1}", Atk, Hp);
        }
    }
}
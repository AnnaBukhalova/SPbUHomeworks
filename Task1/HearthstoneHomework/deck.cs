using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_HearthStone
{
    public class RandomDeck
    {
        public void Put_cards_in_deck(Card[] deck) // класс, который мешает карты в колоде в рандомном порядке.
        {
            deck[0] = new Murloc_Raider();
            deck[1] = new Stonetush_Boar();
            deck[2] = new Bloodfen_Raptor();
            deck[3] = new Stormwind_Knight();
            deck[4] = new Novice_Engineer();
            deck[5] = new Wild_Pyromancer();
            deck[6] = new Sunfury_Protector();
            deck[7] = new River_Crockolisk();
            deck[8] = new Dalaran_Mage();
            deck[9] = new Jungle_Panther();
            deck[10] = new Wolfrider();
            deck[11] = new Booty_Bay_Bodyguard();
            deck[12] = new Nightblade();
            deck[13] = new Cairne_Bloodhoof();
            deck[14] = new Frostwolf_Warlord();
            deck[15] = new Shattered_Sun_Cleric();
            deck[16] = new Frostwolf_Grunt();
            deck[17] = new Stormpike_Commando();
            deck[18] = new Thrallmar_Farseer();
            deck[19] = new Arcane_Golem();
            Random rand = new Random();

            for (int i = deck.Length - 1; i >= 1; i--)
            {
                var j = rand.Next(i + 1);
                (deck[j], deck[i]) = (deck[i], deck[j]);

            }
        }
    }
}
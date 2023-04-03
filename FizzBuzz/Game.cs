using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Game
    {
        public int Players { get; set; } = 2;

        public List<Card> Cards { get; private set; } = new List<Card>()
        {
            new Card("Diamonds",6,"Six"),
            new Card("Hearts",6,"Six"),
            new Card("Spades",6,"Six"),
            new Card("Clubs",6,"Six"),

            new Card("Diamonds",7,"Seven"),
            new Card("Hearts",7,"Seven"),
            new Card("Spades",7,"Seven"),
            new Card("Clubs",7,"Seven"),

            new Card("Diamonds",8,"Eight"),
            new Card("Hearts",8,"Eight"),
            new Card("Spades",8,"Eight"),
            new Card("Clubs",8,"Eight"),

            new Card("Diamonds",9,"Nine"),
            new Card("Hearts",9,"Nine"),
            new Card("Spades",9,"Nine"),
            new Card("Clubs",9,"Nine"),

            new Card("Diamonds",10,"Ten"),
            new Card("Hearts",10,"Ten"),
            new Card("Spades",10,"Ten"),
            new Card("Clubs",10,"Ten"),

            new Card("Diamonds",11,"Jack"),
            new Card("Hearts",11,"Jack"),
            new Card("Spades",11,"Jack"),
            new Card("Clubs",11,"Jack"),

            new Card("Diamonds",12,"Queen"),
            new Card("Hearts",12,"Queen"),
            new Card("Spades",12,"Queen"),
            new Card("Clubs",12,"Queen"),

            new Card("Diamonds",13,"King"),
            new Card("Hearts",13,"King"),
            new Card("Spades",13,"King"),
            new Card("Clubs",13,"King"),

            new Card("Diamonds",14,"Ace"),
            new Card("Hearts",14,"Ace"),
            new Card("Spades",14,"Ace"),
            new Card("Clubs",14,"Ace"),
        };

        public void Distribute(Player player1, Player player2)
        {
            for (int i = 0; i <36 / Players ; i++)
            {
                player1.Cards[i] = Cards[i];
                player2.Cards[i] = Cards[i + 1];
            }
            Console.WriteLine(player1);
            Console.WriteLine(player2);
        }
        public List<Card>Shuffle()
        {
            List<Card> cards = new List<Card>();
            while(Cards.Count > 0)
            {
                int index = new Random().Next(Cards.Count);
                cards.Add(Cards[index]);
                Cards.RemoveAt(index);              
            }
            Cards = cards;
            return Cards;
            
        }
        public Player Gaming(Player p1,Player p2)
        {
            while(p1.Cards.Count!=0 || p2.Cards.Count != 0)
            {
                int index1 = new Random().Next(p1.Cards.Count - 1);
                int index2 = new Random().Next(p2.Cards.Count - 1);

                if (p1.Cards[index1].Value == 14 && p2.Cards[index2].Value == 6)
                {
                    p2.Cards.Add(p1.Cards[index1]);
                    p1.Cards.RemoveAt(index1);
                }
                else if (p2.Cards[index2].Value == 14 && p1.Cards[index1].Value == 6)
                {
                    p1.Cards.Add(p2.Cards[index2]);
                    p2.Cards.RemoveAt(index1);
                }
                else if(p1.Cards[index1].Value > p2.Cards[index2].Value)
                {
                    p2.Cards.Add(p1.Cards[index1]);
                    p1.Cards.RemoveAt(index1);
                }
                else
                {
                    p1.Cards.Add(p2.Cards[index2]);
                    p2.Cards.RemoveAt(index1);
                }
                
            }
            if (p1.Cards.Count == 0)
            {
                p2.IsWinner = true;
                return p2;
            }
                
            else
            {
                p1.IsWinner = true;
                return p1;
            }
        } 
        public Game(int players)
        {
            Players = players;
        }
    }
}

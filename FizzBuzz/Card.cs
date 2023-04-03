using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Card
    {
        public string Suit { get; private set; }
        public string Title { get; private set; }
        public int Value { get; private set; }
        public override string ToString()
        {
            return $"{Suit} : {Title} : {Value}";
        }
        public Card(string suit, int value, string title)
        {
            Suit = suit;
            Value = value;
            Title = title;
        }
    }
}

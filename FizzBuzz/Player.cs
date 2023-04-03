using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Player
    {
        public List<Card> Cards { get; set; } = new List<Card>();
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsWinner { get; set; } = false
        public override string ToString()
        {
            return $"{Cards} : {Name} : {Description}";
        }
        public Player( string name, string description)
        {           
            Name = name;
            Description = description;
        }
    }
}

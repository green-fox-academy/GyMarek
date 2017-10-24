using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_TwentyPlusOne
{
    public class Deck
    {
        public Deck()
        {
            cardsDeck = from ranksCard in Enum.GetValues(typeof(Rank)).OfType<Rank>().ToList()
                        from suitsCard in Enum.GetValues(typeof(Suit)).OfType<Suit>().ToList()
                        select new Card(ranksCard, suitsCard);
        }

        private IEnumerable<Card> cardsDeck; 
    }    
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckofCards.Model;

namespace DeckofCards
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck cardDeck = new Deck();

            //Shuffling the Deck
            cardDeck.Shuffle();

            //Sorting the Deck
            CardSorter sorter = new CardSorter(CardSortType.SuitThenKind);
            cardDeck.Sort(sorter);

            //Deal the top card of Deck
            cardDeck.DrawTopCard();

            //Shuffle the Deck
            cardDeck.Shuffle();
            CardSorter cardsorter = new CardSorter(CardSortType.SuitThenKind);
            cardDeck.Sort(cardsorter);

            // Keep console open until a key is pressed
            Console.ReadKey();
        }
    }


}

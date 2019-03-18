using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentThree
{
    public class Deck
    {
        private List<Card> cards;

        /**
         * Instantiate and populate List 'cards' such that
         * it contains a card of every possible suit and rank.
         * After being populated, the deck should contain 64 cards.
         *  
         */
        public Deck()
        {
            cards = new List<Card>();
            for (int i = 5; i <= 20; i++)
            {
                Card card1 = new Card("lung", i);
                Card card2 = new Card("stone", i);
                Card card3 = new Card("tree", i);
                Card card4 = new Card("fork", i);
                List<Card> a = new List<Card> { card1, card2, card3, card4 };
                cards.AddRange(a);
                //to be completed
            }
         }

        /**
         * do not modify or delete
         * @return number of cards in the list
         */
        public int Size
        {
            get 
            {

                if (cards == null)
                {
                    return -1;
                }
           
                return cards.Count;                 
            }            
        }        

        /**
         * @return a random card from the deck.
         * IMPORTANT: This is like dealing a card from the deck,
         * so it is important that the card you return gets
         * removed from the deck.
         */
        public Card GetRandomCard()
        {
            // to be completed
            Random rand = new Random();
            Card card_remove = new Card();
            do
            {
                int num = rand.Next(cards.Count - 1);
                  while (num >= cards.Count) ;
                 card_remove = cards[num];
            }
            while (card_remove == null);
            cards.Remove(card_remove);
            return card_remove;
        }

        /**
         * Shuffle the deck.
         * 
         * Hint: one way to do this is:
         * - Pick two random cards in the deck.
         * - Swap their locations in the deck.
         * - Repeat this N times (where N is the number of cards in the deck.)
         * - Now all the cards should be randomly placed.
         */
        public void Shuffle()
        {
            Random rand1 = new Random();
        //    Random rand2 = new Random();
            int a = 0, b = 0;
            Card[] card = new Card[cards.Count];
            cards.CopyTo(card);
            for(int i=0;i<cards.Count;i++)
            {
                while (a == i) 
                a = rand1.Next(64);    
                cards[i] = card[a];
       
            }
            // to be completed
        }

        /**
         * @return an List containing 'n' random cards.
         * 
         * The cards added to the List returned must be removed from the deck.
         * 
         * If there aren't enough cards in the deck to deal 'n' cards, return null.
         * 
         */
        public List<Card> Deal(int n)
        {
            //to be completed
            Random rand = new Random();
            List<Card> card = new List<Card>();
            if (cards.Count >= n)
            {
                for (int i = 0; i < n; i++)
                {
                    Card card_remove = cards[rand.Next(cards.Count)];
                    card.Add(card_remove);
                    cards.Remove(card_remove);
                }
                return card;
            }
            return null;
        }

        /**
         * do not modify or delete
         * @return the first card from the list
         */
        public Card RemoveFirstCard()
        {
            if (cards.Count== 0)
            {
                return null;
            }
            Card card=cards[0];
            cards.RemoveAt(0);
            return card;
        }
                
        /**
         * do not modify or delete
         * add the parameter to the end of cards
         */
        public void Add(Card c)
        {
            cards.Add(c);
        }

        /**
         * do not modify or delete
         * check if the deck contains a particular card
         * @return true or false
         */
        public bool HasCard(String suit, int rank)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].Suit.Equals(suit) && cards[i].Rank.Equals(rank))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

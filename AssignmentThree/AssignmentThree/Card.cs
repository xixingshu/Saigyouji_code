using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentThree
{
    public class Card
    {
        public readonly String[] validSuits ={"lung", "stone", "tree", "fork"};

        private String _suit;
        private int _rank;

        public String Suit
        {
            get 
            {
                for (int i = 0; i < validSuits.Length; i++)
                {
                    if (_suit == null)
                    {
                        return "fork";
                    }
                    else if (_suit.ToUpper()== validSuits[i].ToUpper())
                    {

                        return validSuits[i];
                    }

                }
                return "fork";
            }
            /**
	         * Set the instance variable suit to the given parameter.
	         * If the parameter is not one of the valid suits (from validSuits above),
	         * set the instance variable to "fork".
	         * 
	         * Note: the parameter may be in a different case; so "stone", "Stone", "STONE",
	         * should all result in an instance variable value of "stone".
	         */
            set 
            {
                //to be completed
                _suit = value; 
            }
        }
       
        public int Rank
        {
            get 
            {
                if (_rank <= 5)
                    return 5;
                else if (_rank >= 20)
                    return 20;
                else
                    return _rank;
            }
            /**
            * Set the instance variable rank to the given parameter.
            * If the given parameter is less than 5, instance variable should become 5.
            * If the given parameter is more than 20, the instance variable should become 20.
            */
            set 
            {
                //to be completed
                _rank = value; 
            }
        }	    	
	    	  	   
	    /**
	     * Parameterised constructor.
	     * Assigns values to instance variable using the above setters.
	     */
	    public Card(String suit, int rank) {
            //to be completed            
            Suit =suit;
            Rank = rank;
        }
	
	    /**
	     * Default constructor.
	     * Make this card the 5 of forks.
	     */
	    public Card() {
            //to be completed

	    }

	    /**
	     * 
	     * @return 4 if lung, 3 if stone, 2 if tree, 1 if fork
	     * This method will be useful for using in compareTo 
	     */
	    public int GetSuitWeight() {
            int i = 0;
                for (;i<validSuits.Length;i++)
            {
                if(Suit==validSuits[i])
                {
                    i=4-i;
                    break;
                }
            }
                return i;
	    }
                
	    /**
	     * 
	     * @return 1 if the calling object beats parameter object.
	     * -1 if the calling object is beaten by the parameter object.
	     * 0 if the calling object is the same as parameter object.
	     * 
	     * Basis of comparison:
	     * - The card with the higher rank wins.
	     * - If the ranks are the same, lung beats stone, stone beats tree, tree beats fork.
	     * - If the suits AND ranks are the same, return 0
	     * 
	     */
	    public int CompareTo(Card other) {
            //to be completed

            if (this.Suit.CompareTo(other.Suit)==0)
            {
                  return   this.Rank.CompareTo(other.Rank);
            }
            else 
            {
                return -this.Suit.CompareTo(other.Suit);
            }
	    }
	
	    /**
	     * @return a String describing the card.
	     * For example, if rank=8 and suit="tree", return "8 of trees".
	     * 
	     * Further, the ranks 19 and 20 are called "henchman" and "boss" respectively,
	     * so if rank=19 and suit="lung", return "henchman of lungs".
	     * 
	     */
	    public String ToString() {
            //to be completed
            string str;
            if (Rank < 19)
                str = Rank.ToString() + " of " + Suit + "s";
            else if (Rank == 19)
                str = "henchman of " + Suit + "s";
            else
                str = "boss of " + Suit + "s";
            return str;
	    }
    }
}

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentThree;

namespace AssignmentThreeTest
{
    /// <summary>
    /// DeckTest 的摘要说明
    /// </summary>
    [TestClass]
    public class DeckTest
    {
        public DeckTest()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性:
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestDeck()
        {
           Deck deck = new Deck();
		
		    // check there are 64 cards
            Assert.AreEqual(64,deck.Size);
		
		    // check that every card is present in the deck
            string[] str={"tree", "stone", "lung", "fork"};
            foreach(string s in str)
            {		    
			    for (int r=20; r>=5; r--) 
                {
                    Assert.IsTrue(deck.HasCard(s,r));				   
			    }
		    }
        }

        [TestMethod]
        public void TestGetRandomCard()
        {
            // test the getRandomCard method
		    // note: you need your default constructor working
		    // before this test can pass
            Deck deck = new Deck();
            int cardsInDeck=deck.Size;

            // manually get 16 random cards
            List<Card> hand=new List<Card>();
            for(int i=0;i<16;i++)
            {
                hand.Add(deck.GetRandomCard());
            }

            // check that 16 cards are now missing
            Assert.AreEqual(cardsInDeck-16,deck.Size);

		    // check there are 64 cards
            //Assert.AreEqual(64, deck.Size);
       
            // check there are no repeats
            bool duplicates=false;
            for(int i=0;i<hand.Count;i++)
            {
                for(int k=i+1;k<hand.Count;k++)
                {
                    if(hand[i].Suit.Equals(hand[k].Suit))
                    {
                        if(hand[i].Rank==hand[k].Rank)
                            {
                                duplicates =true;
                        }
                    }
                }
            }
		    Assert.IsFalse(duplicates);

        }

        [TestMethod]
        public void TestSuffle()
        {           
            Deck deck_1 = new Deck();
            Deck deck_2=new Deck();

            // check shuffling doesn't change deck size
		    int sizebefore =deck_1.Size;
            deck_1.Shuffle();
		     Assert.AreEqual(sizebefore,deck_1.Size);

            // deal the whole decks into hands.
            List<Card> hand_1=new List<Card>();
            List<Card> hand_2=new List<Card>();
            for(int i=0;i<deck_1.Size;i++)
            {
                hand_1.Add(deck_1.RemoveFirstCard());
                hand_2.Add(deck_2.RemoveFirstCard());
            }
   
            // check the two hands don't have much in common
            int countsame = 0;
            for(int i=0;i<hand_1.Count;i++)
            {
                if(hand_1[i].Suit.Equals(hand_2[i].Suit))
                {
                    if(hand_1[i].Rank==hand_2[i].Rank)
                    {
                        countsame++;
                    }
                }
            }
            Assert.IsTrue(countsame<10);
    
        }

        [TestMethod]
        public void TestDeal()
        {           
            Deck deck = new Deck();
            int decksize=deck.Size;

            // deal two hands, check the cards have left the deck
            List<Card> hand_1=deck.Deal(16);
            Assert.AreEqual(decksize-16,deck.Size);

             List<Card> hand_2=deck.Deal(16);
            Assert.AreEqual(decksize-32,deck.Size);

            // check they are the right sizes
            Assert.AreEqual(16,hand_1.Count);
            Assert.AreEqual(16,hand_2.Count);

            // check the hands have no cards in common
            int countsame = 0;
            for (int i = 0; i < 16; i++)
            {
                for (int k = 0; k < 16; k++)
                {
                    if (hand_1[i].Suit.Equals(hand_2[k].Suit))
                    {
                        if (hand_1[i].Rank == hand_2[k].Rank)
                        {
                            countsame++;
                        }
                    }
                }
            }
            Assert.AreEqual(0,countsame);
        }
    }
}

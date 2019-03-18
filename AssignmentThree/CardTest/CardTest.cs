using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentThree;

namespace AssignmentThreeTest
{
    /// <summary>
    /// CardTest 的摘要说明
    /// </summary>
    [TestClass]
    public class CardTest
    {
        public CardTest()
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
        public void TestSetSuit_1()
        {
            // testing setSuit with lowercase inputs

            Card card = new Card();
            card.Suit = "bingo";
            Assert.AreEqual("fork", card.Suit);
                        
            card.Suit="fork";
            Assert.AreEqual("fork", card.Suit);
            
            card.Suit="tree";
            Assert.AreEqual("tree", card.Suit);
           
            card.Suit="stone";
            Assert.AreEqual("stone", card.Suit);
            
            card.Suit="lung";
            Assert.AreEqual("lung", card.Suit);
        }

        [TestMethod]
        public void TestSetSuit_2()
        {
            // testing setSuit with weird input cases

            Card card = new Card();
            card.Suit = "";
            Assert.AreEqual("fork", card.Suit);

            card.Suit = "fORk";
            Assert.AreEqual("fork", card.Suit);

            card.Suit = "trEE";
            Assert.AreEqual("tree", card.Suit);

            card.Suit = "STONE";
            Assert.AreEqual("stone", card.Suit);

            card.Suit = "Lung";
            Assert.AreEqual("lung", card.Suit);
        }

        [TestMethod]
        public void TestSetRank()
        {
            //  testing setRank, including the input validation

            Card card = new Card();
            card.Rank = 10;
            Assert.AreEqual(10, card.Rank);

            card.Rank = -5;
            Assert.AreEqual(5, card.Rank);

            card.Rank = 3;
            Assert.AreEqual(5, card.Rank);

            card.Rank = 0;
            Assert.AreEqual(5, card.Rank);

            card.Rank = 20;
            Assert.AreEqual(20, card.Rank);

            card.Rank = 21;
            Assert.AreEqual(20, card.Rank);

            card.Rank = 31;
            Assert.AreEqual(20, card.Rank);
        }

        [TestMethod]
        public void TestDefaultConstrctor()
        {
            //  testing  the default constructor

            Card card = new Card();           
            Assert.AreEqual("fork", card.Suit);
            Assert.AreEqual(5, card.Rank);           
        }

        [TestMethod]
        public void TestParameterisedConstrctor()
        {
            //  testing the parameterised constructor, including input validation

            Card card0 = new Card("tree",10);
            Assert.AreEqual(card0.Suit, "tree");
            Assert.AreEqual(card0.Rank,10);

            card0 = new Card("fork", 30);
            Assert.AreEqual(card0.Suit, "fork");
            Assert.AreEqual(card0.Rank, 20);

            card0 = new Card("Stone", 18);
            Assert.AreEqual(card0.Suit, "stone");
            Assert.AreEqual(card0.Rank, 18);

            // check that parameterised constructor does
            // the same as using setters, with lots of input data
            string[] str={"fork","tree","stone","lung","mongoose"};
            Card card1, card2;
            foreach( string s in str)
            {
                for(int i=0;i<35;i++)
                {
                    card1=new Card();
                    card1.Suit=s;
                    card1.Rank=i;
                    card2=new Card(s,i);

                    Assert.AreEqual(card1.Suit,card2.Suit);
                    Assert.AreEqual(card1.Rank,card2.Rank);                        
                }
            }
        }

        [TestMethod]
        public void TestCompareTo_1()
        {
            // testing compareTo with the same suit
            // note, you need your parameterised constructor
            // working for this test to pass.

            Card card1 = new Card("fork",5);
            Card card2 = new Card("fork", 9);
            Card card3 = new Card("fork", 12);
            Card card4 = new Card("fork", 15);
            Card card5 = new Card("fork", 15);

            Assert.AreEqual(0, card1.CompareTo(card1));
            Assert.AreEqual(-1, card1.CompareTo(card2));
            Assert.AreEqual(-1, card1.CompareTo(card3));
            Assert.AreEqual(-1, card1.CompareTo(card4));
            Assert.AreEqual(-1, card1.CompareTo(card5));

            Assert.AreEqual(1, card2.CompareTo(card1));
            Assert.AreEqual(0, card2.CompareTo(card2));
            Assert.AreEqual(-1, card2.CompareTo(card3));
            Assert.AreEqual(-1, card2.CompareTo(card4));
            Assert.AreEqual(-1, card2.CompareTo(card5));

            Assert.AreEqual(1, card3.CompareTo(card1));
            Assert.AreEqual(1, card3.CompareTo(card2));
            Assert.AreEqual(0, card3.CompareTo(card3));
            Assert.AreEqual(-1, card3.CompareTo(card4));
            Assert.AreEqual(-1, card3.CompareTo(card5));

            Assert.AreEqual(1, card4.CompareTo(card1));
            Assert.AreEqual(1, card4.CompareTo(card2));
            Assert.AreEqual(1, card4.CompareTo(card3));
            Assert.AreEqual(0, card4.CompareTo(card4));
            Assert.AreEqual(0, card4.CompareTo(card5));
        }

        [TestMethod]
        public void TestCompareTo_2()
        {
            // testing compareTo with the different suits
            // note, you need your parameterised constructor
            // working for this test to pass.

            Card card1 = new Card("lung", 8);
            Card card2 = new Card("lung", 12);
            Card card3 = new Card("stone", 8);
            Card card4 = new Card("fork", 14);
            Card card5 = new Card("fork", 14);

            Assert.AreEqual(0, card1.CompareTo(card1));
            Assert.AreEqual(-1, card1.CompareTo(card2));
            Assert.AreEqual(1, card1.CompareTo(card3));
            Assert.AreEqual(-1, card1.CompareTo(card4));
            Assert.AreEqual(-1, card1.CompareTo(card5));

            Assert.AreEqual(1, card2.CompareTo(card1));
            Assert.AreEqual(0, card2.CompareTo(card2));
            Assert.AreEqual(1, card2.CompareTo(card3));
            Assert.AreEqual(-1, card2.CompareTo(card4));
            Assert.AreEqual(-1, card2.CompareTo(card5));

            Assert.AreEqual(-1, card3.CompareTo(card1));
            Assert.AreEqual(-1, card3.CompareTo(card2));
            Assert.AreEqual(0, card3.CompareTo(card3));
            Assert.AreEqual(-1, card3.CompareTo(card4));
            Assert.AreEqual(-1, card3.CompareTo(card5));

            Assert.AreEqual(1, card4.CompareTo(card1));
            Assert.AreEqual(1, card4.CompareTo(card2));
            Assert.AreEqual(1, card4.CompareTo(card3));
            Assert.AreEqual(0, card4.CompareTo(card4));
            Assert.AreEqual(0, card4.CompareTo(card5));
        }

        [TestMethod]
        public void TestGetSuitWeight()
        {
            Card card1 = new Card("lung", 5);
            Card card2 = new Card("stone", 15);
            Card card3 = new Card("tree",19);
            Card card4 = new Card("fork", 10);            

            Assert.AreEqual(4, card1.GetSuitWeight());
            Assert.AreEqual(3, card2.GetSuitWeight());
            Assert.AreEqual(2, card3.GetSuitWeight());
            Assert.AreEqual(1, card4.GetSuitWeight());            
        }

        [TestMethod]
        public void TestToString_1()
        {
            Card card1 = new Card("lung", 5);
            Card card2 = new Card("stone", 15);
            Card card3 = new Card("tree", 7);
            Card card4 = new Card("fork", 14);

            Assert.AreEqual("5 of lungs", card1.ToString());
            Assert.AreEqual("15 of stones", card2.ToString());
            Assert.AreEqual("7 of trees", card3.ToString());
            Assert.AreEqual("14 of forks", card4.ToString());
        }

        [TestMethod]
        public void TestToString_2()
        {
            Card card1 = new Card("lung", 17);
            Card card2 = new Card("stone", 18);
            Card card3 = new Card("tree", 19);
            Card card4 = new Card("fork", 20);

            Assert.AreEqual("17 of lungs", card1.ToString());
            Assert.AreEqual("18 of stones", card2.ToString());
            Assert.AreEqual("henchman of trees", card3.ToString());
            Assert.AreEqual("boss of forks", card4.ToString());
        }
    }
}

using AssignmentTwo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestAssigntmentTwo
{
    
    
    /// <summary>
    ///这是 TestAssignmentTwo 的测试类，旨在
    ///包含所有 TestAssignmentTwo 单元测试
    ///</summary>
    [TestClass()]
    public class TestAssignmentTwo
    {
        private static int score = 0;

        int[] arr1 = { 1, 2, 3, 3, 4, 5 };
        int[] arr2 = { 1, 2, 3, 4, 1, -4, 9 };
        int[] arr3 = { 9, 9, 9, 9, 9, 9, 99 };
        int[] arr4 = { 14 };
        int[] arr5 = { 100, 1000, 100 };         

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
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
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            Console.WriteLine("Your score is :{0}",score);
        }
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
           
        //}        
        #endregion


        /// <summary>
        ///max 的测试
        ///</summary>
        [TestMethod()]
        public void maxUnitTest()
        {            
            Assert.AreEqual(5, DataProcess.max(arr1));
            Assert.AreEqual(9, DataProcess.max(arr2));
            Assert.AreEqual(99, DataProcess.max(arr3));
            Assert.AreEqual(14, DataProcess.max(arr4));
            Assert.AreEqual(1000, DataProcess.max(arr5));
            Assert.AreEqual(100, DataProcess.mostCommonItem(arr5));
            score += 5;            
        }

        /// <summary>
        ///min 的测试
        ///</summary>
        [TestMethod()]
        public void minUnitTest()
        {            
            Assert.AreEqual(1, DataProcess.min(arr1));
            Assert.AreEqual(-4, DataProcess.min(arr2));
            Assert.AreEqual(9, DataProcess.min(arr3));
            Assert.AreEqual(14, DataProcess.min(arr4));
            Assert.AreEqual(100, DataProcess.min(arr5));
            score += 5;
            //Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///mostCommonItem 的测试
        ///</summary>
        [TestMethod()]
        public void mostCommonItemUnitTest()
        {           
            Assert.AreEqual(3, DataProcess.mostCommonItem(arr1));
            Assert.AreEqual(1, DataProcess.mostCommonItem(arr2));
            Assert.AreEqual(9, DataProcess.mostCommonItem(arr3));
            //Assert.AreEqual(14, DataProcess.mostCommonItem(arr4));
            score += 20;
            //Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///numberOfDivisors 的测试
        ///</summary>
        [TestMethod()]
        public void numberOfDivisorsUnitTest()
        {            
            Assert.AreEqual(1, DataProcess.numberOfDivisors(1));
            Assert.AreEqual(2, DataProcess.numberOfDivisors(2));
            Assert.AreEqual(2, DataProcess.numberOfDivisors(3));
            Assert.AreEqual(4, DataProcess.numberOfDivisors(6));
            Assert.AreEqual(3, DataProcess.numberOfDivisors(9));
            Assert.AreEqual(6, DataProcess.numberOfDivisors(12));
            Assert.AreEqual(16, DataProcess.numberOfDivisors(6556335));
            score += 15;
            //Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///isTriangular 的测试
        ///</summary>
        [TestMethod()]
        public void isTriangularUnitTest()
        {                                                                
            Assert.AreEqual(true, DataProcess.isTriangular(10));
            Assert.AreEqual(false, DataProcess.isTriangular(9));
            Assert.AreEqual(true, DataProcess.isTriangular(15));
            Assert.AreEqual(false, DataProcess.isTriangular(60));
            Assert.AreEqual(true, DataProcess.isTriangular(66));
            Assert.AreEqual(false, DataProcess.isTriangular(900));
            Assert.AreEqual(true, DataProcess.isTriangular(105));
            Assert.AreEqual(false, DataProcess.isTriangular(104));
            Assert.AreEqual(false, DataProcess.isTriangular(106));
            Assert.AreEqual(true, DataProcess.isTriangular(9591));
            Assert.AreEqual(false, DataProcess.isTriangular(959199));
            Assert.AreEqual(true, DataProcess.isTriangular(794430));
            Assert.AreEqual(true, DataProcess.isTriangular(658378));
            Assert.AreEqual(false, DataProcess.isTriangular(959399));
            Assert.AreEqual(false, DataProcess.isTriangular(784430));
            Assert.AreEqual(false, DataProcess.isTriangular(658388));
            score += 15;
            //Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///formatArray 的测试
        ///</summary>
        [TestMethod()]
        public void formatArrayUnitTest()
        {            
            Assert.AreEqual("[1, 2, 3, 3, 4, 5]", DataProcess.formatArray(arr1));
            Assert.AreEqual("[1, 2, 3, 4, 1, -4, 9]", DataProcess.formatArray(arr2));
            Assert.AreEqual("[9, 9, 9, 9, 9, 9, 99]", DataProcess.formatArray(arr3));
            Assert.AreEqual("[14]", DataProcess.formatArray(arr4));
            Assert.AreEqual("[100, 1000, 100]", DataProcess.formatArray(arr5));
            Assert.AreEqual("[]", DataProcess.formatArray(new int[0]));
            score += 15;
            //Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///concatArray 的测试
        ///</summary>
        [TestMethod()]
        public void concatArrayUnitTest()
        {
            int[] arr0 = { };
            int[] arr12 = { 1, 2, 3, 3, 4, 5, 1, 2, 3, 4, 1, -4, 9 };
            int[] arr45 = { 14, 100, 1000, 100 };
            int[] arr345 = { 9, 9, 9, 9, 9, 9, 99, 14, 100, 1000, 100 };
            int[] actual = DataProcess.concatArray(arr1, arr2);
            string str_1=null, str_2=null;
            str_1 = arr12.ToString();
            str_2=DataProcess.concatArray(arr1, arr2).ToString();
            Assert.AreEqual(str_1, str_2);

            str_1 = arr45.ToString();
            str_2 = DataProcess.concatArray(arr4, arr5).ToString();
            Assert.AreEqual(str_1, str_2);

            str_1 = arr345.ToString();
            str_2 = DataProcess.concatArray(arr3, arr45).ToString();
            Assert.AreEqual(str_1, str_2);

            str_1 = arr0.ToString();
            str_2 = DataProcess.concatArray(arr0, arr0).ToString();
            Assert.AreEqual(str_1, str_2);

            str_1 = arr2.ToString();
            str_2 = DataProcess.concatArray(arr2, arr0).ToString();
            Assert.AreEqual(str_1, str_2);

            str_1 = arr2.ToString();
            str_2 = DataProcess.concatArray(arr0, arr2).ToString();
            Assert.AreEqual(str_1, str_2);           
            score += 15;            
            //Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///bigDiff 的测试
        ///</summary>
        [TestMethod()]
        public void bigDiffUnitTest()
        {           
            Assert.AreEqual(4, DataProcess.bigDiff(arr1));
            Assert.AreEqual(13, DataProcess.bigDiff(arr2));
            Assert.AreEqual(90, DataProcess.bigDiff(arr3));
            Assert.AreEqual(0, DataProcess.bigDiff(arr4));
            Assert.AreEqual(900, DataProcess.bigDiff(arr5));
            score += 10;
            //Assert.Inconclusive("验证此测试方法的正确性。");
        }
    }
}

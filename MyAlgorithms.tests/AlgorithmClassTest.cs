using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.tests
{
    [TestClass] 
    public class AlgorithmClassTest
    {
/*
        [TestMethod]
        public void MyTestMethod()
        {
            Assert.AreEqual(10, 10);
            Assert.AreEqual(10, 100);

        }
*/
        [TestMethod]
        public void TestSelectionSortAscendingOrder()
        {
            //Step 1) Arrange
            int[] arr = { 100, 50, 10 };

            //Step 2) Act
            int[] results = MyAlgorithms.SelectionSort(arr);

            //Step 3) Assert
            Assert.AreEqual(10, results[0]);// True
            Assert.AreEqual(100, results[arr.Length - 1]);// True


        }
    }
}

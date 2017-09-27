using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Ex02_Sum;

namespace SumListTest
{
    [TestFixture]
    public class SumListTest
    {
        SumList sumList = new SumList();

        [Test]
        public void TestSumListWithEmpty()
        {
            //arrange
            List<int> test= new List<int>(new int[] {});

            //act
            int output = 0;

            //assert
            Assert.AreEqual(output, sumList.SumFromList(test));
        }

        [Test]
        public void TestSumListWithOneElement()
        {
            //arrange
            List<int> test = new List<int>(new int[] {5});

            //act
            int output = 5;

            //assert
            Assert.AreEqual(output, sumList.SumFromList(test));
        }

        [Test]
        public void TestSumListWithMultiplieElements()
        {
            //arrange
            List<int> test = new List<int>(new int[] { -2, 2, 3 });

            //act
            int output = 3;

            //assert
            Assert.AreEqual(output, sumList.SumFromList(test));
        }

        [Test]
        public void TestSumListWithNull()
        {
            //arrange
            List<int> test = null;

            //act
            int output = 0;

            //assert
            Assert.AreEqual(output, sumList.SumFromList(test));
        }
    }
}

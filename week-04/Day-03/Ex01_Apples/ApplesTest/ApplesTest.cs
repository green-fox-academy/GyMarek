using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Ex01_Apples;

namespace ApplesTest
{
    [TestFixture]
    public class ApplesTest
    {
        Apples apples = new Apples();

        [Test]
        public void TestApple()
        {
            //arrange
            string myObject = "apple";

            //act
            string output = "apple";

            //assert
            Assert.AreEqual(output, apples.GetApple());
        }
    }
}

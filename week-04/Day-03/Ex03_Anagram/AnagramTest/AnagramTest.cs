using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Ex03_Anagram;

namespace AnagramTest
{
    [TestFixture]
    public class AnagramTest
    {
        //Anagram anagram = new Anagram();

        [Test]
        public void TestIsAnagramWithAnagram()
        {
            //arrange
            string one = "hello";
            string two = "olleh";

            //act
            bool output = true;

            //assert
            Assert.AreEqual(output, Anagram.IsAnagram(one,two));
        }
        
        [Test]
        public void TestIsAnagramWithUpperAndLowerCase()
        {
            //arrange
            string one = "Hello";
            string two = "oLleh";

            //act
            bool output = false;

            //assert
            Assert.AreEqual(output, Anagram.IsAnagram(one, two));
        }

        [Test]
        public void TestIsAnagramWithSpace()
        {
            //arrange
            string one = "hello";
            string two = "oll eh";

            //act
            bool output = false;

            //assert
            Assert.AreEqual(output, Anagram.IsAnagram(one, two));
        }

        [Test]
        public void TestIsAnagramWithSpecialCaracter()
        {
            //arrange
            string one = "he#llo.";
            string two = "o#ll.eh";

            //act
            bool output = true;

            //assert
            Assert.AreEqual(output, Anagram.IsAnagram(one, two));
        }

        [Test]
        public void TestIsAnagramWithOneString()
        {
            //arrange
            string one = "hello";
            string two = "";

            //act
            bool output = false;

            //assert
            Assert.AreEqual(output, Anagram.IsAnagram(one, two));
        }

        [Test]
        public void TestIsAnagramWithTwoEmptyString()
        {
            //arrange
            string one = "";
            string two = "";

            //act
            bool output = true;

            //assert
            Assert.AreEqual(output, Anagram.IsAnagram(one, two));
        }

        [Test]
        public void TestIsAnagramWithTwoNUllString()
        {
            //arrange
            string one = null;
            string two = null;

            //act
            bool output = false;

            //assert
            Assert.AreEqual(output, Anagram.IsAnagram(one, two));
        }

        [Test]
        public void TestIsAnagramWithOneNUllString()
        {
            //arrange
            string one = "hello";
            string two = null;

            //act
            bool output = false;

            //assert
            Assert.AreEqual(output, Anagram.IsAnagram(one, two));
        }
    }
}

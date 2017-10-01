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
        [Test]
        public void TestIsAnagramWithAnagram()
        {
            string one = "hello";
            string two = "olleh";
            
            bool output = true;
            
            Assert.AreEqual(output, Anagram.IsAnagram(one,two));
        }
        
        [Test]
        public void TestIsAnagramWithUpperAndLowerCase()
        {           
            string one = "Hello";
            string two = "oLleh";

            bool output = true;

            Assert.AreEqual(output, Anagram.IsAnagram(one, two));
        }

        [Test]
        public void TestIsAnagramWithSpace()
        {
            string one = "hello";
            string two = "oll eh";

            bool output = true;
                       
            Assert.AreEqual(output, Anagram.IsAnagram(one, two));
        }

        [Test]
        public void TestIsAnagramWithOneString()
        {
            string one = "hello";
            string two = "";

            bool output = false;

            Assert.AreEqual(output, Anagram.IsAnagram(one, two));
        }       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Ex04_CountLetters;

namespace TestCountLetters
{
    [TestFixture]
    public class TestCount
    {
        CountLetters countLetter = new CountLetters();

        [Test]
        public void TestLetterCounterWithString()
        {
            string input = "helloworld";

            Dictionary<char, int> output = new Dictionary<char, int>()
            {  
                { 'h' , 1 },
                { 'e' , 1 },
                { 'l' , 3 },
                { 'o' , 2 },
                { 'w' , 1 },
                { 'r' , 1 },
                { 'd' , 1 }     
            };
            Assert.AreEqual(output, countLetter.LetterCounter(input));
        }


        [Test]
        public void TestLetterCounterWithStringWithSpace()
        {
            string input = "hello world";

            Dictionary<char, int> output = new Dictionary<char, int>()
            {
                { 'h' , 1 },
                { 'e' , 1 },
                { 'l' , 3 },
                { 'o' , 2 },
                { 'w' , 1 },
                { 'r' , 1 },
                { 'd' , 1 }
            };
            Assert.AreEqual(output, countLetter.LetterCounter(input));
        }

        [Test]
        public void TestLetterCounterWithEmptyString()
        {
            string input = "";

            Dictionary<char, int> output = new Dictionary<char, int>();
            
            Assert.AreEqual(output, countLetter.LetterCounter(input));
        }

        [Test]
        public void TestLetterCounterWithNull()
        {
            string input = null;

            Dictionary<char, int> output = new Dictionary<char, int>();

            Assert.AreEqual(output, countLetter.LetterCounter(input));
        }
    }
}

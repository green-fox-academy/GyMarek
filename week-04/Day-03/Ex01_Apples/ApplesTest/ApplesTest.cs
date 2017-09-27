using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex01_Apples;

namespace ApplesTest
{
    [TestFixture]
    class ApplesTest
    {
        Apples apple = new Apples();

        static void Main(string[] args)
        {
        }

        [TestCase]
        public void AppleString()
        {
            Assert.AreEqual("Apple", apple.GetApple());
        }
    }
}

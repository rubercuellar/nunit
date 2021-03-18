using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NunitDem
{
    [TestFixture]
    class MyTestCase
    {
        [TestCase]
        public void Add()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(31, math.Add(20, 11));
        }

        [TestCase]
        public void Sub()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(10, math.Sub(20, 10));
        }
    }
}

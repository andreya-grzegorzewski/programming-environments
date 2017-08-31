using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArithmeticClassLibrary;

// Note that a reference to SimpleArithmetic was added to the ArithmeticUnitTest
// project.  To do this 
//    1.  expand the ArithmeticUnitTestProject
//    2.  right click on References
//    3.  select Add Reference...
//    4.  check the box next to SimpleArithmetic in the resulting Reference Manager window
//    5.  click OK.
//   
// You will then need to add a using directive for the namespace that contains the 
// code for the SimpleArithmetic.  In this case it is nsArithmeticClassLibrary which
// is specified in the file SimpleArithmetic.cs.

namespace ArithmeticUnitTest
{
    [TestClass]
    public class ArithmeticUnitTest
    {
        [TestMethod]
        public void AdditionTest()
        {
            SimpleArithmetic c = new SimpleArithmetic();
            // test ArithmeticClassLibrary addition one way 
            Assert.IsTrue(5 == c.Add(3,2));
        }

        [TestMethod]
        public void SubtractionTest()
        {
            SimpleArithmetic s = new SimpleArithmetic();
            // test ArithmeticClassLibrary subtraction several ways
            Assert.IsFalse(5 == s.Subtract(2, 7));
            Assert.IsTrue(5 == s.Subtract(7, 2));
            Assert.IsTrue(-5 == s.Subtract(2, 7));
        }

        [TestMethod]
        public void ProductTest()
        {
            HarderArithmetic h = new HarderArithmetic();
            // test ArithmeticClassLibrary HarderArithmetic.Product one way
            Assert.IsTrue(10 == h.Product(5, 2));
        }

        [TestMethod]
        public void QuotientTest()
        {
            HarderArithmetic h = new HarderArithmetic();
            // test ArithmeticClassLIbrary HarderArithmetic.Quotient for
            // quotients with and without a remainder.
            Assert.IsTrue(2 == h.Quotient(5, 2));
            Assert.IsTrue(2 == h.Quotient(4, 2));
        }
    }
}

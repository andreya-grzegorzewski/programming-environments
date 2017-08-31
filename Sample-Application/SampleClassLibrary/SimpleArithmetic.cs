using System;

// This is a sample class library.  It can contain multiple classes

namespace ArithmeticClassLibrary
{
    public class SimpleArithmetic         // a simple arithmetic class to demonstrate unit testing
    {
        public SimpleArithmetic()
        {

        }

        public int Add(int a, int b)            // return the sum of the two integer arguments
        {
            return a + b;
        }

        public int Subtract(int a, int b)       // subtract b from a and return the result
        {
            return a - b;
        }
    }

    public class HarderArithmetic
    {
        public HarderArithmetic()
        {

        }

        public int Product(int a, int b)
        {
            return a * b;
        }

        public int Quotient(int a, int b)
        {
            return a / b;
        }
    }
}

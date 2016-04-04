using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzTest
{
    [TestClass]
    public sealed class FizzBuzzTest
    {
        private static Fizzbuzz fizzbuzz;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            fizzbuzz = new Fizzbuzz();
        }
        [TestMethod]
        public void printIntegerFor1()
        {
            Assert.AreEqual("1", fizzbuzz.fizzbuzzer(1)); 
        }

        [TestMethod]
        public void printIntegerFor2()
        {
            Assert.AreEqual("2", fizzbuzz.fizzbuzzer(2));
        }

        [TestMethod]
        public void printFizzFor3()
        {
            Assert.AreEqual("fizz", fizzbuzz.fizzbuzzer(3));
        }

        [TestMethod]
        public void printFizzFor9()
        {
            Assert.AreEqual("fizz", fizzbuzz.fizzbuzzer(9));
        }

        [TestMethod]
        public void printBuzzFor5()
        {
            Assert.AreEqual("buzz", fizzbuzz.fizzbuzzer(5));
        }

        [TestMethod]
        public void printBuzzFor20()
        {
            Assert.AreEqual("buzz", fizzbuzz.fizzbuzzer(20));
        }

        [TestMethod]
        public void printFizzBuzz15()
        {
            Assert.AreEqual("fizzbuzz", fizzbuzz.fizzbuzzer(15));
        }

        [TestMethod]
        public void printFizzBuzz45()
        {
            Assert.AreEqual("fizzbuzz", fizzbuzz.fizzbuzzer(45));
        }
    }
}

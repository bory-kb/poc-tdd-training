using NUnit.Framework;
using poc_tdd_training;

namespace poc_tdd_training_test
{
    public class FizzBuzzTest

    {
        private FizzBuzz _fizzBuzz;
        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]

        public void 数字1を渡して文字列1を返す()
        {
            Assert.AreEqual("1", FizzBuzz.Convert(1));
        }
        [Test]
        public void 数字2を渡して文字列2を返す()
        {
            Assert.AreEqual("2", FizzBuzz.Convert(2));
        }

        [Test]
        public void 数字3を渡して数字の代わりにFizzを返す()
        {
            Assert.AreEqual("Fizz", FizzBuzz.Convert(3));
        }

        [Test]
        public void 数字6を渡して数字の代わりにFizzを返す()
        {
            Assert.AreEqual("Fizz", FizzBuzz.Convert(6));
        }

        [Test]
        public void 数字5を渡して数字の代わりにBuzzを返す()
        {
            Assert.AreEqual("Buzz", FizzBuzz.Convert(5));
        }

        [Test]
        public void 数字15を渡して数字の代わりにFizzBuzzを返す()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.Convert(15));
        }
    }
}
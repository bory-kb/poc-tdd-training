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
            Assert.AreEqual("1", _fizzBuzz.Convert(1));
        }
        [Test]
        public void 数字2を渡して文字列2を返す()
        {
            Assert.AreEqual("2", _fizzBuzz.Convert(2));
        }

        [Test]
        public void 数字3を渡して数字の代わりにFizzを返す()
        {
            Assert.AreEqual("Fizz", _fizzBuzz.Convert(3));
        }

        [Test]
        public void 数字6を渡して数字の代わりにFizzを返す()
        {
            Assert.AreEqual("Fizz", _fizzBuzz.Convert(6));
        }

        [Test]
        public void 数字5を渡して数字の代わりにBuzzを返す()
        {
            Assert.AreEqual("Buzz", _fizzBuzz.Convert(5));
        }
    }
}
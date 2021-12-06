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
            string ret = _fizzBuzz.Convert(1);
            Assert.AreEqual("1", ret);
        }
        [Test]
        public void 数字2を渡して文字列2を返す()
        {
            string ret = _fizzBuzz.Convert(2);
            Assert.AreEqual("2", ret);
        }

        [Test]
        public void 数字3を渡して数字の代わりにFizzを返す()
        {
            string ret = _fizzBuzz.Convert(3);
            Assert.AreEqual("Fizz", ret);
        }

        [Test]
        public void 数字6を渡して数字の代わりにFizzを返す()
        {
            string ret = _fizzBuzz.Convert(6);
            Assert.AreEqual("Fizz", ret);
        }
    }
}
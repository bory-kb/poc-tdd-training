using NUnit.Framework;
using poc_tdd_training;

namespace poc_tdd_training_test
{
    public class FizzBuzzTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]

        public void 数字1を渡して文字列1を返す()
        {
            var fizzBuzz = new FizzBuzz();
            string ret = fizzBuzz.returnNum(1);
            Assert.AreEqual("1", ret);
        }
        [Test]
        public void 数字2を渡して文字列2を返す()
        {
            var fizzBuzz = new FizzBuzz();
            string ret = fizzBuzz.returnNum(2);
            Assert.AreEqual("2", ret);
        }

        [Test]
        public void _3の倍数のときは数字の代わりにFizzを返す()
        {
            var fizzBuzz = new FizzBuzz();
            string ret = fizzBuzz.returnNum(3);
            Assert.AreEqual("Fizz", ret);
        }
    }
}
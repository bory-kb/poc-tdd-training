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

        [TestFixture]
        public class 数字を文字列にして返す
        {
            FizzBuzz _fizzBuzz = new FizzBuzz();

            [Test]

            public void 数字1を渡して文字列1を返す()
            {
                Assert.AreEqual("1", _fizzBuzz.Convert(1));
            }
        }

        [TestFixture]
        public class _3の倍数のときは数字の代わりにFizzを返す
        {
            FizzBuzz _fizzBuzz = new FizzBuzz();


            [Test]
            public void 数字3を渡して数字の代わりにFizzを返す()
            {
                Assert.AreEqual("Fizz", _fizzBuzz.Convert(3));
            }

        }
        [TestFixture]
        public class _5の倍数のときは数字の代わりにBuzzを返す
        {
            FizzBuzz _fizzBuzz = new FizzBuzz();


            [Test]
            public void 数字5を渡して数字の代わりにBuzzを返す()
            {
                Assert.AreEqual("Buzz", _fizzBuzz.Convert(5));
            }
        }
        [TestFixture]
        public class _15の倍数のときは数字の代わりにFizzBuzzを返す
        {
            FizzBuzz _fizzBuzz = new FizzBuzz();

            [Test]
            public void 数字15を渡して数字の代わりにFizzBuzzを返す()
            {
                Assert.AreEqual("FizzBuzz", _fizzBuzz.Convert(15));
            }
        }
    }
}
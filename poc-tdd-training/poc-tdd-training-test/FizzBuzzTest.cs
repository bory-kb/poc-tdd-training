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
            string ret = fizzBuzz.returnNum();
            Assert.AreEqual("1", ret);
        }
    }
}
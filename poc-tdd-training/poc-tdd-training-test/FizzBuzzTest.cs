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

        public void ����1��n���ĕ�����1��Ԃ�()
        {
            var fizzBuzz = new FizzBuzz();
            string ret = fizzBuzz.returnNum(1);
            Assert.AreEqual("1", ret);
        }
        [Test]
        public void ����2��n���ĕ�����2��Ԃ�()
        {
            var fizzBuzz = new FizzBuzz();
            string ret = fizzBuzz.returnNum(2);
            Assert.AreEqual("2", ret);
        }
    }
}
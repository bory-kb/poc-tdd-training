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

        public void ����1��n���ĕ�����1��Ԃ�()
        {
            string ret = _fizzBuzz.Convert(1);
            Assert.AreEqual("1", ret);
        }
        [Test]
        public void ����2��n���ĕ�����2��Ԃ�()
        {
            string ret = _fizzBuzz.Convert(2);
            Assert.AreEqual("2", ret);
        }

        [Test]
        public void ����3��n���Đ����̑����Fizz��Ԃ�()
        {
            string ret = _fizzBuzz.Convert(3);
            Assert.AreEqual("Fizz", ret);
        }

        [Test]
        public void ����6��n���Đ����̑����Fizz��Ԃ�()
        {
            string ret = _fizzBuzz.Convert(6);
            Assert.AreEqual("Fizz", ret);
        }
    }
}
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
            Assert.AreEqual("1", _fizzBuzz.Convert(1));
        }
        [Test]
        public void ����2��n���ĕ�����2��Ԃ�()
        {
            Assert.AreEqual("2", _fizzBuzz.Convert(2));
        }

        [Test]
        public void ����3��n���Đ����̑����Fizz��Ԃ�()
        {
            Assert.AreEqual("Fizz", _fizzBuzz.Convert(3));
        }

        [Test]
        public void ����6��n���Đ����̑����Fizz��Ԃ�()
        {
            Assert.AreEqual("Fizz", _fizzBuzz.Convert(6));
        }
    }
}
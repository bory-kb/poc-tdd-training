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
            Assert.AreEqual("1", FizzBuzz.Convert(1));
        }
        [Test]
        public void ����2��n���ĕ�����2��Ԃ�()
        {
            Assert.AreEqual("2", FizzBuzz.Convert(2));
        }

        [Test]
        public void ����3��n���Đ����̑����Fizz��Ԃ�()
        {
            Assert.AreEqual("Fizz", FizzBuzz.Convert(3));
        }

        [Test]
        public void ����6��n���Đ����̑����Fizz��Ԃ�()
        {
            Assert.AreEqual("Fizz", FizzBuzz.Convert(6));
        }

        [Test]
        public void ����5��n���Đ����̑����Buzz��Ԃ�()
        {
            Assert.AreEqual("Buzz", FizzBuzz.Convert(5));
        }

        [Test]
        public void ����15��n���Đ����̑����FizzBuzz��Ԃ�()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.Convert(15));
        }
    }
}
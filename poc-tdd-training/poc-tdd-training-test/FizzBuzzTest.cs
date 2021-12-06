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
        public class �����𕶎���ɂ��ĕԂ�
        {
            FizzBuzz _fizzBuzz = new FizzBuzz();

            [Test]

            public void ����1��n���ĕ�����1��Ԃ�()
            {
                Assert.AreEqual("1", _fizzBuzz.Convert(1));
            }
        }

        [TestFixture]
        public class _3�̔{���̂Ƃ��͐����̑����Fizz��Ԃ�
        {
            FizzBuzz _fizzBuzz = new FizzBuzz();


            [Test]
            public void ����3��n���Đ����̑����Fizz��Ԃ�()
            {
                Assert.AreEqual("Fizz", _fizzBuzz.Convert(3));
            }

        }
        [TestFixture]
        public class _5�̔{���̂Ƃ��͐����̑����Buzz��Ԃ�
        {
            FizzBuzz _fizzBuzz = new FizzBuzz();


            [Test]
            public void ����5��n���Đ����̑����Buzz��Ԃ�()
            {
                Assert.AreEqual("Buzz", _fizzBuzz.Convert(5));
            }
        }
        [TestFixture]
        public class _15�̔{���̂Ƃ��͐����̑����FizzBuzz��Ԃ�
        {
            FizzBuzz _fizzBuzz = new FizzBuzz();

            [Test]
            public void ����15��n���Đ����̑����FizzBuzz��Ԃ�()
            {
                Assert.AreEqual("FizzBuzz", _fizzBuzz.Convert(15));
            }
        }
    }
}
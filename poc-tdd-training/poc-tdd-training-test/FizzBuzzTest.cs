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
        public class ”š‚ğ•¶š—ñ‚É‚µ‚Ä•Ô‚·
        {
            FizzBuzz _fizzBuzz = new FizzBuzz();

            [Test]

            public void ”š1‚ğ“n‚µ‚Ä•¶š—ñ1‚ğ•Ô‚·()
            {
                Assert.AreEqual("1", _fizzBuzz.Convert(1));
            }
        }

        [TestFixture]
        public class _3‚Ì”{”‚Ì‚Æ‚«‚Í”š‚Ì‘ã‚í‚è‚ÉFizz‚ğ•Ô‚·
        {
            FizzBuzz _fizzBuzz = new FizzBuzz();


            [Test]
            public void ”š3‚ğ“n‚µ‚Ä”š‚Ì‘ã‚í‚è‚ÉFizz‚ğ•Ô‚·()
            {
                Assert.AreEqual("Fizz", _fizzBuzz.Convert(3));
            }

        }
        [TestFixture]
        public class _5‚Ì”{”‚Ì‚Æ‚«‚Í”š‚Ì‘ã‚í‚è‚ÉBuzz‚ğ•Ô‚·
        {
            FizzBuzz _fizzBuzz = new FizzBuzz();


            [Test]
            public void ”š5‚ğ“n‚µ‚Ä”š‚Ì‘ã‚í‚è‚ÉBuzz‚ğ•Ô‚·()
            {
                Assert.AreEqual("Buzz", _fizzBuzz.Convert(5));
            }
        }
        [TestFixture]
        public class _15‚Ì”{”‚Ì‚Æ‚«‚Í”š‚Ì‘ã‚í‚è‚ÉFizzBuzz‚ğ•Ô‚·
        {
            FizzBuzz _fizzBuzz = new FizzBuzz();

            [Test]
            public void ”š15‚ğ“n‚µ‚Ä”š‚Ì‘ã‚í‚è‚ÉFizzBuzz‚ğ•Ô‚·()
            {
                Assert.AreEqual("FizzBuzz", _fizzBuzz.Convert(15));
            }
        }
    }
}
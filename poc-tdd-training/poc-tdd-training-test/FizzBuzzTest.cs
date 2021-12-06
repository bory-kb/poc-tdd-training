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

        public void ”š1‚ğ“n‚µ‚Ä•¶š—ñ1‚ğ•Ô‚·()
        {
            Assert.AreEqual("1", FizzBuzz.Convert(1));
        }
        [Test]
        public void ”š2‚ğ“n‚µ‚Ä•¶š—ñ2‚ğ•Ô‚·()
        {
            Assert.AreEqual("2", FizzBuzz.Convert(2));
        }

        [Test]
        public void ”š3‚ğ“n‚µ‚Ä”š‚Ì‘ã‚í‚è‚ÉFizz‚ğ•Ô‚·()
        {
            Assert.AreEqual("Fizz", FizzBuzz.Convert(3));
        }

        [Test]
        public void ”š6‚ğ“n‚µ‚Ä”š‚Ì‘ã‚í‚è‚ÉFizz‚ğ•Ô‚·()
        {
            Assert.AreEqual("Fizz", FizzBuzz.Convert(6));
        }

        [Test]
        public void ”š5‚ğ“n‚µ‚Ä”š‚Ì‘ã‚í‚è‚ÉBuzz‚ğ•Ô‚·()
        {
            Assert.AreEqual("Buzz", FizzBuzz.Convert(5));
        }

        [Test]
        public void ”š15‚ğ“n‚µ‚Ä”š‚Ì‘ã‚í‚è‚ÉFizzBuzz‚ğ•Ô‚·()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.Convert(15));
        }
    }
}
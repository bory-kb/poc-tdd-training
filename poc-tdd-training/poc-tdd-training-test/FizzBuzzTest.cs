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
            string ret = _fizzBuzz.Convert(1);
            Assert.AreEqual("1", ret);
        }
        [Test]
        public void ”š2‚ğ“n‚µ‚Ä•¶š—ñ2‚ğ•Ô‚·()
        {
            string ret = _fizzBuzz.Convert(2);
            Assert.AreEqual("2", ret);
        }

        [Test]
        public void ”š3‚ğ“n‚µ‚Ä”š‚Ì‘ã‚í‚è‚ÉFizz‚ğ•Ô‚·()
        {
            string ret = _fizzBuzz.Convert(3);
            Assert.AreEqual("Fizz", ret);
        }

        [Test]
        public void ”š6‚ğ“n‚µ‚Ä”š‚Ì‘ã‚í‚è‚ÉFizz‚ğ•Ô‚·()
        {
            string ret = _fizzBuzz.Convert(6);
            Assert.AreEqual("Fizz", ret);
        }
    }
}
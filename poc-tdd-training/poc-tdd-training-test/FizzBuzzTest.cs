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

        public void ”š1‚ğ“n‚µ‚Ä•¶š—ñ1‚ğ•Ô‚·()
        {
            var fizzBuzz = new FizzBuzz();
            string ret = fizzBuzz.returnNum(1);
            Assert.AreEqual("1", ret);
        }
        [Test]
        public void ”š2‚ğ“n‚µ‚Ä•¶š—ñ2‚ğ•Ô‚·()
        {
            var fizzBuzz = new FizzBuzz();
            string ret = fizzBuzz.returnNum(2);
            Assert.AreEqual("2", ret);
        }
    }
}
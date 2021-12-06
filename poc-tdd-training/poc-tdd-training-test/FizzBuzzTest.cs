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
            string ret = fizzBuzz.returnNum();
            Assert.AreEqual("1", ret);
        }
    }
}
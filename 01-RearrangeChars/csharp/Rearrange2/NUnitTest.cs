namespace RearrangeChars
{
    using NUnit.Framework;
    [TestFixture]
    public class NUnitTest
    {

        [Test]
        public void GracefulFromStart()
        {
            string input = "aaabc";
            var arr = new RearrangeChars.CharacterArranger(input);
            string result = arr.arrange();
            
            Assert.AreEqual( "abaca",result);

        }

        [Test]
        public void InvalidShortSet()
        {
            string input = "aa";
            var arr = new RearrangeChars.CharacterArranger(input);
            string result = arr.arrange();
            Assert.AreEqual("No valid output", result);
        }

        [Test]
        public void InvalidLongFromStart()
        {
            string input = "aaaabc";
            var arr = new RearrangeChars.CharacterArranger(input);
            string result = arr.arrange();
            Assert.AreEqual("No valid output", result);
        }

        [Test]
        public void GracefulFromEnd()
        {
            string input = "abcaa";
            var arr = new RearrangeChars.CharacterArranger(input);
            string result = arr.arrange();
            bool paired = false;
            for (var i = 0; i < result.Length - 1; i++) paired |= (result[i] == result[i + 1]);
            Assert.False(paired);
        }
        [Test]
        public void NotRequiresArrange()
        {
            string input = "abcad";
            var arr = new RearrangeChars.CharacterArranger(input);
            string result = arr.arrange();
            Assert.AreEqual (input, result);
        }
    }
}

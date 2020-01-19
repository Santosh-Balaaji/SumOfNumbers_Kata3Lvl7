using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class SequenceSumTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("0+1+2+3+4+5+6 = 21", SequenceSum.ShowSequence(6));
            Assert.AreEqual("-15<0", SequenceSum.ShowSequence(-15));
            Assert.AreEqual("0=0", SequenceSum.ShowSequence(0));
        }
    }
}
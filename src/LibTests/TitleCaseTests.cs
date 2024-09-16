namespace LibTests;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Kata = TitleCaseKata;

[TestFixture]
public class TitleCaseTests
{
    [TestCase("a clash of KINGS", "a an the of", "A Clash of Kings")]
    [TestCase("THE WIND IN THE WILLOWS", "The In", "The Wind in the Willows")]
    [TestCase("The resturaunt at the end of the universe", "at the in a of the", "The Resturaunt at the End of the Universe")]
    public void TitleCastTest(string sampleTitle, string sampleMinorWords, string expected)
    {
        Assert.AreEqual(expected, Kata.TitleCase(sampleTitle, sampleMinorWords));
    }

    [Test]
    public void EmptyTiltleTest()
    {
        Assert.AreEqual("", Kata.TitleCase(""));
    }

    [Test]
    public void QuickBrownFoxTest()
    {
        Assert.AreEqual("The Quick Brown Fox", Kata.TitleCase("the quick brown fox"));
    }
}
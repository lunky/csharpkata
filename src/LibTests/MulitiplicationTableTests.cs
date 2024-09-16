using Kata = MultiplicationTableKata;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

[TestFixture]
  public class MultiplicationTableTests
  {
    [Test]
    public void MyTest()
    {
      int[,] expected = new int[,]{{1,2,3},{2,4,6},{3,6,9}};
      Assert.AreEqual(expected, Kata.MultiplicationTable(3));
    }
  }

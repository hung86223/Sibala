using NUnit.Framework;

namespace Sibala
{
    public class SibalaTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NoPoint_NoPoint()
        {
            var sibalaGame = new SibalaGame();

            var actual = sibalaGame.Result("Amy:1 2 3 4  Lin:2 3 4 5");

            Assert.AreEqual("Tie.",actual);
        }
    }

    public class SibalaGame
    {
        public string Result(string input)
        {
            return "Tie.";
        }
    }
}
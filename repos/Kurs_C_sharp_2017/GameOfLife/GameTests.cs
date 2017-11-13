using NUnit.Framework;

namespace GameOfLife
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void SomeTest()
        {
            bool[,] field = new bool[3,3];
            bool[,] expectedField = new bool[3, 3];
            field[2, 2] = true;
            field = Game.NextStep(field);
            Assert.AreEqual(field, expectedField);
        }
    }
}
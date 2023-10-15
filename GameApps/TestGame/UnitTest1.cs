using NUnit.Framework;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace GameApps.Tests
{
    [TestFixture]
    public class GameMapTests
    {
        [Test]
        public void TestMovePlayer()
        {
            string[] testMap = {
                "#####",
                "# @ #",
                "#####"
            };

            string tempFileName = Path.GetTempFileName();
            File.WriteAllLines(tempFileName, testMap);

            var gameMap = new GameMap(tempFileName);

            using (var consoleOutput = new ConsoleOutput())
            {
                gameMap.MovePlayer(1, 0); 

                Assert.AreEqual(' ', gameMap.GetCell(1, 1)); 
                Assert.AreEqual('@', gameMap.GetCell(2, 1)); 
                consoleOutput.Assert();
            }
        }
    }
}
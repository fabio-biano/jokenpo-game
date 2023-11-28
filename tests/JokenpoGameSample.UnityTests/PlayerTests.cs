namespace JokenpoGameSample.UnityTests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void GivenPaperVsPaperMustDraw()
        {   // Arrange
            Player paper = new Paper();

            // Act
            string result = paper.Play(paper);

            // Assert
            Assert.AreEqual("Match draw.", result);
        }

        [TestMethod]
        public void GivenPaperVsStonePaperMustWin()
        {   // Arrange
            Player paper = new Paper();
            Player stone = new Stone();

            // Act
            string result = paper.Play(stone);

            // Assert
            Assert.AreEqual("Paper wins.", result);
        }

        [TestMethod]
        public void GivenPaperVsScissorPaperMustLose()
        {   // Arrange
            Player paper = new Paper();
            Player scissor = new Scissor();

            // Act
            string result = paper.Play(scissor);

            // Assert
            Assert.AreEqual("Paper lose.", result);
        }

        [TestMethod]
        public void GivenStoneVsStoneMustDraw()
        {   // Arrange
            Player stone = new Stone();

            // Act
            string result = stone.Play(stone);

            // Assert
            Assert.AreEqual("Match draw.", result);
        }

        [TestMethod]
        public void GivenStoneVsScissorStoneMustWin()
        {   // Arrange
            Player stone = new Stone();
            Player scissor = new Scissor();

            // Act
            string result = stone.Play(scissor);

            // Assert
            Assert.AreEqual("Stone wins.", result);
        }

        [TestMethod]
        public void GivenStoneVsPaperStoneMustLose()
        {   // Arrange
            Player stone = new Stone();
            Player paper = new Paper();

            // Act
            string result = stone.Play(paper);

            // Assert
            Assert.AreEqual("Stone lose.", result);
        }

        [TestMethod]
        public void GivenScissorVsScissorMustDraw()
        {   // Arrange
            Player scissor = new Scissor();

            // Act
            string result = scissor.Play(scissor);

            // Assert
            Assert.AreEqual("Match draw.", result);
        }

        [TestMethod]
        public void GivenScissorVsPaperScisorMustWin()
        {   // Arrange
            Player scissor = new Scissor();
            Player paper = new Paper();            

            // Act
            string result = scissor.Play(paper);

            // Assert
            Assert.AreEqual("Scissor wins.", result);
        }

        [TestMethod]
        public void GivenScissorVsStoneScissorMustLose()
        {   // Arrange
            Player scissor = new Scissor();
            Player stone = new Stone();

            // Act
            string result = scissor.Play(stone);

            // Assert
            Assert.AreEqual("Scissor lose.", result);
        }
    }
}
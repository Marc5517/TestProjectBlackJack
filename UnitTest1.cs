using BlackJackProject.Models;

namespace TestProjectBlackJack
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCard()
        {
            //Arrange
            Card card = new Card();

            //Act
            card.Name = "King";

            //Assert
            Assert.AreEqual("King", card.Name);
        }

        [TestMethod]
        public void TestPlayerName()
        {
            //Arrange
            Player player = new Player();

            //Act
            player.Name = "Marc";

            //Assert
            Assert.AreEqual("Marc", player.Name);
        }

        [TestMethod]
        public void TestPlayerTotalPoints()
        {
            //Arrange
            Player player = new Player();

            //Act
            player.TotalPoints = 0;

            //Assert
            Assert.AreEqual(0, player.TotalPoints);
        }

        [TestMethod]
        public void TestReceivePoints()
        {
            //Arrange
            Player player = new Player("Marc", 0);
            Card card = new Card("King", 10, "Hearts");

            //Act
            player.ReceivePoints(card);

            //Assert
            Assert.AreEqual(10, player.TotalPoints);
        }

        [TestMethod]
        public void TestReceivePoints2()
        {
            //Arrange
            Player player = new Player("Marc", 0);
            Card card = new Card("King", 10, "Hearts");
            Card card2 = new Card("Ace", 11, "Clovers");

            //Act
            player.ReceivePoints(card);
            player.ReceivePoints(card2);

            //Assert
            Assert.AreEqual(21, player.TotalPoints);
        }
    }
}
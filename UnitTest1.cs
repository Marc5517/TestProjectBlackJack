using BlackJackProject.Models;

namespace TestProjectBlackJack
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests if the card's name will be as it should be.
        /// </summary>
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

        /// <summary>
        /// This here tests if the player's name is as it should be.
        /// </summary>
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

        /// <summary>
        /// Tests if the player's total points will be as it should be.
        /// </summary>
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

        /// <summary>
        /// To test if the method receive points works as calculated.
        /// </summary>
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

        /// <summary>
        /// The same test as above, but with 2 cards with different points.
        /// </summary>
        [TestMethod]
        public void TestReceivePoints2()
        {
            //Arrange
            Player player = new Player("Marc", 0);
            Card card = new Card("King", 10, "Hearts");
            Card card2 = new Card("10", 10, "Spades");
            Card card3 = new Card("Ace", 1, "Clovers");

            //Act
            player.ReceivePoints(card);
            player.ReceivePoints(card2);
            player.ReceivePoints(card3);

            //Assert
            Assert.AreEqual(21, player.TotalPoints);
        }

        /// <summary>
        /// Testing if the player's total points do become 21 if the card "Joker" is picked.
        /// </summary>
        [TestMethod]
        public void TestPickingJoker()
        {
            //Arrange
            Player player = new Player("Marc", 0);
            Card card = new Card("Joker", 0, "");

            //Act
            card.PickingJoker(card, player);

            //Assert
            Assert.AreEqual(21, player.TotalPoints);
        }

        /// <summary>
        /// Test to see if the player's total points increases by 10, if an Ace is picked.
        /// </summary>
        [TestMethod]
        public void TestPickingAce()
        {
            //Arrange
            Player player = new Player("Marc", 10);
            Card card = new Card("Ace", 1, "Hearts");

            //Act
            card.PickingAce(card.Name, player);
            player.ReceivePoints(card);

            //Assert
            Assert.AreEqual(21, player.TotalPoints);
        }

        /// <summary>
        /// Tests the same as TestPickingAce, but this one is more like a real game of blackjack.
        /// </summary>
        [TestMethod]
        public void TestPickingAceAndWin()
        {
            //Arrange
            Player player = new Player("Marc", 0);
            Card card = new Card("King", 10, "Clover");
            Card cardA = new Card("Ace", 1, "Hearts");

            //Act
            cardA.PickingAce(cardA.Name, player);
            player.ReceivePoints(card);
            player.ReceivePoints(cardA);

            //Assert
            Assert.AreEqual(21, player.TotalPoints);
        }
    }
}
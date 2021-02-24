using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame_20210224.Tests
{
    [TestClass]
    public class TennisGameTests
    {
        private readonly TennisGame _tennisGame = new("Player1", "Player2");

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        private void ScoreShouldBe(string expected)
        {
            var score = _tennisGame.Score();
            Assert.AreEqual(expected, score);
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            _tennisGame.SetPlayer1(1);
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Lova()
        {
            _tennisGame.SetPlayer1(2);
            ScoreShouldBe("Thirty Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            _tennisGame.SetPlayer1(3);
            ScoreShouldBe("Forty Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            _tennisGame.SetPlayer2(1);
            ScoreShouldBe("Love Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            _tennisGame.SetPlayer2(2);
            ScoreShouldBe("Love Thirty");
        }

        [TestMethod]
        public void Love_Forty()
        {
            _tennisGame.SetPlayer2(3);
            ScoreShouldBe("Love Forty");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            _tennisGame.SetPlayer1(1);
            _tennisGame.SetPlayer2(1);
            ScoreShouldBe("Fifteen All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            _tennisGame.SetPlayer1(2);
            _tennisGame.SetPlayer2(2);
            ScoreShouldBe("Thirty All");
        }

        [TestMethod]
        public void When3_3_Deuce()
        {
            _tennisGame.SetPlayer1(3);
            _tennisGame.SetPlayer2(3);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void When4_4_Deuce()
        {
            _tennisGame.SetPlayer1(4);
            _tennisGame.SetPlayer2(4);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void When4_3_Player1_Adv()
        {
            _tennisGame.SetPlayer1(4);
            _tennisGame.SetPlayer2(3);
            ScoreShouldBe("Player1 Adv");
        }

        [TestMethod]
        public void When3_4_Player2_Adv()
        {
            _tennisGame.SetPlayer1(3);
            _tennisGame.SetPlayer2(4);
            ScoreShouldBe("Player2 Adv");
        }

        [TestMethod]
        public void When5_3_Player1_Win()
        {
            _tennisGame.SetPlayer1(5);
            _tennisGame.SetPlayer2(3);
            ScoreShouldBe("Player1 Win");
        }

        [TestMethod]
        public void When3_5_Player2_Win()
        {
            _tennisGame.SetPlayer1(3);
            _tennisGame.SetPlayer2(5);
            ScoreShouldBe("Player2 Win");
        }
    }
}
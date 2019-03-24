using Game_Pacman.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Pacman.Unit_Tests
{
    [TestFixture]
    public class HighScore_Test
    {
        public HighScore HighScore = new HighScore();

        [Test]
        public void CreateHighScoreTest()
        {
            // Check High Score has been created
            HighScore.CreateHighScore(new Form());
            Assert.AreEqual(HighScore.InitalScore.ToString(), HighScore.HighScoreText.Text);
        }
    }
}

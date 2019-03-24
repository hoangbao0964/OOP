using NUnit.Framework;
using Game_Pacman.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Pacman.Unit_Tests
{
    class FormElements_Test
    {
        public FormElements FormElements = new FormElements();

        [Test]
        public void CreateFormElementsTest()
        {
            // Check Form Elements have been created
            FormElements.CreateFormElements(new Form());
            Assert.AreEqual("1UP", FormElements.PlayerOneScoreText.Text);
            Assert.AreEqual("HIGH SCORE", FormElements.HighScoreText.Text);
        }
    }
}

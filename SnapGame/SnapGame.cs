using SnapGame.Enums;
using SnapGame.Factory;
using SnapGame.InterFaces;
using System;
using System.Windows.Forms;

namespace SnapGame
{
    public partial class SnapGame : Form
    {
        public SnapGame()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int numberOfDecks = Convert.ToInt32(txtNoOfDeck.Text);
            int numberOfPlayers = Convert.ToInt32(txtNoOfPlayers.Text);
            var matchingCondition = (MatchingCondition)Enum.Parse(typeof(MatchingCondition), ddlMatchingCondition.SelectedItem.ToString());

            IPlayCardGame playGame = CardGameFactory.GetGame(GameType.Snap, numberOfDecks, numberOfPlayers, matchingCondition); // Create different concrete class objects based on game type e.g PlayCardSnapGame, PlayCardPokerGame etc., every concrete class should have atleast two function, PlayGame and DeclareResult which is required for any card game.
            playGame.PlayGame();
            var strResult = playGame.DeclareResult();

            lblResult.Text = strResult;
        }
    }
}
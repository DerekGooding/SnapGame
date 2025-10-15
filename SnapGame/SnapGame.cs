using SnapGame.Enums;
using SnapGame.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SnapGame;

public partial class SnapGame : Form
{
    private readonly IGameService _gameService;

    public SnapGame(IGameService gameService)
    {
        InitializeComponent();

        _gameService = gameService;
    }

    private void btnPlay_Click(object sender, EventArgs e)
    {
        int numberOfDecks, numberOfPlayers;
        if (!int.TryParse(txtNoOfDeck.Text, out numberOfDecks) || numberOfDecks <= 0)
        {
            MessageBox.Show("Please enter valid number of decks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!int.TryParse(txtNoOfPlayers.Text, out numberOfPlayers) || numberOfPlayers <= 1)
        {
            MessageBox.Show("Please enter valid number of players, Minimum two players.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (ddlMatchingCondition.SelectedItem == null)
        {
            MessageBox.Show("Please select matching condition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var matchingCondition = (MatchingCondition)Enum.Parse(typeof(MatchingCondition), ddlMatchingCondition.SelectedItem.ToString());
            var resultDto = _gameService.PlayGame(GameType.Snap, numberOfDecks, numberOfPlayers, matchingCondition);

            string formattedResult;
            if (resultDto.IsDraw)
            {
                formattedResult = "Match is Draw, " +
                    string.Join(", ", resultDto.PlayerResults.Select(x => $"{x.Name} cards: {x.CardsCollected}"));
            }
            else
            {
                formattedResult = $"{resultDto.WinnerName} is won, " +
                    string.Join(", ", resultDto.PlayerResults.Select(x => $"{x.Name} cards: {x.CardsCollected}"));
            }
            lblResult.Text = formattedResult;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
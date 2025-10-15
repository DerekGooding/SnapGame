using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SnapGame.Classes;
using SnapGame.Enums;
using SnapGame.Interfaces;

namespace SnapGame.Tests.Services;

[TestClass]
public class GameServiceMockTests
{
    [TestMethod]
    public void PlayGame_ReturnsExpectedResult()
    {
        var expectedResult = new GameResultDto
        {
            IsDraw = false,
            WinnerName = "Player 1",
            PlayerResults = new System.Collections.Generic.List<PlayerResultDto>
            {
                new PlayerResultDto { Name = "Player 1", CardsCollected = 10 },
                new PlayerResultDto { Name = "Player 2", CardsCollected = 5 }
            }
        };

        var mockService = new Mock<IGameService>();
        mockService.Setup(s => s.PlayGame(GameType.Snap, 1, 2, MatchingCondition.FaceValue))
                   .Returns(expectedResult);

        var result = mockService.Object.PlayGame(GameType.Snap, 1, 2, MatchingCondition.FaceValue);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsFalse(result.IsDraw);
        Assert.AreEqual("Player 1", result.WinnerName);
        Assert.HasCount(2, result.PlayerResults);
        Assert.AreEqual(10, result.PlayerResults[0].CardsCollected);
    }

    [TestMethod]
    public void PlayGame_DrawScenario_ReturnsDrawResult()
    {
        var expectedResult = new GameResultDto
        {
            IsDraw = true,
            WinnerName = null,
            PlayerResults = new System.Collections.Generic.List<PlayerResultDto>
            {
                new PlayerResultDto { Name = "Player 1", CardsCollected = 7 },
                new PlayerResultDto { Name = "Player 2", CardsCollected = 7 }
            }
        };

        var mockService = new Mock<IGameService>();
        mockService.Setup(s => s.PlayGame(GameType.Snap, 1, 2, MatchingCondition.FaceValue))
                   .Returns(expectedResult);

        var result = mockService.Object.PlayGame(GameType.Snap, 1, 2, MatchingCondition.FaceValue);

        // Assert
        Assert.IsTrue(result.IsDraw);
        Assert.IsNull(result.WinnerName);
        Assert.HasCount(2, result.PlayerResults);
        Assert.AreEqual(7, result.PlayerResults[0].CardsCollected);
    }
}
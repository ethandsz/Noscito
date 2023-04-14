using Noscito.Api.Models;
using Noscito.ComputationalLayer;
using NUnit.Framework;

namespace Noscito.ComputationalLayerTests;

[TestFixture]
public class CandleStickTests
{
    private HoldLevelFinder _holdLevelFinder;

    [SetUp]
    public void Init()
    {
        _holdLevelFinder = HoldLevelFinder.Instance();
    }
    
    [Test]
    public void IdentifyWickRanges_ReturnsEmptyList_WhenGivenEmptyList()
    {
        // Arrange
        List<CandleStick> wicks = new List<CandleStick>();

        // Act
        List<CandleStick> result = _holdLevelFinder.IdentifyWickRanges(wicks);
        
        // Assert
        Assert.AreEqual(0, result.Count);
    }

    [Test]
    public void IdentifyWickRanges_ReturnsEmptyList_WhenGivenOneWick()
    {
        // Arrange
        List<CandleStick> wicks = new List<CandleStick>
        {
            new() {Open = 1, Close = 2}
        };
    
        // Act
        List<CandleStick> result = _holdLevelFinder.IdentifyWickRanges(wicks);
    
        // Assert
        Assert.AreEqual(0, result.Count);
    }
    
    [Test]
    public void IdentifyWickRanges_ReturnsCorrectHoldLevels_WhenGivenMultipleWicks()
    {
        // Arrange
        List<CandleStick> wicks = new List<CandleStick>
        {
            new() {Open = 1, Close = 2},
            new() {Open = 1, Close = 2},
            new() {Open = 2, Close = 1},
            new() {Open = 2, Close = 1},
            new() {Open = 1, Close = 2},
            new() {Open = 1, Close = 2},
        };
    
        // Act
        List<CandleStick> result = _holdLevelFinder.IdentifyWickRanges(wicks);
    
        // Assert
        Assert.AreEqual(2, result.Count);
    }
}
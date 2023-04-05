using ArchUnitNET.xUnit;
using DDD.ArchTest.Settings;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.Common;

public class PropertyArchTest : ArchTestSettings
{
    [Fact]
    public void ShouldStartWithUppercaseLetter()
    {
        var assert = PropertyMembers()
            .That()
            .ArePublic()
            .Should().HaveNameStartingWith("A")
            .OrShould().HaveNameStartingWith("B")
            .OrShould().HaveNameStartingWith("C")
            .OrShould().HaveNameStartingWith("D")
            .OrShould().HaveNameStartingWith("E")
            .OrShould().HaveNameStartingWith("F")
            .OrShould().HaveNameStartingWith("G")
            .OrShould().HaveNameStartingWith("H")
            .OrShould().HaveNameStartingWith("I")
            .OrShould().HaveNameStartingWith("J")
            .OrShould().HaveNameStartingWith("K")
            .OrShould().HaveNameStartingWith("L")
            .OrShould().HaveNameStartingWith("M")
            .OrShould().HaveNameStartingWith("N")
            .OrShould().HaveNameStartingWith("O")
            .OrShould().HaveNameStartingWith("P")
            .OrShould().HaveNameStartingWith("Q")
            .OrShould().HaveNameStartingWith("R")
            .OrShould().HaveNameStartingWith("S")
            .OrShould().HaveNameStartingWith("T")
            .OrShould().HaveNameStartingWith("U")
            .OrShould().HaveNameStartingWith("V")
            .OrShould().HaveNameStartingWith("W")
            .OrShould().HaveNameStartingWith("X")
            .OrShould().HaveNameStartingWith("Y")
            .OrShould().HaveNameStartingWith("Z");

        assert.Check(Architecture);
    }
}
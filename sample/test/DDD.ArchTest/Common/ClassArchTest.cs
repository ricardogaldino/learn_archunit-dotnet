using ArchUnitNET.xUnit;
using DDD.ArchTest.Settings;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.Common;

public class ClassArchTest : ArchTestSettings
{
    [Fact]
    public void ShouldResideInNamespace()
    {
        var assert = Classes()
            .That()
            .DoNotHaveNameContaining("Dto")
            .Should()
            .NotResideInNamespace(InterfaceNamespace, true);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldStartWithUppercaseLetter()
    {
        var assert = Classes()
            .That()
            .DoNotResideInNamespace("Migrations", true)
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

    [Fact]
    public void ShouldNotStartWithVerb()
    {
        var assert = Classes()
            .That()
            .DoNotResideInNamespace("Migrations", true)
            .Should().NotHaveNameStartingWith("Get")
            .AndShould().NotHaveNameStartingWith("Set")
            .AndShould().NotHaveNameStartingWith("Post")
            .AndShould().NotHaveNameStartingWith("Put")
            .AndShould().NotHaveNameStartingWith("Patch")
            .AndShould().NotHaveNameStartingWith("Insert")
            .AndShould().NotHaveNameStartingWith("Select")
            .AndShould().NotHaveNameStartingWith("Drop")
            .AndShould().NotHaveNameStartingWith("Truncate")
            .AndShould().NotHaveNameStartingWith("Create")
            .AndShould().NotHaveNameStartingWith("Read")
            .AndShould().NotHaveNameStartingWith("Update")
            .AndShould().NotHaveNameStartingWith("Delete")
            .AndShould().NotHaveNameStartingWith("Save")
            .AndShould().NotHaveNameStartingWith("Alter")
            .AndShould().NotHaveNameStartingWith("Change")
            .AndShould().NotHaveNameStartingWith("Register")
            .AndShould().NotHaveNameStartingWith("Accept")
            .AndShould().NotHaveNameStartingWith("Calculate")
            .AndShould().NotHaveNameStartingWith("Confirm")
            .AndShould().NotHaveNameStartingWith("Generate")
            .AndShould().NotHaveNameStartingWith("Download")
            .AndShould().NotHaveNameStartingWith("Upload")
            .AndShould().NotHaveNameStartingWith("Take")
            .AndShould().NotHaveNameStartingWith("Make")
            .AndShould().NotHaveNameStartingWith("Go")
            .AndShould().NotHaveNameStartingWith("Do")
            .AndShould().NotHaveNameStartingWith("Have")
            .AndShould().NotHaveNameStartingWith("Give")
            .AndShould().NotHaveNameStartingWith("Find")
            .AndShould().NotHaveNameStartingWith("Build");

        assert.Check(Architecture);
    }
}
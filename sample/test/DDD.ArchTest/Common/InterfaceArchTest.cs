using ArchUnitNET.Fluent.Syntax.Elements.Types;
using ArchUnitNET.xUnit;
using DDD.ArchTest.Settings;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.Common;

public class InterfaceArchTest : ArchTestSettings
{
    private readonly GivenTypesConjunction _interfaces = Types().That().Are(Interfaces);

    [Fact]
    public void ShouldStartWithI()
    {
        var assert = Interfaces().Should().HaveNameStartingWith("I");

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInNamespace()
    {
        var assert = Interfaces()
            .Should()
            .ResideInNamespace(InterfaceNamespace, true);

        assert.Check(Architecture);
    }
}
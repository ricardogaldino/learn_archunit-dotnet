using ArchUnitNET.Fluent.Syntax.Elements.Types;
using ArchUnitNET.xUnit;
using DDD.ArchTest.Helpers;
using DDD.ArchTest.Settings;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.Common;

public class DtoArchTest : ArchTestSettings
{
    private readonly GivenTypesConjunction _dtos = Types().That().Are(Dtos);

    [Fact]
    public void ShouldStartWithDto()
    {
        var assert = _dtos.Should().HaveNameEndingWith("Dto");

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInNamespace()
    {
        var assert = ArchTestHelper.ResideInImplementationNamespace(
            DtoNamespace,
            DtoSuffix
        );

        assert.Check(Architecture);
    }
}
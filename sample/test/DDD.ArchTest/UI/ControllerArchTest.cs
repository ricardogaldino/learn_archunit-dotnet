using ArchUnitNET.Fluent.Syntax.Elements.Types;
using ArchUnitNET.xUnit;
using DDD.ArchTest.Helpers;
using DDD.ArchTest.Settings;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.UI;

public class ControllerArchTest : ArchTestSettings
{
    private readonly GivenTypesConjunction _controllers = Types().That().Are(Controllers);

    [Fact]
    public void ShouldHaveNameContaining()
    {
        var assert = ArchTestHelper.ShouldHaveNameContaining(_controllers, ControllerSuffix);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInImplementationNamespace()
    {
        var assert = ArchTestHelper.ResideInImplementationNamespace(
            ControllerNamespace,
            ControllerSuffix
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependDomain()
    {
        var assert = ArchTestHelper.AndNotDepend(
            _controllers,
            IDomainServices,
            DomainServices
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependRepository()
    {
        var assert = ArchTestHelper.AndNotDepend(
            _controllers,
            IRepositories,
            Repositories
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependExternals()
    {
        var assert = ArchTestHelper.AndNotDepend(
            _controllers,
            IExternalServices,
            ExternalServices
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependApplicationImplementations()
    {
        var assert = ArchTestHelper.NotDepend(_controllers, ApplicationServices);

        assert.Check(Architecture);
    }
}
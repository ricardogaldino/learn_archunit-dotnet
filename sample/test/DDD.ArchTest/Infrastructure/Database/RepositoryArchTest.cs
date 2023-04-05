using ArchUnitNET.Fluent.Syntax.Elements.Types;
using ArchUnitNET.xUnit;
using DDD.ArchTest.Helpers;
using DDD.ArchTest.Settings;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.Infrastructure.Database;

public class RepositoryArchTest : ArchTestSettings
{
    private readonly GivenTypesConjunction _iRepositories = Types().That().Are(IRepositories);
    private readonly GivenTypesConjunction _repositories = Types().That().Are(Repositories);

    [Fact]
    public void ShouldHaveNameContaining()
    {
        var assert = ArchTestHelper.ShouldHaveNameContaining(
            _repositories,
            _iRepositories,
            RepositoriesSuffix);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInImplementationNamespace()
    {
        var assert = ArchTestHelper.ResideInImplementationNamespace(
            RepositoriesNamespace,
            RepositoriesSuffix
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInInterfaceNamespace()
    {
        var assert = ArchTestHelper.ResideInInterfaceNamespace(
            IRepositoriesNamespace,
            RepositoriesSuffix
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependController()
    {
        var assert = ArchTestHelper.NotDepend(_repositories, Controllers);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependDomain()
    {
        var assert = ArchTestHelper.AndNotDepend(
            _repositories,
            IDomainServices,
            DomainServices
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependApplication()
    {
        var assert = ArchTestHelper.AndNotDepend(
            _repositories,
            IApplicationServices,
            ApplicationServices
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependExternal()
    {
        var assert = ArchTestHelper.AndNotDepend(
            _repositories,
            IExternalServices,
            ExternalServices
        );

        assert.Check(Architecture);
    }
}
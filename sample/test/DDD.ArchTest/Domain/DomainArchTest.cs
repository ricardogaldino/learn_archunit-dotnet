using ArchUnitNET.Fluent.Syntax.Elements.Types;
using ArchUnitNET.xUnit;
using DDD.ArchTest.Helpers;
using DDD.ArchTest.Settings;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.Domain;

public class DomainArchTest : ArchTestSettings
{
    private readonly GivenTypesConjunction _domainServices = Types().That().Are(DomainServices);
    private readonly GivenTypesConjunction _iDomainServices = Types().That().Are(IDomainServices);

    [Fact]
    public void ShouldHaveNameContaining()
    {
        var assert = ArchTestHelper.ShouldHaveNameContaining(
            _domainServices,
            _iDomainServices,
            DomainServicesSuffix);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInImplementationNamespace()
    {
        var assert = ArchTestHelper.ResideInImplementationNamespace(
            DomainServicesNamespace,
            DomainServicesSuffix
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInInterfaceNamespace()
    {
        var assert = ArchTestHelper.ResideInInterfaceNamespace(
            IDomainServicesNamespace,
            DomainServicesSuffix
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependController()
    {
        var assert = ArchTestHelper.NotDepend(_domainServices, Controllers);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependApplication()
    {
        var assert = ArchTestHelper.AndNotDepend(
            _domainServices,
            IApplicationServices,
            ApplicationServices
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependRepository()
    {
        var assert = ArchTestHelper.AndNotDepend(
            _domainServices,
            IRepositories,
            Repositories
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependExternal()
    {
        var assert = ArchTestHelper.AndNotDepend(
            _domainServices,
            IExternalServices,
            ExternalServices
        );

        assert.Check(Architecture);
    }
}
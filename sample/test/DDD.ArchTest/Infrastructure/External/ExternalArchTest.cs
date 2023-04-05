using ArchUnitNET.Fluent.Syntax.Elements.Types;
using ArchUnitNET.xUnit;
using DDD.ArchTest.Helpers;
using DDD.ArchTest.Settings;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.Infrastructure.External;

public class ExternalArchTest : ArchTestSettings
{
    private readonly GivenTypesConjunction _externalServices = Types().That().Are(ExternalServices);
    private readonly GivenTypesConjunction _iExternalServices = Types().That().Are(IExternalServices);

    [Fact]
    public void ShouldHaveNameContaining()
    {
        var assert = ArchTestHelper.ShouldHaveNameContaining(
            _externalServices,
            _iExternalServices,
            ExternalServicesSuffix);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInImplementationNamespace()
    {
        var assert = ArchTestHelper.ResideInImplementationNamespace(
            ExternalServicesNamespace,
            ExternalServicesSuffix
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInInterfaceNamespace()
    {
        var assert = ArchTestHelper.ResideInInterfaceNamespace(
            IExternalServicesNamespace,
            ExternalServicesSuffix
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependController()
    {
        var assert = ArchTestHelper.NotDepend(
            _externalServices,
            Controllers
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependDomain()
    {
        var assert = ArchTestHelper.AndNotDepend(
            _externalServices,
            IDomainServices,
            DomainServices
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependApplication()
    {
        var assert = ArchTestHelper.AndNotDepend(
            _externalServices,
            IApplicationServices,
            ApplicationServices
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependRepository()
    {
        var assert = ArchTestHelper.AndNotDepend(
            _externalServices,
            IRepositories,
            Repositories
        );

        assert.Check(Architecture);
    }
}
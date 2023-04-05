using ArchUnitNET.Fluent.Syntax.Elements.Types;
using ArchUnitNET.xUnit;
using DDD.ArchTest.Helpers;
using DDD.ArchTest.Settings;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.Application;

public class ApplicationArchTest : ArchTestSettings
{
    private readonly GivenTypesConjunction _applicationServices = Types().That().Are(ApplicationServices);
    private readonly GivenTypesConjunction _iApplicationServices = Types().That().Are(IApplicationServices);

    [Fact]
    public void ShouldHaveNameContaining()
    {
        var assert = ArchTestHelper.ShouldHaveNameContaining(
            _applicationServices,
            _iApplicationServices,
            ApplicationServicesSuffix);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInImplementationNamespace()
    {
        var assert = ArchTestHelper.ResideInImplementationNamespace(
            ApplicationServicesNamespace,
            ApplicationServicesSuffix
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldResideInInterfaceNamespace()
    {
        var assert = ArchTestHelper.ResideInInterfaceNamespace(
            IApplicationServicesNamespace,
            ApplicationServicesSuffix
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependController()
    {
        var assert = ArchTestHelper.NotDepend(
            _applicationServices,
            Controllers
        );

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependRepositoryImplementation()
    {
        var assert = ArchTestHelper.NotDepend(
            _applicationServices,
            Repositories);

        assert.Check(Architecture);
    }

    [Fact]
    public void ShouldNotDependExternalImplementation()
    {
        var assert = ArchTestHelper.NotDepend(
            _applicationServices,
            ExternalServices);

        assert.Check(Architecture);
    }
}
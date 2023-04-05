using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using ArchUnitNET.Fluent.Syntax.Elements.Types;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.Helpers;

public static class ArchTestHelper
{
    public static IArchRule ShouldHaveNameContaining(GivenTypesConjunction source, string suffix)
    {
        return source.Should().HaveNameContaining(suffix);
    }

    public static IArchRule ShouldHaveNameContaining(
        GivenTypesConjunction implementations,
        GivenTypesConjunction interfaces,
        string suffix)
    {
        var implementationsRule = implementations.Should().HaveNameContaining(suffix);
        var interfacesRule = interfaces.Should().HaveNameContaining(suffix);

        return implementationsRule.And(interfacesRule);
    }

    public static IArchRule Depend(GivenTypesConjunction source, IObjectProvider<IType> provider)
    {
        return source.Should().DependOnAny(provider);
    }

    public static IArchRule NotDepend(GivenTypesConjunction source, IObjectProvider<IType> provider)
    {
        return source.Should().NotDependOnAny(provider);
    }

    public static IArchRule OrDepend(
        GivenTypesConjunction source,
        IObjectProvider<IType> firstProvider,
        IObjectProvider<IType> lastProvider)
    {
        return source.Should().DependOnAny(firstProvider)
            .OrShould().DependOnAny(lastProvider);
    }

    public static IArchRule AndNotDepend(
        GivenTypesConjunction source,
        IObjectProvider<IType> firstProvider,
        IObjectProvider<IType> lastProvider)
    {
        return source.Should().NotDependOnAny(firstProvider)
            .AndShould().NotDependOnAny(lastProvider);
    }

    public static IArchRule ResideInImplementationNamespace(string classNamespace, string suffix)
    {
        return Classes().That()
            .HaveNameEndingWith(suffix)
            .Should()
            .ResideInNamespace(classNamespace, true);
    }

    public static IArchRule ResideInInterfaceNamespace(string interfaceNamespace, string suffix)
    {
        return Interfaces().That()
            .HaveNameEndingWith(suffix)
            .Should()
            .ResideInNamespace(interfaceNamespace, true);
    }
}
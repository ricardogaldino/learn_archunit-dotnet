using ArchUnitNET.Domain;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.Settings;

public partial class ArchTestSettings
{
    protected static readonly string InterfaceNamespace = "Domain.Interfaces";

    protected static readonly IObjectProvider<IType> Interfaces = Interfaces()
        .That().ResideInNamespace(InterfaceNamespace, true)
        .And().DoNotHaveNameEndingWith("Dto")
        .As("Interfaces");
}
using ArchUnitNET.Domain;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.Settings;

public partial class ArchTestSettings
{
    protected static readonly string ExternalServicesSuffix = "ExternalService";
    protected static readonly string ExternalServicesNamespace = "Externals.Services";
    protected static readonly string IExternalServicesNamespace = "Domain.Interfaces.Infrastructure.Externals.Services";

    protected static readonly IObjectProvider<IType> ExternalServices = Classes()
        .That().ResideInNamespace(ExternalServicesNamespace, true)
        .And().DoNotHaveNameEndingWith("Dto")
        .Or().HaveNameEndingWith(ExternalServicesSuffix)
        .As("ExternalServices");

    protected static readonly IObjectProvider<IType> IExternalServices = Interfaces()
        .That().ResideInNamespace(IExternalServicesNamespace, true)
        .And().DoNotHaveNameEndingWith("Dto")
        .Or().HaveNameEndingWith(ExternalServicesSuffix)
        .As("IExternalServices");
}
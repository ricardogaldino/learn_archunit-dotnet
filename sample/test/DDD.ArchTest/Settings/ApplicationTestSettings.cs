using ArchUnitNET.Domain;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.Settings;

public partial class ArchTestSettings
{
    protected static readonly string ApplicationServicesSuffix = "ApplicationService";
    protected static readonly string ApplicationServicesNamespace = "Application.Services";
    protected static readonly string IApplicationServicesNamespace = "Domain.Interfaces.Application.Services";

    protected static readonly IObjectProvider<IType> ApplicationServices = Classes()
        .That().ResideInNamespace(ApplicationServicesNamespace, true)
        .And().DoNotHaveNameEndingWith("Dto")
        .Or().HaveNameEndingWith(ApplicationServicesSuffix)
        .As("ApplicationServices");

    protected static readonly IObjectProvider<IType> IApplicationServices = Interfaces()
        .That().ResideInNamespace(IApplicationServicesNamespace, true)
        .And().DoNotHaveNameEndingWith("Dto")
        .Or().HaveNameEndingWith(ApplicationServicesSuffix)
        .As("IApplicationServices");
}
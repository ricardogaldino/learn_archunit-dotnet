using ArchUnitNET.Domain;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.Settings;

public partial class ArchTestSettings
{
    protected static readonly string DomainServicesSuffix = "DomainService";
    protected static readonly string DomainServicesNamespace = "Domain.Services";
    protected static readonly string IDomainServicesNamespace = "Domain.Interfaces.Domain.Services";

    protected static readonly IObjectProvider<IType> DomainServices = Classes()
        .That().ResideInNamespace(DomainServicesNamespace, true)
        .And().DoNotHaveNameEndingWith("Dto")
        .Or().HaveNameEndingWith(DomainServicesSuffix)
        .As("DomainServices");

    protected static readonly IObjectProvider<IType> IDomainServices = Interfaces()
        .That().ResideInNamespace(IDomainServicesNamespace, true)
        .And().DoNotHaveNameEndingWith("Dto")
        .Or().HaveNameEndingWith(DomainServicesSuffix)
        .As("IDomainServices");
}
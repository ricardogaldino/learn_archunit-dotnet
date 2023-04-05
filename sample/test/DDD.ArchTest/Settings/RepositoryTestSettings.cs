using ArchUnitNET.Domain;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.Settings;

public partial class ArchTestSettings
{
    protected static readonly string RepositoriesSuffix = "Repository";
    protected static readonly string RepositoriesNamespace = "Infrastructure.Database.Repositories";
    protected static readonly string IRepositoriesNamespace = "Domain.Interfaces.Infrastructure.Database.Repositories";

    protected static readonly IObjectProvider<IType> Repositories = Classes()
        .That().ResideInNamespace(RepositoriesNamespace, true)
        .And().DoNotHaveNameEndingWith("Dto")
        .Or().HaveNameEndingWith(RepositoriesSuffix)
        .As("Repositories");

    protected static readonly IObjectProvider<IType> IRepositories = Interfaces()
        .That().ResideInNamespace(IRepositoriesNamespace, true)
        .And().DoNotHaveNameEndingWith("Dto")
        .Or().HaveNameEndingWith(RepositoriesSuffix)
        .As("IRepositories");
}
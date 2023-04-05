using ArchUnitNET.Domain;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.Settings;

public partial class ArchTestSettings
{
    protected static readonly string DtoSuffix = "Dto";
    protected static readonly string DtoNamespace = "Dtos";

    protected static readonly IObjectProvider<IType> Dtos = Classes()
        .That().ResideInNamespace(DtoNamespace, true)
        .Or().HaveNameEndingWith("Dto")
        .Or().HaveNameEndingWith("DTO")
        .As("Dtos");
}
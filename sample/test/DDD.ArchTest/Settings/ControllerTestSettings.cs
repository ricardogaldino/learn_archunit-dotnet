using ArchUnitNET.Domain;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace DDD.ArchTest.Settings;

public partial class ArchTestSettings
{
    protected static readonly string ControllerSuffix = "Controller";
    protected static readonly string ControllerNamespace = "UI.Controllers";

    protected static readonly IObjectProvider<IType> Controllers = Classes()
        .That().ResideInNamespace(ControllerNamespace, true)
        .And().DoNotHaveNameEndingWith("Dto")
        .Or().HaveNameEndingWith(ControllerSuffix)
        .As("Controllers");
}
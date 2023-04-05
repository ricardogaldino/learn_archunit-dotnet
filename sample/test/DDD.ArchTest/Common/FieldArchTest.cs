using ArchUnitNET.Fluent;
using ArchUnitNET.xUnit;
using DDD.ArchTest.Settings;

namespace DDD.ArchTest.Common;

using static ArchRuleDefinition;

public class FieldArchTest : ArchTestSettings
{
    public static void ShouldStartWithUnderscore()
    {
        var assert = FieldMembers()
            .That()
            .AreNotStatic()
            .And()
            .ArePrivate()
            .Should()
            .HaveNameStartingWith("_");

        assert.Check(Architecture);
    }
}
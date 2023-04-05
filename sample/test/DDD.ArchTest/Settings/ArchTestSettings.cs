using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using Assembly = System.Reflection.Assembly;

namespace DDD.ArchTest.Settings;

public partial class ArchTestSettings
{
    protected static readonly Architecture Architecture =
        new ArchLoader().LoadAssemblies(GetAssemblies()).Build();

    private static Assembly[] GetAssemblies()
    {
        return new[]
        {
            Assembly.Load("DDD.UI"),
            Assembly.Load("DDD.Application"),
            Assembly.Load("DDD.Domain"),
            Assembly.Load("DDD.Infrastructure")
        };
    }
}
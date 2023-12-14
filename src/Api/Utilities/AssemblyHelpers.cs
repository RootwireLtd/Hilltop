using System.Reflection;

namespace Rootwire.Hilltop.Api.Utilities;

public static class AssemblyHelpers
{
    private static readonly AssemblyInformationalVersionAttribute _assemblyInformationalVersionAttributes;
    private static string _version;

    static AssemblyHelpers()
    {
        _assemblyInformationalVersionAttributes = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>();
    }

    public static string GetVersion()
    {
        if (string.IsNullOrWhiteSpace(_version))
        {
            _version = _assemblyInformationalVersionAttributes.InformationalVersion;
        }

        return _version;
    }
}
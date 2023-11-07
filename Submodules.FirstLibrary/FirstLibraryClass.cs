using System.Runtime.CompilerServices;

namespace Submodules.FirstLibrary;

public class FirstLibraryClass
{
    private static string initiMessage = null!;
#pragma warning disable CA2255
    [ModuleInitializer]
#pragma warning restore CA2255
    internal static void M1()
    {
        initiMessage = "Test";
        Console.WriteLine($"{nameof(FirstLibrary)}:{nameof(FirstLibraryClass)} initialized with {initiMessage}!");
    }

    public static string GetMessage() => 
        $"""
        {initiMessage} 
        Update 1
        Update 2
        """;
}

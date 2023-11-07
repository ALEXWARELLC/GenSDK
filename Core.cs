using GenSDK.Settings;

namespace GenSDK;

public class Core
{
    internal static GenSettings? _settings;
    public static void Start(GenSettings Settings)
    {
        Console.WriteLine("Starting GenSDK...");
        _settings = Settings;
    }
}

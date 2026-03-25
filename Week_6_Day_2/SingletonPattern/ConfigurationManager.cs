using System;
using System.Collections.Generic;
using System.Text;

public class ConfigurationManager
{
    // Single instance - created only once
    private static ConfigurationManager _instance = null;
    private static readonly object _lock = new object();

    // Configuration data
    public string AppName { get; private set; }
    public string Version { get; private set; }
    public string ConnectionString { get; private set; }

    // Private constructor prevents external instantiation
    private ConfigurationManager()
    {
        AppName = "InventoryApp";
        Version = "1.0.0";
        ConnectionString = "Server=localhost;Database=InventoryDB;Trusted_Connection=True;";
        Console.WriteLine("[ConfigurationManager] Instance created and settings loaded.");
    }

    // GetInstance() ensures only one object exists (thread-safe)
    public static ConfigurationManager GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                    _instance = new ConfigurationManager();
            }
        }
        return _instance;
    }

    public void DisplayConfig()
    {
        Console.WriteLine($"\n--- Application Configuration ---");
        Console.WriteLine($"App Name         : {AppName}");
        Console.WriteLine($"Version          : {Version}");
        Console.WriteLine($"Connection String: {ConnectionString}");
        Console.WriteLine($"---------------------------------\n");
    }
}

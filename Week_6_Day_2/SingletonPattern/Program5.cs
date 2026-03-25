using System;
using System.Collections.Generic;
using System.Text;

class Program5
{
    static void Main()
    {
        ConfigurationManager config1 = ConfigurationManager.GetInstance();
        config1.DisplayConfig();

        ConfigurationManager config2 = ConfigurationManager.GetInstance();
        config2.DisplayConfig();

        // Verify both references point to the same object
        Console.WriteLine($"Same instance? {ReferenceEquals(config1, config2)}");
    }
}

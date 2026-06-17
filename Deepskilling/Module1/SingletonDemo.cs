using System;

public class AppManager
{
    private static AppManager manager;

    private AppManager()
    {
    }

    public static AppManager GetManager()
    {
        if (manager == null)
        {
            manager = new AppManager();
        }

        return manager;
    }

    public void DisplayStatus()
    {
        Console.WriteLine("Hello from Singleton!");
    }
}

class Program
{
    static void Main()
    {
        AppManager primaryManager = AppManager.GetManager();
        AppManager backupManager = AppManager.GetManager();

        primaryManager.DisplayStatus();

        Console.WriteLine(primaryManager == backupManager);
    }
}
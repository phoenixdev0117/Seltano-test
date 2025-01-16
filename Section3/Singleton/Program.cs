using System;

public sealed class Singleton {
    // Create a single instance of Singleton
    private static readonly Singleton instance = new Singleton();

    // Private constructor prevents instantiation from outside
    private Singleton() { }

    public static Singleton Instance {
        get {
            // Provides global access point to the instance
            return instance;
        }
    }

    //Print Message
    public void ShowMessage() {
        Console.WriteLine("Hello from Singleton instance!");
    }
}

class Program {
    static void Main(string[] args) {
        // Accessing the singleton instance and calling a method
        Singleton singletonInstance = Singleton.Instance;
        singletonInstance.ShowMessage();
    }
}
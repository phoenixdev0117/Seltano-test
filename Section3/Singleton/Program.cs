using System;

public sealed class Singleton {
    private static readonly Singleton instance = new Singleton();

    // Private constructor prevents instantiation from other classes
    private Singleton() { }

    public static Singleton Instance {
        get {
            return instance;
        }
    }

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
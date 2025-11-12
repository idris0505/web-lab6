using System;

public class Car
{
    private string _make;
    private string _model;
    private string _colour;
    private readonly string _regNumber;

    public Car(string make, string model, string colour, string regNumber)
    {
        Make = make;
        _model = model;
        _colour = colour;
        _regNumber = regNumber ?? throw new ArgumentNullException(nameof(regNumber));
    }

    public string Registration => _regNumber;

    public string Make
    {
        get => _make;
        set => _make = string.IsNullOrWhiteSpace(value)
                      ? throw new ArgumentException("Make cannot be empty")
                      : value;
    }

    public string Model { get => _model; set => _model = value; }
    public string Colour { get => _colour; set => _colour = value; }

    public void PrintInfo()
    {
        Console.WriteLine($"Make: {Make}, Model: {Model}, Colour: {Colour}, Reg: {Registration}");
    }
}

class Program
{
    static void Main()
    {
        Car c = new Car("Toyota", "Camry", "Red", "ABC123");
        c.PrintInfo();

    }
}
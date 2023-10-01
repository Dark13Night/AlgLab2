using System;

class Vehicle
{
    protected double x, y;
    protected double price, speed;
    protected int year;

    public Vehicle(double x, double y, double price, double speed, int year)
    {
        this.x = x;
        this.y = y;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Coordinates: ({0}, {1})", x, y);
        Console.WriteLine("Price: {0}", price);
        Console.WriteLine("Speed: {0}", speed);
        Console.WriteLine("Year: {0}", year);
    }
}

class Plane : Vehicle
{
    private double height;
    private int passengers;

    public Plane(double x, double y, double price, double speed, int year, double height, int passengers)
    : base(x, y, price, speed, year)
    {
        this.height = height;
        this.passengers = passengers;
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Height: {0}", height);
        Console.WriteLine("Passengers: {0}", passengers);
    }
}

class Car : Vehicle
{
    public Car(double x, double y, double price, double speed, int year)
    : base(x, y, price, speed, year)
    {
    }
}

class Ship : Vehicle
{
    private int passengers;
    private string port;

    public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
    : base(x, y, price, speed, year)
    {
        this.passengers = passengers;
        this.port = port;
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Passengers: {0}", passengers);
        Console.WriteLine("Port: {0}", port);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Plane plane = new Plane(100, 200, 1000000, 700, 2020, 10000, 200);
        Console.WriteLine("Plane info:");
        plane.DisplayInfo();

        Car car = new Car(300, 400, 50000, 200, 2018);
        Console.WriteLine("\nCar info:");
        car.DisplayInfo();

        Ship ship = new Ship(500, 600, 2000000, 50, 2015, 1000, "New York");
        Console.WriteLine("\nShip info:");
        ship.DisplayInfo();

        Console.ReadLine();
    }
}

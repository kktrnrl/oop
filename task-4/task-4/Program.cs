using System;

abstract class GeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual void GetInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Coordinates: X={X}, Y={Y}");
        Console.WriteLine($"Description: {Description}");
    }
}

class River : GeographicObject
{
    public double FlowSpeed { get; set; }
    public double TotalLength { get; set; }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Flow Speed: {FlowSpeed} cm/s");
        Console.WriteLine($"Total Length: {TotalLength} cm");
    }
}

class Mountain : GeographicObject
{
    public double HighestPoint { get; set; }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Highest Point: {HighestPoint} meters");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string symbol = new string('-', 100);

        Console.WriteLine(symbol);
        Console.WriteLine("Enter details for a River:");
        River river = GetRiverDetails();

        Console.WriteLine("\nEnter details for a Mountain:");
        Mountain mountain = GetMountainDetails();
        Console.WriteLine(symbol);

        Console.WriteLine($"\n{symbol}");
        Console.WriteLine("River Details:");
        river.GetInfo();

        Console.WriteLine("\nMountain Details:");
        mountain.GetInfo();
        Console.WriteLine(symbol);
    }

    static River GetRiverDetails()
    {
        River river = new River();

        Console.Write("Name: ");
        river.Name = Console.ReadLine();

        Console.Write("X Coordinate: ");
        if (double.TryParse(Console.ReadLine(), out double x))
        {
            river.X = x;
        }

        Console.Write("Y Coordinate: ");
        if (double.TryParse(Console.ReadLine(), out double y))
        {
            river.Y = y;
        }

        Console.Write("Description: ");
        river.Description = Console.ReadLine();

        Console.Write("Flow Speed (cm/s): ");
        if (double.TryParse(Console.ReadLine(), out double flowSpeed))
        {
            river.FlowSpeed = flowSpeed;
        }

        Console.Write("Total Length (cm): ");
        if (double.TryParse(Console.ReadLine(), out double totalLength))
        {
            river.TotalLength = totalLength;
        }

        return river;
    }

    static Mountain GetMountainDetails()
    {
        Mountain mountain = new Mountain();

        Console.Write("Name: ");
        mountain.Name = Console.ReadLine();

        Console.Write("X Coordinate: ");
        if (double.TryParse(Console.ReadLine(), out double x))
        {
            mountain.X = x;
        }

        Console.Write("Y Coordinate: ");
        if (double.TryParse(Console.ReadLine(), out double y))
        {
            mountain.Y = y;
        }

        Console.Write("Description: ");
        mountain.Description = Console.ReadLine();

        Console.Write("Highest Point (meters): ");
        if (double.TryParse(Console.ReadLine(), out double highestPoint))
        {
            mountain.HighestPoint = highestPoint;
        }

        return mountain;
    }
}

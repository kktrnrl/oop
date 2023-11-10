interface IGeographicObject
{
    void GetInfo();
}

class River : IGeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double FlowSpeed { get; set; }
    public double TotalLength { get; set; }

    public void GetInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Coordinates: X={X}, Y={Y}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Flow Speed: {FlowSpeed} cm/s");
        Console.WriteLine($"Total Length: {TotalLength} cm");
    }
}

class Mountain : IGeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double HighestPoint { get; set; }

    public void GetInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Coordinates: X={X}, Y={Y}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Highest Point: {HighestPoint} meters");
    }
}

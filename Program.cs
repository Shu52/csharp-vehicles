using System;
using System.Linq;
using System.Collections.Generic;


public interface IVehicle
{
    int PassengerCapacity { get; set; }
    double EngineVolume { get; set; }
    void Start();
    void Stop();

}

public class JetSki : IVehicle, IWater
{

    public int PassengerCapacity { get; set; } = 2;
    public double EngineVolume { get; set; } = 3.00;
    public double MaxWaterSpeed { get; set; } = 90;

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }


    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class Speedboat : IVehicle, IWater
{

    public int PassengerCapacity { get; set; } = 4;
    public double EngineVolume { get; set; } = 5.7;
    public double MaxWaterSpeed { get; set; } = 70;

    public void Drive()
    {
        Console.WriteLine("The Speedboat rips through the water");
    }


    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class Yacht : IVehicle, IWater
{

    public int PassengerCapacity { get; set; } = 10;
    public double EngineVolume { get; set; } = 9.7;
    public double MaxWaterSpeed { get; set; } = 60;

    public void Drive()
    {
        Console.WriteLine("The yacht leisurely floats on the ocean");
    }


    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Motorcycle : IVehicle, ILand
{
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; } = 1;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;


    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class StationWagon : IVehicle, ILand
{
    public int Wheels { get; set; } = 4;
    public int Doors { get; set; } = 4;
    public int PassengerCapacity { get; set; } = 6;
    public string TransmissionType { get; set; } = "Automatic";
    public double EngineVolume { get; set; } = 2.2;
    public double MaxLandSpeed { get; set; } = 77;


    public void Drive()
    {
        Console.WriteLine("The station wagon putters down the street");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
public class Lancer : IVehicle, ILand
{
    public int Wheels { get; set; } = 4;
    public int Doors { get; set; } = 4;
    public int PassengerCapacity { get; set; } = 5;
    public string TransmissionType { get; set; } = "Automatic";
    public double EngineVolume { get; set; } = 3.2;
    public double MaxLandSpeed { get; set; } = 130;


    public void Drive()
    {
        Console.WriteLine("The lancer hugs the corners");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Cessna : IVehicle, IAir, IWheelsandDoors
{
    public int Wheels { get; set; } = 3;
    public int Doors { get; set; } = 3;
    public int PassengerCapacity { get; set; } = 113;
    public bool Winged { get; set; } = true;
    public double EngineVolume { get; set; } = 31.1;
    public double MaxAirSpeed { get; set; } = 309.0;

    public void Fly()
    {
        Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }

}
public class C5 : IVehicle, IAir, IWheelsandDoors
{
    public int Wheels { get; set; } = 28;
    public int Doors { get; set; } = 6;
    public int PassengerCapacity { get; set; } = 200;
    public bool Winged { get; set; } = true;
    public double EngineVolume { get; set; } = 350.5;
    public double MaxAirSpeed { get; set; } = 450.0;

    public void Fly()
    {
        Console.WriteLine("The Galaxy punches through the clouds");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }

}
public class Boieng747 : IVehicle, IAir, IWheelsandDoors
{
    public int Wheels { get; set; } = 16;
    public int Doors { get; set; } = 6;
    public int PassengerCapacity { get; set; } = 416;
    public bool Winged { get; set; } = true;
    public double EngineVolume { get; set; } = 250.1;
    public double MaxAirSpeed { get; set; } = 570.0;

    public void Fly()
    {
        Console.WriteLine("The 747 takes the tourists home");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }

}


public class Program
{

    public static void Main()
    {

        // Build a collection of all vehicles that fly
        List<IAir> aircrafts = new List<IAir>();
        C5 galaxy = new C5();
        aircrafts.Add(galaxy);
        Cessna bird = new Cessna();
        aircrafts.Add(bird);
        Boieng747 southwest = new Boieng747();
        aircrafts.Add(southwest);
        // With a single `foreach`, have each vehicle Fly()
        foreach (var air in aircrafts)
        {
            air.Fly();
        }

        // Build a collection of all vehicles that operate on roads
        List<ILand> rovers = new List<ILand>();
        Motorcycle motorcycle = new Motorcycle();
        StationWagon leBaron = new StationWagon();
        Lancer lancer = new Lancer();
        rovers.Add(motorcycle);
        rovers.Add(leBaron);
        rovers.Add(lancer);
        // With a single `foreach`, have each road vehicle Drive()
        foreach (var rover in rovers)
        {
            rover.Drive();
        }

        // Build a collection of all vehicles that operate on water
            List<IWater> floats = new List<IWater>();
            JetSki yamaha = new JetSki();
            Speedboat smuggler = new Speedboat();
            Yacht money = new Yacht();
            floats.Add(yamaha);
            floats.Add(smuggler);
            floats.Add(money);
        // With a single `foreach`, have each water vehicle Drive()
        foreach (var floaties in floats)
        {
            floaties.Drive();
        }
    }

}
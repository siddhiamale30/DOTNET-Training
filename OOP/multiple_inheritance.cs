using System;

public class Device
{
    public string name;
    public Device(string name)
    {
        this.name = name;
    }

    public void ReportStatus()
    {
        Console.WriteLine(name+" is working properly");
    }
}

public class Thermo
{
    public int temp;
    public Thermo(int t){
        this.temp=t;
    }
    public void ShowTemperature()
    {
        Console.WriteLine("Temperature is :"+temp);
    }
}

public class SmartLight : Device,Thermo
{

    public void TurnOn()
    {
        Console.WriteLine($"{name} is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine($"{name} is turned off.");
    }
}

class multiple{
    public static void Main(string[] args){
        
    }
}
using System;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Managers;
using TecNM.Practica1.Core.Services;

namespace TecNM.Practica1.App;

public static class Program{
    //Peso en Marte= (Peso en la Tierra/9.81m/s2) * 3.711m/s2
    public static void Main(string[] args){        
        float weightEarth = 0;

        System.Console.Write("Please enter the weight in Earth-> ");
        Single.TryParse(System.Console.ReadLine(), out weightEarth);

        var person = new Person{ WeightEarth = weightEarth };

        var service = new WeightService();
        var manager = new WeightManager(service);

        Weight weight = manager.GetWeight(person);

        System.Console.WriteLine($"The result is {weight.WeightMars}");
    }
}
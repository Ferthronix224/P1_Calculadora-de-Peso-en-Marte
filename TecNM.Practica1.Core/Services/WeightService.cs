using TecNM.Practica1.Core.Services.Interfaces;
using TecNM.Practica1.Core.Entities;

namespace TecNM.Practica1.Core.Services;

public class WeightService : IWeightService
{
    public Weight ProcessWeight(Person person)
    {
        var weight = new Weight();
        weight.WeightMars = ((float)((person.WeightEarth / 9.81) * 3.711));
        return weight;
    }
}
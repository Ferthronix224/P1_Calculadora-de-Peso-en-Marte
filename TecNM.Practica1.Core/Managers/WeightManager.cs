using TecNM.Practica1.Core.Managers.Interfaces;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Managers;

public class WeightManager : IWeightManager
{
    private readonly IWeightService _service;

    public WeightManager(IWeightService service)
    {
        _service = service;
    }

    public Weight GetWeight(Person person)
    {
        return _service.ProcessWeight(person);
    }
}
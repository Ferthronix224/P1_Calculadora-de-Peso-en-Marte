using TecNM.Practica1.Core.Entities;

namespace TecNM.Practica1.Core.Managers.Interfaces;

public interface IWeightManager
{
    Weight GetWeight(Person person);
}
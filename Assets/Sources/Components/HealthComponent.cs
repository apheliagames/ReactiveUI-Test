using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game][Unique][Event(false)]
public class HealthComponent : IComponent
{
    public float value;
}
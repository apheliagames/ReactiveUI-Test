using Entitas;

public class InitHealthSystem : IInitializeSystem
{
    readonly Contexts _contexts;

    public InitHealthSystem(Contexts contexts)
    {
        this._contexts = contexts;
    }
    public void Initialize()
    {
        _contexts.game.SetHealth(100);        
    }
}
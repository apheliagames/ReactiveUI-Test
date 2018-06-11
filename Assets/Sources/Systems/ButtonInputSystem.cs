using System.Collections.Generic;
using Entitas;

public sealed class ButtonInputSystem : ReactiveSystem<InputEntity>
{
    GameContext game;

    public ButtonInputSystem(Contexts contexts) : base(contexts.input)
    {
        game = contexts.game;
    }
    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
    {
        return context.CreateCollector(InputMatcher.Button);
    }
    protected override bool Filter(InputEntity entity)
    {
        return entity.isButton;
    }

    protected override void Execute(List<InputEntity> entities)
    {
        game.ReplaceHealth(game.health.value + 1);
        foreach (var e in entities)
        {
            e.Destroy();
        }
    }
}

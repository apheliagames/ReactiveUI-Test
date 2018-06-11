public sealed class GameSystems : Feature
{

    public GameSystems(Contexts contexts)
    {

        //Init
        Add(new InitHealthSystem(contexts));


        // Input
        Add(new ButtonInputSystem(contexts));

        //Events
        Add(new GameEventSystems(contexts));

    }
}

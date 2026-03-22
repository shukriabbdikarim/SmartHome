public class EcoMode : IModeStrategy
{
    public bool CanRun(string action)
    {
        return action != "TurnOn";
    }
}
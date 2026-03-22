public class TurnOnCommand : ICommand
{
    private Lamp lamp;

    public TurnOnCommand(Lamp lamp)
    {
        this.lamp = lamp;
    }

    public void Execute()
    {
        lamp.TurnOn();
    }

    public void Undo()
    {
        lamp.TurnOff();
    }
}
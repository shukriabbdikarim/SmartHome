class Program
{
    static void Main()
    {
        var hub = new SmartHomeFacade();

        var lamp = new Lamp("Living Room Lamp");

        lamp.AddObserver(new Dashboard());
        lamp.AddObserver(new Audit());
        lamp.AddObserver(new LoggerObserver());

        hub.SetMode(new NormalMode());

        hub.MorningRoutine(lamp);

        hub.RunCommand(new TurnOnCommand(lamp), "TurnOn");

        hub.SetMode(new EcoMode());

        hub.RunCommand(new TurnOnCommand(lamp), "TurnOn");

        hub.Undo();

        hub.Replay();
    }
}
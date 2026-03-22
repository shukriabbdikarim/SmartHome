public class SmartHomeFacade
{
    private CommandInvoker invoker = new();
    private IModeStrategy mode = new NormalMode();

    public void SetMode(IModeStrategy newMode)
    {
        mode = newMode;
        Console.WriteLine("Mode changed");
    }

    public void RunCommand(ICommand cmd, string action)
    {
        if (!mode.CanRun(action))
        {
            Console.WriteLine("Blocked by mode!");
            return;
        }

        invoker.Run(cmd);
        Logger.Instance.Log($"Ran {action}");
    }

    public void Undo()
    {
        invoker.Undo();
    }

    public void Replay()
    {
        invoker.Replay();
    }

    public void MorningRoutine(Lamp lamp)
    {
        Console.WriteLine("Morning routine...");
        RunCommand(new TurnOnCommand(lamp), "TurnOn");
    }
}
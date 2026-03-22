public class CommandInvoker
{
    private Stack<ICommand> history = new();

    public void Run(ICommand cmd)
    {
        cmd.Execute();
        history.Push(cmd);
    }

    public void Undo()
    {
        if (history.Count > 0)
        {
            var cmd = history.Pop();
            cmd.Undo();
        }
    }

    public void Replay()
    {
        Console.WriteLine("Replaying last 5...");

        foreach (var cmd in history.TakeLast(5))
            cmd.Execute();
    }
}
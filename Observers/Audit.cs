public class Audit : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"[Audit] {message}");
    }
}
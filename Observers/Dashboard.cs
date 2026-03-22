public class Dashboard : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"[Dashboard] {message}");
    }
}
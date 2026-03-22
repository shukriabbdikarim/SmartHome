public class Lamp
{
    public string Name { get; }

    private List<IObserver> observers = new();

    public Lamp(string name)
    {
        Name = name;
    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    private void Notify(string message)
    {
        foreach (var o in observers)
            o.Update(message);
    }

    public void TurnOn()
    {
        Notify($"{Name} is ON");
    }

    public void TurnOff()
    {
        Notify($"{Name} is OFF");
    }
}
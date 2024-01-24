namespace Test_pet2;

public abstract class Pet
{
    public string Name { get; }
    public string Description { get; protected set; }
    public string Trick { get; protected set; }
    public string Noise { get; protected set; }
    
    //Constructor with protected access, designed for use by subclasses
    protected Pet(string name)
    {
        Name = name;
    }
    
    // Virtual allows for method to be overridden, else shows as standard
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}\nDescription: {Description}\n" +
                          $"Trick: {Trick}\nNoise: {Noise}");
    }
    // abstract method forces subclasses to implement method
    // adding and abstract method to preform trick
    public abstract void PerformTrick();
}
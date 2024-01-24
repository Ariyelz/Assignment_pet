namespace Test_pet2;

public class Pet
{

    public string Name { get; }
    public string Description { get; protected set; }
    public string Trick { get; protected set; }
    public string Noise { get; protected set; }

    public Pet(string name)
    {
        Name = name;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}\nDescription: {Description}\n" +
                          $"Trick: {Trick}\nNoise: {Noise}");
    }
    
}
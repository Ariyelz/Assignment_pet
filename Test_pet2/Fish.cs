namespace Test_pet2;

public class Fish : Pet
{
    public Fish(string name) : base(name)
    {
        Description = "Lives near a pineapple under the sea";
        Trick = "Blows Bubbles";
        Noise = "Blub";
    }
    //Implementing abstract method to preform trick
    public override void PerformTrick()
    {
        Console.WriteLine($"Fish {Name} performs trick: {Trick}");
    }
}
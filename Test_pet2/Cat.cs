namespace Test_pet2;

public class Cat : Pet
{
    public Cat(string name) : base(name)
    {
        Description = "A fluffy creature with ambitions of ruling the world";
        Trick = "Cuteness overload";
        Noise = "Meow";
    }
    //Implementing abstract method to preform trick
    public override void PerformTrick()
    {
        Console.WriteLine($"Cat {Name} preforms trick: {Trick}");
    }
}
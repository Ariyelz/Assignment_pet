namespace Test_pet2;

public class Dog : Pet
{
    public Dog(string name) : base(name)
    {
        Description = "Probably a better companion than any human";
        Trick = "Puppy eyes";
        Noise = "Woof";
    }
    //Implementing abstract method to preform trick
    public override void PerformTrick()
    {
        Console.WriteLine($"Dog {Name} performs trick: {Trick}");
    }
}
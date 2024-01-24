namespace Test_pet2;

public class Cat : Pet
{
    public Cat(string name) : base(name)
    {
        Description = "A fluffy creature with ambitions of ruling the world";
        Trick = "Cuteness overload";
        Noise = "Meow";
    }
}
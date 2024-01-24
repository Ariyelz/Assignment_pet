namespace Test_pet2;

class Program
{
    static void Main()
    {
        List<Pet> myPets = new List<Pet>();
        
        //Creating pets (objects)
        Pet fish1 = new Fish("Lady Vashj");
        Pet cat1 = new Cat("Mephisto");
        Pet dog1 = new Dog("Fenrir");
        
        //adding pets to the collection(list?)
        myPets.Add(fish1);
        myPets.Add(cat1);
        myPets.Add(dog1);
        
        //iterating through the collection(list)
        foreach (Pet pet in myPets)
        {
            pet.ShowInfo();
            pet.PerformTrick(); // using abstract method
            Console.WriteLine();
        }
    }
}
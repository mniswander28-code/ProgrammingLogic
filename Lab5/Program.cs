using System;
    //step 1
class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}
    //step 2
class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}
    //step 3
class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        Animal myCat = new Cat();
        Animal myDog = new Dog();

        myAnimal.animalSound();
        myCat.animalSound();
        myDog.animalSound();
    }
}
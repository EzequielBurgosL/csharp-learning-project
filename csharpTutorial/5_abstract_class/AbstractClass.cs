namespace oopTutorial.AbstractClass
{
    abstract class Animal
    {
        abstract public string MakeSound();
    };

    class Dog : Animal
    {
        public override string MakeSound() => "Woof!";
    };

    class Cat : Animal
    {
        public override string MakeSound() => "Meow!";
    };
}

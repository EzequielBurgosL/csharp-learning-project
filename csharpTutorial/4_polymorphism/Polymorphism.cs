namespace oopTutorial.Polymorphism
{
    class Person
    {
        public virtual string Greet()
        {
            return $"Hi! Greetings from Person class.";
        }
    };

    class Student : Person
    {
        public override string Greet()
        {
            return $"Hi! Greetings from Student class.";
        }
    };
}

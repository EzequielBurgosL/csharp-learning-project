namespace oopTutorial.exercise1
{
    class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void Greet()
        {
            Console.WriteLine($"Hi! My name is {this.Name} and I am {this.Age} years old.");
        }
    };
}

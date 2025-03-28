namespace oopTutorial.exercise3
{
    abstract class Person
    {
        protected string Name { get; }
        protected int Age { get; }

        public Person(string name, int age)
        {
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(age), "Age cannot be negative.");
            }

            Name = name;
            Age = age;
        }

        public abstract void Greet();
    };

    class Student : Person
    {
        private string Course;

        public Student(string name, int age, string course): base(name, age)
        {
             this.Course = course;
        }

        public override void Greet()
        {
            Console.WriteLine($"Hi! My name is {this.Name} and I'm a student at {this.Course}");
        }
    };
}

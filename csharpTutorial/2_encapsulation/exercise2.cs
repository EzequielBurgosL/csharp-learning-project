namespace oopTutorial.exercise2
{
    class PersonPrivateProps
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(age), "Age cannot be negative.");
                }
                else
                {
                    age = value;
                }

            }
        }

        public string Greet()
        {
            return $"Hi! My name is {this.Name} and I am {this.Age} years old.";
        }
    };
}

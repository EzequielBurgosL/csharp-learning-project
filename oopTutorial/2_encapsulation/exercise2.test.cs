using oopTutorial.exercise2;

namespace oopTutorial.Exercise2.Tests
{
    public class PersonTest
    {
        [Fact]
        public void Setter_ShouldNotSetNegativeAge()
        {
            var person = new PersonPrivateProps();
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            person.Age = -5;

            var expectedOutput = "Age can't be negative\n";
            Assert.Equal(expectedOutput, consoleOutput.ToString());
        }

        [Fact]
        public void Greet_ShouldPrintCorrectMessage()
        {
            var person = new PersonPrivateProps();
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            person.Age = 5;
            person.Name = "Bob";

            person.Greet();

            var expectedOutput = "Hi! My name is Bob and I am 5 years old.\n";
            Assert.Equal(expectedOutput, consoleOutput.ToString());
        }
    }
}

using oopTutorial.exercise1;

namespace oopTutorial.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Constructor_ShouldInitializeNameAndAge()
        {
            // Arrange
            var person = new Person("Alice", 30);

            // Act & Assert
            Assert.Equal("Alice", person.Name);
            Assert.Equal(30, person.Age);
        }

        [Fact]
        public void Greet_ShouldPrintCorrectMessage()
        {
            // Arrange
            var person = new Person("Bob", 25);
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            person.Greet();

            // Assert
            var expectedOutput = "Hi! My name is Bob and I am 25 years old.\n";
            Assert.Equal(expectedOutput, consoleOutput.ToString());
        }
    }
}

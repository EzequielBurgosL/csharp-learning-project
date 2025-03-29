using oopTutorial.exercise3;

namespace oopTutorial.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Constructor_ShouldThrowException_WhenAgeIsNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Student("Charlie", -5, "Physics"));
        }

        [Fact]
        public void Greet_ShouldPrintCorrectMessage()
        {
            var student = new Student("Bob", 22, "Mathematics");
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            student.Greet();

            var expectedOutput = "Hi! My name is Bob and I'm a student at Mathematics\n";
            Assert.Equal(expectedOutput, consoleOutput.ToString());
        }
    }
}

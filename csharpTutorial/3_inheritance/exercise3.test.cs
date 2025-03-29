using oopTutorial.exercise3;

namespace oopTutorial.exercise3.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Constructor_ShouldThrowException_WhenAgeIsNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Student("Charlie", -5, "Physics"));
        }

        [Fact]
        public void Greet_ShouldPrintCorretMessage()
        {
            var student = new Student("Bob", 22, "Mathematics");
            var expectedOutput = "Hi! My name is Bob and I'm a student at Mathematics";

            Assert.Equal(expectedOutput, student.Greet());
        }
    }
}

using oopTutorial.exercise2;

namespace oopTutorial.Exercise2.Tests
{
    public class PersonTest
    {
        [Fact]
        public void Setter_ShouldThrowException_WhenAgeIsNegative()
        {
            var student = new PersonPrivateProps();

            Assert.Throws<ArgumentOutOfRangeException>(() => student.Age = -1);
        }

        [Fact]
        public void Greet_ShouldPrintCorrectMessage()
        {
            var person = new PersonPrivateProps
            {
                Age = 5,
                Name = "Bob"
            };

            Assert.Equal("Hi! My name is Bob and I am 5 years old.", person.Greet());
        }
    }
}

using oopTutorial.Polymorphism;

namespace oopTutorial.Tests.Polymorphism
{
    public class PersonTest
    {
        [Fact]
        public void Polymorphism_Greet_CallsCorrectMethod()
        {
            Person person = new Person();
            Person student = new Student();
            Person teacher = new Teacher();

            Assert.Equal("Hi! Greetings from Person class.", person.Greet());
            Assert.Equal("Hi! Greetings from Student class.", student.Greet());
            Assert.Equal("Hi! Greetings from Teacher class.", teacher.Greet());
        }
    }
}

using oopTutorial.Polymorphism;

namespace oopTutorial.Tests.Polymorphism
{
    public class PersonTest
    {
        [Fact]
        public void Greet_ShouldGreetFromParentClass()
        {
            Person person = new Person();
            Assert.Equal("Hi! Greetings from Person class.", person.Greet());
        }
    }
}

namespace oopTutorial.AbstractClass.Test
{
    public class AnimalTests
    {
        [Fact]
        public void Dog_Should_Make_Woof_Sound()
        {
            var dog = new Dog();
            Assert.Equal("Woof!", dog.MakeSound());
        }

        [Fact]
        public void Cat_Should_Make_Meow_Sound()
        {
            var cat = new Cat();
            Assert.Equal("Meow!", cat.MakeSound());
        }
    }
}

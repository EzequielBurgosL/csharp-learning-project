using oopTutorial.exercise1;
using oopTutorial.exercise2;

var person = new Person("John", 25);
person.Greet();

var personPrivateProps = new PersonPrivateProps();
personPrivateProps.Name = "Jane";
personPrivateProps.Age = -1;
personPrivateProps.Age = 30;
personPrivateProps.Greet();
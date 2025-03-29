## **Polymorphism in OOP: A Deeper Dive**

Polymorphism is one of the core principles of **Object-Oriented Programming (OOP)**, allowing different objects to respond to the same method in different ways. The goal of polymorphism is to allow a single method or function to work with objects of different types, making the code more flexible, extensible, and maintainable.

Polymorphism, in this case, is achieved through method overriding (`virtual` and `override` keywords) and dynamic method dispatch. The key benefit of polymorphism is that the code can work with objects of different types (e.g., `Person`, `Student`, `Teacher`) while calling the appropriate method based on the object's actual type. This makes your code more flexible, extensible, and easier to maintain.

## **Method Overriding vs Overloading**
- This example highlights **method overriding**, where the derived class provides its own version of the base class method.
- Unlike **overloading** (same method name with different parameters), overriding maintains the same signature but changes behavior.

The implementation applies several key **Object-Oriented Programming (OOP)** principles:

### 1. **Abstraction**
- The `IVehicle` interface defines a common contract (`Accelerate()`) for all vehicle types. This hides implementation details while exposing only essential functionality, ensuring that other parts of the code interact with vehicles without worrying about their internal mechanics.

### 2. **Encapsulation**
- Each class (`Car`, `Motorcycle`, `Truck`) encapsulates its own `speed` property and logic within the class. This keeps the internal state protected from external interference, promoting data integrity.

### 3. **Inheritance**
- Each vehicle class implements the `IVehicle` interface, which acts as a base contract. While this isn't classical inheritance (like `class Car : Vehicle`), implementing interfaces is a form of inheritance that promotes shared behavior across different types.

### 4. **Polymorphism**
- The `List<IVehicle>` collection demonstrates polymorphism. The test iterates over different vehicle types (`Car`, `Motorcycle`, `Truck`) and calls `Accelerate()` without knowing the specific class type at compile time. This allows different implementations to respond to the same method call in their unique way.

### 5. **Open/Closed Principle (SOLID)**
- The code is **open for extension** but **closed for modification**. Adding a new `vehicle` class didn't require changing existing vehicle logic or modifying the test's core structure.

### 6. **Interface Segregation Principle (SOLID)**
- The `IVehicle` interface is focused on a single responsibility — defining the `Accelerate()` method. This ensures that implementing classes are not burdened with irrelevant methods.

### 7. **Dependency Inversion Principle (SOLID)**
- The test depends on the `IVehicle` interface rather than concrete classes. This improves flexibility, making it easier to introduce new vehicle types without altering dependent code.

This design follows OOP best practices, making it scalable, maintainable, and easy to extend.

## **Key Difference between abstract classes and interfaces (exercise 5 VS exercise 6)**
**Abstract Class (`Animal`)** is ideal when classes share common behavior or structure.
**Interface (`IVehicle`)** is better when multiple unrelated classes need to implement the same functionality.

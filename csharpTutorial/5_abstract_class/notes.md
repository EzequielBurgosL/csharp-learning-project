# OOP Principles Animal Implementation

## 1. **Abstraction**
- The `Animal` class is an **abstract class** that defines a common method `MakeSound()` for all derived classes to implement.
- This abstracts the concept of "making a sound," allowing each subclass to provide its own specific implementation.

## 2. **Encapsulation**
- Each class (`Dog`, `Cat`) encapsulates its unique sound logic within the `MakeSound()` method.
- Additionally, the new `sleep()` method is implemented directly in the `Animal` class, ensuring shared functionality is kept in one place — improving code reuse.

## 3. **Inheritance**
- `Dog` and `Cat` **inherit** from the `Animal` class, gaining access to the shared `sleep()` method while providing unique implementations for `MakeSound()`.

**Example Code:**
```csharp
Animal dog = new Dog();
Animal cat = new Cat();

Console.WriteLine(dog.MakeSound()); // Outputs: Woof!
Console.WriteLine(cat.MakeSound()); // Outputs: Meow!
Console.WriteLine(dog.sleep());     // Outputs: Zzzz!
Console.WriteLine(cat.sleep());     // Outputs: Zzzz!
```

## 4. **Polymorphism**
- Both `Dog` and `Cat` override the `MakeSound()` method.  
- Since they are treated as `Animal` types, **runtime polymorphism** ensures the correct method is called depending on the actual object type.

## 5. **Open/Closed Principle (SOLID)**
- The code remains **open for extension** — adding a new `Bird` class would only require implementing `MakeSound()`.
- It’s **closed for modification** — no changes are required in the `Animal` class or existing code to support new animal types.

## 6. **Code Reuse through Shared Logic**
- The `sleep()` method is implemented in the `Animal` class, demonstrating effective code reuse.  
- All animal types automatically inherit this functionality, reducing duplication and improving maintainability.
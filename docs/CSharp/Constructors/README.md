# Constructors 🏗️

## Points to Remember

- Constructors are methods called when creating instances of classes or structs, allowing setting default values and facilitating flexible, readable code.
- They can be used to set initial values for the object's fields.
- Constructors are named the same as the class and do not return values.
- [Expression body definitions]([https://](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members)) can be used for concise constructors.
- Constructors can be defined explicitly with custom logic and parameters.
- User defined constructors can be public, private, or have different access modifiers.
- A method with the same name as a class is not allowed in C#.
- Types of constructors include default, parameterless, parameterized, static, and copy constructors.
  - *Default constructor* initializes class instances with default values. Numeric filed are set to zero, while string and object fields are set to null.
  - *Parameterless constructor* do not have any parameters.
  - *Parameterized* constructors have parameters that are used to initialize the fields.
  - *Static constructor* is called when the class is first loaded. Only one static constructor can exist within a class. They are not allowed to have parameter.
  - *Copy constructor* creates objects by copying values from another object. They are useful for initializing new instances with existing values.

**Check the related demo applications:**

- [ConstructorsDemo1](https://github.com/cmkaya/dotnet-practical-guide/tree/main/demos/CSharpDemoApps/ConstructorsDemo1)
- [ConstructorsDemo2](https://github.com/cmkaya/dotnet-practical-guide/tree/main/demos/CSharpDemoApps/ConstructorsDemo2)

**Learn more:**

- [Microsoft documentation](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors)
- [Programiz](https://www.programiz.com/csharp-programming/constructors)

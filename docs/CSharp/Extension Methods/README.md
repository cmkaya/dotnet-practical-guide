# Extension Methods

Extension methods in C# allow you to add new methods to a class without modifying its source code.

## Points to Remember

- Extension methods allow adding functionality to existing classes, even those not under your control.
- To create an extension method, create a static class and a static method within it.
- Use the `this` keyword before the first parameter to specify the type you're extending.
- They are static methods but are called using instance method syntax.
- Extension methods will not be called if they have the same signature as a method defined in the type.
- Managing namespaces is essential when working with extension methods, ensuring they are in scope for use.
- When using extension methods for a given type, be aware of the risk of breaking if the type's implementation changes.
- Extension methods enable customization and enhancement of existing types, making them a valuable tool in C# development.
- These methods make code more readable and can be useful for third-party library integration.
- Many LINQ standard query operators are implemented as extension methods. These methods enhance existing enumerable types.


**Check the related demo applications:**

- [ExtensionMethodsDemo1](https://github.com/cmkaya/dotnet-practical-guide/tree/main/demos/CSharpDemoApps/ExtensionMethodsDemo1)
- [ExtensionMethodsDemo2](https://github.com/cmkaya/dotnet-practical-guide/tree/main/demos/CSharpDemoApps/ExtensionMethodsDemo2)

**Learn more:**

- [Microsoft documentation](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)
- [dotnettutorials](https://dotnettutorials.net/lesson/extension-methods-csharp/?expand_article=1)
- [IAmTimCorey - Youtube Channel](https://youtu.be/C_1DzspLy4Y?si=9ND8H0coydBMzV99)
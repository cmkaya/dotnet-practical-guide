# Statics

---

The `static` keyword in C# is used to declare a member that belongs to the type itself rather than to a specific object instance. This means that there is only one copy of the static member, regardless of how many objects of the type are created.

Static members can be fields, methods, properties, operators, events, and constructors. Static classes can also be declared, but they can only contain static members.

Static members are often used to store data that is shared by all objects of a type. For example, a static field could be used to store the number of objects of a type that have been created.

Static methods are often used to perform operations that do not need to be associated with a specific object. For example, a static method could be used to calculate a mathematical formula.

**Here are some of the key points to remember about static members:**

- Static members are shared by all objects of a type.
- Static members can only be accessed using the name of the type.
- Static members are initialized when the type is loaded, not when an object of the type is created.
- Static members cannot be used to modify the state of an object.

**Here are some examples of when to use static members:**

- To store data that is shared by all objects of a type.
- To perform operations that do not need to be associated with a specific object.
- To create utility classes that contain commonly used methods.

**Here are some examples of when not to use static members:**

- To store data that is specific to a particular object.
- To perform operations that need to be associated with a specific object.
- To create classes that are tightly coupled to each other.

**Check the related demo applications:**

- [StaticsDemo1](https://github.com/cmkaya/dotnet-practical-guide/tree/main/demos/CSharpDemoApps/StaticsDemo1)
- [StaticsDemo2](https://github.com/cmkaya/dotnet-practical-guide/tree/main/demos/CSharpDemoApps/StaticsDemo2)

**Learn more:**

- [Microsoft](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static)
- [programiz](https://www.programiz.com/csharp-programming/static-keyword)
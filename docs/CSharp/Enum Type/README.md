# Enum Types in C#

- Enum types define a set of named values.
- They're used for representing limited options or choices.
- Use `[Flags]` attribute when combining multiple enum values as bit flags, allowing efficient bitwise operations.
- Internally stored as integers (int), ensuring efficiency.
- Default index starts from 0.
- Explicitly set byte/ushort values for small option sets.

> Enum types are ideal for representing a concise set of choices in your code, enhancing readability and maintainability.

**Check the related demo applications:**
- [EnumTypeDemo1](https://github.com/cmkaya/dotnet-practical-guide/tree/main/demos/CSharpDemoApps/EnumTypeDemo1)
- [EnumTypeDemo2](https://github.com/cmkaya/dotnet-practical-guide/tree/main/demos/CSharpDemoApps/EnumTypeDemo2)
- [EnumTypeDemo3](https://github.com/cmkaya/dotnet-practical-guide/tree/main/demos/CSharpDemoApps/EnumTypeDemo3)

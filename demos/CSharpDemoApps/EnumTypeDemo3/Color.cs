namespace EnumTypeDemo3;

[Flags]
public enum Color : byte
{
    None = 0b_0000_0000, // int = 0
    GoldenYellow = 0b_0000_0001, // int = 1
    Blue = 0b_0000_0010, // int = 2
    OliveGreen = 0b_0000_0100, // int = 4
    Red = 0b_0000_1000, // int = 8
    Orange = 0b_0001_000 // int = 16
}
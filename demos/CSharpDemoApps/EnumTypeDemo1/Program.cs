using EnumTypeDemo1;

RoadDirection currentDirection = RoadDirection.North;

Console.WriteLine($"You're currently facing: {currentDirection}.");

// Using pattern matching in switch expression
Console.WriteLine(currentDirection switch
{
    RoadDirection.East => "You are heading to east.",
    RoadDirection.South => "You are heading to south.",
    RoadDirection.West => "You are heading to west.",
    _ => "You are heading to north."
});
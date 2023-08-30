using StaticsDemo1;

string? textRadius = RequestData.GetAString("Enter radius for circle: ");
string? textSide = RequestData.GetAString("Enter side for square: ");

double radius = RequestData.GetADouble(textRadius);
double sideSquare = RequestData.GetADouble(textSide);

double resultCircleArea = Circle.CalculateArea(radius);
double resultSquareArea = Square.CalculateArea(sideSquare);
double resultSquarePerimeter = Square.CalculatePerimeter(sideSquare);

Console.WriteLine($"The area of the circle is {resultCircleArea}");
Console.WriteLine($"The area of the square is {resultSquareArea}");
Console.WriteLine($"The perimeter of the square is {resultSquarePerimeter}");
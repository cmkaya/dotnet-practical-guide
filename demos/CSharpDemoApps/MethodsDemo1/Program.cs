using MethodsDemo1;

UserMessages.GreetUser("Eric");
UserMessages.GreetUser("Jack", "Grealish");

Double length = RequestData.GetADouble("What is the length for the rectangle: ");
Double width = RequestData.GetADouble("What is the width for the rectangle: ");

ShapeCalculator shapeCalculator = new();
double rectangleAreaResult = shapeCalculator.CalculateRectangleArea(length, width);

UserMessages.PrintResultMessage(rectangleAreaResult);
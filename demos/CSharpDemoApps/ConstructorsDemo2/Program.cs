using ConstructorsDemo2;

List<Person> employees = new()
{
    new Employee(firstName: "John", lastName: "Smith", dateOfBirth: new DateOnly(1981, 12, 3)),
    new Employee(firstName: "William", lastName: "Platoon", dateOfBirth: new DateOnly(1986, 9, 27))
};

List<Person> students = new()
{
    new Student(firstName: "Oscar", lastName: "Milner", dateOfBirth: new DateOnly(2005, 02, 22)),
    new Student(firstName: "Eleanor", lastName: "Graham", dateOfBirth: new DateOnly(2007, 06, 15)),
    new Student(firstName: "Scarlett", lastName: "White", dateOfBirth: new DateOnly(2006, 11, 12))
};

UserMessages.DisplayPersonInformationMessage(Employee.EmployeeCount, employees);
UserMessages.DisplayPersonInformationMessage(Student.StudentCount, students, false);

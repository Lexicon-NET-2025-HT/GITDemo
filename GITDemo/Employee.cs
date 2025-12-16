namespace GITDemo;

internal record Employee(int Salary, string Name, int Age)  : Person(Name, Age);


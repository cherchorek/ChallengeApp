using ChallengeApp;

var employee = new Employee("Mariusz", "P");
employee.AddGrade(2000);
employee.AddGrade("Adam");
employee.AddGrade(1.6);
employee.AddGrade(99.79);
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

using ChallengeApp;

var employee = new Employee("Mariusz", "P");
//employee.AddGrade(2000);
//employee.AddGrade("Adam");
employee.AddGrade(1.6);
employee.AddGrade(99.79);
employee.AddGrade(2);
employee.AddGrade(9f);
employee.AddGrade(6);
employee.AddGrade(27);


var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWhithForEach();
var statistics2 = employee.GetStatisticsWhithFor();
var statistics3 = employee.GetStatisticsWhithDoWhile();
var statistics4 = employee.GetStatisticsWhithWhile();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine($"Average1: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

Console.WriteLine($"Average2: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine($"Average3: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

Console.WriteLine($"Average4: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");
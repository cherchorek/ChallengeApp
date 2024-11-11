using ChallengeApp;

Employee employee1 = new Employee("Julia", "Nowak", 20);
Employee employee2 = new Employee("Monika", "Janowska", 33);
Employee employee3 = new Employee("Marcin", "Adrzejczak", 44);

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(4);

employee2.AddScore(7);
employee2.AddScore(1);
employee2.AddScore(3);
employee2.AddScore(2);
employee2.AddScore(3);

employee3.AddScore(8);
employee3.AddScore(2);
employee3.AddScore(5);
employee3.AddScore(2);
employee3.AddScore(5);

List<Employee> employeesList = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
string[] record = new string[4];

foreach (var employee in employeesList)
{
    if (employee.Result > maxResult)
    {
        //employeeWithMaxResult = employee.Name;
        record[0] = "Name: " + employee.Name;
        record[1] = "Last Name: " + employee.LastName;
        record[2] = "Age: " + employee.Age;
        record[3] = "Wynik: " + employee.Result.ToString();
    }
}

foreach (var rec in record)
{
    Console.WriteLine(rec);
}
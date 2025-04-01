namespace Personalregister;

internal class Employee
{
    internal string Name;
    internal int Salary;

    public Employee(string name, int salary)
    {       
        Name = name;
        Salary = salary;
    }

    public Employee()
    {
    }

    internal List<Employee> Employees = [];
}

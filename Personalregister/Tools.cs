using System.Text.RegularExpressions;

namespace Personalregister;


internal class Tools : Employee
{
    private static readonly Employee employee = new();    
    internal string CatchMessage = "\nKlicka på valfri tangent för att försöka igen";

    public Tools()
    {
    }
    internal int GetAmountOfEmployeesToRegister()
    {
        int amountOfEmployee = 0;

        while (amountOfEmployee <= 0)
        {
            try
            {
                Console.Write("Ange hur många anställda som du vill lägga till: ");
                amountOfEmployee = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

            catch
            {
                Console.WriteLine("Var vänlig och fyll en siffra högre än 0");
                Console.Clear();
            }
        }

        return amountOfEmployee;
    }

    internal Employee Register(int employeeNumber)
    {
        Employee employee = new();
        string? name = null;
        int salary = 0;
        string validSymobols = @"^(?:(?!\b(?:AND|O[RK]|NOT)\b)[\wåäöÅÄÖ.])*$";
        bool nameIsValid = false;
        bool salaryIsGreaterThanZero = false;
        employeeNumber++;
        // Registerar namn

        while (!nameIsValid)
        {
            try
            {
                if (employeeNumber - 1 == 0) 
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Personal " + employeeNumber);
                }

                else
                {      
                    Console.WriteLine("\n\n----------------------------------");
                    Console.WriteLine("Personal " + employeeNumber);
                }

                Console.WriteLine("----------------------------------\n");              
                Console.Write("Ange personalens namn: ");
                name = Console.ReadLine();
                if (name != null && !(name.Contains(validSymobols)))
                {
                    employee.Name = name;
                    nameIsValid = true;
                }

                else
                {
                    Console.Clear();
                }
            }

            catch
            {
                Console.WriteLine("Var vänlig och ange ett giltigt namn" + CatchMessage);
                Console.ReadLine();
                Console.Clear();
            }

        }

        // Registerar lön

        while (!salaryIsGreaterThanZero)
        {
            try
            {

                Console.Write("\nAnge " + name + "s lön: ");
                salary = Convert.ToInt32(Console.ReadLine());
                if (salary > 0)
                {
                    employee.Salary = salary;
                    salaryIsGreaterThanZero = true;
                    Console.WriteLine("\n----------------------------------");
                    Console.WriteLine("\n----------------------------------");
                }

                else
                {
                    Console.Clear();
                }

            }

            catch
            {
                Console.WriteLine("Var vänlig och ange ett tal högre än 0" + CatchMessage);
                Console.ReadLine();
                Console.Clear();
            }

        }

        return employee;
    }

    internal void Add(Employee employee)
    {
        if (employee != null)
        {
            Employees.Add(employee);
        }
    }

    internal void PrintOutInfo()
    {
        Console.Clear();
        int employeeNumber = 0;
        foreach (Employee employee in Employees)
        {
            
            Console.WriteLine
                (
                    "\n----------------------------------" +
                    "\nPersonal " + employeeNumber +
                    "\nName: " + employee.Name +
                    "\nSalary: " + employee.Salary +
                    "\n----------------------------------"
                );

            employeeNumber++;
        }
    }

    
}

    


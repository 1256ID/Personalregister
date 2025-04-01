namespace Personalregister;

internal class Program 
{   
    static void Main()
    {
        Tools tools = new();
        int amountOfEmployee = tools.GetAmountOfEmployeesToRegister();

        for (int i = 0; i < amountOfEmployee; i++)
        {
            Employee employee = tools.Register(i);
            tools.Add(employee);
        }
    
        Console.WriteLine("\nKlicka på valfri tangent för att skriva ut personalen");
        Console.ReadLine();
        
        tools.PrintOutInfo();

    }

    

}

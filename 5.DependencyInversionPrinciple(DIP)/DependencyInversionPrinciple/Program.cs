using System;

public interface ICustomerDataAccess
{
    string GetCustomerName(int id);
}

public class CustomerDataAccess : ICustomerDataAccess
{
    public string GetCustomerName(int id)
    {
        return "Dummy Customer Name";
    }
}

public class CustomerBusinessLogic
{
    private readonly ICustomerDataAccess _custDataAccess;

    public CustomerBusinessLogic(ICustomerDataAccess custDataAccess)
    {
        _custDataAccess = custDataAccess;
    }

    public string GetCustomerName(int id)
    {
        return _custDataAccess.GetCustomerName(id);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICustomerDataAccess dataAccess = new CustomerDataAccess();
        CustomerBusinessLogic businessLogic = new CustomerBusinessLogic(dataAccess);

        int customerId = 1;
        string customerName = businessLogic.GetCustomerName(customerId);
        Console.WriteLine($"Customer Name: {customerName}");
    }
}
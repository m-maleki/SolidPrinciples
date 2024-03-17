public interface IBaseWorker
{
    string ID { get; set; }
    string Name { get; set; }
    string Email { get; set; }
}

public interface IFullTimeWorkerSalary : IBaseWorker
{
    float CalculateNetSalary();
}

public interface IContractWorkerSalary : IBaseWorker
{
    float CalculateWorkedSalary();
}

public class FullTimeEmployee : IFullTimeWorkerSalary
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public float CalculateNetSalary()
    {
        throw new NotImplementedException();
    }
}

public class ContractEmployee : IContractWorkerSalary
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public float CalculateWorkedSalary()
    {
        throw new NotImplementedException();
    }
}
namespace Solid._5___Dependency_Inversion_Principle__DIP_;

public class DataService
{
    private readonly IRepository _repository;

    public DataService(IRepository repository)
    {
        _repository = repository;
    }

    public void SaveData(string data)
    {
        _repository.Save(data);
    }
}
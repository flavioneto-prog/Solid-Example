namespace Solid._5___Dependency_Inversion_Principle__DIP_;

public class SqlRepository : IRepository
{
    public void Save(string data) => Console.WriteLine($"Saving {data} to SQL DB");
}
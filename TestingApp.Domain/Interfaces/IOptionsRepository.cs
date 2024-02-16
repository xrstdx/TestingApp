namespace TestingApp.Domain.Interfaces;

public interface IOptionsRepository
{
    Task<bool> IsOptionRight(Guid id);
}

namespace Param.Application.IRepositories;

public interface IUnitOfWork
{
    ICityRepository CityRepository { get; }
   
    Task<int> CompleteAsync();
}

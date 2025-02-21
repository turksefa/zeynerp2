namespace zeynerp.Core.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}
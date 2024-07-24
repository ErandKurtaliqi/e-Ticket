using WebApplication1.Models;

namespace WebApplication1.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
        Task<string?> GetAllAsync();
        Task AddAsync(Actor actor);
    }
}

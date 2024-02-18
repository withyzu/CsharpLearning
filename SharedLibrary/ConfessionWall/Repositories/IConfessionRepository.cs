using SharedLibrary.ConfessionWall.Models;

namespace SharedLibrary.ConfessionWall.Repositories;
public interface IConfessionRepository {

    Task<Confession> AddConfessionAsync(Confession model);
    Task<Confession> DeleteConfessionAsync(int id);
    Task<Confession> UpdateConfessionAsync(Confession model);
    Task<Confession> GetConfessionByIdAsync(int id);

    Task<List<Confession>> GetAllConfessionsAsync();
}

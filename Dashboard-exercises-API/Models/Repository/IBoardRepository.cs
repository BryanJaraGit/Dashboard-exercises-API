namespace Dashboard_exercises_API.Models.Repository
{
    public interface IBoardRepository
    {
        Task<List<Board>> GetListBoards();
        Task<Board> GetBoard(int id);
    }
}

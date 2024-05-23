using Microsoft.EntityFrameworkCore;

namespace Dashboard_exercises_API.Models.Repository
{
    public class BoardRepository: IBoardRepository
    {
        private readonly AplicationDbContext _context;

        public BoardRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Board>> GetListBoards()
        {
            return await _context.Board.ToListAsync();
        }

        public async Task<Board> GetBoard(int id)
        {
            return await _context.Board.FindAsync(id);
        }

    }
}

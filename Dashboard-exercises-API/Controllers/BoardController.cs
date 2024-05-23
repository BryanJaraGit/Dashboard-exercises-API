using AutoMapper;
using Dashboard_exercises_API.Models.DTO;
using Dashboard_exercises_API.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard_exercises_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IBoardRepository _boardRepository;

        public BoardController(IMapper mapper, IBoardRepository boardRepository)
        {
            _mapper = mapper;
            _boardRepository = boardRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listBoards = await _boardRepository.GetListBoards();

                var listBoardsDto = _mapper.Map<IEnumerable<BoardDTO>>(listBoards);

                return Ok(listBoardsDto);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var board = await _boardRepository.GetBoard(id);

                if(board == null)
                {
                    return NotFound();
                }

                var boardDto = _mapper.Map<BoardDTO>(board);

                return Ok(boardDto);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

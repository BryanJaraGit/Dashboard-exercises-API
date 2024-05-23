using AutoMapper;
using Dashboard_exercises_API.Models.DTO;

namespace Dashboard_exercises_API.Models.Profiles
{
    public class BoardProfile: Profile
    {
        public BoardProfile() 
        {
            CreateMap<Board, BoardDTO>();
            CreateMap<BoardDTO, Board>();
        }
    }
}

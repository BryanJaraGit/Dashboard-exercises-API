using System.ComponentModel.DataAnnotations;

namespace Dashboard_exercises_API.Models.DTO
{
    public class BoardDTO
    {
        //[Key]
        //public int IdBoard { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        
    }
}

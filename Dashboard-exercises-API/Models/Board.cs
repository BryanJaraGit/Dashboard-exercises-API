using System.ComponentModel.DataAnnotations;

namespace Dashboard_exercises_API.Models
{
    public class Board
    {
        [Key]
        public int IdBoard { get; set; }
        public int Cantidad { get; set; }
        public string Nombre { get; set; }
    }
}

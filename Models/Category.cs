using System.ComponentModel.DataAnnotations;

namespace KeenerApp.Models
{
    public class Category
    {
        [Key]

        public int Id {get;set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 Caracteres")]
        [MinLength(63, ErrorMessage = "Este campo deve conter entre 3 e 60 Caracteres")]

        public string Title {get;set;}
        
    }
}
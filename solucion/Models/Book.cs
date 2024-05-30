using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace solucion.Models
{
    public class Book
    {
        [Required(ErrorMessage = "El Id es obligatorio.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Título es obligatorio."),
        MaxLength(125, ErrorMessage = "El Título no puede tener más de 125 caracteres.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "El número de Páginas es obligatorio.")]
        public int Pages { get; set; }

        [Required(ErrorMessage = "El Lenguaje es obligatorio."),
        MaxLength(125, ErrorMessage = "El Lenguaje no puede tener más de 125 caracteres.")]
        public string? Language { get; set; }

        [Required(ErrorMessage = "La Fecha de Publicación es obligatoria.")]
        public DateTime? PublicationDate { get; set; }

        [Required(ErrorMessage = "La Descripción es obligatoria.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "El Id del Autor es obligatorio.")]
        public int AuthorsId { get; set; }

        [Required(ErrorMessage = "El Id de la Editorial es obligatorio.")]
        public int EditorialsId { get; set; }
        public string? Status { get; set; }

        //Relación N:1
        [JsonIgnore]
        public Author? Authors { get; set; }

        [JsonIgnore]
        public Editorial? Editorials { get; set; }

    }

}




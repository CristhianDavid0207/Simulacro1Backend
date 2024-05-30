using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace solucion.Models
{
    public class Editorial
    {
        [Required(ErrorMessage = "El Id es obligatorio.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio."),
        MaxLength(125, ErrorMessage = "El Nombre no puede tener más de 125 caracteres.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "La Dirección es obligatoria."),
        MaxLength(125, ErrorMessage = "La Dirección no puede tener más de 125 caracteres.")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "El Teléfono es obligatorio.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "El Estado es obligatorio.")]
        public string? Status { get; set; }

        //Relación 1:N
        [JsonIgnore]
        public List<Book>? Books { get; set; }

    }
}


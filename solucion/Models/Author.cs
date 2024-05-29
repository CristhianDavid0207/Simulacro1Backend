using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace solucion.Models
{
    public class Author
    {
        [Required]
        public int Id { get; set; }

        [Required (ErrorMessage = "El Nombre es obligatorio."), 
        MaxLength(125, ErrorMessage = "El Nombre no puede tener más de 125 caracteres.")]
        public string? Name { get; set; }

        [Required (ErrorMessage = "El Nombre es obligatorio."), 
        MaxLength(45, ErrorMessage = "El Apellido no puede tener más de 45 caracteres.")]
        public string? LastName { get; set; }

        [Required (ErrorMessage = "El correo electrónico es obligatorio."), 
        EmailAddress (ErrorMessage = "El correo electrónico no tiene un formato válido."), 
        MaxLength(125, ErrorMessage = "El correo electrónico no puede tener más de 125 caracteres.")]
        public string? Email { get; set; }

        [Required (ErrorMessage = "La Nacionalidad es obligatorio."), 
        MaxLength(125, ErrorMessage = "El correo electrónico no puede tener más de 125 caracteres.")]
        public string? Nationality { get; set; }
        
        [Required (ErrorMessage = "El Estado es obligatorio.")]
        public AuthorStatus Status { get; set; }

        //Relación 1:N
        [JsonIgnore]
        public List<Book>? Books {get; set;}
    
    }


    public enum AuthorStatus
    {
        Active,
        Inactive
    }
}

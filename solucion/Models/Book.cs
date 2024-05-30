namespace solucion.Models
{
    public class Book
    {
       public int Id {get; set;} 
       public string? Title {get; set;} 
       public int? Pages {get; set;} 
       public string? Language {get; set;}
       public DateOnly PublicationDate {get; set;}
       public string? Description {get; set;}
       public int AuthorsId  {get; set;}
       public Author? Author {get; set;}
       public int EditorialsId  {get; set;}
       public Editorial? Editorial {get; set;}
        // public Status Status { get; set; } = Author.Status.Active


        // public class enum Status {Active, Inactive}
    }
}
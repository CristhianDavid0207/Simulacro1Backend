namespace solucion.Models
{
    public class Editorial
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Address {get; set;}
        public string Phone {get; set;}
        public Status Status { get; set; } = Author.Status.Active


        public class enum Status {Active, Inactive}

        //Relación 1:N
        [JsonIgnore]
        public List<Book> Books {get; set;}

    }
}

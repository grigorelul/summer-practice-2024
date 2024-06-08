namespace TodoApi.Models
{
    public class UserDTO
    {
        public long Id { get; set; }
        public string? Nume { get; set; }
        public string? Prenume { get; set; }
        public string? Email { get; set; }
        public string? Parola { get; set; }
        public bool? Admin { get; set; }
    }
}

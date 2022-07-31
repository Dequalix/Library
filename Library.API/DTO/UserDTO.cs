namespace Library.API.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Email { get; set; }
        public string? Adres { get; set; } 
        public string? ZipCode { get; set; }
        public string? City { get; set; }

    }
}

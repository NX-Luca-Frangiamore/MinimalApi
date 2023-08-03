namespace MinimalApi.Model
{
    public class NEmail
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public Utente utente { get; set; }
    }
}
namespace MinimalApi.Model
{
    public class Utente
    {
        public int id { get; set; }
        public string name { get; set; }
        public string cognome { get; set; }
        public string indirizzo { get; set; }
        public ICollection<NTelefono> nTelefoni { get; set;}
        public ICollection<NEmail> nEmails { get; set; }
    }
}

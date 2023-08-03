namespace MinimalApi.Model
{
    public class Utente
    {
        public int id { get; set; }
        public string name { get; set; }
        public string cognome { get; set; }
        public string? indirizzo { get; set; }
        public ICollection<NTelefono> nTelefoni { get; set;}
        public ICollection<NEmail> nEmails { get; set; }
        public override string ToString()
        {
            Console.WriteLine("CJA");
            return $"nome {name}, cognome {cognome}, indirizzo {indirizzo}";
        }
    }
}

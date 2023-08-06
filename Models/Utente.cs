namespace MinimalApi.Model
{
    public class Utente
    {
       

        public int id { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string? indirizzo { get; set; }
        public List<NEmail> emails { get; set; }
        public List<NTelefono> telefoni { get; set; }
        public override string ToString()
        {
            return $"nome {nome}, cognome {cognome}, indirizzo {indirizzo}";
        }
    }
}

namespace MinimalApi.Model
{
    public class Utente
    {
       

        public int id { get; set; }
        public string name { get; set; }
        public string cognome { get; set; }
        public string? indirizzo { get; set; }
        public override string ToString()
        {
            return $"nome {name}, cognome {cognome}, indirizzo {indirizzo}";
        }
    }
}

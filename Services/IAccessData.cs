using MinimalApi.Model;

namespace MinimalApi.Services
{
    public abstract class IAccessData
    {
        readonly protected Context context;
        public IAccessData(Context context)
        {
            this.context = context;
        }
        abstract public Task<IQueryable<Utente>> getUtenti();
        abstract public Task<Utente> getUtente(string nome, string cognome);

        abstract public Task<IQueryable<NTelefono>> getNumero(int idUtente);
        abstract public Task<IQueryable<NEmail>> getEmail(int idUtente);

        abstract public void addUtenti(Utente utente);
        abstract public void addNumero(int idUtente, NTelefono numero);
        abstract public void addEmail(int idUtente, NEmail email);
        abstract public void resetDati();

    }
}

using MinimalApi.Model;

namespace MinimalApi
{
    public abstract class AccessData
    {
        readonly protected Context context;
        public AccessData(Context context) { 
            this.context = context;
        }
        abstract public Task<IEnumerable<Utente>> getUtenti();
        abstract public Task<IEnumerable<NTelefono>> getNumero(int idUtente);
        abstract public Task<IEnumerable<NEmail>> getEmail(int idUtente);

        abstract public void addUtenti(Utente utente);
        abstract public void addNumero(int idUtente, NTelefono numero);
        abstract public void addEmail(int idUtente,NEmail email);

    }
}

using MinimalApi.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MinimalApi
{
    public class AccessMysqlite : AccessData
    {
        public AccessMysqlite(Context context):base(context) { }
        public override void addEmail(int idUtente, NEmail email)
        {
            context.nemail.Add(email);
            context.SaveChanges();
        }

        public override void addNumero(int idUtente, NTelefono numero)
        {
            context.ntelefono.Add(numero);
            context.SaveChanges();
        }

        public override void addUtenti(Utente utente)
        {
            context.utente.Add(utente);
            context.SaveChanges();
        }

        public override Task<IEnumerable<NEmail>> getEmail(int idUtente)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<NTelefono>> getNumero(int idUtente)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<Utente>> getUtenti()
        {
            throw new NotImplementedException();
        }
    }
}

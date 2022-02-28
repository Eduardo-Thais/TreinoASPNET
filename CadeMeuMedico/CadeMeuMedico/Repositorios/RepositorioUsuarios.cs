using CadeMeuMedico.Data;
using System;
using System.Linq;

namespace CadeMeuMedico.Repositorios
{
    public class RepositorioUsuarios
    {
       /* private static MedicosContext _context;


        public RepositorioUsuarios(MedicosContext context)
        {
            _context = context;
        }
        public static bool AutenticarUsuario(string Login, string Senha)
        {
            

            try
            {
                
                {
                    var QueryAutenticaUsuarios =
                    _context.Usuario.
                    Where(x => x.Login == Login && x.Senha == Senha).
                    SingleOrDefault();
                    if (QueryAutenticaUsuarios == null)
                    {
                        return false;
                    }
                    else
                    {
                        RepositorioCookies.RegistraCookieAutenticacao(
                        QueryAutenticaUsuarios.IDUsuario);
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

        }*/
    }
}

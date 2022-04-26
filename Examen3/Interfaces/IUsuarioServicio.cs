using Modelos;

namespace Examen3.Interfaces;

public interface IUsuarioServicio
{
  
    Task<IEnumerable<Usuario>> GetLista();
    Task<Usuario> GetPorCodigo(string codigo);
}
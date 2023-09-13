using Entidades;

namespace Repositorio
{
    public interface IRepositorioPersonas
    {
        Task<Persona> AltaPersona(Persona nuevaPersona);
        Task<IEnumerable<Persona>> ObtenerTodasPersonas();
        Task<Persona> ObtenerPersona(string personaId);
        Task<IEnumerable<Persona>> Obtener10();

    }
}
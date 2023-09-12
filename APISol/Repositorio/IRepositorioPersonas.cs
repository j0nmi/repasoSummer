using Entidades;

namespace Repositorio
{
    public interface IRepositorioPersonas
    {
        bool PersonaExiste(Guid personaId);
        Task<Persona> AltaPersona(Persona nuevaPersona);
        Task<IEnumerable<Persona>> ObtenerTodasPersonas();
        Task<Persona> ObtenerPersona(Guid id);

    }
}
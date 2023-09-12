using AutoMapper;
using Entidades;
using DTOs;
namespace APIPersonas.Profiles
{
    public class PersonasProfile : Profile
    {
        public PersonasProfile()
        {
            CreateMap<Persona, PersonaVerDto>();
            CreateMap<PersonaAltaDto, Persona>();
        }
    }
}

using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRepositorioPersonas
    {
        IEnumerable<Persona> getAllPersona();
        Persona addPersona(Persona persona);
        Persona updatePersona(Persona persona);
        Persona getPersona(int idPersona);
        void deletePersona(int idPersona); 
    }
}
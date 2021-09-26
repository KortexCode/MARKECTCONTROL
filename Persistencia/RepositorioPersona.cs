using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia
{
    public class RepositorioPersona:IRepositorioPersonas
    {
        public readonly AplicationDbContext _appContext;

        public RepositorioPersona(AplicationDbContext appContext){

            _appContext=appContext;

        }

        IEnumerable<Persona> IRepositorioPersonas.getAllPersona(){
            return _appContext.personas;
        }
        Persona IRepositorioPersonas.addPersona(Persona persona)
        {
            var new_Persona = _appContext.personas.Add(persona);
            _appContext.SaveChanges();
            return new_Persona.Entity;
        }
        Persona IRepositorioPersonas.updatePersona(Persona persona){

            var personaEncontrada = _appContext.personas.FirstOrDefault(p=> p.Id ==persona.Id);

            if(personaEncontrada!=null){

                personaEncontrada.Nombre = persona.Nombre;
                personaEncontrada.Correo = persona.Correo;
                personaEncontrada.DocumentoId = persona.DocumentoId;
                _appContext.SaveChanges();

            }

            return personaEncontrada;
        }

        Persona IRepositorioPersonas.getPersona(int idPersona){

            return _appContext.personas.FirstOrDefault(p=> p.Id ==idPersona);
            
        }

        
        void IRepositorioPersonas.deletePersona(int idPersona){

            var personaEncontrada = _appContext.personas.FirstOrDefault(p=> p.Id ==idPersona);

            
            _appContext.Remove(personaEncontrada);
            _appContext.SaveChanges();

           
        }
    }
    
}
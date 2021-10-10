using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace MyApp.Namespace
{
    public class updateModel : PageModel
    {

        private readonly IRepositorioPersonas _repo;

        public updateModel(IRepositorioPersonas repositorioPersonas){

            _repo=repositorioPersonas;

        }

        public Persona persona{get; set;}
       
      
        public void OnGet(int id)
        {
            persona=_repo.getPersona(id);

        }

          public void OnPost(Persona persona)
        {
            _repo.updatePersona(persona);
        }
    }
}

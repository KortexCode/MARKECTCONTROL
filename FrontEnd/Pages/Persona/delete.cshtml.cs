using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace MyApp.Namespace
{
    public class deleteModel : PageModel
    {
        private readonly IRepositorioPersonas _repo;

        public deleteModel(IRepositorioPersonas repositorioPersonas){

            _repo=repositorioPersonas;

        }

        public Persona persona{get; set;}
        public void OnGet(int id)
        {
            persona=_repo.getPersona(id);
        }
        public void OnPost(int id)
        {
            _repo.deletePersona(id);
        }
    }
}

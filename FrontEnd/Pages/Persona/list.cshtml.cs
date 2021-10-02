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
    public class listModel : PageModel
    {
        private readonly IRepositorioPersonas _repo;

        public IEnumerable<Persona> Personas{get; set;}

        public listModel(IRepositorioPersonas repositorioPersonas){

            _repo=repositorioPersonas;
        }

        
        public void OnGet()
        {
            Personas =_repo.getAllPersona();
        }
    }
}

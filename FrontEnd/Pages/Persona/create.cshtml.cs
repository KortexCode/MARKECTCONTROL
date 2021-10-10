using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;


namespace MyApp.Namespace
{
    public class createModel : PageModel
    {
        
        private readonly IRepositorioPersonas _repo;

        public createModel(IRepositorioPersonas repositorioPersonas){

            _repo=repositorioPersonas;

        }

        public Persona persona{get; set;}
       
        public void OnGet()
        {

        }

        public void OnPost(Persona persona)
        {
            _repo.addPersona(persona);
        }
    }
}

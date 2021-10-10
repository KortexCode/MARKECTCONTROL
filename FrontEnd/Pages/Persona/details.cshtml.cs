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
    public class detailsModel : PageModel
    {
        private readonly IRepositorioPersonas _repo;

        public Persona Personas{get; set;}

        public detailsModel(IRepositorioPersonas repositorioPersonas){

            _repo=repositorioPersonas;
        }
        public void OnGet(int id)
        {
            Personas =_repo.getPersona(id);
        }
    }
}

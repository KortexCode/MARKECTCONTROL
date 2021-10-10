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
    
    public class detailsEModel : PageModel
    {
        private readonly IRepositorioEmpleado _repo;

        public IEnumerable<Empleado> Empleados{get; set;}


        public detailsEModel(IRepositorioEmpleado repositorioEmpleados){

            _repo=repositorioEmpleados;
        }
        public void OnGet()
        {
            Empleados =_repo.getAllEmpleado();
        }
    }
}

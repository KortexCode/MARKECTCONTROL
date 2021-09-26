using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia
{
    public class RepositorioDirectivo:IRepositorioDirectivo
    {
        public readonly AplicationDbContext _appContext;

        
        public RepositorioDirectivo(AplicationDbContext appContext){

            _appContext=appContext;

        }

        IEnumerable<Directivo> IRepositorioDirectivo.getAllDirectivo(){
            return _appContext.directivos;
        }
        Directivo IRepositorioDirectivo.addDirectivo(Directivo directivo)
        {
            var new_directivo = _appContext.directivos.Add(directivo);
            _appContext.SaveChanges();
            return new_directivo.Entity;
        }
        Directivo IRepositorioDirectivo.updateDirectivo(Directivo directivo){

            var directivoEncontrado = _appContext.directivos.FirstOrDefault(p=> p.Id ==directivo.Id);

            if(directivoEncontrado!=null){

                directivoEncontrado.Nombre = directivo.Nombre;
                directivoEncontrado.Correo = directivo.Correo;
                directivoEncontrado.DocumentoId = directivo.DocumentoId;
                directivoEncontrado.SalarioBruto = directivo.SalarioBruto;
                directivoEncontrado.FechaDeNacimiento = directivo.FechaDeNacimiento;
                directivoEncontrado.Categoria = directivo.Categoria;

                _appContext.SaveChanges();

            }

            return directivoEncontrado;
        }

        Directivo IRepositorioDirectivo.getDirectivo(int idDirectivo){

            return _appContext.directivos.FirstOrDefault(p=> p.Id ==idDirectivo);
            
        }

        
        void IRepositorioDirectivo.deleteDirectivo(int idDirectivo){

            var directivoEncontrado = _appContext.empleados.FirstOrDefault(p=> p.Id ==idDirectivo);

            
            _appContext.Remove(directivoEncontrado);
            _appContext.SaveChanges();

           
        }
    }
}
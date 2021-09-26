using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia
{
    public class RepositorioEmpresa:IRepositorioEmpresa
    {
        public readonly AplicationDbContext _appContext;

        public RepositorioEmpresa(AplicationDbContext appContext){

            _appContext=appContext;

        }

        IEnumerable<Empresa> IRepositorioEmpresa.getAllEmpresa(){
            return _appContext.empresas;
        }
        Empresa IRepositorioEmpresa.addEmpresa(Empresa empresa)
        {
            var new_Empresa = _appContext.empresas.Add(empresa);
            _appContext.SaveChanges();
            return new_Empresa.Entity;
        }
        Empresa IRepositorioEmpresa.updateEmpresa(Empresa empresa){

            var empresaEncontrada = _appContext.empresas.FirstOrDefault(p=> p.Id ==empresa.Id);

            if(empresaEncontrada!=null){

                empresaEncontrada.RazonSocial = empresa.RazonSocial;
                empresaEncontrada.CodigoEmpresa = empresa.CodigoEmpresa;
                
                _appContext.SaveChanges();

            }

            return empresaEncontrada;
        }

        Empresa IRepositorioEmpresa.getEmpresa(int idEmpresa){

            return _appContext.empresas.FirstOrDefault(p=> p.Id ==idEmpresa);
            
        }

        
        void IRepositorioEmpresa.deleteEmpresa(int idEmpresa){

            var empresaEncontrada = _appContext.empresas.FirstOrDefault(p=> p.Id ==idEmpresa);

            
            _appContext.Remove(empresaEncontrada);
            _appContext.SaveChanges();

           
        }
    }
}
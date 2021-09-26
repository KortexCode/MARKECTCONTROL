using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRepositorioEmpresa
    {
        IEnumerable<Empresa> getAllEmpresa();
        Empresa addEmpresa(Empresa empresa);
        Empresa updateEmpresa(Empresa empresa);
        Empresa getEmpresa(int idEmpresa);
        void deleteEmpresa(int idEmpresa); 
    }
}
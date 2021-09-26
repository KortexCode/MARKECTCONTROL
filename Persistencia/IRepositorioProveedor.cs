using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRepositorioProveedor
    {
        IEnumerable<Proveedor> getAllProveedor();
        Proveedor addProveedor(Proveedor proveedor);
        Proveedor updateProveedor(Proveedor proveedor);
        Proveedor getProveedor(int proveedor);
        void deleteProveedor(int proveedor); 
    }
}
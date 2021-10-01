using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Persistencia
{
    public class RepositorioProveedor: IRepositorioProveedor
    {
       
    
        public readonly AplicationDbContext _appContext;

        public RepositorioProveedor(AplicationDbContext appContext){

            _appContext=appContext;

        }

        IEnumerable<Proveedor> IRepositorioProveedor.getAllProveedor(){
            return _appContext.proveedores;
        }
        Proveedor IRepositorioProveedor.addProveedor(Proveedor proveedor)
        {
            var new_Proveedor = _appContext.proveedores.Add(proveedor);
            _appContext.SaveChanges();
            return new_Proveedor.Entity;
        }
        Proveedor IRepositorioProveedor.updateProveedor(Proveedor proveedor){

            var proveedorEncontrado = _appContext.proveedores.FirstOrDefault(p=> p.Id ==proveedor.Id);

            if(proveedorEncontrado!=null){

                proveedorEncontrado.Nombre = proveedor.Nombre;
                proveedorEncontrado.Correo = proveedor.Correo;
                proveedorEncontrado.DocumentoId = proveedor.DocumentoId;
                proveedorEncontrado.Contacto = proveedor.Contacto;
                proveedorEncontrado.Direccion = proveedor.Direccion;
                _appContext.SaveChanges();

            }

            return proveedorEncontrado;
        }

        Proveedor IRepositorioProveedor.getProveedor(int idProveedor){

            return _appContext.proveedores.FirstOrDefault(p=> p.Id ==idProveedor);
            
        }

        
        void IRepositorioProveedor.deleteProveedor(int idProveedor){

            var proveedorEncontrado = _appContext.clientes.FirstOrDefault(p=> p.Id ==idProveedor);

            
            _appContext.Remove(proveedorEncontrado);
            _appContext.SaveChanges();

           
        }
    }
}
using System;
using Persistencia;
using Dominio;


namespace Aplicacion
{
    class Program
    {
        /*
        private static IRepositorioEmpleado _repoEmpleado = new RepositorioEmpleado(new Persistencia.AplicationDbContext());
        private static IRepositorioInventario _repoInventario = new RepositorioInventario(new Persistencia.AplicationDbContext());
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persistencia.AplicationDbContext());
        private static IRepositorioProveedor _repoProveedor = new RepositorioProveedor(new Persistencia.AplicationDbContext());
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AplicationDbContext());
        private static IRepositorioEmpresa _repoEmpresa = new RepositorioEmpresa(new Persistencia.AplicationDbContext());
        private static IRepositorioPersonas _repoPersona = new RepositorioPersona(new Persistencia.AplicationDbContext());
        */
        static void Main(string[] args)
        {
            //EJECUTAR CONSULTA DEL CRUD EMPLEADO
            //AddEmpleado();
            //upDateEmpleado();
            //getEmpleado(2);
            //deleteEmpleado(4);
            //getAllEmpleado();

            //EJECUTAR CONSULTA DEL CRUD INVENTARIO
            //AddInventario();
            //updateInventario();
            //getInventario(4);
            //deleteInventario(2);
            //getAllInventario();

            //EJECUTAR CONSULTA DEL CRUD CLIENTE
            //AddCliente();
            //getCliente(2);
            //upDateCliente();
            //deleteCliente(4);

            ////EJECUTAR CONSULTA DEL CRUD PROVEEDOR
            //AddProveedor();
            //getProveedor(2);
            //upDateProveedor();
            //deleteProveedor(4);

            ////EJECUTAR CONSULTA DEL CRUD DIRECTIVO
            //AddDirectivo();
            //getDirectivo(2);
            //upDateDirectivo();
            //deleteDirectivo(4);

            ////EJECUTAR CONSULTA DEL CRUD PERSONA
            //AddPersona();
            //getPersona(2);
            //upDatePersona();
            //deletePersona(4);

            ////EJECUTAR CONSULTA DEL CRUD EMPRESA
            //AddEmpresa();
            //getEmpresa(2);
            //upDateEmpresa();
            //deleteEmpresa(4);


            Console.WriteLine("Hello World!");
        }

        //CRUD EMPRESA
        /*
        public static void getAllEmpresa(){
            var empresa = _repoEmpresa.getAllEmpresa();
            Console.WriteLine("LISTA DE EMPRESA:");
            foreach(var e in empresa){

                Console.WriteLine("ID "+e.Id+", "+" Nombre: "+ e.RazonSocial +", "+"Código Empresa: "+ e.CodigoEmpresa);
            }
            
        }
        public static void AddEmpresa(){
        
            Console.WriteLine("REGISTRO DE EMPRESA EXITOSO");
            
            var empresa = new Empresa{RazonSocial = "MARKETCONTROL", CodigoEmpresa = "473283273"};
            
            _repoEmpresa.addEmpresa(empresa);
        }
        public static void upDateEmpresa(){

            
            var empresa = new Empresa{Id = 4, RazonSocial = "James Howlett", CodigoEmpresa = "agujadinamica@gmail.com"};
            _repoEmpresa.updateEmpresa(empresa);
            Console.WriteLine("SE ACTUALIZÓ LA EMPRESA CON ID " + empresa.Id); 
        }
        public static void getEmpresa(int idEmpresa){
           
            var empresa = _repoEmpresa.getEmpresa(idEmpresa);
            if(empresa==null){

                Console.WriteLine("NO SE ENCONTRÓ LA EMPRESA CON ID "+idEmpresa);
            }
            Console.WriteLine("LA EMPRESA CON ID "+idEmpresa+" CONSULTADA ES: "+ "Nombre: "+ empresa.RazonSocial +", "+"CodigoEmpresa: "+ empresa.CodigoEmpresa);

        }
        public static void deleteEmpresa(int idEmpresa){

            _repoEmpresa.deleteEmpresa(idEmpresa);

            Console.WriteLine("LA EMPRESA CON ID "+idEmpresa+" HA SIDO REMOVIDA");
            
        }
        
        //CRUD PERSONA
        /*
        public static void getAllPersona(){
            var persona = _repoPersona.getAllPersona();
            Console.WriteLine("LISTA DE PERSONA:");
            foreach(var e in persona){

                Console.WriteLine("ID "+e.Id+", "+" Nombre: "+ e.Nombre +", "+"Correo: "+ e.Correo +", "+ "DocumentoID: "+e.DocumentoId);
            }
            
        }
        public static void AddPersona(){
        
            Console.WriteLine("REGISTRO DE PERSONA EXITOSO");
            
            var persona = new Persona{Nombre = "Kuwabara Kurosaki", Correo = "kuwasaki@gmail.com.com", DocumentoId = "104344565"};
            
            _repoPersona.addPersona(persona);
        }
        
        public static void upDatePersona(){

            
            var persona = new Persona{Id = 1, Nombre = "Koharu Shiba", Correo = "kohashi@gmail.com.com", DocumentoId = "107279565"};
            _repoPersona.updatePersona(persona);
            Console.WriteLine("SE ACTUALIZÓ LA PERSONA CON ID " + persona.Id); 
        }
        
        public static void getPersona(int idPersona){
           
            var persona = _repoPersona.getPersona(idPersona);
            if(persona==null){

                Console.WriteLine("NO SE ENCONTRÓ EL EMPLEADO CON ID "+idPersona);
            }
            Console.WriteLine("EL EMPLEADO CON ID "+idPersona+" CONSULTADO ES: "+ "Nombre: "+ persona.Nombre +", "+"Correo: "+ persona.Correo +", "+ "DocumentoID: "+persona.DocumentoId );

        }
        public static void deletePersona(int idPersona){

            _repoPersona.deletePersona(idPersona);

            Console.WriteLine("EL PERSONA CON ID "+idPersona+" HA SIDO REMOVIDO");
            
        }
        */
        //CRUD DE EMPLEADO
        /*

        public static void getAllEmpleado(){
            var empleado = _repoEmpleado.getAllEmpleado();
            Console.WriteLine("LISTA DE EMPLEADOS:");
            foreach(var e in empleado){

                Console.WriteLine("ID "+e.Id+", "+" Nombre: "+ e.Nombre +", "+"Correo: "+ e.Correo +", "+ "DocumentoID: "+e.DocumentoId +", "+ "Salaraio Bruto: "+e.SalarioBruto+", "+"Fecha de nacimiento: "+e.FechaDeNacimiento);
            }
            
        }
        public static void AddEmpleado(){
        
            Console.WriteLine("REGISTRO DE EMPLEADO EXITOSO");
            
            var empleado = new Empleado{Nombre = "Bruce Wayne", Correo = "darkknight@gmail.com", DocumentoId = "1025473325", SalarioBruto=2000000, FechaDeNacimiento=1897};
            
            _repoEmpleado.addEmpleado(empleado);
        }
        
        public static void upDateEmpleado(){

            
            var empleado = new Empleado{Id = 1, Nombre = "James Howlett", Correo = "agujadinamica@gmail.com", DocumentoId = "1012090443", SalarioBruto=5000000, FechaDeNacimiento=1875};
            _repoEmpleado.updateEmpleado(empleado);
            Console.WriteLine("SE ACTUALIZÓ EL EMPLEADO CON ID " + empleado.Id); 
        }
        
        public static void getEmpleado(int idEmpleado){
           
            var empleado = _repoEmpleado.getEmpleado(idEmpleado);
            if(empleado==null){

                Console.WriteLine("NO SE ENCONTRÓ EL EMPLEADO CON ID "+idEmpleado);
            }
            Console.WriteLine("EL EMPLEADO CON ID "+idEmpleado+" CONSULTADO ES: "+ "Nombre: "+ empleado.Nombre +", "+"Correo: "+ empleado.Correo +", "+ "DocumentoID: "+empleado.DocumentoId +", "+ "Salaraio Bruto: "+empleado.SalarioBruto+", "+"Fecha de nacimiento: "+empleado.FechaDeNacimiento);

        }
        public static void deleteEmpleado(int idEmpleado){

            _repoEmpleado.deleteEmpleado(idEmpleado);

            Console.WriteLine("EL USUARIO CON ID "+idEmpleado+" HA SIDO REMOVIDO");
            
        }

        //CRUD INVENTARIO

        public static void getAllInventario(){
            var inventario = _repoInventario.getAllInventario();
            Console.WriteLine("LISTA DE PRODUCTOS:");
            foreach(var i in inventario){

                Console.WriteLine("ID "+i.Id+", "+"Nombre: "+ i.nombreProducto +", "+"Disponibilidad: "+ i.disponibilidadProducto +", "+ "Precio: "+i.precio +", "+ "stock: "+i.stock);
            }

        
        public static void AddInventario(){
        
            var producto = new Inventario{nombreProducto = "Lechuga", disponibilidadProducto = "si", stock = 15, precio=400};
            
            _repoInventario.addInventario(producto);

            Console.WriteLine("REGISTRO DE PRODUCTO EXITOSO");
       
        
        public static void updateInventario(){

            
            var inventario = new Inventario{Id = 2, nombreProducto = "Arroz", disponibilidadProducto = "si", stock = 60, precio=1200};
            _repoInventario.updateInventario(inventario);
            Console.WriteLine("SE ACTUALIZÓ EL PRODUCTO CON ID " + inventario.Id); 
        }
      
        public static void getInventario(int idInventario){
           
            var inventario = _repoInventario.getInventario(idInventario);
            if(inventario==null){

                Console.WriteLine("NO SE ENCONTRÓ EL PRODUCTO CON ID "+idInventario);
            }
            Console.WriteLine("EL PRODUCTO CON ID "+idInventario+" CONSULTADO ES: "+ "Nombre: "+ inventario.nombreProducto +", "+"Disponibilidad: "+ inventario.disponibilidadProducto +", "+ "Precio: "+inventario.precio +", "+ "stock: "+inventario.stock);

        }
        public static void deleteInventario(int idInventario){

            _repoInventario.deleteInventario(idInventario);

            Console.WriteLine("EL PRODUCTO CON ID "+idInventario+" HA SIDO REMOVIDO");
            
        }

        //CRUD CLIENTE
        public static void getAllCliente(){
            var cliente = _repoCliente.getAllCliente();
            Console.WriteLine("LISTA DE CLIENTES:");
            foreach(var c in cliente){

                Console.WriteLine("ID "+c.Id+", "+" Nombre: "+ c.Nombre +", "+"Correo: "+ c.Correo +", "+ "DocumentoID: "+c.DocumentoId +", "+"Teléfono: "+c.Telefono);
            }
            
        }*/
        /*
        public static void AddCliente(){
        
            Console.WriteLine("REGISTRO DE CLIENTE EXITOSO");
            
            var cliente = new Cliente{Nombre = "Ramirez&Ramirez", Correo = "ramirez.adm@gmail.com", DocumentoId = "107334623231", Telefono="5353428"};
            
            _repoCliente.addCliente(cliente);
        }
        
        public static void upDateCliente(){

            
            var cliente = new Cliente{Id = 2, Nombre = "Mercabastos", Correo = "MercaAministracion@gmail.com", DocumentoId = "101209348745", Telefono="=5902365"};
            _repoCliente.updateCliente(cliente);
            Console.WriteLine("SE ACTUALIZÓ EL EMPLEADO CON ID " + cliente.Id); 
        }
        public static void getCliente(int idCliente){
           
            var cliente = _repoCliente.getCliente(idCliente);
            if(cliente==null){

                Console.WriteLine("NO SE ENCONTRÓ EL EMPLEADO CON ID "+idCliente);
            }
            Console.WriteLine("EL EMPLEADO CON ID "+idCliente+" CONSULTADO ES: "+ "Nombre: "+ cliente.Nombre +", "+"Correo: "+ cliente.Correo +", "+ "DocumentoID: "+cliente.DocumentoId +", "+ "Télefono: "+cliente.Telefono);

        }
        public static void deleteCliente(int idCliente){

            _repoCliente.deleteCliente(idCliente);

            Console.WriteLine("EL USUARIO CON ID "+idCliente+" HA SIDO REMOVIDO");
            
        }

        //CRUD PROVEEDOR

        public static void getAllProveedor(){
            var proveedor = _repoProveedor.getAllProveedor();
            Console.WriteLine("LISTA DE PROVEEDOR:");
            foreach(var c in proveedor){

                Console.WriteLine("ID "+c.Id+", "+" Nombre: "+ c.Nombre +", "+"Correo: "+ c.Correo +", "+ "DocumentoID: "+c.DocumentoId +", "+"Contacto: "+c.Contacto+", "+"Dirección: "+c.Direccion);
            }
            
        }*/
        /*
        public static void AddProveedor(){
        
            Console.WriteLine("REGISTRO DE PROVEEDOR EXITOSO");
            
            var proveedor = new Proveedor{Nombre = "AlmacénVegetal", Correo = "vegetal@gmail.com", DocumentoId = "347834425631", Contacto="3213453678", Direccion="calle 78 #89 -12"};
            
            _repoProveedor.addProveedor(proveedor);
        }*/
        /*
        public static void upDateProveedor(){

            
            var proveedor = new Proveedor{Id = 1, Nombre = "MercadoVerde", Correo = "MercaAministracion@gmail.com", DocumentoId = "211209348745", Contacto="=5902365", Direccion="calle 2 # 45 -5"};
            _repoProveedor.updateProveedor(proveedor);
            Console.WriteLine("SE ACTUALIZÓ EL PROVEEDOR CON ID " + proveedor.Id); 
        }
        
        public static void getProveedor(int idProveedor){
           
            var proveedor = _repoProveedor.getProveedor(idProveedor);
            if(proveedor==null){

                Console.WriteLine("NO SE ENCONTRÓ EL EMPLEADO CON ID "+idProveedor);
            }
            Console.WriteLine("EL EMPLEADO CON ID "+idProveedor+" CONSULTADO ES: "+ "Nombre: "+ proveedor.Nombre +", "+"Correo: "+ proveedor.Correo +", "+ "DocumentoID: "+proveedor.DocumentoId +", "+ "Télefono: "+proveedor.Contacto+"Dirección: "+proveedor.Direccion);

        }
        public static void deleteProveedor(int idProveedor){

            _repoProveedor.deleteProveedor(idProveedor);

            Console.WriteLine("EL USUARIO CON ID "+idProveedor+" HA SIDO REMOVIDO");
            
        }

        //CRUD DIRECTIVO

        public static void getAllDirectivo(){
            var directivo = _repoDirectivo.getAllDirectivo();
            Console.WriteLine("LISTA DE DIRECTIVOS:");
            foreach(var e in directivo){

                Console.WriteLine("ID "+e.Id+", "+" Nombre: "+ e.Nombre +", "+"Correo: "+ e.Correo +", "+ "DocumentoID: "+e.DocumentoId +", "+ "Salaraio Bruto: "+e.SalarioBruto+", "+"Fecha de nacimiento: "+e.FechaDeNacimiento+"Categoría"+e.Categoria);
            }
            
        }
        
        public static void AddDirectivo(){
        
            Console.WriteLine("REGISTRO DE DIRECTIVO EXITOSO");
            
            var directivos = new Directivo{Nombre = "Diana Prince", Correo = "princed@gmail.com.com", DocumentoId = "1045212425", SalarioBruto=2323000, FechaDeNacimiento=1899, Categoria="Coordinadora"};
            
            _repoDirectivo.addDirectivo(directivos);
        }
        
        public static void upDateDirectivo(){

            
            var directivo = new Directivo{Id = 4, Nombre = "James Howlett", Correo = "agujadinamica@gmail.com", DocumentoId = "1012090443", SalarioBruto=5000000, FechaDeNacimiento=1875, Categoria="Administrador"};
            _repoDirectivo.updateDirectivo(directivo);
            Console.WriteLine("SE ACTUALIZÓ EL DIRECTIVO CON ID " + directivo.Id); 
        }
        public static void getDirectivo(int idDirectivo){
           
            var directivo = _repoDirectivo.getDirectivo(idDirectivo);
            if(directivo==null){

                Console.WriteLine("NO SE ENCONTRÓ EL DIRECTIVO CON ID "+idDirectivo);
            }
            Console.WriteLine("EL DIRECTIVO CON ID "+idDirectivo+" CONSULTADO ES: "+ "Nombre: "+ directivo.Nombre +", "+"Correo: "+ directivo.Correo +", "+ "DocumentoID: "+directivo.DocumentoId +", "+ "Salaraio Bruto: "+directivo.SalarioBruto+", "+"Fecha de nacimiento: "+directivo.FechaDeNacimiento+", "+"Categoría: "+directivo.Categoria);

        }
        public static void deleteDirectivo(int idDirectivo){

            _repoDirectivo.deleteDirectivo(idDirectivo);

            Console.WriteLine("EL USUARIO CON ID "+idDirectivo+" HA SIDO REMOVIDO");
            
        }
        */
    }
}

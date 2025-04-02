using Servicios_jueves.Clases;
using Servicios_jueves.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Servicios_jueves.Controllers
{
    [RoutePrefix("api/empleados")]
    public class EmpleadosController : ApiController
    {

        //GET: SE UTILIZA PARA CONSULTAR INFORMACION , NODEBEN MODIFICAR LA BASE DE DATOS
        //POST: SE UTILIZA PARA INSETAR INFORMACIOM EM LA BASE DE DATOS
        //PUT: SE UTILIZA PARA MODIFICAR (ACTUALIZAR) LA BASE DE DATOS
        //DELETE= SE UTILIZA PARA ELIMINAR INFORMACION

        [HttpGet] //es el servicio qur se va a exponer: GET, PUT, POST , DELETE
        [Route("ConsultarTodos")] //Es la funcionalidad que se va a ejecutar
        public List<EMPLeado> ConsultarTodos() //se debe llamar tal cual se puso en el route
        {
            //se crea una instancia de la clase empleados
            clsEmpleado Empleado = new clsEmpleado();
            //Se invoca el metodo ConcultarTodos() de la clase clsEmpleado
            return Empleado.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXDocumento")]
        public EMPLeado ConsultarXDocumento(String Documento)
        {
            clsEmpleado Empleado = new clsEmpleado();
            return Empleado.Consultar(Documento);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] EMPLeado empleado) 
        {
            clsEmpleado Empleado = new clsEmpleado();

            //Se crea la propiedad empleado al objeto de la clase empleados
            Empleado.empleado = empleado;
            //Se invoca el metodo insertar
            return Empleado.Insertar();

        }
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] EMPLeado empleado)
        {
            clsEmpleado Empleado = new clsEmpleado();
            Empleado.empleado = empleado;
            return Empleado.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Elimnar([FromBody] EMPLeado empleado)
        {
            clsEmpleado Empleado = new clsEmpleado();
            Empleado.empleado = empleado;
            return Empleado.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXDocumento")]
        public string EliminarXDocumento(string Documento)
        {
            clsEmpleado Empleado = new clsEmpleado();
            return Empleado.Eliminar(Documento);
        }



    }
}
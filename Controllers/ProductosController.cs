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
    [RoutePrefix("api/productos")]
    public class ProductosController : ApiController
    {
        [HttpGet] 
        [Route("ConsultarTodos")] 
        public List<PRODucto> ConsultarTodos() 
        {
            clsProducto Producto = new clsProducto();
            return Producto.ConsultarTodos();
        }

        [HttpGet]
        [Route("Consultar")]
        public PRODucto Consultar(int Codigo)
        {
            clsProducto Producto = new clsProducto();
            return Producto.Consultar(Codigo);
        }

        [HttpGet]
        [Route("ConsultarXTipoProducto")]
        public List<PRODucto> ConsultarXTipoProducto (int CodTipoProducto)
        {
            clsProducto Producto = new clsProducto();
            return Producto.ConsultarXTipoProducto(CodTipoProducto);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] PRODucto producto)
        {
            clsProducto Producto = new clsProducto();
            Producto.producto = producto;
            return Producto.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] PRODucto producto)
        {
            clsProducto Producto = new clsProducto();
            Producto.producto = producto;
            return Producto.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Elimnar([FromBody] PRODucto producto)
        {
            clsProducto Producto = new clsProducto();
            Producto.producto = producto;
            return Producto.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXCodigo")]
        public string EliminarXCodigo(int Codigo)
        {
            clsProducto Producto = new clsProducto();
            return Producto.Eliminar(Codigo);
        }

        [HttpPut]
        [Route("inactivar")]
        public string inactivar(int Codigo)
        {
            clsProducto Producto = new clsProducto();
            return Producto.ModificarEstado(Codigo, false);
        }

        [HttpPut]
        [Route("Activar")]
        public string Activar(int Codigo)
        {
            clsProducto Producto = new clsProducto();
            return Producto.ModificarEstado(Codigo, true);
        }

    }
}
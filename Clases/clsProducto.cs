using Servicios_jueves.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Servicios_jueves.Clases
{
	public class clsProducto
	{
		private DBSuperEntities dbSuper = new DBSuperEntities();

		public PRODucto producto { get; set; }

		public string Insertar()
		{
			try
			{
				dbSuper.PRODuctoes.Add(producto);
				dbSuper.SaveChanges();
				return "Producto insertado correctamente";
			}
			catch (Exception ex)
			{
				return "Error al insertar el producto " + ex.Message;

			}
		}

        public string Actualizar()
        {
            try
            {
                PRODucto prod = Consultar(producto.Codigo);
                if (prod == null)
                {
                    return "El producto con el codigo ingresado no existe, no se puede actualizar";
                }
                dbSuper.PRODuctoes.AddOrUpdate(producto); //Actualiza el empleado en la lista
                dbSuper.SaveChanges(); //guardar los cambio en la base de datos
                return ("Producto actualizado con exito");

            }
            catch (Exception ex)
            {
                return "Error al actualizar el Producto: " + ex.Message;
            }
        }

        public PRODucto Consultar(int Codigo)
        {
            return dbSuper.PRODuctoes.FirstOrDefault(p => p.Codigo == Codigo);
        }

        public List<PRODucto> ConsultarTodos()
        {
            return dbSuper.PRODuctoes
                .OrderBy(p => p.Nombre) 
                .ToList(); 
        }

        public List<PRODucto> ConsultarXTipoProducto(int CodTipoProducto)
        {
            return dbSuper.PRODuctoes
                .Where(p => p.CodigoTipoProducto== CodTipoProducto)
                .OrderBy(p => p.Nombre)
                .ToList();
        }

       

        public string Eliminar()
        {
            try
            {
                PRODucto prod = Consultar(producto.Codigo);
                if (prod == null)
                {
                    return "El prodcuto con el codigo ingresado no existe";
                }
                dbSuper.PRODuctoes.Remove(prod); 
                dbSuper.SaveChanges(); 
                return ("Producto eliminado con exito");
            }
            catch (Exception ex)
            {
                return "Hubo un error al eliminar el producto " + ex.Message;
            }
        }

        public string Eliminar(int Codigo)
        {
            try
            {
                PRODucto prod = Consultar(Codigo);
                if (prod == null)
                {
                    return "El prodcuto con el codigo ingresado no existe";
                }
                dbSuper.PRODuctoes.Remove(prod);
                dbSuper.SaveChanges();
                return ("Producto eliminado con exito");
            }
            catch (Exception ex)
            {
                return "Hubo un error al eliminar el producto " + ex.Message;
            }
        }

        public string ModificarEstado(int Codigo, bool Activo)
        {
            try
            {
                PRODucto prod = Consultar(Codigo);
                if(prod== null)
                {
                    return "El codigo delproducto no existe en la base de datos";
                }
                prod.Activo = Activo;
                dbSuper.SaveChanges();
                if (Activo)
                {
                    return "Se activo correctamente el producto";
                }
                else
                {
                    return "Se inactivo correctamente el producto";
                }
            }
            catch(Exception ex)
            {
                return "Hubo un error al modificar el estado del producto " + ex.Message;
            }
        }

    }
}
using Servicios_jueves.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Servicios_jueves.Clases
{
	public class clsTipoProducto
	{
		private DBSuperEntities dbSuper = new DBSuperEntities;

		public TIpoPRoducto tipoProducto { get; set; }

		public List<TIpoPRoducto> ConsultarTodos()
		{
			return dbSuper.TIpoPRoductoes.ToList();
		}

		public TIpoPRoducto Consultar( int Codigo)
		{
			return dbSuper.TIpoPRoductoes.Where(x => x.Codigo == Codigo).FirstOrDefault();
		}

		public string Insertar()
		{
			try
			{
				dbSuper.TIpoPRoductoes.Add(tipoProducto);
				dbSuper.SaveChanges();
				return "Tipo producto insertado correctamente";
			}
			catch(Exception ex)
			{
				return "Error: " + ex.Message;
			}
		}
        public string Actualizar()
        {
            try
            {
                TIpoPRoducto tipoProd = Consultar(tipoProducto.Codigo);
                if (tipoProd == null)
                {
                    return "El tipo producto con el codigo ingresado no existe, no se puede actualizar";
                }
				tipoProd.Nombre = tipoProducto.Nombre;
				tipoProd.Activo = tipoProducto.Activo;
                dbSuper.SaveChanges();
                return ("Tipo producto actualizado con exito");

            }
            catch (Exception ex)
            {
                return "Error al actualizar el Producto: " + ex.Message;
            }
        }
    }
}
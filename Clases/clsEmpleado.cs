using Servicios_jueves.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace Servicios_jueves.Clases
{
	public class clsEmpleado
	{
		private DBSuperEntities dbSuper = new DBSuperEntities(); //Atributo para gestionar la conexion a la base de datos

		public EMPLeado empleado { get; set; } //propied para manipular la informacion en la base de datos permite agregar, modificar o eliminar

		public string Insertar()
		{
			try
			{
				dbSuper.EMPLeadoes.Add(empleado); //agrega el objeto empleado a la lista de empleadoes
				dbSuper.SaveChanges(); //guardar los cambio en la base de datos
				return ("Empleado creado con exito");
			}
			catch(Exception ex)
			{
				return "Error al insertar el empleado: " + ex.Message;
			}
		}

		public string Actualizar()
		{
			try
			{
                //antes de actualizar el elemento, se debe consultar, verificar que existe
                EMPLeado empl = Consultar(empleado.Documento);
				if (empl == null)
				{
					return "El empleado con el documento ingresado no existe, no se puede actualizar";
				}
				dbSuper.EMPLeadoes.AddOrUpdate(empleado); //Actualiza el empleado en la lista
                dbSuper.SaveChanges(); //guardar los cambio en la base de datos
                return ("Empleado actualizado con exito");

            }
            catch (Exception ex)
            {
                return "Error al actualizar el empleado: " + ex.Message;
            }

        }

		public List<EMPLeado> ConsultarTodos()
		{
			return dbSuper.EMPLeadoes
				.OrderBy(e => e.PrimerApellido) //funcion para ordenar
				.ToList(); //funcion que convierte la lista de datos en una lista de objetos
		}

		public EMPLeado Consultar(string Documento)
		{
			//Expresiones Lamda= permite definir funciones anonimas o instancias de objetos sin la creacion formal dependiente la lista a la cual se relacione
			// first o defaul= es una funcion que permite consultar el primer elemento de la lista que cumple con las condiciones
			return dbSuper.EMPLeadoes.FirstOrDefault(e => e.Documento == Documento);
		}

		public string Eliminar()
		{
            try
            {
                //antes de eliminar el elemento, se debe verificar que existe el empleado
                EMPLeado empl = Consultar(empleado.Documento);
                if (empl == null)
                {
                    return "El empleado con el documento ingresado no existe, no se puede eliminar";
                }
                dbSuper.EMPLeadoes.Remove(empl); //elimina el objeto que se busco, no el que se envia por parametros
                dbSuper.SaveChanges(); //guardar los cambio en la base de datos
                return ("Empleado eliminado con exito");

            }
            catch (Exception ex)
            {
                return "Error al eliminar el empleado: " + ex.Message;
            }

        }

        public string Eliminar(string Documento)
        {
            try
            {
                //antes de eliminar el elemento, se debe verificar que existe el empleado
                EMPLeado empl = Consultar(Documento);
                if (empl == null)
                {
                    return "El empleado con el documento ingresado no existe, no se puede eliminar";
                }
                dbSuper.EMPLeadoes.Remove(empl); //elimina el objeto que se busco, no el que se envia por parametros
                dbSuper.SaveChanges(); //guardar los cambio en la base de datos
                return ("Empleado eliminado con exito");

            }
            catch (Exception ex)
            {
                return "Error al eliminar el empleado: " + ex.Message;
            }

        }
    }
}
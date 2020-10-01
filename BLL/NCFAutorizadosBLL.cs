using System;
using Microsoft.EntityFrameworkCore;
using Examen_Parcial_1.DAL;
using Examen_Parcial_1.Models;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Examen_Parcial_1.BLL
{
    public class NCFAutorizadosBLL
    {
        public static bool Guardar(NCFAutorizados NCFAutorizado)
        {
            if(!Existe(NCFAutorizado.NcfId))
                return Insertar(NCFAutorizado);
            else
                return Modificar(NCFAutorizado);
        }

        private static bool Existe(int id)
        {
            bool existencia;
            Contexto contexto = new Contexto();

            try
            {
                existencia = contexto.NCFAutorizados.Any(n => n.NcfId == id);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return existencia;
        }

        private static bool Insertar(NCFAutorizados NCFAutorizado)
        {
            Contexto contexto = new Contexto();
            bool guardado = false;

            try
            {
                contexto.NCFAutorizados.Add(NCFAutorizado);
                guardado = (contexto.SaveChanges() > 0);
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return guardado;
        }

        private static bool Modificar(NCFAutorizados nCFAutorizado)
        {
            Contexto contexto = new Contexto();
            bool modificado = false;

            try
            {
                contexto.Entry(nCFAutorizado).State = EntityState.Modified;
                modificado = (contexto.SaveChanges() > 0);
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return modificado;
        }

        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool eliminado = false;

            try
            {
                var nCFAutorizado = contexto.NCFAutorizados.Find(id);

                if (nCFAutorizado != null)
                {
                    contexto.NCFAutorizados.Remove(nCFAutorizado);
                    eliminado = (contexto.SaveChanges() > 0);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return eliminado;
        }


         public static NCFAutorizados Buscar(int id)
        {
            Contexto contexto = new Contexto();
            NCFAutorizados NCFAutorizado;

            try
            {
                NCFAutorizado = contexto.NCFAutorizados.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return NCFAutorizado;
        }



        public static List<NCFAutorizados> GetList(Expression<Func<NCFAutorizados, bool>> NCFAutorizado)
        {
            List<NCFAutorizados> Lista = new List<NCFAutorizados>();
            Contexto contexto = new Contexto();

            try
            {
                Lista = contexto.NCFAutorizados.Where(NCFAutorizado).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return Lista;
        }

    }
}
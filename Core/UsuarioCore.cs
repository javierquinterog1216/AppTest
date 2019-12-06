using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Helper;
using Model;

namespace Core
{
    public class UsuarioCore
    {
        public UsuarioModel Get(int id)
        {
            try
            {
                var usuario = DAL.UsuarioDal.GetUsuario(id).ToList<UsuarioModel>().FirstOrDefault();
                return usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<UsuarioModel> GetAll()
        {
            try
            {
                var usuarios = DAL.UsuarioDal.GetUsuario(Constant.AllItems).ToList<UsuarioModel>();
                return usuarios;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int Add(UsuarioModel model)
        {
            try
            {
                return DAL.UsuarioDal.AddUsuario(model);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int Modify(UsuarioModel model)
        {
            try
            {
                return DAL.UsuarioDal.ModifyUsuario(model);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Delete(int id)
        {
            try
            {
                return DAL.UsuarioDal.DeleteUsuario(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

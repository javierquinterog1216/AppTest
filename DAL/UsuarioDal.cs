using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Helper;
using System.Data;

namespace DAL
{
    public class UsuarioDal
    {
        private const string Get = "Get_Usuario";
        private const string Add = "Add_Usuario";
        private const string Modify = "Modify_Usuario";
        private const string Delete = "Delete_Usuario";

       
        public static DataTable GetUsuario(int id)
        {
            DataTable result;
            Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(Utility.ConnectionStr);
            var command = db.GetStoredProcCommand(Get);
            db.AddInParameter(command, "@IdUsuario", DbType.Int32, id);
            result = db.ExecuteDataSet(command).Tables[0];
            return result;

        }
        public static int AddUsuario(UsuarioModel model)
        {
            Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(Utility.ConnectionStr);
            var command = db.GetStoredProcCommand(Add);
            //db.AddInParameter(command, "@Id", DbType.Int32, model.Id);
            db.AddInParameter(command, "@NombreUsuario", DbType.String, model.NombreUsuario);
            db.AddInParameter(command, "@Password", DbType.String, model.Password);
            return db.ExecuteNonQuery(command);

        }
        public static int ModifyUsuario(UsuarioModel model)
        {
            Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(Utility.ConnectionStr);
            var command = db.GetStoredProcCommand(Modify);
            db.AddInParameter(command, "@IdUsuario", DbType.Int32, model.IdUsuario);
            db.AddInParameter(command, "@NombreUsuario", DbType.String, model.NombreUsuario);
            db.AddInParameter(command, "@Password", DbType.String, model.Password);
            return db.ExecuteNonQuery(command);

        }
        
        public static int DeleteUsuario(int id)
        {
            Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(Utility.ConnectionStr);
            var command = db.GetStoredProcCommand(Delete);
            db.AddInParameter(command, "@IdUsuario", DbType.Int32, id);
            return db.ExecuteNonQuery(command);
        }

    }
}

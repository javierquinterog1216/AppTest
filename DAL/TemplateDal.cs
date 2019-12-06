using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using System.Data;
using Helper;
using Model;
namespace DAL
{
    public class TemplateDal
    {
        private const string spAdd = "Add";
        private const string spGet = "Get";
        private const string spModify = "Modify";
        private const string spDelete = "Delete";

        public static DataTable Get(int Id)
        {
            DataTable result;
            Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(Constant.connectionString);
            var command = db.GetStoredProcCommand(spGet);
            db.AddInParameter(command, "@Parameter", DbType.Int32, Id);
            result = db.ExecuteDataSet(command).Tables[0];
            return result;
        }

        public static int Add(ObjTemplateModel model)
        {
            Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(Constant.connectionString);
            var command = db.GetStoredProcCommand(spAdd);
            //db.AddInParameter(command, "@Id", DbType.Int32, model.Id);
            db.AddInParameter(command, "@Name", DbType.String, model.Name);
            db.AddInParameter(command, "@Phone", DbType.String, model.Phone);
            return db.ExecuteNonQuery(command);
        }

        public static int Modify(ObjTemplateModel model)
        {
            Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(Constant.connectionString);
            var command = db.GetStoredProcCommand(spModify);
            db.AddInParameter(command, "@Id", DbType.Int32, model.Id);
            db.AddInParameter(command, "@Name", DbType.String, model.Name);
            db.AddInParameter(command, "@Phone", DbType.String, model.Phone);
            return db.ExecuteNonQuery(command);
        }

        public static int Delete(int Id)
        {
            Database db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(Constant.connectionString);
            var command = db.GetStoredProcCommand(spDelete);
            db.AddInParameter(command, "@Id", DbType.Int32, Id);
            return db.ExecuteNonQuery(command);
        }

    }
}

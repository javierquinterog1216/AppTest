using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Helper
{
    public static class Utility
    {
        public static string ConnectionStr { get; private set; }//Propiedad donde quedará almacenado el connectioString
        /// <summary>
        /// Metodo para asignar la cadena de conexión al la propiedad ConnetionStr del Utility
        /// </summary>
        /// <param name="strConn"></param>
        public static void SetConnectioStr(string strConn)
        {
            ConnectionStr = strConn;
        }

        public static List<T> ToList<T>(this DataTable obj)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<T>>(JsonConvert.SerializeObject(obj));
            }
            catch (Exception)
            {

                throw;
            }
        }

       
    }

}

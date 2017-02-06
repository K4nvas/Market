using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace K4nvas.Market.Repository.Helper
{
    public static class Connection
    {
        public static string ObtenerStringConnection()
        {
            string server = WebConfigurationManager.AppSettings["Server"].ToString();
            string database = WebConfigurationManager.AppSettings["DataBase"].ToString();
            string user = WebConfigurationManager.AppSettings["User"].ToString();
            string pass = WebConfigurationManager.AppSettings["PassWord"].ToString();
            string stringConnection = $"server={server};iud={user};pwd={pass};database={database}";
            return stringConnection;
        }
    }
}

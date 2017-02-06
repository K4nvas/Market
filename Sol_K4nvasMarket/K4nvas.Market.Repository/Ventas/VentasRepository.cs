using K4nvas.Market.Repository.Contract.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K4nvas.Market.Model;
using MySql.Data.MySqlClient;
using K4nvas.Market.Repository.Helper;
using System.Data;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace K4nvas.Market.Repository.Ventas
{
    public class VentasRepository : IVentasRepository
    {
        private static DatabaseProviderFactory oDatabaseProviderFactory = new DatabaseProviderFactory();
        private readonly Database oDataBase = oDatabaseProviderFactory.Create("Cn_Market");
        private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["Cn_Market"].ConnectionString;

        public ListaCategoria ListarCategoriaProducto()
        {
            ListaCategoria oListaCategoria = new ListaCategoria();

            #region Data de Prueba

            //oListaCategoria.Add(new Categoria { IdCategoria = 1, Descripcion = "COMESTIBLES" });
            //oListaCategoria.Add(new Categoria { IdCategoria = 2, Descripcion = "BEBIDAS" });
            //oListaCategoria.Add(new Categoria { IdCategoria = 2, Descripcion = "EMPAQUETADOS" });
            //oListaCategoria.Add(new Categoria { IdCategoria = 2, Descripcion = "NO EMPAQUETADOS" });
            //oListaCategoria.Add(new Categoria { IdCategoria = 2, Descripcion = "GALLETAS" });

            #endregion

            Categoria oCategoria = null;

            DbCommand oDbCommand = oDataBase.GetStoredProcCommand(Procedimiento.Maestro.Usp_Sel_Categorias);

            using (IDataReader oIDataReader = oDataBase.ExecuteReader(oDbCommand))
            {
                while (oIDataReader.Read())
                {
                    oCategoria = new Categoria();
                    oCategoria.IdCategoria = Convert.ToInt32(oIDataReader[0]);
                    oCategoria.Descripcion = Convert.ToString(oIDataReader[1]);
                    oListaCategoria.Add(oCategoria);
                }
            }

            //using (MySqlConnection oMySqlConnection = new MySqlConnection(ConnectionString))
            //{
            //    MySqlCommand Command = new MySqlCommand();
            //    Command.CommandText = Procedimiento.Maestro.Usp_Sel_Categorias;
            //    Command.Connection = oMySqlConnection;
            //    Command.CommandType = CommandType.StoredProcedure;

            //    oMySqlConnection.Open();

            //    using (MySqlDataReader reader = Command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            oCategoria = new Categoria();
            //            oCategoria.IdCategoria = Convert.ToInt32(reader[0]);
            //            oCategoria.Descripcion = Convert.ToString(reader[1]);
            //            oListaCategoria.Add(oCategoria);
            //        }
            //    }
            //}


            return oListaCategoria;
        }
    }
}

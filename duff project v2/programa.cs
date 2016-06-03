using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duff_project_v2
{
    class programa
    {
       static int x;

        public static int Agregar(bebidas bbebida)
        {
             
            
        }
        public static int AgregarStock(stock sstock)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into registros (ID_BEBIDA,CANTIDAD,FECHA_REG,PRECIO_VENTA) values ('{0}','{1}','{2}','{3}')",
            sstock.idBebida, sstock.Cantidad, sstock.fechaReg, sstock.Precioventa), Conection.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static DataTable LlenarCombobox()
        {
            using (Conection.ObtenerConexion())
            {
                string query = "SELECT NOMBRE from bebidas ";
                MySqlCommand cmd = new MySqlCommand(query, Conection.ObtenerConexion());
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);
                return (dt);
               /* cbo_name.ValueMember = "NOMBRE";
                cbo_name.DataSource = dt;*/
            }
        }
        public static int LLenarTextbox(string pass)
        {
            
            using (Conection.ObtenerConexion())
            {
                MySqlCommand mycmd = new MySqlCommand();
                string consulta = "SELECT ID_BEBIDA from bebidas where NOMBRE='"+ pass +"'";
                mycmd.Connection = Conection.ObtenerConexion();
                mycmd.CommandText = consulta;
                MySqlDataReader myreader = mycmd.ExecuteReader();
                if (myreader.HasRows)
                {
                    while (myreader.Read())
                    {
                        myreader.Read();
                        x = int.Parse(myreader["ID_BEBIDA"] + Environment.NewLine);
                    }

                }
            }
            return (x);
        }
        public static MySqlConnection ObtenerConexion() //conectar a la base de datos
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=duff; Uid=root ; pwd=1234;");
            conectar.Open();
            return conectar;
        }

        public static List<bebidas> Actual()
        {
            List<bebidas> _lista = new List<bebidas>();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT  NOMBRE,TIPO,  CANTIDAD_MIN,DESCRIPCION  FROM bebidas "), ObtenerConexion());
            // ,U.CANTIDAD, U.PRECIO_VENTA
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                bebidas pBebidas = new bebidas();
                pBebidas.Nombre = _reader.GetString(0);
                pBebidas.Tipo = _reader.GetString(1);
                pBebidas.Cantidad_min = _reader.GetString(2);
                pBebidas.Descripcion = _reader.GetString(3);
                _lista.Add(pBebidas);
            }
            return _lista;


        }
        public static List<bebidas> ActualStock()
        {
            List<bebidas> _lista = new List<bebidas>();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT  NOMBRE,TIPO,  CANTIDAD_MIN,DESCRIPCION  FROM bebidas "), ObtenerConexion());
            // ,U.CANTIDAD, U.PRECIO_VENTA
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                bebidas pBebidas = new bebidas();
                pBebidas.Nombre = _reader.GetString(0);
                pBebidas.Tipo = _reader.GetString(1);
                pBebidas.Cantidad_min = _reader.GetString(2);
                pBebidas.Descripcion = _reader.GetString(3);
                _lista.Add(pBebidas);
            }
            return _lista;
        }
        public static List<buscar> Buscar(string pBebidaNom)
        {
            List<buscar> _lista = new List<buscar>();

          //  MySqlCommand _comando = new MySqlCommand(String.Format(
          // "SELECT  NOMBRE,TIPO,  CANTIDAD_MIN,DESCRIPCION  FROM bebidas where NOMBRE ='{0}'", pBebidaNom), ObtenerConexion());
             MySqlCommand _comando = new MySqlCommand(String.Format("SELECT b.NOMBRE,b.TIPO,b.CANTIDAD_MIN,b.DESCRIPCION, r.CANTIDAD,r.FECHA_REG,r.PRECIO_VENTA FROM duff.bebidas b, duff.registros r where b.NOMBRE = '{0}'and  r.ID_BEBIDA  = b.ID_BEBIDA",pBebidaNom), ObtenerConexion());
            // ,U.CANTIDAD, U.PRECIO_VENTA
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                buscar pBuscar = new buscar();
                //pBebidas. = _reader.GetInt32(0);
                pBuscar.Nombre = _reader.GetString(0);
                pBuscar.Tipo = _reader.GetString(1);
                pBuscar.Cantidad_min = _reader.GetString(2);
                pBuscar.Descripcion = _reader.GetString(3);
              //  stock pStock = new stock();
                pBuscar.Cantidad = _reader.GetString(4);
                pBuscar.fechaReg = _reader.GetDateTime(5);
                pBuscar.Precioventa = _reader.GetInt32(6);
                


               _lista.Add(pBuscar);
            }
            return _lista;
            
        }

       /* public static List<stock> BuscarP(string pBebidaNom)
        {
            List<stock> _lista = new List<stock>();
            stock sstock = new stock();
            int idBeb = sstock.idBebida;

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT r.CANTIDAD, r.PRECIO_VENTA  FROM duff.bebidas b, duff.registros r where b.NOMBRE =  '{0}' and r.ID_BEBIDA  = b.ID_BEBIDA ", pBebidaNom), ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
              
                stock pStock = new stock();
                pStock.Cantidad = _reader.GetString(0);
                pStock.Precioventa = _reader.GetInt32(1);
                //  pBebidas.Direccion = _reader.GetString(4);
                _lista.Add(pStock);
            }
            return _lista;
        }
        */
       
        public static List<buscar> Buscar2(string pBebidaNom)
        {
            List<buscar> _lista = new List<buscar>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT b.NOMBRE,b.TIPO,b.CANTIDAD_MIN,b.DESCRIPCION, r.CANTIDAD,r.FECHA_REG,r.PRECIO_VENTA FROM duff.bebidas b, duff.registros r where b.TIPO = '{0}' ORDER BY b.TIPO, r.FECHA_REG", pBebidaNom), ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                buscar pBuscar = new buscar();
                //pBebidas. = _reader.GetInt32(0);
                pBuscar.Nombre = _reader.GetString(0);
                pBuscar.Tipo = _reader.GetString(1);
                pBuscar.Cantidad_min = _reader.GetString(2);
                pBuscar.Descripcion = _reader.GetString(3);
                //  stock pStock = new stock();
                pBuscar.Cantidad = _reader.GetString(4);
                pBuscar.fechaReg = _reader.GetDateTime(5);
                pBuscar.Precioventa = _reader.GetInt32(6);



                _lista.Add(pBuscar);

            }

            return _lista;
        }
       /* public static List<stock> BuscarP2(string pBebidaNom)
        {
            List<stock> _lista = new List<stock>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT r.CANTIDAD, r.PRECIO_VENTA  FROM duff.bebidas b, duff.registros r where  b.TIPO = '{0}' and r.ID_BEBIDA  = b.ID_BEBIDA ", pBebidaNom), ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {



                stock pStock = new stock();
                pStock.Cantidad = _reader.GetString(0);
                pStock.Precioventa = _reader.GetInt32(1);
                //  pBebidas.Direccion = _reader.GetString(4);


                _lista.Add(pStock);
            }
            return _lista;
        }*/

        public static bebidas ObtenerClientebebi(String pId)
        {
           // List<bebidas> _lista = new List<bebidas>();
            bebidas pBebidas = new bebidas();

            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=duff; Uid=root ; pwd=1234;");
            conectar.Open();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT  NOMBRE,TIPO ,CANTIDAD_MIN,DESCRIPCION FROM bebidas where bebidas.NOMBRE='{0}'", pId), conectar);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                
                pBebidas.Tipo = _reader.GetString(0);
                pBebidas.Nombre = _reader.GetString(1);
                pBebidas.Cantidad_min = _reader.GetString(2);
                pBebidas.Descripcion = _reader.GetString(3);

             
            }

            conectar.Close();
            return pBebidas;

        }

        public static int Actualizar(bebidas pBebida)
        {
            int retorno = 0;
            MySqlConnection conexion = Conection.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update bebidas set NOMBRE = '{0}', TIPO='{1}',CANTIDAD_MIN ='{2}', DESCRIPCION='{3}' where NOMBRE='{0}'",
                pBebida.Nombre, pBebida.Tipo, pBebida.Cantidad_min, pBebida.Descripcion), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }

        public static int Eliminar(string pId)
        {
            int retorno = 0;
            MySqlConnection conexion = Conection.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From bebidas where NOMBRE='{0}'", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

    }
}

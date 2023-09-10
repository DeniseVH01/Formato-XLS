using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PlantillaExcel
{
    internal class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=LAPTOP-RNN6MELF\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos" + ex.ToString());

            }
        }

        public void MostrarTabla(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select top 50 CustomerID,OrderDate,ShippedDate,ShipVia,Freight,ShipName from Orders", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el data grid view" + ex.ToString());
            }
        }
    }
}

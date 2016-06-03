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
    public partial class menu_principal_vendedor : Form
    {
        public menu_principal_vendedor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView12.Visible = true;
            dataGridView11.Visible = true;

          //  if (cmbBus.Text == "BEBIDA")
          //  {
           //     dataGridView1.DataSource = programa.Buscar(textBus.Text);
                //dataGridView2.DataSource = programa.BuscarP(textBus.Text);
          //  }
           /// else
          //  {
           //     dataGridView1.DataSource = programa.Buscar2(textBus.Text);
          //      dataGridView2.DataSource = programa.BuscarP2(textBus.Text);
          //  }
//
            if (cmbBus1.Text == "BEBIDA")
            {
                dataGridView11.DataSource = programa.Buscar(textBus1.Text);
                //dataGridView12.DataSource = programa.BuscarP(textBus1.Text);
            }
            else
            {
                dataGridView11.DataSource = programa.Buscar2(textBus1.Text);
               // dataGridView12.DataSource = programa.BuscarP2(textBus1.Text);
            }
        }

        void autocomplete()
        {


            textBus1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBus1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            // Conection.ObtenerConexion();

        
            try
            {
                conectar.Open();
                myread = cmd.ExecuteReader();
                while (myread.Read())
                {
                    string Nombre = myread.GetString("NOMBRE");
                    coll.Add(Nombre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void textBus1_TextChanged(object sender, EventArgs e)
        {
         
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=duff; Uid=root ; pwd=1234;");
             conectar.Open();
             MySqlCommand cmd = new MySqlCommand("SELECT * FROM duff.bebidas ", conectar);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "My List");


                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                col.Add(ds.Tables[0].Rows[i]["NOMBRE"].ToString());
            // col.Add(ds.Tables[0].Rows[i]["phone_no"].ToString());
                        }

                textBus1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBus1.AutoCompleteCustomSource = col;     
                            textBus1.AutoCompleteMode = AutoCompleteMode.Suggest;

                                conectar.Close();

                }
        


    }
}

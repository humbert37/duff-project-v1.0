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
    public partial class menu_principal : Form
    {
        public menu_principal()
        {
            InitializeComponent();
            guardar.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            txModNom.Visible = false;
            textModCant.Visible = false;
            textModDesc.Visible = false;
            cmbMod.Visible = false;
            cbouni.DropDownStyle = ComboBoxStyle.DropDownList; //pa que no modifiquen el combobox
            cbo_unis.DropDownStyle = ComboBoxStyle.DropDownList; //pa que no modifiquen el combobox
            cbo_name.DropDownStyle = ComboBoxStyle.DropDownList; //pa que no modifiquen el combobox
            cbo_tipo.DropDownStyle = ComboBoxStyle.DropDownList; //pa que no modifiquen el combobox
            txt_caja.Enabled = false;
            lbl_caja.Enabled = false;
            cbouni.Enabled = false;
            //////vamo a inicia papu :v
            lbl_unidades.Enabled = false;
            txt_unidades.Enabled = false;
            ////
            txtcaj.Enabled = false;
            label14.Enabled = false;
            cbo_unis.Enabled = false;

            //////
            label15.Enabled = false;
            txtuni.Enabled = false;
            //inicializamos combobox con parametros papu
           cbo_name.ValueMember = "NOMBRE";
           cbo_name.DataSource = programa.LlenarCombobox();
            //inicializamos textbox con parametros papu
           //txtid.Text = Convert.ToString(programa.LLenarTextbox(cbo_name.Text));
           txtid.Text = "";
           
        }

        private void registro_bebida_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_caja.Enabled = true;
            lbl_caja.Enabled = true;
            cbouni.Enabled = true;
            //////
            lbl_unidades.Enabled = false;
            txt_unidades.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbl_caja.Enabled = false;
            txt_caja.Enabled= false;
            cbouni.Enabled = false;
            //////

            lbl_unidades.Enabled = true;
            txt_unidades.Enabled=true;


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void stock_bebidas_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtcaj.Enabled = true;
            label14.Enabled = true;
            cbo_unis.Enabled = true;
            
            //////
            label15.Enabled = false;
            txtuni.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtcaj.Enabled = false;
            label14.Enabled = false;
            cbo_unis.Enabled = false;

            //////
            label15.Enabled =true;
            txtuni.Enabled =true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bebidas bbebida = new bebidas();
            bbebida.Tipo = cbo_tipo.Text.Trim();
            bbebida.Nombre = txtbname.Text.Trim();
            if (radioButton1.Checked) { bbebida.Cantidad_min = txt_caja.Text.Trim() + "caja(s)" + cbouni.Text.Trim(); }
            else if (radioButton2.Checked) { bbebida.Cantidad_min = txt_unidades.Text.Trim() + "unidad(es)"; }
            bbebida.Descripcion = txt_descrip.Text.Trim();
            //bbebidas. = dtpFechaNacimiento.Value.Year + "/" + dtpFechaNacimiento.Value.Month + "/" + dtpFechaNacimiento.Value.Day;
            int resultado = programa.Agregar(bbebida);
            DialogResult boton = MessageBox.Show("Los datos ingresados son correctos?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (boton == DialogResult.OK)
            {
                if (resultado > 0)
                {
                    MessageBox.Show("Bebida Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la bebida", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            txtbname.Clear();
            txt_descrip.Clear();
            txt_caja.Clear();
            txt_unidades.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stock sstock = new stock(); 
            sstock.idBebida = int.Parse(txtid.Text.Trim());
            if (radioButton4.Checked) { sstock.Cantidad = txtcaj.Text.Trim() + "caja(s)" + cbo_unis.Text.Trim(); }
            else if (radioButton3.Checked) { sstock.Cantidad = txtuni.Text.Trim() +"unidad(es)"  ; }
            sstock.fechaReg = dtpRegistro.Value.Year + "/" + dtpRegistro.Value.Month + "/" + dtpRegistro.Value.Day;
            sstock.Precioventa = (int.Parse(txt_precio.Text.Trim()));
            int resultado = programa.AgregarStock(sstock);
            DialogResult boton = MessageBox.Show("Los datos ingresados son correctos?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (boton == DialogResult.OK)
            {
                if (resultado > 0)
                {
                    MessageBox.Show("Registro Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            cbo_name.ValueMember = "NOMBRE";
            cbo_name.DataSource = programa.LlenarCombobox();
            txtid.Text = Convert.ToString(programa.LLenarTextbox(cbo_name.Text));
        }
        
       

        private void cbo_name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtid.Text = Convert.ToString(programa.LLenarTextbox(cbo_name.Text));
        }



        void autocomplete()
        {


                textBus.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBus.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
                // Conection.ObtenerConexion();

                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=duff; Uid=root ; pwd=1234;");
                string query = "SELECT * FROM duff.bebidas ;";
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                MySqlDataReader myread;
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        //  dataGridView2.Visible = true;
        
            if (cmbBus.Text == "BEBIDA")
            {
                dataGridView1.DataSource = programa.Buscar(textBus.Text);
               // dataGridView2.DataSource = programa.BuscarP(textBus.Text);
            }
            else 
            {
                //
                dataGridView1.DataSource = programa.Buscar2(textBus.Text);
               // dataGridView2.DataSource = programa.BuscarP2(textBus.Text);
            }

           /* menu_principal  busmenu =  new menu_principal();
           busmenu.ShowDialog();

            if (busmenu.clienteSeleccionado != null)
            {
                txtbname.Text = busmenu.clienteSeleccionado.Nombre;
                txt_unidades.Text = busmenu.clienteSeleccionado.Cantidad_min;
                txt_descrip.Text = busmenu.clienteSeleccionado.Descripcion;
                cbo_tipo.Text = busmenu.clienteSeleccionado.Tipo;
            }*/

            
        }

        private void textBus_TextChanged(object sender, EventArgs e)
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

                textBus.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBus.AutoCompleteCustomSource = col;     
                            textBus.AutoCompleteMode = AutoCompleteMode.Suggest;

                                conectar.Close();

                }
        public bebidas clienteSeleccionado { get; set; }

        private void butMod_Click(object sender, EventArgs e)
        {
            guardar.Visible = true;
            txModNom.Visible = true;
            textModCant.Visible = true;
            textModDesc.Visible = true;
            cmbMod.Visible = true;
            txModNom.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textModCant.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textModDesc.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
          //  txtModMarca.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
           // txtModCilin.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();

                // modif esto abajo 

         //   if (dataGridView1.SelectedRows.Count == 1)
            //{

            //    String NOMBRE = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);

                



                //MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=duff; Uid=root ; pwd=1234;");
               // string query = "SELECT ID_BEBIDA FROM bebidas WHERE ID_BEBIDA={0} ";
              //  MySqlCommand cmd = new MySqlCommand((query, conectar);
                //MySqlDataReader myread;
              
           // MySqlCommand cmd = new MySqlCommand("SELECT ID_BEBIDA FROM bebidas WHERE ID_BEBIDA={0} " NOMBRE), conectar);

             //  clienteSeleccionado = programa.ObtenerClientebebi(NOMBRE);


               // this.Close();
           // }
          //  else
           //     MessageBox.Show("debe de seleccionar una fila");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            txModNom.Visible = false;
            textModCant.Visible = false;
            textModDesc.Visible = false;
            cmbMod.Visible = false;
            bebidas pBebidas = new bebidas();
             pBebidas.Tipo = cmbMod.Text.Trim();
             pBebidas.Nombre = txModNom.Text.Trim();
             pBebidas.Cantidad_min= textModCant.Text.Trim();
             pBebidas.Descripcion = textModDesc.Text.Trim();
             //pBebidas.Id = ClienteActual.Id;

            if (programa.Actualizar(pBebidas) > 0)
            {
                MessageBox.Show("Los datos del cliente se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            dataGridView1.DataSource = programa.Actual();

            
            
            
            
            /*menu_principal busmenu = new menu_principal();
            busmenu.ShowDialog();

            if (busmenu.clienteSeleccionado != null)
            {
                txtbname.Text = busmenu.clienteSeleccionado.Nombre;
                txt_unidades.Text = busmenu.clienteSeleccionado.Cantidad_min;
                txt_descrip.Text = busmenu.clienteSeleccionado.Descripcion;
                cbo_tipo.Text = busmenu.clienteSeleccionado.Tipo;
            }*/
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            String Nombre = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var resultado = MessageBox.Show("desea eliminar cliente?", "confirme eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                programa.Eliminar(Nombre);

                //logicaMoto.delMotos(identificacion);
                MessageBox.Show(" ELIMINADO");
                // gridlistausuarios(); // nos oculta todo
               // dataGridView1.Visible = false;
            }
            else
            {
                return;
            }
        }
        
        
    }
}

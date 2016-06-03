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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            string id_admin = txt_usuario.Text;
            string vadmin = "admin";
            string password = "adminpass";
            string pass = txt_contra.Text;

            if (pass.Equals(password) && id_admin.Equals(vadmin))
            {
                this.Visible = false;
                menu_principal menuprinc = new menu_principal();
                menuprinc.Show();

            }
            else
            {
                MessageBox.Show("Datos incorrectos!");

                txt_contra.Text = "";


                /////////////////////////

                string id_vendedor = txt_usuario.Text;
                string vidvendedor = "vendedor";
                string passwordv = "vendedorpass";
                string passv = txt_contra.Text;

                if (pass.Equals(passwordv) && id_vendedor.Equals(vidvendedor))
                {
                    this.Visible = false;
                    menu_principal_vendedor menuprincv = new menu_principal_vendedor();
                    menuprincv.Show();

                }
                else
                {
                    MessageBox.Show("Datos incorrectos!");

                    txt_contra.Text = "";

                }



            }


        }

        private void txt_contra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string id_admin = txt_usuario.Text;
                string vadmin = "admin";
                string password = "adminpass";
                string pass = txt_contra.Text;

                if (pass.Equals(password) && id_admin.Equals(vadmin))
                {
                    this.Visible = false;
                    menu_principal menuprinc = new menu_principal();
                    menuprinc.Show();

                }
                else
                {
                    MessageBox.Show("Datos incorrectos!");

                    txt_contra.Text = "";


                    /////////////////////////

                    string id_vendedor = txt_usuario.Text;
                    string vidvendedor = "vendedor";
                    string passwordv = "vendedorpass";
                    string passv = txt_contra.Text;

                    if (pass.Equals(passwordv) && id_vendedor.Equals(vidvendedor))
                    {
                        this.Visible = false;
                        menu_principal_vendedor menuprincv = new menu_principal_vendedor();
                        menuprincv.Show();

                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos!");

                        txt_contra.Text = "";

                    }



                }
            
            
            }
        }



        }
    }


namespace duff_project_v2
{
    partial class menu_principal_vendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_principal_vendedor));
            this.tab_menu = new System.Windows.Forms.TabControl();
            this.busqueda_bebida = new System.Windows.Forms.TabPage();
            this.cmbBus1 = new System.Windows.Forms.ComboBox();
            this.butBus1 = new System.Windows.Forms.Button();
            this.textBus1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.stock_bebidas = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView12 = new System.Windows.Forms.DataGridView();
            this.tab_menu.SuspendLayout();
            this.busqueda_bebida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_menu
            // 
            this.tab_menu.Controls.Add(this.busqueda_bebida);
            this.tab_menu.Controls.Add(this.stock_bebidas);
            this.tab_menu.Location = new System.Drawing.Point(120, 141);
            this.tab_menu.Name = "tab_menu";
            this.tab_menu.SelectedIndex = 0;
            this.tab_menu.Size = new System.Drawing.Size(639, 411);
            this.tab_menu.TabIndex = 1;
            // 
            // busqueda_bebida
            // 
            this.busqueda_bebida.Controls.Add(this.dataGridView12);
            this.busqueda_bebida.Controls.Add(this.cmbBus1);
            this.busqueda_bebida.Controls.Add(this.butBus1);
            this.busqueda_bebida.Controls.Add(this.textBus1);
            this.busqueda_bebida.Controls.Add(this.label9);
            this.busqueda_bebida.Controls.Add(this.dataGridView11);
            this.busqueda_bebida.Location = new System.Drawing.Point(4, 22);
            this.busqueda_bebida.Name = "busqueda_bebida";
            this.busqueda_bebida.Padding = new System.Windows.Forms.Padding(3);
            this.busqueda_bebida.Size = new System.Drawing.Size(631, 385);
            this.busqueda_bebida.TabIndex = 1;
            this.busqueda_bebida.Text = "Busqueda de bebida";
            this.busqueda_bebida.UseVisualStyleBackColor = true;
            // 
            // cmbBus1
            // 
            this.cmbBus1.FormattingEnabled = true;
            this.cmbBus1.Items.AddRange(new object[] {
            "TIPO",
            "BEBIDA"});
            this.cmbBus1.Location = new System.Drawing.Point(180, 37);
            this.cmbBus1.Name = "cmbBus1";
            this.cmbBus1.Size = new System.Drawing.Size(121, 21);
            this.cmbBus1.TabIndex = 8;
            // 
            // butBus1
            // 
            this.butBus1.Location = new System.Drawing.Point(516, 39);
            this.butBus1.Name = "butBus1";
            this.butBus1.Size = new System.Drawing.Size(75, 23);
            this.butBus1.TabIndex = 4;
            this.butBus1.Text = "Buscar";
            this.butBus1.UseVisualStyleBackColor = true;
            this.butBus1.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBus1
            // 
            this.textBus1.Location = new System.Drawing.Point(368, 38);
            this.textBus1.Name = "textBus1";
            this.textBus1.Size = new System.Drawing.Size(116, 20);
            this.textBus1.TabIndex = 3;
            this.textBus1.TextChanged += new System.EventHandler(this.textBus1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Buscar pro Tipo  :";
            // 
            // dataGridView11
            // 
            this.dataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView11.Location = new System.Drawing.Point(55, 87);
            this.dataGridView11.Name = "dataGridView11";
            this.dataGridView11.Size = new System.Drawing.Size(264, 106);
            this.dataGridView11.TabIndex = 1;
            // 
            // stock_bebidas
            // 
            this.stock_bebidas.Location = new System.Drawing.Point(4, 22);
            this.stock_bebidas.Name = "stock_bebidas";
            this.stock_bebidas.Size = new System.Drawing.Size(631, 385);
            this.stock_bebidas.TabIndex = 2;
            this.stock_bebidas.Text = "Stock de Bebidas";
            this.stock_bebidas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(288, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // dataGridView12
            // 
            this.dataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView12.Location = new System.Drawing.Point(318, 87);
            this.dataGridView12.Name = "dataGridView12";
            this.dataGridView12.Size = new System.Drawing.Size(240, 106);
            this.dataGridView12.TabIndex = 9;
            // 
            // menu_principal_vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(903, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tab_menu);
            this.Name = "menu_principal_vendedor";
            this.Text = "menu_principal_vendedor";
            this.tab_menu.ResumeLayout(false);
            this.busqueda_bebida.ResumeLayout(false);
            this.busqueda_bebida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_menu;
        private System.Windows.Forms.TabPage busqueda_bebida;
        private System.Windows.Forms.Button butBus1;
        private System.Windows.Forms.TextBox textBus1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.TabPage stock_bebidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBus1;
        private System.Windows.Forms.DataGridView dataGridView12;
    }
}
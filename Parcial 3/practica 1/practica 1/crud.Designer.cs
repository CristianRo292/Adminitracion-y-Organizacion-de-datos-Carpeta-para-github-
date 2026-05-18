namespace practica_1
{
    partial class crud
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
            panel1 = new Panel();
            btnAcivar_crud = new Button();
            btnSalir_crud = new Button();
            btnModificar_crud = new Button();
            btnEliminar_crud = new Button();
            txtPasware_crud = new TextBox();
            txtUsuario_crud = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dataUsuario_crud = new DataGridView();
            Numero = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            pageSetupDialog1 = new PageSetupDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataUsuario_crud).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAcivar_crud);
            panel1.Controls.Add(btnSalir_crud);
            panel1.Controls.Add(btnModificar_crud);
            panel1.Controls.Add(btnEliminar_crud);
            panel1.Controls.Add(txtPasware_crud);
            panel1.Controls.Add(txtUsuario_crud);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 150);
            panel1.TabIndex = 0;
            // 
            // btnAcivar_crud
            // 
            btnAcivar_crud.Enabled = false;
            btnAcivar_crud.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnAcivar_crud.Location = new Point(501, 33);
            btnAcivar_crud.Name = "btnAcivar_crud";
            btnAcivar_crud.Size = new Size(102, 78);
            btnAcivar_crud.TabIndex = 7;
            btnAcivar_crud.Text = "Activar";
            btnAcivar_crud.UseVisualStyleBackColor = true;
            btnAcivar_crud.Click += btnAcivar_crud_Click;
            // 
            // btnSalir_crud
            // 
            btnSalir_crud.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnSalir_crud.Location = new Point(636, 33);
            btnSalir_crud.Name = "btnSalir_crud";
            btnSalir_crud.Size = new Size(102, 78);
            btnSalir_crud.TabIndex = 6;
            btnSalir_crud.Text = "Salir";
            btnSalir_crud.UseVisualStyleBackColor = true;
            btnSalir_crud.Click += btnSalir_crud_Click;
            // 
            // btnModificar_crud
            // 
            btnModificar_crud.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnModificar_crud.Location = new Point(501, 33);
            btnModificar_crud.Name = "btnModificar_crud";
            btnModificar_crud.Size = new Size(102, 78);
            btnModificar_crud.TabIndex = 5;
            btnModificar_crud.Text = "Modificar";
            btnModificar_crud.UseVisualStyleBackColor = true;
            btnModificar_crud.Visible = false;
            btnModificar_crud.Click += btnModificar_crud_Click;
            // 
            // btnEliminar_crud
            // 
            btnEliminar_crud.Enabled = false;
            btnEliminar_crud.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnEliminar_crud.Location = new Point(371, 33);
            btnEliminar_crud.Name = "btnEliminar_crud";
            btnEliminar_crud.Size = new Size(102, 78);
            btnEliminar_crud.TabIndex = 4;
            btnEliminar_crud.Text = "Eliminar";
            btnEliminar_crud.UseVisualStyleBackColor = true;
            btnEliminar_crud.Click += btnEliminar_crud_Click;
            // 
            // txtPasware_crud
            // 
            txtPasware_crud.Enabled = false;
            txtPasware_crud.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            txtPasware_crud.Location = new Point(102, 89);
            txtPasware_crud.Name = "txtPasware_crud";
            txtPasware_crud.Size = new Size(236, 27);
            txtPasware_crud.TabIndex = 3;
            // 
            // txtUsuario_crud
            // 
            txtUsuario_crud.Enabled = false;
            txtUsuario_crud.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            txtUsuario_crud.Location = new Point(102, 38);
            txtUsuario_crud.Name = "txtUsuario_crud";
            txtUsuario_crud.Size = new Size(236, 27);
            txtUsuario_crud.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            label2.Location = new Point(21, 89);
            label2.Name = "label2";
            label2.Size = new Size(79, 22);
            label2.TabIndex = 1;
            label2.Text = "Pasware";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            label1.Location = new Point(21, 38);
            label1.Name = "label1";
            label1.Size = new Size(75, 22);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataUsuario_crud);
            panel2.Location = new Point(1, 168);
            panel2.Name = "panel2";
            panel2.Size = new Size(779, 286);
            panel2.TabIndex = 1;
            // 
            // dataUsuario_crud
            // 
            dataUsuario_crud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUsuario_crud.Columns.AddRange(new DataGridViewColumn[] { Numero, Usuario, Contraseña });
            dataUsuario_crud.Location = new Point(3, 3);
            dataUsuario_crud.Name = "dataUsuario_crud";
            dataUsuario_crud.RowHeadersWidth = 51;
            dataUsuario_crud.Size = new Size(773, 280);
            dataUsuario_crud.TabIndex = 0;
            dataUsuario_crud.CellClick += dataUsuario_crud_CellClick;
            dataUsuario_crud.MouseClick += dataUsuario_crud_MouseClick;
            // 
            // Numero
            // 
            Numero.HeaderText = "N°";
            Numero.MinimumWidth = 6;
            Numero.Name = "Numero";
            Numero.Width = 125;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.Width = 320;
            // 
            // Contraseña
            // 
            Contraseña.HeaderText = "Contraseña";
            Contraseña.MinimumWidth = 6;
            Contraseña.Name = "Contraseña";
            Contraseña.Width = 320;
            // 
            // crud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "crud";
            Text = "crud";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataUsuario_crud).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnSalir_crud;
        private Button btnModificar_crud;
        private Button btnEliminar_crud;
        private TextBox txtPasware_crud;
        private TextBox txtUsuario_crud;
        private Label label2;
        private Label label1;
        private DataGridView dataUsuario_crud;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Contraseña;
        private PageSetupDialog pageSetupDialog1;
        private Button btnAcivar_crud;
    }
}
namespace practica_1
{
    partial class Practica1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnAceptar = new Button();
            btnGuardar = new Button();
            txtUsuario = new TextBox();
            txtPasware = new TextBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold);
            label1.Location = new Point(23, 32);
            label1.Name = "label1";
            label1.Size = new Size(77, 24);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold);
            label2.Location = new Point(23, 90);
            label2.Name = "label2";
            label2.Size = new Size(81, 24);
            label2.TabIndex = 1;
            label2.Text = "Pasware";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold);
            btnAceptar.Location = new Point(45, 198);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 43);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold);
            btnGuardar.Location = new Point(207, 198);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 43);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Gruardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic);
            txtUsuario.Location = new Point(106, 32);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(252, 34);
            txtUsuario.TabIndex = 4;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // txtPasware
            // 
            txtPasware.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic);
            txtPasware.Location = new Point(110, 90);
            txtPasware.Name = "txtPasware";
            txtPasware.Size = new Size(248, 34);
            txtPasware.TabIndex = 5;
            txtPasware.KeyPress += txtPasware_KeyPress;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold);
            btnSalir.Location = new Point(353, 198);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 43);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Practica1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(btnSalir);
            Controls.Add(txtPasware);
            Controls.Add(txtUsuario);
            Controls.Add(btnGuardar);
            Controls.Add(btnAceptar);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(500, 300);
            MinimumSize = new Size(500, 300);
            Name = "Practica1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAceptar;
        private Button btnGuardar;
        private TextBox txtUsuario;
        private TextBox txtPasware;
        private Button btnSalir;
    }
}

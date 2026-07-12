namespace PROYECTO_INTEGRADOR
{
    partial class FormRegistroUsuario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelConfContraseña = new System.Windows.Forms.Label();
            this.labelPerfil = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textConfPassword = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Controls.Add(this.buttonRegistrar);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textConfPassword);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.labelPerfil);
            this.groupBox1.Controls.Add(this.labelConfContraseña);
            this.groupBox1.Controls.Add(this.labelContraseña);
            this.groupBox1.Controls.Add(this.labelNombreUsuario);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ristro de Usuario";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(203, 42);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(240, 26);
            this.textNombre.TabIndex = 0;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Location = new System.Drawing.Point(7, 45);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(150, 20);
            this.labelNombreUsuario.TabIndex = 1;
            this.labelNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(6, 91);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(96, 20);
            this.labelContraseña.TabIndex = 2;
            this.labelContraseña.Text = "Contraseña:";
            // 
            // labelConfContraseña
            // 
            this.labelConfContraseña.AutoSize = true;
            this.labelConfContraseña.Location = new System.Drawing.Point(6, 143);
            this.labelConfContraseña.Name = "labelConfContraseña";
            this.labelConfContraseña.Size = new System.Drawing.Size(160, 20);
            this.labelConfContraseña.TabIndex = 3;
            this.labelConfContraseña.Text = "Confirmar Contrseña:";
            // 
            // labelPerfil
            // 
            this.labelPerfil.AutoSize = true;
            this.labelPerfil.Location = new System.Drawing.Point(7, 197);
            this.labelPerfil.Name = "labelPerfil";
            this.labelPerfil.Size = new System.Drawing.Size(48, 20);
            this.labelPerfil.TabIndex = 4;
            this.labelPerfil.Text = "Perfil:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(203, 91);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(240, 26);
            this.textPassword.TabIndex = 5;
            // 
            // textConfPassword
            // 
            this.textConfPassword.Location = new System.Drawing.Point(203, 143);
            this.textConfPassword.Name = "textConfPassword";
            this.textConfPassword.Size = new System.Drawing.Size(240, 26);
            this.textConfPassword.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Medico",
            "Enfermera"});
            this.comboBox1.Location = new System.Drawing.Point(203, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(203, 257);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(89, 33);
            this.buttonRegistrar.TabIndex = 8;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(356, 257);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(87, 33);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 344);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRegistroUsuario";
            this.Text = "FormRegistroUsuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPerfil;
        private System.Windows.Forms.Label labelConfContraseña;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textConfPassword;
        private System.Windows.Forms.TextBox textPassword;
    }
}
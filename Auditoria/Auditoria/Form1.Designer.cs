namespace Auditoria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Host = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.lstConexion = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Puerto = new System.Windows.Forms.Label();
            this.Tipoconexion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Respuesta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(747, 107);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(203, 26);
            this.Host.TabIndex = 0;
            this.Host.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(747, 196);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(203, 26);
            this.User.TabIndex = 1;
            this.User.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(747, 150);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(203, 26);
            this.Port.TabIndex = 2;
            // 
            // lstConexion
            // 
            this.lstConexion.FormattingEnabled = true;
            this.lstConexion.Items.AddRange(new object[] {
            "ORACLE",
            "SQL SERVER"});
            this.lstConexion.Location = new System.Drawing.Point(747, 66);
            this.lstConexion.Name = "lstConexion";
            this.lstConexion.Size = new System.Drawing.Size(203, 28);
            this.lstConexion.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(747, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Analizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(747, 256);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(203, 26);
            this.Password.TabIndex = 5;
            // 
            // Puerto
            // 
            this.Puerto.AutoSize = true;
            this.Puerto.Location = new System.Drawing.Point(666, 113);
            this.Puerto.Name = "Puerto";
            this.Puerto.Size = new System.Drawing.Size(43, 20);
            this.Puerto.TabIndex = 6;
            this.Puerto.Text = "Host";
            this.Puerto.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tipoconexion
            // 
            this.Tipoconexion.AutoSize = true;
            this.Tipoconexion.Location = new System.Drawing.Point(574, 74);
            this.Tipoconexion.Name = "Tipoconexion";
            this.Tipoconexion.Size = new System.Drawing.Size(135, 20);
            this.Tipoconexion.TabIndex = 7;
            this.Tipoconexion.Text = "Tipo de Conexion ";
            this.Tipoconexion.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Puerto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contraseña";
            // 
            // Respuesta
            // 
            this.Respuesta.AutoSize = true;
            this.Respuesta.Location = new System.Drawing.Point(558, 414);
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.Size = new System.Drawing.Size(0, 20);
            this.Respuesta.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(409, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 495);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 548);
            this.Controls.Add(this.Respuesta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tipoconexion);
            this.Controls.Add(this.Puerto);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstConexion);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Sistema de Auditoria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.ComboBox lstConexion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Puerto;
        private System.Windows.Forms.Label Tipoconexion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Respuesta;
        private System.Windows.Forms.Panel panel1;
    }
}


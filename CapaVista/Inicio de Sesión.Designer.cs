namespace CapaVista
{
    partial class Inicio_de_Sesión
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_iniciarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(182, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar Sesión";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.icono_usuario;
            this.pictureBox1.Location = new System.Drawing.Point(243, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(189, 366);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(278, 26);
            this.txt_Usuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(242, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(189, 429);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(278, 26);
            this.txt_Contraseña.TabIndex = 5;
            // 
            // btn_iniciarSesion
            // 
            this.btn_iniciarSesion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciarSesion.Location = new System.Drawing.Point(204, 475);
            this.btn_iniciarSesion.Name = "btn_iniciarSesion";
            this.btn_iniciarSesion.Size = new System.Drawing.Size(254, 65);
            this.btn_iniciarSesion.TabIndex = 7;
            this.btn_iniciarSesion.Text = "Iniciar Sesión";
            this.btn_iniciarSesion.UseVisualStyleBackColor = true;
            this.btn_iniciarSesion.Click += new System.EventHandler(this.btn_iniciarSesion_Click);
            // 
            // Inicio_de_Sesión
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(648, 651);
            this.Controls.Add(this.btn_iniciarSesion);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Inicio_de_Sesión";
            this.Text = "Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Button btn_iniciarSesion;
    }
}
namespace MantencionCLA
{
    partial class frm_activa_usuario
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
            this.cmd_salir = new System.Windows.Forms.Button();
            this.cmd_ingreso = new System.Windows.Forms.Button();
            this.txt_nueva_2 = new System.Windows.Forms.TextBox();
            this.txt_nueva_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_usuario_activo = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_salir
            // 
            this.cmd_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_salir.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.cmd_salir.FlatAppearance.BorderSize = 0;
            this.cmd_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.cmd_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_salir.Location = new System.Drawing.Point(350, 121);
            this.cmd_salir.Name = "cmd_salir";
            this.cmd_salir.Size = new System.Drawing.Size(96, 96);
            this.cmd_salir.TabIndex = 10;
            this.cmd_salir.Text = "Salir";
            this.cmd_salir.UseVisualStyleBackColor = true;
            this.cmd_salir.Click += new System.EventHandler(this.cmd_salir_Click);
            // 
            // cmd_ingreso
            // 
            this.cmd_ingreso.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_ingreso.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.cmd_ingreso.FlatAppearance.BorderSize = 0;
            this.cmd_ingreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.cmd_ingreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.cmd_ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_ingreso.Location = new System.Drawing.Point(16, 121);
            this.cmd_ingreso.Name = "cmd_ingreso";
            this.cmd_ingreso.Size = new System.Drawing.Size(96, 96);
            this.cmd_ingreso.TabIndex = 9;
            this.cmd_ingreso.Text = "Activar";
            this.cmd_ingreso.UseVisualStyleBackColor = true;
            this.cmd_ingreso.Click += new System.EventHandler(this.cmd_ingreso_Click);
            // 
            // txt_nueva_2
            // 
            this.txt_nueva_2.BackColor = System.Drawing.Color.Snow;
            this.txt_nueva_2.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nueva_2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txt_nueva_2.Location = new System.Drawing.Point(183, 82);
            this.txt_nueva_2.Name = "txt_nueva_2";
            this.txt_nueva_2.Size = new System.Drawing.Size(263, 33);
            this.txt_nueva_2.TabIndex = 8;
            this.txt_nueva_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nueva_2.UseSystemPasswordChar = true;
            // 
            // txt_nueva_1
            // 
            this.txt_nueva_1.BackColor = System.Drawing.Color.Snow;
            this.txt_nueva_1.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nueva_1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txt_nueva_1.Location = new System.Drawing.Point(183, 43);
            this.txt_nueva_1.Name = "txt_nueva_1";
            this.txt_nueva_1.Size = new System.Drawing.Size(263, 33);
            this.txt_nueva_1.TabIndex = 7;
            this.txt_nueva_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nueva_1.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Repita nueva clave";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nueva clave";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_usuario_activo
            // 
            this.lbl_usuario_activo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_usuario_activo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_usuario_activo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario_activo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_usuario_activo.Location = new System.Drawing.Point(183, 4);
            this.lbl_usuario_activo.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_usuario_activo.Name = "lbl_usuario_activo";
            this.lbl_usuario_activo.Size = new System.Drawing.Size(263, 33);
            this.lbl_usuario_activo.TabIndex = 13;
            this.lbl_usuario_activo.Text = "Usuario";
            this.lbl_usuario_activo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_usuario.Location = new System.Drawing.Point(12, 9);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(124, 23);
            this.lbl_usuario.TabIndex = 14;
            this.lbl_usuario.Text = "Usuario";
            this.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_activa_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 237);
            this.Controls.Add(this.cmd_salir);
            this.Controls.Add(this.cmd_ingreso);
            this.Controls.Add(this.txt_nueva_2);
            this.Controls.Add(this.txt_nueva_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_usuario_activo);
            this.Controls.Add(this.lbl_usuario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(474, 276);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(474, 276);
            this.Name = "frm_activa_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dar de Alta Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_salir;
        private System.Windows.Forms.Button cmd_ingreso;
        private System.Windows.Forms.TextBox txt_nueva_2;
        private System.Windows.Forms.TextBox txt_nueva_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_usuario_activo;
        private System.Windows.Forms.Label lbl_usuario;
    }
}
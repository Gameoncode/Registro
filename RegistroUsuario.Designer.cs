
namespace Registro
{
    partial class RegistroUsuario
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
            this.BTNombre = new System.Windows.Forms.Label();
            this.LBPass = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.BTLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRelog = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNombre
            // 
            this.BTNombre.AutoSize = true;
            this.BTNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNombre.Location = new System.Drawing.Point(126, 145);
            this.BTNombre.Name = "BTNombre";
            this.BTNombre.Size = new System.Drawing.Size(147, 37);
            this.BTNombre.TabIndex = 0;
            this.BTNombre.Text = "Matricula";
            this.BTNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBPass
            // 
            this.LBPass.AutoSize = true;
            this.LBPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPass.Location = new System.Drawing.Point(118, 244);
            this.LBPass.Name = "LBPass";
            this.LBPass.Size = new System.Drawing.Size(155, 31);
            this.LBPass.TabIndex = 1;
            this.LBPass.Text = "Contraseña";
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.Location = new System.Drawing.Point(298, 144);
            this.TBNombre.MaxLength = 7;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(166, 38);
            this.TBNombre.TabIndex = 2;
            this.TBNombre.TextChanged += new System.EventHandler(this.TBNombre_TextChanged);
            // 
            // TBPass
            // 
            this.TBPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPass.Location = new System.Drawing.Point(298, 237);
            this.TBPass.MaxLength = 16;
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(155, 38);
            this.TBPass.TabIndex = 3;
            this.TBPass.TextChanged += new System.EventHandler(this.TBPass_TextChanged);
            // 
            // Registrar
            // 
            this.Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.Location = new System.Drawing.Point(327, 357);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(164, 67);
            this.Registrar.TabIndex = 4;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // BTLimpiar
            // 
            this.BTLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLimpiar.Location = new System.Drawing.Point(548, 357);
            this.BTLimpiar.Name = "BTLimpiar";
            this.BTLimpiar.Size = new System.Drawing.Size(164, 67);
            this.BTLimpiar.TabIndex = 5;
            this.BTLimpiar.Text = "Limpiar";
            this.BTLimpiar.UseVisualStyleBackColor = true;
            this.BTLimpiar.Click += new System.EventHandler(this.BTLimpiar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(124, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRelog
            // 
            this.lblRelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelog.Location = new System.Drawing.Point(942, 9);
            this.lblRelog.Name = "lblRelog";
            this.lblRelog.Size = new System.Drawing.Size(148, 74);
            this.lblRelog.TabIndex = 8;
            this.lblRelog.Text = "label1";
            this.lblRelog.Click += new System.EventHandler(this.lblRelog_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(773, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 67);
            this.button2.TabIndex = 9;
            this.button2.Text = "Salida";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblRelog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTLimpiar);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LBPass);
            this.Controls.Add(this.BTNombre);
            this.Name = "RegistroUsuario";
            this.Text = "RegistroUsuario";
            this.Load += new System.EventHandler(this.RegistroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BTNombre;
        private System.Windows.Forms.Label LBPass;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button BTLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRelog;
        private System.Windows.Forms.Button button2;
    }
}

namespace Registro
{
    partial class InicioDeSesion
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
            this.BTLimpiar = new System.Windows.Forms.Button();
            this.BTIniciarSesion = new System.Windows.Forms.Button();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LBPass = new System.Windows.Forms.Label();
            this.BTNombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTLimpiar
            // 
            this.BTLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLimpiar.Location = new System.Drawing.Point(489, 330);
            this.BTLimpiar.Name = "BTLimpiar";
            this.BTLimpiar.Size = new System.Drawing.Size(188, 73);
            this.BTLimpiar.TabIndex = 11;
            this.BTLimpiar.Text = "Limpiar";
            this.BTLimpiar.UseVisualStyleBackColor = true;
            this.BTLimpiar.Click += new System.EventHandler(this.BTLimpiar_Click);
            // 
            // BTIniciarSesion
            // 
            this.BTIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTIniciarSesion.Location = new System.Drawing.Point(275, 330);
            this.BTIniciarSesion.Name = "BTIniciarSesion";
            this.BTIniciarSesion.Size = new System.Drawing.Size(182, 73);
            this.BTIniciarSesion.TabIndex = 10;
            this.BTIniciarSesion.Text = "Iniciar Sesion";
            this.BTIniciarSesion.UseVisualStyleBackColor = true;
            this.BTIniciarSesion.Click += new System.EventHandler(this.BTIniciarSesion_Click);
            // 
            // TBPass
            // 
            this.TBPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPass.Location = new System.Drawing.Point(329, 249);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(155, 38);
            this.TBPass.TabIndex = 9;
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.Location = new System.Drawing.Point(329, 164);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(155, 38);
            this.TBNombre.TabIndex = 8;
            // 
            // LBPass
            // 
            this.LBPass.AutoSize = true;
            this.LBPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPass.Location = new System.Drawing.Point(151, 249);
            this.LBPass.Name = "LBPass";
            this.LBPass.Size = new System.Drawing.Size(155, 31);
            this.LBPass.TabIndex = 7;
            this.LBPass.Text = "Contraseña";
            // 
            // BTNombre
            // 
            this.BTNombre.AutoSize = true;
            this.BTNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNombre.Location = new System.Drawing.Point(172, 164);
            this.BTNombre.Name = "BTNombre";
            this.BTNombre.Size = new System.Drawing.Size(124, 31);
            this.BTNombre.TabIndex = 6;
            this.BTNombre.Text = "Matricula";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(85, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 70);
            this.button1.TabIndex = 12;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "Iniciar Sesion";
            // 
            // InicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTLimpiar);
            this.Controls.Add(this.BTIniciarSesion);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LBPass);
            this.Controls.Add(this.BTNombre);
            this.Name = "InicioDeSesion";
            this.Text = "InicioDeSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTLimpiar;
        private System.Windows.Forms.Button BTIniciarSesion;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LBPass;
        private System.Windows.Forms.Label BTNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
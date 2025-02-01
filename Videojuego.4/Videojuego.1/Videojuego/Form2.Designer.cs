namespace Videojuego
{
    partial class Form2
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
            this.OutPutTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBJugador = new System.Windows.Forms.TextBox();
            this.GuardarBt = new System.Windows.Forms.Button();
            this.LeerBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutPutTB
            // 
            this.OutPutTB.Location = new System.Drawing.Point(73, 90);
            this.OutPutTB.Multiline = true;
            this.OutPutTB.Name = "OutPutTB";
            this.OutPutTB.Size = new System.Drawing.Size(577, 397);
            this.OutPutTB.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre del Jugador";
            // 
            // TBJugador
            // 
            this.TBJugador.Location = new System.Drawing.Point(38, 47);
            this.TBJugador.Name = "TBJugador";
            this.TBJugador.Size = new System.Drawing.Size(228, 26);
            this.TBJugador.TabIndex = 20;
            // 
            // GuardarBt
            // 
            this.GuardarBt.Location = new System.Drawing.Point(389, 11);
            this.GuardarBt.Name = "GuardarBt";
            this.GuardarBt.Size = new System.Drawing.Size(130, 69);
            this.GuardarBt.TabIndex = 21;
            this.GuardarBt.Text = "Guardar Partida";
            this.GuardarBt.UseVisualStyleBackColor = true;
            this.GuardarBt.Click += new System.EventHandler(this.GuardarBt_Click);
            // 
            // LeerBt
            // 
            this.LeerBt.Location = new System.Drawing.Point(539, 20);
            this.LeerBt.Name = "LeerBt";
            this.LeerBt.Size = new System.Drawing.Size(130, 53);
            this.LeerBt.TabIndex = 22;
            this.LeerBt.Text = "Leer Partidas Anteriores";
            this.LeerBt.UseVisualStyleBackColor = true;
            this.LeerBt.Click += new System.EventHandler(this.LeerBt_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 508);
            this.Controls.Add(this.LeerBt);
            this.Controls.Add(this.GuardarBt);
            this.Controls.Add(this.TBJugador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutPutTB);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutPutTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBJugador;
        private System.Windows.Forms.Button GuardarBt;
        private System.Windows.Forms.Button LeerBt;
    }
}
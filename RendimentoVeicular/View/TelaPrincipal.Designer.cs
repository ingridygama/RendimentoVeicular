
namespace RendimentoVeicular.View
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblKM = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.lblRendimento = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.tbxKM = new System.Windows.Forms.TextBox();
            this.tbxLitros = new System.Windows.Forms.TextBox();
            this.lblRendimentoResultado = new System.Windows.Forms.Label();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(354, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(133, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculo de Combustivel";
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Location = new System.Drawing.Point(195, 164);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(25, 15);
            this.lblKM.TabIndex = 1;
            this.lblKM.Text = "&KM";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(188, 230);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(36, 15);
            this.lblLitros.TabIndex = 2;
            this.lblLitros.Text = "&Litros";
            // 
            // lblRendimento
            // 
            this.lblRendimento.AutoSize = true;
            this.lblRendimento.Location = new System.Drawing.Point(545, 123);
            this.lblRendimento.Name = "lblRendimento";
            this.lblRendimento.Size = new System.Drawing.Size(135, 15);
            this.lblRendimento.TabIndex = 3;
            this.lblRendimento.Text = "Rendimento - KM/Litros";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(545, 192);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(122, 15);
            this.lblConsumo.TabIndex = 4;
            this.lblConsumo.Text = "Consumo - Litros/KM";
            // 
            // tbxKM
            // 
            this.tbxKM.Location = new System.Drawing.Point(226, 159);
            this.tbxKM.Name = "tbxKM";
            this.tbxKM.Size = new System.Drawing.Size(100, 23);
            this.tbxKM.TabIndex = 5;
            // 
            // tbxLitros
            // 
            this.tbxLitros.Location = new System.Drawing.Point(226, 226);
            this.tbxLitros.Name = "tbxLitros";
            this.tbxLitros.Size = new System.Drawing.Size(100, 23);
            this.tbxLitros.TabIndex = 6;
            // 
            // lblRendimentoResultado
            // 
            this.lblRendimentoResultado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblRendimentoResultado.Location = new System.Drawing.Point(500, 149);
            this.lblRendimentoResultado.Name = "lblRendimentoResultado";
            this.lblRendimentoResultado.Size = new System.Drawing.Size(228, 30);
            this.lblRendimentoResultado.TabIndex = 7;
            // 
            // lblCalculo
            // 
            this.lblCalculo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCalculo.Location = new System.Drawing.Point(500, 216);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(228, 33);
            this.lblCalculo.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCalcular.Location = new System.Drawing.Point(242, 289);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(335, 79);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(242, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCalculo);
            this.Controls.Add(this.lblRendimentoResultado);
            this.Controls.Add(this.tbxLitros);
            this.Controls.Add(this.tbxKM);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lblRendimento);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblKM);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.Text = "Sistema de Tela de Combustivel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label lblRendimento;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.TextBox tbxKM;
        private System.Windows.Forms.TextBox tbxLitros;
        private System.Windows.Forms.Label lblRendimentoResultado;
        private System.Windows.Forms.Label lblCalculo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
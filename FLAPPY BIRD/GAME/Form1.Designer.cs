namespace GAME
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSaltar = new System.Windows.Forms.Button();
            this.picBird = new System.Windows.Forms.PictureBox();
            this.picObstaculo1 = new System.Windows.Forms.PictureBox();
            this.picObstaculo2 = new System.Windows.Forms.PictureBox();
            this.lbPonto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculo2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSaltar
            // 
            this.btnSaltar.Location = new System.Drawing.Point(528, 469);
            this.btnSaltar.Name = "btnSaltar";
            this.btnSaltar.Size = new System.Drawing.Size(75, 23);
            this.btnSaltar.TabIndex = 0;
            this.btnSaltar.Text = "Saltar";
            this.btnSaltar.UseVisualStyleBackColor = true;
            this.btnSaltar.Click += new System.EventHandler(this.btnSaltar_Click);
            // 
            // picBird
            // 
            this.picBird.Image = ((System.Drawing.Image)(resources.GetObject("picBird.Image")));
            this.picBird.Location = new System.Drawing.Point(86, 136);
            this.picBird.Name = "picBird";
            this.picBird.Size = new System.Drawing.Size(56, 44);
            this.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBird.TabIndex = 1;
            this.picBird.TabStop = false;
            // 
            // picObstaculo1
            // 
            this.picObstaculo1.BackColor = System.Drawing.Color.Transparent;
            this.picObstaculo1.Image = ((System.Drawing.Image)(resources.GetObject("picObstaculo1.Image")));
            this.picObstaculo1.Location = new System.Drawing.Point(566, 354);
            this.picObstaculo1.Name = "picObstaculo1";
            this.picObstaculo1.Size = new System.Drawing.Size(98, 174);
            this.picObstaculo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picObstaculo1.TabIndex = 2;
            this.picObstaculo1.TabStop = false;
            // 
            // picObstaculo2
            // 
            this.picObstaculo2.BackColor = System.Drawing.Color.Transparent;
            this.picObstaculo2.Image = ((System.Drawing.Image)(resources.GetObject("picObstaculo2.Image")));
            this.picObstaculo2.Location = new System.Drawing.Point(566, -2);
            this.picObstaculo2.Name = "picObstaculo2";
            this.picObstaculo2.Size = new System.Drawing.Size(98, 153);
            this.picObstaculo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picObstaculo2.TabIndex = 3;
            this.picObstaculo2.TabStop = false;
            // 
            // lbPonto
            // 
            this.lbPonto.AutoSize = true;
            this.lbPonto.BackColor = System.Drawing.Color.Transparent;
            this.lbPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPonto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbPonto.Location = new System.Drawing.Point(289, 53);
            this.lbPonto.Name = "lbPonto";
            this.lbPonto.Size = new System.Drawing.Size(51, 55);
            this.lbPonto.TabIndex = 4;
            this.lbPonto.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(619, 631);
            this.Controls.Add(this.lbPonto);
            this.Controls.Add(this.picObstaculo2);
            this.Controls.Add(this.btnSaltar);
            this.Controls.Add(this.picObstaculo1);
            this.Controls.Add(this.picBird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.btnSaltar_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObstaculo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSaltar;
        private System.Windows.Forms.PictureBox picBird;
        private System.Windows.Forms.PictureBox picObstaculo1;
        private System.Windows.Forms.PictureBox picObstaculo2;
        private System.Windows.Forms.Label lbPonto;
    }
}


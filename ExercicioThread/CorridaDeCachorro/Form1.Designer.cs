namespace CorridaDeCachorro
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pcbQuartoCao = new System.Windows.Forms.PictureBox();
            this.pcbSegundoCao = new System.Windows.Forms.PictureBox();
            this.pcbTerceiroCao = new System.Windows.Forms.PictureBox();
            this.pcbPrimeiroCao = new System.Windows.Forms.PictureBox();
            this.pcbPistaCorrida = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQuartoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSegundoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTerceiroCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrimeiroCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPistaCorrida)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.pcbQuartoCao);
            this.groupBox2.Controls.Add(this.pcbSegundoCao);
            this.groupBox2.Controls.Add(this.pcbTerceiroCao);
            this.groupBox2.Controls.Add(this.pcbPrimeiroCao);
            this.groupBox2.Controls.Add(this.pcbPistaCorrida);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 213);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pista de corridas";
            // 
            // pcbQuartoCao
            // 
            this.pcbQuartoCao.Image = ((System.Drawing.Image)(resources.GetObject("pcbQuartoCao.Image")));
            this.pcbQuartoCao.Location = new System.Drawing.Point(6, 166);
            this.pcbQuartoCao.Name = "pcbQuartoCao";
            this.pcbQuartoCao.Size = new System.Drawing.Size(75, 20);
            this.pcbQuartoCao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbQuartoCao.TabIndex = 4;
            this.pcbQuartoCao.TabStop = false;
            // 
            // pcbSegundoCao
            // 
            this.pcbSegundoCao.Image = ((System.Drawing.Image)(resources.GetObject("pcbSegundoCao.Image")));
            this.pcbSegundoCao.Location = new System.Drawing.Point(6, 72);
            this.pcbSegundoCao.Name = "pcbSegundoCao";
            this.pcbSegundoCao.Size = new System.Drawing.Size(75, 20);
            this.pcbSegundoCao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbSegundoCao.TabIndex = 2;
            this.pcbSegundoCao.TabStop = false;
            // 
            // pcbTerceiroCao
            // 
            this.pcbTerceiroCao.Image = ((System.Drawing.Image)(resources.GetObject("pcbTerceiroCao.Image")));
            this.pcbTerceiroCao.Location = new System.Drawing.Point(6, 120);
            this.pcbTerceiroCao.Name = "pcbTerceiroCao";
            this.pcbTerceiroCao.Size = new System.Drawing.Size(75, 20);
            this.pcbTerceiroCao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbTerceiroCao.TabIndex = 3;
            this.pcbTerceiroCao.TabStop = false;
            // 
            // pcbPrimeiroCao
            // 
            this.pcbPrimeiroCao.Image = ((System.Drawing.Image)(resources.GetObject("pcbPrimeiroCao.Image")));
            this.pcbPrimeiroCao.Location = new System.Drawing.Point(6, 28);
            this.pcbPrimeiroCao.Name = "pcbPrimeiroCao";
            this.pcbPrimeiroCao.Size = new System.Drawing.Size(75, 20);
            this.pcbPrimeiroCao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbPrimeiroCao.TabIndex = 1;
            this.pcbPrimeiroCao.TabStop = false;
            // 
            // pcbPistaCorrida
            // 
            this.pcbPistaCorrida.Image = ((System.Drawing.Image)(resources.GetObject("pcbPistaCorrida.Image")));
            this.pcbPistaCorrida.Location = new System.Drawing.Point(6, 19);
            this.pcbPistaCorrida.Name = "pcbPistaCorrida";
            this.pcbPistaCorrida.Size = new System.Drawing.Size(505, 182);
            this.pcbPistaCorrida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPistaCorrida.TabIndex = 0;
            this.pcbPistaCorrida.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(436, 262);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "1,2,3 e já!";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 297);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Corrida de Cachorro";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQuartoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSegundoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTerceiroCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPrimeiroCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPistaCorrida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pcbQuartoCao;
        private System.Windows.Forms.PictureBox pcbSegundoCao;
        private System.Windows.Forms.PictureBox pcbTerceiroCao;
        private System.Windows.Forms.PictureBox pcbPrimeiroCao;
        private System.Windows.Forms.PictureBox pcbPistaCorrida;
        private System.Windows.Forms.Button btnIniciar;
    }
}


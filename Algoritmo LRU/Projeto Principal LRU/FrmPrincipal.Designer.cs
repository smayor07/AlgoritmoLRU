namespace Projeto_Principal_LRU
{
    partial class FrmPrincipal
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
            this.nudIntervalo = new System.Windows.Forms.NumericUpDown();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdStart = new System.Windows.Forms.Button();
            this.lblPVitima = new System.Windows.Forms.Label();
            this.lblProximaP = new System.Windows.Forms.Label();
            this.lblMemoriaRAM = new System.Windows.Forms.Label();
            this.txtPV = new System.Windows.Forms.TextBox();
            this.txtPP = new System.Windows.Forms.TextBox();
            this.txtP4 = new System.Windows.Forms.TextBox();
            this.txtP3 = new System.Windows.Forms.TextBox();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.txtP1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // nudIntervalo
            // 
            this.nudIntervalo.Location = new System.Drawing.Point(668, 13);
            this.nudIntervalo.Name = "nudIntervalo";
            this.nudIntervalo.Size = new System.Drawing.Size(120, 22);
            this.nudIntervalo.TabIndex = 38;
            this.nudIntervalo.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.Location = new System.Drawing.Point(569, 15);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(82, 20);
            this.lblSegundos.TabIndex = 37;
            this.lblSegundos.Text = "Intervalo:";
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(713, 415);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 36;
            this.cmdClose.Text = "CLOSE";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(12, 41);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(80, 23);
            this.cmdStop.TabIndex = 35;
            this.cmdStop.Text = "STOP";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(12, 12);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(80, 23);
            this.cmdStart.TabIndex = 34;
            this.cmdStart.Text = "START";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // lblPVitima
            // 
            this.lblPVitima.AutoSize = true;
            this.lblPVitima.Font = new System.Drawing.Font("Bernard MT Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPVitima.Location = new System.Drawing.Point(401, 284);
            this.lblPVitima.Name = "lblPVitima";
            this.lblPVitima.Size = new System.Drawing.Size(180, 33);
            this.lblPVitima.TabIndex = 33;
            this.lblPVitima.Text = "Página Vítima";
            // 
            // lblProximaP
            // 
            this.lblProximaP.AutoSize = true;
            this.lblProximaP.Font = new System.Drawing.Font("Bernard MT Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximaP.Location = new System.Drawing.Point(389, 132);
            this.lblProximaP.Name = "lblProximaP";
            this.lblProximaP.Size = new System.Drawing.Size(203, 33);
            this.lblProximaP.TabIndex = 32;
            this.lblProximaP.Text = "Próxima Página";
            // 
            // lblMemoriaRAM
            // 
            this.lblMemoriaRAM.AutoSize = true;
            this.lblMemoriaRAM.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoriaRAM.Location = new System.Drawing.Point(98, 43);
            this.lblMemoriaRAM.Name = "lblMemoriaRAM";
            this.lblMemoriaRAM.Size = new System.Drawing.Size(267, 39);
            this.lblMemoriaRAM.TabIndex = 31;
            this.lblMemoriaRAM.Text = "Memória Principal";
            // 
            // txtPV
            // 
            this.txtPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPV.Location = new System.Drawing.Point(421, 323);
            this.txtPV.Multiline = true;
            this.txtPV.Name = "txtPV";
            this.txtPV.Size = new System.Drawing.Size(130, 70);
            this.txtPV.TabIndex = 30;
            // 
            // txtPP
            // 
            this.txtPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPP.Location = new System.Drawing.Point(421, 171);
            this.txtPP.Multiline = true;
            this.txtPP.Name = "txtPP";
            this.txtPP.Size = new System.Drawing.Size(130, 70);
            this.txtPP.TabIndex = 29;
            // 
            // txtP4
            // 
            this.txtP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP4.Location = new System.Drawing.Point(161, 323);
            this.txtP4.Multiline = true;
            this.txtP4.Name = "txtP4";
            this.txtP4.Size = new System.Drawing.Size(130, 70);
            this.txtP4.TabIndex = 28;
            // 
            // txtP3
            // 
            this.txtP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP3.Location = new System.Drawing.Point(161, 247);
            this.txtP3.Multiline = true;
            this.txtP3.Name = "txtP3";
            this.txtP3.Size = new System.Drawing.Size(130, 70);
            this.txtP3.TabIndex = 27;
            // 
            // txtP2
            // 
            this.txtP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP2.Location = new System.Drawing.Point(161, 171);
            this.txtP2.Multiline = true;
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(130, 70);
            this.txtP2.TabIndex = 26;
            // 
            // txtP1
            // 
            this.txtP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP1.Location = new System.Drawing.Point(161, 95);
            this.txtP1.Multiline = true;
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(130, 70);
            this.txtP1.TabIndex = 25;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Principal_LRU.Properties.Resources.LRU;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudIntervalo);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.lblPVitima);
            this.Controls.Add(this.lblProximaP);
            this.Controls.Add(this.lblMemoriaRAM);
            this.Controls.Add(this.txtPV);
            this.Controls.Add(this.txtPP);
            this.Controls.Add(this.txtP4);
            this.Controls.Add(this.txtP3);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.txtP1);
            this.Name = "FrmPrincipal";
            this.Text = "LRU";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudIntervalo;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label lblPVitima;
        private System.Windows.Forms.Label lblProximaP;
        private System.Windows.Forms.Label lblMemoriaRAM;
        private System.Windows.Forms.TextBox txtPV;
        private System.Windows.Forms.TextBox txtPP;
        private System.Windows.Forms.TextBox txtP4;
        private System.Windows.Forms.TextBox txtP3;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.TextBox txtP1;
    }
}


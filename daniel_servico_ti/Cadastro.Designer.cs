﻿namespace daniel_servico_ti
{
    partial class Cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSTATUS = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxACESS = new System.Windows.Forms.TextBox();
            this.textBoxQUEIXA = new System.Windows.Forms.TextBox();
            this.textBoxOBS = new System.Windows.Forms.TextBox();
            this.textBoxORC = new System.Windows.Forms.TextBox();
            this.textBoxDATA = new System.Windows.Forms.TextBox();
            this.textBoxVIDEO = new System.Windows.Forms.TextBox();
            this.textBoxRAM = new System.Windows.Forms.TextBox();
            this.textBoxFONTE = new System.Windows.Forms.TextBox();
            this.textBoxPLACAM = new System.Windows.Forms.TextBox();
            this.textBoxPROC = new System.Windows.Forms.TextBox();
            this.textBoxCEL = new System.Windows.Forms.TextBox();
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSALVAR = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.comboBoxSTATUS);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBoxACESS);
            this.panel1.Controls.Add(this.textBoxQUEIXA);
            this.panel1.Controls.Add(this.textBoxOBS);
            this.panel1.Controls.Add(this.textBoxORC);
            this.panel1.Controls.Add(this.textBoxDATA);
            this.panel1.Controls.Add(this.textBoxVIDEO);
            this.panel1.Controls.Add(this.textBoxRAM);
            this.panel1.Controls.Add(this.textBoxFONTE);
            this.panel1.Controls.Add(this.textBoxPLACAM);
            this.panel1.Controls.Add(this.textBoxPROC);
            this.panel1.Controls.Add(this.textBoxCEL);
            this.panel1.Controls.Add(this.textBoxNOME);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 565);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxSTATUS
            // 
            this.comboBoxSTATUS.FormattingEnabled = true;
            this.comboBoxSTATUS.Items.AddRange(new object[] {
            "Aberto",
            "Em Andamento",
            "Concluído",
            "Cancelado"});
            this.comboBoxSTATUS.Location = new System.Drawing.Point(49, 260);
            this.comboBoxSTATUS.Name = "comboBoxSTATUS";
            this.comboBoxSTATUS.Size = new System.Drawing.Size(245, 21);
            this.comboBoxSTATUS.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Status";
            // 
            // textBoxACESS
            // 
            this.textBoxACESS.Location = new System.Drawing.Point(69, 234);
            this.textBoxACESS.Name = "textBoxACESS";
            this.textBoxACESS.Size = new System.Drawing.Size(225, 20);
            this.textBoxACESS.TabIndex = 24;
            // 
            // textBoxQUEIXA
            // 
            this.textBoxQUEIXA.Location = new System.Drawing.Point(8, 489);
            this.textBoxQUEIXA.Multiline = true;
            this.textBoxQUEIXA.Name = "textBoxQUEIXA";
            this.textBoxQUEIXA.Size = new System.Drawing.Size(286, 66);
            this.textBoxQUEIXA.TabIndex = 23;
            // 
            // textBoxOBS
            // 
            this.textBoxOBS.Location = new System.Drawing.Point(8, 366);
            this.textBoxOBS.Multiline = true;
            this.textBoxOBS.Name = "textBoxOBS";
            this.textBoxOBS.Size = new System.Drawing.Size(286, 104);
            this.textBoxOBS.TabIndex = 22;
            this.textBoxOBS.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBoxORC
            // 
            this.textBoxORC.Location = new System.Drawing.Point(66, 321);
            this.textBoxORC.Name = "textBoxORC";
            this.textBoxORC.Size = new System.Drawing.Size(228, 20);
            this.textBoxORC.TabIndex = 21;
            // 
            // textBoxDATA
            // 
            this.textBoxDATA.Location = new System.Drawing.Point(92, 293);
            this.textBoxDATA.Name = "textBoxDATA";
            this.textBoxDATA.Size = new System.Drawing.Size(202, 20);
            this.textBoxDATA.TabIndex = 20;
            // 
            // textBoxVIDEO
            // 
            this.textBoxVIDEO.Location = new System.Drawing.Point(92, 205);
            this.textBoxVIDEO.Name = "textBoxVIDEO";
            this.textBoxVIDEO.Size = new System.Drawing.Size(202, 20);
            this.textBoxVIDEO.TabIndex = 19;
            // 
            // textBoxRAM
            // 
            this.textBoxRAM.Location = new System.Drawing.Point(66, 179);
            this.textBoxRAM.Name = "textBoxRAM";
            this.textBoxRAM.Size = new System.Drawing.Size(228, 20);
            this.textBoxRAM.TabIndex = 18;
            // 
            // textBoxFONTE
            // 
            this.textBoxFONTE.Location = new System.Drawing.Point(47, 150);
            this.textBoxFONTE.Name = "textBoxFONTE";
            this.textBoxFONTE.Size = new System.Drawing.Size(247, 20);
            this.textBoxFONTE.TabIndex = 17;
            // 
            // textBoxPLACAM
            // 
            this.textBoxPLACAM.Location = new System.Drawing.Point(69, 124);
            this.textBoxPLACAM.Name = "textBoxPLACAM";
            this.textBoxPLACAM.Size = new System.Drawing.Size(225, 20);
            this.textBoxPLACAM.TabIndex = 16;
            // 
            // textBoxPROC
            // 
            this.textBoxPROC.Location = new System.Drawing.Point(77, 95);
            this.textBoxPROC.Name = "textBoxPROC";
            this.textBoxPROC.Size = new System.Drawing.Size(217, 20);
            this.textBoxPROC.TabIndex = 15;
            // 
            // textBoxCEL
            // 
            this.textBoxCEL.Location = new System.Drawing.Point(47, 69);
            this.textBoxCEL.Name = "textBoxCEL";
            this.textBoxCEL.Size = new System.Drawing.Size(247, 20);
            this.textBoxCEL.TabIndex = 14;
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(46, 40);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(248, 20);
            this.textBoxNOME.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 473);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Queixa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 350);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Observação";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 324);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Orçamento";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 295);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Data de Entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Acessórios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Placa de Vídeo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "RAM (GB)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Fonte";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Placa Mãe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Processador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Celular";
            // 
            // buttonSALVAR
            // 
            this.buttonSALVAR.Location = new System.Drawing.Point(12, 583);
            this.buttonSALVAR.Name = "buttonSALVAR";
            this.buttonSALVAR.Size = new System.Drawing.Size(305, 32);
            this.buttonSALVAR.TabIndex = 3;
            this.buttonSALVAR.Text = "Salvar";
            this.buttonSALVAR.UseVisualStyleBackColor = true;
            this.buttonSALVAR.Click += new System.EventHandler(this.buttonSALVAR_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 629);
            this.Controls.Add(this.buttonSALVAR);
            this.Controls.Add(this.panel1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxACESS;
        private System.Windows.Forms.TextBox textBoxQUEIXA;
        private System.Windows.Forms.TextBox textBoxOBS;
        private System.Windows.Forms.TextBox textBoxORC;
        private System.Windows.Forms.TextBox textBoxDATA;
        private System.Windows.Forms.TextBox textBoxVIDEO;
        private System.Windows.Forms.TextBox textBoxRAM;
        private System.Windows.Forms.TextBox textBoxFONTE;
        private System.Windows.Forms.TextBox textBoxPLACAM;
        private System.Windows.Forms.TextBox textBoxPROC;
        private System.Windows.Forms.TextBox textBoxCEL;
        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonSALVAR;
        private System.Windows.Forms.ComboBox comboBoxSTATUS;
        private System.Windows.Forms.Label label11;
    }
}


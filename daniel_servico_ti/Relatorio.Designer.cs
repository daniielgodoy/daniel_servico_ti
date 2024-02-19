namespace daniel_servico_ti
{
    partial class Relatorio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewSELECT = new System.Windows.Forms.DataGridView();
            this.textBoxDATA = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonBUSCAR2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonVOLTAR = new System.Windows.Forms.Button();
            this.buttonBUSCAR = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewTOP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDATAS2 = new System.Windows.Forms.TextBox();
            this.buttonENTREDATAS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDATAS1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSELECT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTOP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.textBoxDATAS1);
            this.panel1.Controls.Add(this.textBoxDATAS2);
            this.panel1.Controls.Add(this.buttonENTREDATAS);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridViewSELECT);
            this.panel1.Controls.Add(this.textBoxDATA);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.buttonBUSCAR2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonVOLTAR);
            this.panel1.Controls.Add(this.buttonBUSCAR);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dataGridViewTOP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 292);
            this.panel1.TabIndex = 5;
            // 
            // dataGridViewSELECT
            // 
            this.dataGridViewSELECT.AllowUserToAddRows = false;
            this.dataGridViewSELECT.AllowUserToDeleteRows = false;
            this.dataGridViewSELECT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSELECT.Location = new System.Drawing.Point(11, 120);
            this.dataGridViewSELECT.Name = "dataGridViewSELECT";
            this.dataGridViewSELECT.ReadOnly = true;
            this.dataGridViewSELECT.Size = new System.Drawing.Size(489, 110);
            this.dataGridViewSELECT.TabIndex = 32;
            // 
            // textBoxDATA
            // 
            this.textBoxDATA.Location = new System.Drawing.Point(244, 66);
            this.textBoxDATA.Name = "textBoxDATA";
            this.textBoxDATA.Size = new System.Drawing.Size(185, 20);
            this.textBoxDATA.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aberto",
            "Em Andamento",
            "Concluído",
            "Cancelado"});
            this.comboBox1.Location = new System.Drawing.Point(149, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "Concluído";
            // 
            // buttonBUSCAR2
            // 
            this.buttonBUSCAR2.Location = new System.Drawing.Point(435, 65);
            this.buttonBUSCAR2.Name = "buttonBUSCAR2";
            this.buttonBUSCAR2.Size = new System.Drawing.Size(65, 23);
            this.buttonBUSCAR2.TabIndex = 15;
            this.buttonBUSCAR2.Text = "Buscar";
            this.buttonBUSCAR2.UseVisualStyleBackColor = true;
            this.buttonBUSCAR2.Click += new System.EventHandler(this.buttonBUSCAR2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Procurar por Data AAAA-MM-DD";
            // 
            // buttonVOLTAR
            // 
            this.buttonVOLTAR.Location = new System.Drawing.Point(425, 4);
            this.buttonVOLTAR.Name = "buttonVOLTAR";
            this.buttonVOLTAR.Size = new System.Drawing.Size(75, 23);
            this.buttonVOLTAR.TabIndex = 7;
            this.buttonVOLTAR.Text = "Voltar";
            this.buttonVOLTAR.UseVisualStyleBackColor = true;
            this.buttonVOLTAR.Click += new System.EventHandler(this.buttonVOLTAR_Click);
            // 
            // buttonBUSCAR
            // 
            this.buttonBUSCAR.Location = new System.Drawing.Point(435, 39);
            this.buttonBUSCAR.Name = "buttonBUSCAR";
            this.buttonBUSCAR.Size = new System.Drawing.Size(65, 23);
            this.buttonBUSCAR.TabIndex = 12;
            this.buttonBUSCAR.Text = "Buscar";
            this.buttonBUSCAR.UseVisualStyleBackColor = true;
            this.buttonBUSCAR.Click += new System.EventHandler(this.buttonBUSCAR_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Procurar por Status";
            // 
            // dataGridViewTOP
            // 
            this.dataGridViewTOP.AllowUserToAddRows = false;
            this.dataGridViewTOP.AllowUserToDeleteRows = false;
            this.dataGridViewTOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTOP.Location = new System.Drawing.Point(11, 236);
            this.dataGridViewTOP.Name = "dataGridViewTOP";
            this.dataGridViewTOP.ReadOnly = true;
            this.dataGridViewTOP.Size = new System.Drawing.Size(489, 46);
            this.dataGridViewTOP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório Orçamental";
            // 
            // textBoxDATAS2
            // 
            this.textBoxDATAS2.Location = new System.Drawing.Point(304, 92);
            this.textBoxDATAS2.Name = "textBoxDATAS2";
            this.textBoxDATAS2.Size = new System.Drawing.Size(125, 20);
            this.textBoxDATAS2.TabIndex = 35;
            // 
            // buttonENTREDATAS
            // 
            this.buttonENTREDATAS.Location = new System.Drawing.Point(435, 91);
            this.buttonENTREDATAS.Name = "buttonENTREDATAS";
            this.buttonENTREDATAS.Size = new System.Drawing.Size(65, 23);
            this.buttonENTREDATAS.TabIndex = 34;
            this.buttonENTREDATAS.Text = "Buscar";
            this.buttonENTREDATAS.UseVisualStyleBackColor = true;
            this.buttonENTREDATAS.Click += new System.EventHandler(this.buttonENTREDATAS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Procurar entre Datas";
            // 
            // textBoxDATAS1
            // 
            this.textBoxDATAS1.Location = new System.Drawing.Point(164, 92);
            this.textBoxDATAS1.Name = "textBoxDATAS1";
            this.textBoxDATAS1.Size = new System.Drawing.Size(125, 20);
            this.textBoxDATAS1.TabIndex = 36;
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 311);
            this.Controls.Add(this.panel1);
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSELECT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTOP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonVOLTAR;
        private System.Windows.Forms.Button buttonBUSCAR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewTOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBUSCAR2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxDATA;
        private System.Windows.Forms.DataGridView dataGridViewSELECT;
        private System.Windows.Forms.TextBox textBoxDATAS1;
        private System.Windows.Forms.TextBox textBoxDATAS2;
        private System.Windows.Forms.Button buttonENTREDATAS;
        private System.Windows.Forms.Label label3;
    }
}
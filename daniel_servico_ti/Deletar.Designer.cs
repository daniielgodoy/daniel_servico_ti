namespace daniel_servico_ti
{
    partial class Deletar
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
            this.buttonBUSCAR = new System.Windows.Forms.Button();
            this.textBoxBUSCA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewTOP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDELETAR = new System.Windows.Forms.Button();
            this.buttonVOLTAR = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTOP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.buttonVOLTAR);
            this.panel1.Controls.Add(this.buttonBUSCAR);
            this.panel1.Controls.Add(this.textBoxBUSCA);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dataGridViewTOP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 520);
            this.panel1.TabIndex = 3;
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
            // textBoxBUSCA
            // 
            this.textBoxBUSCA.Location = new System.Drawing.Point(149, 41);
            this.textBoxBUSCA.Name = "textBoxBUSCA";
            this.textBoxBUSCA.Size = new System.Drawing.Size(280, 20);
            this.textBoxBUSCA.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Procurar por nome";
            // 
            // dataGridViewTOP
            // 
            this.dataGridViewTOP.AllowUserToAddRows = false;
            this.dataGridViewTOP.AllowUserToDeleteRows = false;
            this.dataGridViewTOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTOP.Location = new System.Drawing.Point(11, 67);
            this.dataGridViewTOP.Name = "dataGridViewTOP";
            this.dataGridViewTOP.ReadOnly = true;
            this.dataGridViewTOP.Size = new System.Drawing.Size(489, 442);
            this.dataGridViewTOP.TabIndex = 1;
            this.dataGridViewTOP.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o registro que deseja deletar";
            // 
            // buttonDELETAR
            // 
            this.buttonDELETAR.Location = new System.Drawing.Point(12, 539);
            this.buttonDELETAR.Name = "buttonDELETAR";
            this.buttonDELETAR.Size = new System.Drawing.Size(512, 23);
            this.buttonDELETAR.TabIndex = 4;
            this.buttonDELETAR.Text = "Deletar";
            this.buttonDELETAR.UseVisualStyleBackColor = true;
            this.buttonDELETAR.Click += new System.EventHandler(this.buttonDELETAR_Click);
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
            // Deletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 574);
            this.Controls.Add(this.buttonDELETAR);
            this.Controls.Add(this.panel1);
            this.Name = "Deletar";
            this.Text = "Deletar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTOP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTOP;
        private System.Windows.Forms.Button buttonDELETAR;
        private System.Windows.Forms.Button buttonBUSCAR;
        private System.Windows.Forms.TextBox textBoxBUSCA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonVOLTAR;
    }
}
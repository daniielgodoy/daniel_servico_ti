namespace daniel_servico_ti
{
    partial class menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioOrçamentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.atualizarRegistrosToolStripMenuItem,
            this.apagarRegistrosToolStripMenuItem,
            this.relatórioOrçamentalToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // atualizarRegistrosToolStripMenuItem
            // 
            this.atualizarRegistrosToolStripMenuItem.Name = "atualizarRegistrosToolStripMenuItem";
            this.atualizarRegistrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atualizarRegistrosToolStripMenuItem.Text = "Atualizar Registros";
            this.atualizarRegistrosToolStripMenuItem.Click += new System.EventHandler(this.atualizarRegistrosToolStripMenuItem_Click);
            // 
            // apagarRegistrosToolStripMenuItem
            // 
            this.apagarRegistrosToolStripMenuItem.Name = "apagarRegistrosToolStripMenuItem";
            this.apagarRegistrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apagarRegistrosToolStripMenuItem.Text = "Apagar Registros";
            this.apagarRegistrosToolStripMenuItem.Click += new System.EventHandler(this.apagarRegistrosToolStripMenuItem_Click);
            // 
            // relatórioOrçamentalToolStripMenuItem
            // 
            this.relatórioOrçamentalToolStripMenuItem.Name = "relatórioOrçamentalToolStripMenuItem";
            this.relatórioOrçamentalToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.relatórioOrçamentalToolStripMenuItem.Text = "Relatório Orçamental";
            this.relatórioOrçamentalToolStripMenuItem.Click += new System.EventHandler(this.relatórioOrçamentalToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 233);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarRegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarRegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioOrçamentalToolStripMenuItem;
    }
}
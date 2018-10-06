namespace apeno
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participaçãoDeTopicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topicoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raletorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvedorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.topicoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apeNoDataSet = new apeno.ApeNoDataSet();
            this.desenvolvedoresTableAdapter = new apeno.ApeNoDataSetTableAdapters.desenvolvedoresTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apeNoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.topicoToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.raletorioToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem1,
            this.desenvolvedorToolStripMenuItem,
            this.administradorToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.usuarioToolStripMenuItem1.Text = "Usuário";
            this.usuarioToolStripMenuItem1.Click += new System.EventHandler(this.usuarioToolStripMenuItem1_Click);
            // 
            // desenvolvedorToolStripMenuItem
            // 
            this.desenvolvedorToolStripMenuItem.Name = "desenvolvedorToolStripMenuItem";
            this.desenvolvedorToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.desenvolvedorToolStripMenuItem.Text = "Desenvolvedor";
            this.desenvolvedorToolStripMenuItem.Click += new System.EventHandler(this.desenvolvedorToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // topicoToolStripMenuItem
            // 
            this.topicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participaçãoDeTopicoToolStripMenuItem,
            this.topicoToolStripMenuItem1});
            this.topicoToolStripMenuItem.Name = "topicoToolStripMenuItem";
            this.topicoToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.topicoToolStripMenuItem.Text = "Topico";
            // 
            // participaçãoDeTopicoToolStripMenuItem
            // 
            this.participaçãoDeTopicoToolStripMenuItem.Name = "participaçãoDeTopicoToolStripMenuItem";
            this.participaçãoDeTopicoToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.participaçãoDeTopicoToolStripMenuItem.Text = "Participação de topico";
            this.participaçãoDeTopicoToolStripMenuItem.Click += new System.EventHandler(this.participaçãoDeTopicoToolStripMenuItem_Click);
            // 
            // topicoToolStripMenuItem1
            // 
            this.topicoToolStripMenuItem1.Name = "topicoToolStripMenuItem1";
            this.topicoToolStripMenuItem1.Size = new System.Drawing.Size(296, 22);
            this.topicoToolStripMenuItem1.Text = "Topico";
            this.topicoToolStripMenuItem1.Click += new System.EventHandler(this.topicoToolStripMenuItem1_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleToolStripMenuItem,
            this.relatorioToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // controleToolStripMenuItem
            // 
            this.controleToolStripMenuItem.Name = "controleToolStripMenuItem";
            this.controleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.controleToolStripMenuItem.Text = "Controle";
            this.controleToolStripMenuItem.Click += new System.EventHandler(this.controleToolStripMenuItem_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.relatorioToolStripMenuItem.Text = "Relatório";
            this.relatorioToolStripMenuItem.Click += new System.EventHandler(this.relatorioToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.desenvolvedorToolStripMenuItem1,
            this.administradorToolStripMenuItem2,
            this.relatórioToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // desenvolvedorToolStripMenuItem1
            // 
            this.desenvolvedorToolStripMenuItem1.Name = "desenvolvedorToolStripMenuItem1";
            this.desenvolvedorToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.desenvolvedorToolStripMenuItem1.Text = "Desenvolvedor";
            this.desenvolvedorToolStripMenuItem1.Click += new System.EventHandler(this.desenvolvedorToolStripMenuItem1_Click);
            // 
            // administradorToolStripMenuItem2
            // 
            this.administradorToolStripMenuItem2.Name = "administradorToolStripMenuItem2";
            this.administradorToolStripMenuItem2.Size = new System.Drawing.Size(206, 22);
            this.administradorToolStripMenuItem2.Text = "Administrador";
            this.administradorToolStripMenuItem2.Click += new System.EventHandler(this.administradorToolStripMenuItem2_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            this.relatórioToolStripMenuItem.Click += new System.EventHandler(this.relatórioToolStripMenuItem_Click);
            // 
            // raletorioToolStripMenuItem
            // 
            this.raletorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem1,
            this.desenvolvedorToolStripMenuItem2,
            this.administradorToolStripMenuItem1,
            this.topicoToolStripMenuItem2,
            this.relatórioToolStripMenuItem1});
            this.raletorioToolStripMenuItem.Name = "raletorioToolStripMenuItem";
            this.raletorioToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.raletorioToolStripMenuItem.Text = "Relatório";
            // 
            // usuárioToolStripMenuItem1
            // 
            this.usuárioToolStripMenuItem1.Name = "usuárioToolStripMenuItem1";
            this.usuárioToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.usuárioToolStripMenuItem1.Text = "Usuário";
            this.usuárioToolStripMenuItem1.Click += new System.EventHandler(this.usuárioToolStripMenuItem1_Click);
            // 
            // desenvolvedorToolStripMenuItem2
            // 
            this.desenvolvedorToolStripMenuItem2.Name = "desenvolvedorToolStripMenuItem2";
            this.desenvolvedorToolStripMenuItem2.Size = new System.Drawing.Size(206, 22);
            this.desenvolvedorToolStripMenuItem2.Text = "Desenvolvedor";
            this.desenvolvedorToolStripMenuItem2.Click += new System.EventHandler(this.desenvolvedorToolStripMenuItem2_Click);
            // 
            // administradorToolStripMenuItem1
            // 
            this.administradorToolStripMenuItem1.Name = "administradorToolStripMenuItem1";
            this.administradorToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.administradorToolStripMenuItem1.Text = "Administrador";
            this.administradorToolStripMenuItem1.Click += new System.EventHandler(this.administradorToolStripMenuItem1_Click);
            // 
            // topicoToolStripMenuItem2
            // 
            this.topicoToolStripMenuItem2.Name = "topicoToolStripMenuItem2";
            this.topicoToolStripMenuItem2.Size = new System.Drawing.Size(206, 22);
            this.topicoToolStripMenuItem2.Text = "Topico";
            this.topicoToolStripMenuItem2.Click += new System.EventHandler(this.topicoToolStripMenuItem2_Click);
            // 
            // relatórioToolStripMenuItem1
            // 
            this.relatórioToolStripMenuItem1.Name = "relatórioToolStripMenuItem1";
            this.relatórioToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.relatórioToolStripMenuItem1.Text = "Relatório";
            this.relatórioToolStripMenuItem1.Click += new System.EventHandler(this.relatórioToolStripMenuItem1_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sairToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(108, 21);
            this.sairToolStripMenuItem.Text = "Encerrar";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // apeNoDataSet
            // 
            this.apeNoDataSet.DataSetName = "ApeNoDataSet";
            this.apeNoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // desenvolvedoresTableAdapter
            // 
            this.desenvolvedoresTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::apeno.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApeNo";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apeNoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private ApeNoDataSet apeNoDataSet;
        private ApeNoDataSetTableAdapters.desenvolvedoresTableAdapter desenvolvedoresTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem participaçãoDeTopicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topicoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raletorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem desenvolvedorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem topicoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem1;
    }
}
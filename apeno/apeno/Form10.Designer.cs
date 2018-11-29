namespace apeno
{
    partial class Form10
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_reportLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label relatorioLabel;
            System.Windows.Forms.Label areaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apeNoDataSet = new apeno.ApeNoDataSet();
            this.id_reportTextBox = new System.Windows.Forms.TextBox();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.relatorioTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.reportTableAdapter = new apeno.ApeNoDataSetTableAdapters.reportTableAdapter();
            this.tableAdapterManager = new apeno.ApeNoDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.reportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.reportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            id_reportLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            relatorioLabel = new System.Windows.Forms.Label();
            areaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apeNoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingNavigator)).BeginInit();
            this.reportBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_reportLabel
            // 
            id_reportLabel.AutoSize = true;
            id_reportLabel.BackColor = System.Drawing.Color.Transparent;
            id_reportLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            id_reportLabel.Location = new System.Drawing.Point(211, 124);
            id_reportLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_reportLabel.Name = "id_reportLabel";
            id_reportLabel.Size = new System.Drawing.Size(98, 17);
            id_reportLabel.TabIndex = 1;
            id_reportLabel.Text = "id report:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.BackColor = System.Drawing.Color.Transparent;
            categoriaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            categoriaLabel.Location = new System.Drawing.Point(211, 158);
            categoriaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(98, 17);
            categoriaLabel.TabIndex = 3;
            categoriaLabel.Text = "categoria:";
            // 
            // relatorioLabel
            // 
            relatorioLabel.AutoSize = true;
            relatorioLabel.BackColor = System.Drawing.Color.Transparent;
            relatorioLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            relatorioLabel.Location = new System.Drawing.Point(211, 192);
            relatorioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            relatorioLabel.Name = "relatorioLabel";
            relatorioLabel.Size = new System.Drawing.Size(98, 17);
            relatorioLabel.TabIndex = 5;
            relatorioLabel.Text = "relatório:";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.BackColor = System.Drawing.Color.Transparent;
            areaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            areaLabel.Location = new System.Drawing.Point(256, 226);
            areaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new System.Drawing.Size(53, 17);
            areaLabel.TabIndex = 7;
            areaLabel.Text = "área:";
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "report";
            this.reportBindingSource.DataSource = this.apeNoDataSet;
            // 
            // apeNoDataSet
            // 
            this.apeNoDataSet.DataSetName = "ApeNoDataSet";
            this.apeNoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // id_reportTextBox
            // 
            this.id_reportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reportBindingSource, "id_report", true));
            this.id_reportTextBox.Location = new System.Drawing.Point(317, 121);
            this.id_reportTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.id_reportTextBox.Name = "id_reportTextBox";
            this.id_reportTextBox.Size = new System.Drawing.Size(148, 23);
            this.id_reportTextBox.TabIndex = 2;
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reportBindingSource, "categoria", true));
            this.categoriaTextBox.Location = new System.Drawing.Point(317, 155);
            this.categoriaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(148, 23);
            this.categoriaTextBox.TabIndex = 4;
            this.categoriaTextBox.TextChanged += new System.EventHandler(this.categoriaTextBox_TextChanged);
            // 
            // relatorioTextBox
            // 
            this.relatorioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reportBindingSource, "relatorio", true));
            this.relatorioTextBox.Location = new System.Drawing.Point(317, 189);
            this.relatorioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.relatorioTextBox.Name = "relatorioTextBox";
            this.relatorioTextBox.Size = new System.Drawing.Size(148, 23);
            this.relatorioTextBox.TabIndex = 6;
            this.relatorioTextBox.TextChanged += new System.EventHandler(this.relatorioTextBox_TextChanged);
            // 
            // areaTextBox
            // 
            this.areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reportBindingSource, "area", true));
            this.areaTextBox.Location = new System.Drawing.Point(317, 223);
            this.areaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(148, 23);
            this.areaTextBox.TabIndex = 8;
            this.areaTextBox.TextChanged += new System.EventHandler(this.areaTextBox_TextChanged);
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.admin_sistemaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.controle_erroTableAdapter = null;
            this.tableAdapterManager.desenvolvedoresTableAdapter = null;
            this.tableAdapterManager.prti_topicoTableAdapter = null;
            this.tableAdapterManager.reportTableAdapter = this.reportTableAdapter;
            this.tableAdapterManager.topicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = apeno.ApeNoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(265, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // reportBindingNavigatorSaveItem
            // 
            this.reportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("reportBindingNavigatorSaveItem.Image")));
            this.reportBindingNavigatorSaveItem.Name = "reportBindingNavigatorSaveItem";
            this.reportBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.reportBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.reportBindingNavigatorSaveItem.Click += new System.EventHandler(this.reportBindingNavigatorSaveItem_Click);
            // 
            // reportBindingNavigator
            // 
            this.reportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.reportBindingNavigator.BindingSource = this.reportBindingSource;
            this.reportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.reportBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.reportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.reportBindingNavigatorSaveItem});
            this.reportBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.reportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.reportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.reportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.reportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.reportBindingNavigator.Name = "reportBindingNavigator";
            this.reportBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.reportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.reportBindingNavigator.Size = new System.Drawing.Size(704, 25);
            this.reportBindingNavigator.TabIndex = 0;
            this.reportBindingNavigator.Text = "bindingNavigator1";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::apeno.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_reportLabel);
            this.Controls.Add(this.id_reportTextBox);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaTextBox);
            this.Controls.Add(relatorioLabel);
            this.Controls.Add(this.relatorioTextBox);
            this.Controls.Add(areaLabel);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.reportBindingNavigator);
            this.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApeNo - Report";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apeNoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingNavigator)).EndInit();
            this.reportBindingNavigator.ResumeLayout(false);
            this.reportBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ApeNoDataSet apeNoDataSet;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private ApeNoDataSetTableAdapters.reportTableAdapter reportTableAdapter;
        private ApeNoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_reportTextBox;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.TextBox relatorioTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton reportBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator reportBindingNavigator;
    }
}
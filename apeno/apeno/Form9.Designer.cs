namespace apeno
{
    partial class Form9
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
            System.Windows.Forms.Label id_desLabel;
            System.Windows.Forms.Label id_reportLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.apeNoDataSet = new apeno.ApeNoDataSet();
            this.controle_erroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controle_erroTableAdapter = new apeno.ApeNoDataSetTableAdapters.controle_erroTableAdapter();
            this.tableAdapterManager = new apeno.ApeNoDataSetTableAdapters.TableAdapterManager();
            this.controle_erroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.controle_erroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_desTextBox = new System.Windows.Forms.TextBox();
            this.id_reportTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            id_desLabel = new System.Windows.Forms.Label();
            id_reportLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.apeNoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_erroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_erroBindingNavigator)).BeginInit();
            this.controle_erroBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_desLabel
            // 
            id_desLabel.AutoSize = true;
            id_desLabel.BackColor = System.Drawing.Color.Transparent;
            id_desLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            id_desLabel.Location = new System.Drawing.Point(136, 107);
            id_desLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_desLabel.Name = "id_desLabel";
            id_desLabel.Size = new System.Drawing.Size(71, 17);
            id_desLabel.TabIndex = 1;
            id_desLabel.Text = "id des:";
            // 
            // id_reportLabel
            // 
            id_reportLabel.AutoSize = true;
            id_reportLabel.BackColor = System.Drawing.Color.Transparent;
            id_reportLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            id_reportLabel.Location = new System.Drawing.Point(109, 140);
            id_reportLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_reportLabel.Name = "id_reportLabel";
            id_reportLabel.Size = new System.Drawing.Size(98, 17);
            id_reportLabel.TabIndex = 3;
            id_reportLabel.Text = "id report:";
            // 
            // apeNoDataSet
            // 
            this.apeNoDataSet.DataSetName = "ApeNoDataSet";
            this.apeNoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controle_erroBindingSource
            // 
            this.controle_erroBindingSource.DataMember = "controle_erro";
            this.controle_erroBindingSource.DataSource = this.apeNoDataSet;
            // 
            // controle_erroTableAdapter
            // 
            this.controle_erroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.admin_sistemaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.controle_erroTableAdapter = this.controle_erroTableAdapter;
            this.tableAdapterManager.desenvolvedoresTableAdapter = null;
            this.tableAdapterManager.prti_topicoTableAdapter = null;
            this.tableAdapterManager.reportTableAdapter = null;
            this.tableAdapterManager.topicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = apeno.ApeNoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // controle_erroBindingNavigator
            // 
            this.controle_erroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.controle_erroBindingNavigator.BindingSource = this.controle_erroBindingSource;
            this.controle_erroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.controle_erroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.controle_erroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.controle_erroBindingNavigatorSaveItem});
            this.controle_erroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.controle_erroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.controle_erroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.controle_erroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.controle_erroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.controle_erroBindingNavigator.Name = "controle_erroBindingNavigator";
            this.controle_erroBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.controle_erroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.controle_erroBindingNavigator.Size = new System.Drawing.Size(464, 25);
            this.controle_erroBindingNavigator.TabIndex = 0;
            this.controle_erroBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            // controle_erroBindingNavigatorSaveItem
            // 
            this.controle_erroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.controle_erroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("controle_erroBindingNavigatorSaveItem.Image")));
            this.controle_erroBindingNavigatorSaveItem.Name = "controle_erroBindingNavigatorSaveItem";
            this.controle_erroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.controle_erroBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.controle_erroBindingNavigatorSaveItem.Click += new System.EventHandler(this.controle_erroBindingNavigatorSaveItem_Click);
            // 
            // id_desTextBox
            // 
            this.id_desTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controle_erroBindingSource, "id_des", true));
            this.id_desTextBox.Location = new System.Drawing.Point(215, 104);
            this.id_desTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.id_desTextBox.Name = "id_desTextBox";
            this.id_desTextBox.Size = new System.Drawing.Size(148, 23);
            this.id_desTextBox.TabIndex = 2;
            // 
            // id_reportTextBox
            // 
            this.id_reportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controle_erroBindingSource, "id_report", true));
            this.id_reportTextBox.Location = new System.Drawing.Point(215, 137);
            this.id_reportTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.id_reportTextBox.Name = "id_reportTextBox";
            this.id_reportTextBox.Size = new System.Drawing.Size(148, 23);
            this.id_reportTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(215, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::apeno.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_desLabel);
            this.Controls.Add(this.id_desTextBox);
            this.Controls.Add(id_reportLabel);
            this.Controls.Add(this.id_reportTextBox);
            this.Controls.Add(this.controle_erroBindingNavigator);
            this.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApeNo - Controle de Erro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form9_FormClosed);
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apeNoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_erroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_erroBindingNavigator)).EndInit();
            this.controle_erroBindingNavigator.ResumeLayout(false);
            this.controle_erroBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ApeNoDataSet apeNoDataSet;
        private System.Windows.Forms.BindingSource controle_erroBindingSource;
        private ApeNoDataSetTableAdapters.controle_erroTableAdapter controle_erroTableAdapter;
        private ApeNoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator controle_erroBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton controle_erroBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_desTextBox;
        private System.Windows.Forms.TextBox id_reportTextBox;
        private System.Windows.Forms.Button button1;
    }
}
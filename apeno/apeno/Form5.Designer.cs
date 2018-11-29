namespace apeno
{
    partial class Form5
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label areaLabel;
            System.Windows.Forms.Label datanascLabel;
            System.Windows.Forms.Label reportLabel;
            System.Windows.Forms.Label id_adminLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.apeNoDataSet = new apeno.ApeNoDataSet();
            this.desenvolvedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desenvolvedoresTableAdapter = new apeno.ApeNoDataSetTableAdapters.desenvolvedoresTableAdapter();
            this.tableAdapterManager = new apeno.ApeNoDataSetTableAdapters.TableAdapterManager();
            this.desenvolvedoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.desenvolvedoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_desTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.datanascDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reportTextBox = new System.Windows.Forms.TextBox();
            this.id_adminTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            id_desLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            areaLabel = new System.Windows.Forms.Label();
            datanascLabel = new System.Windows.Forms.Label();
            reportLabel = new System.Windows.Forms.Label();
            id_adminLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.apeNoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desenvolvedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desenvolvedoresBindingNavigator)).BeginInit();
            this.desenvolvedoresBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_desLabel
            // 
            id_desLabel.AutoSize = true;
            id_desLabel.BackColor = System.Drawing.Color.Transparent;
            id_desLabel.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_desLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            id_desLabel.Location = new System.Drawing.Point(28, 136);
            id_desLabel.Name = "id_desLabel";
            id_desLabel.Size = new System.Drawing.Size(71, 17);
            id_desLabel.TabIndex = 1;
            id_desLabel.Text = "id des:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.Color.Transparent;
            nomeLabel.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nomeLabel.Location = new System.Drawing.Point(46, 185);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(53, 17);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "nome:";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.BackColor = System.Drawing.Color.Transparent;
            areaLabel.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            areaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            areaLabel.Location = new System.Drawing.Point(46, 234);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new System.Drawing.Size(53, 17);
            areaLabel.TabIndex = 5;
            areaLabel.Text = "área:";
            // 
            // datanascLabel
            // 
            datanascLabel.AutoSize = true;
            datanascLabel.BackColor = System.Drawing.Color.Transparent;
            datanascLabel.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datanascLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            datanascLabel.Location = new System.Drawing.Point(28, 80);
            datanascLabel.Name = "datanascLabel";
            datanascLabel.Size = new System.Drawing.Size(179, 17);
            datanascLabel.TabIndex = 7;
            datanascLabel.Text = "data de nascimento:";
            // 
            // reportLabel
            // 
            reportLabel.AutoSize = true;
            reportLabel.BackColor = System.Drawing.Color.Transparent;
            reportLabel.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            reportLabel.Location = new System.Drawing.Point(373, 137);
            reportLabel.Name = "reportLabel";
            reportLabel.Size = new System.Drawing.Size(71, 17);
            reportLabel.TabIndex = 9;
            reportLabel.Text = "report:";
            // 
            // id_adminLabel
            // 
            id_adminLabel.AutoSize = true;
            id_adminLabel.BackColor = System.Drawing.Color.Transparent;
            id_adminLabel.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_adminLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            id_adminLabel.Location = new System.Drawing.Point(355, 190);
            id_adminLabel.Name = "id_adminLabel";
            id_adminLabel.Size = new System.Drawing.Size(89, 17);
            id_adminLabel.TabIndex = 11;
            id_adminLabel.Text = "id admin:";
            // 
            // apeNoDataSet
            // 
            this.apeNoDataSet.DataSetName = "ApeNoDataSet";
            this.apeNoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // desenvolvedoresBindingSource
            // 
            this.desenvolvedoresBindingSource.DataMember = "desenvolvedores";
            this.desenvolvedoresBindingSource.DataSource = this.apeNoDataSet;
            // 
            // desenvolvedoresTableAdapter
            // 
            this.desenvolvedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.admin_sistemaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.controle_erroTableAdapter = null;
            this.tableAdapterManager.desenvolvedoresTableAdapter = this.desenvolvedoresTableAdapter;
            this.tableAdapterManager.prti_topicoTableAdapter = null;
            this.tableAdapterManager.reportTableAdapter = null;
            this.tableAdapterManager.topicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = apeno.ApeNoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // desenvolvedoresBindingNavigator
            // 
            this.desenvolvedoresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.desenvolvedoresBindingNavigator.BindingSource = this.desenvolvedoresBindingSource;
            this.desenvolvedoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.desenvolvedoresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.desenvolvedoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.desenvolvedoresBindingNavigatorSaveItem});
            this.desenvolvedoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.desenvolvedoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.desenvolvedoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.desenvolvedoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.desenvolvedoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.desenvolvedoresBindingNavigator.Name = "desenvolvedoresBindingNavigator";
            this.desenvolvedoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.desenvolvedoresBindingNavigator.Size = new System.Drawing.Size(704, 25);
            this.desenvolvedoresBindingNavigator.TabIndex = 0;
            this.desenvolvedoresBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // desenvolvedoresBindingNavigatorSaveItem
            // 
            this.desenvolvedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.desenvolvedoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("desenvolvedoresBindingNavigatorSaveItem.Image")));
            this.desenvolvedoresBindingNavigatorSaveItem.Name = "desenvolvedoresBindingNavigatorSaveItem";
            this.desenvolvedoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.desenvolvedoresBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.desenvolvedoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.desenvolvedoresBindingNavigatorSaveItem_Click);
            // 
            // id_desTextBox
            // 
            this.id_desTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.desenvolvedoresBindingSource, "id_des", true));
            this.id_desTextBox.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_desTextBox.Location = new System.Drawing.Point(105, 134);
            this.id_desTextBox.Name = "id_desTextBox";
            this.id_desTextBox.Size = new System.Drawing.Size(200, 23);
            this.id_desTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.desenvolvedoresBindingSource, "nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(105, 179);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 23);
            this.nomeTextBox.TabIndex = 4;
            // 
            // areaTextBox
            // 
            this.areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.desenvolvedoresBindingSource, "area", true));
            this.areaTextBox.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaTextBox.Location = new System.Drawing.Point(105, 228);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(200, 23);
            this.areaTextBox.TabIndex = 6;
            // 
            // datanascDateTimePicker
            // 
            this.datanascDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.desenvolvedoresBindingSource, "datanasc", true));
            this.datanascDateTimePicker.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datanascDateTimePicker.Location = new System.Drawing.Point(213, 75);
            this.datanascDateTimePicker.Name = "datanascDateTimePicker";
            this.datanascDateTimePicker.Size = new System.Drawing.Size(437, 23);
            this.datanascDateTimePicker.TabIndex = 8;
            // 
            // reportTextBox
            // 
            this.reportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.desenvolvedoresBindingSource, "report", true));
            this.reportTextBox.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTextBox.Location = new System.Drawing.Point(450, 133);
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.Size = new System.Drawing.Size(200, 23);
            this.reportTextBox.TabIndex = 10;
            // 
            // id_adminTextBox
            // 
            this.id_adminTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.desenvolvedoresBindingSource, "id_admin", true));
            this.id_adminTextBox.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_adminTextBox.Location = new System.Drawing.Point(450, 187);
            this.id_adminTextBox.Name = "id_adminTextBox";
            this.id_adminTextBox.Size = new System.Drawing.Size(200, 23);
            this.id_adminTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(509, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::apeno.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_desLabel);
            this.Controls.Add(this.id_desTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(areaLabel);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(datanascLabel);
            this.Controls.Add(this.datanascDateTimePicker);
            this.Controls.Add(reportLabel);
            this.Controls.Add(this.reportTextBox);
            this.Controls.Add(id_adminLabel);
            this.Controls.Add(this.id_adminTextBox);
            this.Controls.Add(this.desenvolvedoresBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApeNo - Cadastro de Desenvolvedores";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apeNoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desenvolvedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desenvolvedoresBindingNavigator)).EndInit();
            this.desenvolvedoresBindingNavigator.ResumeLayout(false);
            this.desenvolvedoresBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ApeNoDataSet apeNoDataSet;
        private System.Windows.Forms.BindingSource desenvolvedoresBindingSource;
        private ApeNoDataSetTableAdapters.desenvolvedoresTableAdapter desenvolvedoresTableAdapter;
        private ApeNoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator desenvolvedoresBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton desenvolvedoresBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_desTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.DateTimePicker datanascDateTimePicker;
        private System.Windows.Forms.TextBox reportTextBox;
        private System.Windows.Forms.TextBox id_adminTextBox;
        private System.Windows.Forms.Button button1;
    }
}
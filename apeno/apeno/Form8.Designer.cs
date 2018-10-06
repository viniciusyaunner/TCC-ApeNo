namespace apeno
{
    partial class Form8
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
            System.Windows.Forms.Label id_usLabel;
            System.Windows.Forms.Label id_topicLabel;
            System.Windows.Forms.Label nicknameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.apeNoDataSet = new apeno.ApeNoDataSet();
            this.prti_topicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prti_topicoTableAdapter = new apeno.ApeNoDataSetTableAdapters.prti_topicoTableAdapter();
            this.tableAdapterManager = new apeno.ApeNoDataSetTableAdapters.TableAdapterManager();
            this.prti_topicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.prti_topicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_usTextBox = new System.Windows.Forms.TextBox();
            this.id_topicTextBox = new System.Windows.Forms.TextBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            id_usLabel = new System.Windows.Forms.Label();
            id_topicLabel = new System.Windows.Forms.Label();
            nicknameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.apeNoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prti_topicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prti_topicoBindingNavigator)).BeginInit();
            this.prti_topicoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_usLabel
            // 
            id_usLabel.AutoSize = true;
            id_usLabel.BackColor = System.Drawing.Color.Transparent;
            id_usLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            id_usLabel.Location = new System.Drawing.Point(14, 101);
            id_usLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            id_usLabel.Name = "id_usLabel";
            id_usLabel.Size = new System.Drawing.Size(75, 20);
            id_usLabel.TabIndex = 1;
            id_usLabel.Text = "id us:";
            // 
            // id_topicLabel
            // 
            id_topicLabel.AutoSize = true;
            id_topicLabel.BackColor = System.Drawing.Color.Transparent;
            id_topicLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            id_topicLabel.Location = new System.Drawing.Point(189, 228);
            id_topicLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            id_topicLabel.Name = "id_topicLabel";
            id_topicLabel.Size = new System.Drawing.Size(108, 20);
            id_topicLabel.TabIndex = 3;
            id_topicLabel.Text = "id topic:";
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.BackColor = System.Drawing.Color.Transparent;
            nicknameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nicknameLabel.Location = new System.Drawing.Point(374, 379);
            nicknameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new System.Drawing.Size(108, 20);
            nicknameLabel.TabIndex = 5;
            nicknameLabel.Text = "nickname:";
            // 
            // apeNoDataSet
            // 
            this.apeNoDataSet.DataSetName = "ApeNoDataSet";
            this.apeNoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prti_topicoBindingSource
            // 
            this.prti_topicoBindingSource.DataMember = "prti_topico";
            this.prti_topicoBindingSource.DataSource = this.apeNoDataSet;
            // 
            // prti_topicoTableAdapter
            // 
            this.prti_topicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.admin_sistemaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.controle_erroTableAdapter = null;
            this.tableAdapterManager.desenvolvedoresTableAdapter = null;
            this.tableAdapterManager.prti_topicoTableAdapter = this.prti_topicoTableAdapter;
            this.tableAdapterManager.reportTableAdapter = null;
            this.tableAdapterManager.topicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = apeno.ApeNoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // prti_topicoBindingNavigator
            // 
            this.prti_topicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prti_topicoBindingNavigator.BindingSource = this.prti_topicoBindingSource;
            this.prti_topicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prti_topicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prti_topicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prti_topicoBindingNavigatorSaveItem});
            this.prti_topicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prti_topicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prti_topicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prti_topicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prti_topicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prti_topicoBindingNavigator.Name = "prti_topicoBindingNavigator";
            this.prti_topicoBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.prti_topicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prti_topicoBindingNavigator.Size = new System.Drawing.Size(704, 25);
            this.prti_topicoBindingNavigator.TabIndex = 0;
            this.prti_topicoBindingNavigator.Text = "bindingNavigator1";
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
            // prti_topicoBindingNavigatorSaveItem
            // 
            this.prti_topicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prti_topicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prti_topicoBindingNavigatorSaveItem.Image")));
            this.prti_topicoBindingNavigatorSaveItem.Name = "prti_topicoBindingNavigatorSaveItem";
            this.prti_topicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.prti_topicoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.prti_topicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.prti_topicoBindingNavigatorSaveItem_Click_1);
            // 
            // id_usTextBox
            // 
            this.id_usTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prti_topicoBindingSource, "id_us", true));
            this.id_usTextBox.Location = new System.Drawing.Point(127, 96);
            this.id_usTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.id_usTextBox.Name = "id_usTextBox";
            this.id_usTextBox.Size = new System.Drawing.Size(180, 27);
            this.id_usTextBox.TabIndex = 2;
            // 
            // id_topicTextBox
            // 
            this.id_topicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prti_topicoBindingSource, "id_topic", true));
            this.id_topicTextBox.Location = new System.Drawing.Point(302, 223);
            this.id_topicTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.id_topicTextBox.Name = "id_topicTextBox";
            this.id_topicTextBox.Size = new System.Drawing.Size(180, 27);
            this.id_topicTextBox.TabIndex = 4;
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prti_topicoBindingSource, "nickname", true));
            this.nicknameTextBox.Location = new System.Drawing.Point(487, 374);
            this.nicknameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(180, 27);
            this.nicknameTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::apeno.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_usLabel);
            this.Controls.Add(this.id_usTextBox);
            this.Controls.Add(id_topicLabel);
            this.Controls.Add(this.id_topicTextBox);
            this.Controls.Add(nicknameLabel);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.prti_topicoBindingNavigator);
            this.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApeNo - Numero de Participante";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apeNoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prti_topicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prti_topicoBindingNavigator)).EndInit();
            this.prti_topicoBindingNavigator.ResumeLayout(false);
            this.prti_topicoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ApeNoDataSet apeNoDataSet;
        private System.Windows.Forms.BindingSource prti_topicoBindingSource;
        private ApeNoDataSetTableAdapters.prti_topicoTableAdapter prti_topicoTableAdapter;
        private ApeNoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prti_topicoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton prti_topicoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_usTextBox;
        private System.Windows.Forms.TextBox id_topicTextBox;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.Button button1;

    }
}
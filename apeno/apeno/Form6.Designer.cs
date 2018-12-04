namespace apeno
{
    partial class Form6
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
            System.Windows.Forms.Label id_adminLabel;
            System.Windows.Forms.Label nomeadminLabel;
            System.Windows.Forms.Label regiaoLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label expedienteLabel;
            System.Windows.Forms.Label senhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.apeNoDataSet = new apeno.ApeNoDataSet();
            this.admin_sistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admin_sistemaTableAdapter = new apeno.ApeNoDataSetTableAdapters.admin_sistemaTableAdapter();
            this.tableAdapterManager = new apeno.ApeNoDataSetTableAdapters.TableAdapterManager();
            this.admin_sistemaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.admin_sistemaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_adminTextBox = new System.Windows.Forms.TextBox();
            this.nomeadminTextBox = new System.Windows.Forms.TextBox();
            this.regiaoTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.prti_topicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prti_topicoTableAdapter = new apeno.ApeNoDataSetTableAdapters.prti_topicoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.telefoneMaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.expedienteTextBox = new System.Windows.Forms.TextBox();
            id_adminLabel = new System.Windows.Forms.Label();
            nomeadminLabel = new System.Windows.Forms.Label();
            regiaoLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            expedienteLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.apeNoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_sistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_sistemaBindingNavigator)).BeginInit();
            this.admin_sistemaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prti_topicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_adminLabel
            // 
            id_adminLabel.AutoSize = true;
            id_adminLabel.BackColor = System.Drawing.Color.Transparent;
            id_adminLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            id_adminLabel.Location = new System.Drawing.Point(91, 76);
            id_adminLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_adminLabel.Name = "id_adminLabel";
            id_adminLabel.Size = new System.Drawing.Size(89, 17);
            id_adminLabel.TabIndex = 1;
            id_adminLabel.Text = "id admin:";
            // 
            // nomeadminLabel
            // 
            nomeadminLabel.AutoSize = true;
            nomeadminLabel.BackColor = System.Drawing.Color.Transparent;
            nomeadminLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nomeadminLabel.Location = new System.Drawing.Point(37, 110);
            nomeadminLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeadminLabel.Name = "nomeadminLabel";
            nomeadminLabel.Size = new System.Drawing.Size(143, 17);
            nomeadminLabel.TabIndex = 3;
            nomeadminLabel.Text = "nome do eadmin:";
            nomeadminLabel.Click += new System.EventHandler(this.nomeadminLabel_Click);
            // 
            // regiaoLabel
            // 
            regiaoLabel.AutoSize = true;
            regiaoLabel.BackColor = System.Drawing.Color.Transparent;
            regiaoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            regiaoLabel.Location = new System.Drawing.Point(109, 144);
            regiaoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            regiaoLabel.Name = "regiaoLabel";
            regiaoLabel.Size = new System.Drawing.Size(71, 17);
            regiaoLabel.TabIndex = 5;
            regiaoLabel.Text = "região:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BackColor = System.Drawing.Color.Transparent;
            enderecoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            enderecoLabel.Location = new System.Drawing.Point(91, 178);
            enderecoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(89, 17);
            enderecoLabel.TabIndex = 7;
            enderecoLabel.Text = "endereço:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.BackColor = System.Drawing.Color.Transparent;
            telefoneLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            telefoneLabel.Location = new System.Drawing.Point(430, 73);
            telefoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(89, 17);
            telefoneLabel.TabIndex = 9;
            telefoneLabel.Text = "telefone:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.BackColor = System.Drawing.Color.Transparent;
            celularLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            celularLabel.Location = new System.Drawing.Point(439, 110);
            celularLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(80, 17);
            celularLabel.TabIndex = 11;
            celularLabel.Text = "celular:";
            // 
            // expedienteLabel
            // 
            expedienteLabel.AutoSize = true;
            expedienteLabel.BackColor = System.Drawing.Color.Transparent;
            expedienteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            expedienteLabel.Location = new System.Drawing.Point(412, 144);
            expedienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            expedienteLabel.Name = "expedienteLabel";
            expedienteLabel.Size = new System.Drawing.Size(107, 17);
            expedienteLabel.TabIndex = 13;
            expedienteLabel.Text = "expediente:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.BackColor = System.Drawing.Color.Transparent;
            senhaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            senhaLabel.Location = new System.Drawing.Point(457, 181);
            senhaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(62, 17);
            senhaLabel.TabIndex = 15;
            senhaLabel.Text = "senha:";
            // 
            // apeNoDataSet
            // 
            this.apeNoDataSet.DataSetName = "ApeNoDataSet";
            this.apeNoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admin_sistemaBindingSource
            // 
            this.admin_sistemaBindingSource.DataMember = "admin_sistema";
            this.admin_sistemaBindingSource.DataSource = this.apeNoDataSet;
            // 
            // admin_sistemaTableAdapter
            // 
            this.admin_sistemaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.admin_sistemaTableAdapter = this.admin_sistemaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.controle_erroTableAdapter = null;
            this.tableAdapterManager.desenvolvedoresTableAdapter = null;
            this.tableAdapterManager.prti_topicoTableAdapter = null;
            this.tableAdapterManager.reportTableAdapter = null;
            this.tableAdapterManager.topicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = apeno.ApeNoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // admin_sistemaBindingNavigator
            // 
            this.admin_sistemaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.admin_sistemaBindingNavigator.BindingSource = this.admin_sistemaBindingSource;
            this.admin_sistemaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.admin_sistemaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.admin_sistemaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.admin_sistemaBindingNavigatorSaveItem});
            this.admin_sistemaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.admin_sistemaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.admin_sistemaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.admin_sistemaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.admin_sistemaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.admin_sistemaBindingNavigator.Name = "admin_sistemaBindingNavigator";
            this.admin_sistemaBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.admin_sistemaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.admin_sistemaBindingNavigator.Size = new System.Drawing.Size(704, 25);
            this.admin_sistemaBindingNavigator.TabIndex = 0;
            this.admin_sistemaBindingNavigator.Text = "bindingNavigator1";
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
            // admin_sistemaBindingNavigatorSaveItem
            // 
            this.admin_sistemaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.admin_sistemaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("admin_sistemaBindingNavigatorSaveItem.Image")));
            this.admin_sistemaBindingNavigatorSaveItem.Name = "admin_sistemaBindingNavigatorSaveItem";
            this.admin_sistemaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.admin_sistemaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.admin_sistemaBindingNavigatorSaveItem.Click += new System.EventHandler(this.admin_sistemaBindingNavigatorSaveItem_Click);
            // 
            // id_adminTextBox
            // 
            this.id_adminTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admin_sistemaBindingSource, "id_admin", true));
            this.id_adminTextBox.Location = new System.Drawing.Point(188, 73);
            this.id_adminTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.id_adminTextBox.Name = "id_adminTextBox";
            this.id_adminTextBox.Size = new System.Drawing.Size(148, 23);
            this.id_adminTextBox.TabIndex = 2;
            // 
            // nomeadminTextBox
            // 
            this.nomeadminTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admin_sistemaBindingSource, "nomeadmin", true));
            this.nomeadminTextBox.Location = new System.Drawing.Point(188, 107);
            this.nomeadminTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeadminTextBox.Name = "nomeadminTextBox";
            this.nomeadminTextBox.Size = new System.Drawing.Size(148, 23);
            this.nomeadminTextBox.TabIndex = 4;
            this.nomeadminTextBox.TextChanged += new System.EventHandler(this.nomeadminTextBox_TextChanged);
            // 
            // regiaoTextBox
            // 
            this.regiaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admin_sistemaBindingSource, "regiao", true));
            this.regiaoTextBox.Location = new System.Drawing.Point(188, 141);
            this.regiaoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.regiaoTextBox.Name = "regiaoTextBox";
            this.regiaoTextBox.Size = new System.Drawing.Size(148, 23);
            this.regiaoTextBox.TabIndex = 6;
            this.regiaoTextBox.TextChanged += new System.EventHandler(this.regiaoTextBox_TextChanged);
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admin_sistemaBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(188, 175);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(148, 23);
            this.enderecoTextBox.TabIndex = 8;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admin_sistemaBindingSource, "senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(518, 175);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '⦿';
            this.senhaTextBox.Size = new System.Drawing.Size(148, 23);
            this.senhaTextBox.TabIndex = 16;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(549, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // telefoneMaskedTextBox1
            // 
            this.telefoneMaskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admin_sistemaBindingSource, "telefone", true));
            this.telefoneMaskedTextBox1.Location = new System.Drawing.Point(518, 70);
            this.telefoneMaskedTextBox1.Mask = "(99) 0000-0000";
            this.telefoneMaskedTextBox1.Name = "telefoneMaskedTextBox1";
            this.telefoneMaskedTextBox1.Size = new System.Drawing.Size(148, 23);
            this.telefoneMaskedTextBox1.TabIndex = 19;
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admin_sistemaBindingSource, "celular", true));
            this.celularMaskedTextBox.Location = new System.Drawing.Point(518, 104);
            this.celularMaskedTextBox.Mask = "(99)99999-9999";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(148, 23);
            this.celularMaskedTextBox.TabIndex = 20;
            // 
            // expedienteTextBox
            // 
            this.expedienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admin_sistemaBindingSource, "expediente", true));
            this.expedienteTextBox.Location = new System.Drawing.Point(518, 141);
            this.expedienteTextBox.Name = "expedienteTextBox";
            this.expedienteTextBox.Size = new System.Drawing.Size(148, 23);
            this.expedienteTextBox.TabIndex = 21;
            this.expedienteTextBox.TextChanged += new System.EventHandler(this.expedienteTextBox_TextChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::apeno.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.expedienteTextBox);
            this.Controls.Add(this.celularMaskedTextBox);
            this.Controls.Add(this.telefoneMaskedTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_adminLabel);
            this.Controls.Add(this.id_adminTextBox);
            this.Controls.Add(nomeadminLabel);
            this.Controls.Add(this.nomeadminTextBox);
            this.Controls.Add(regiaoLabel);
            this.Controls.Add(this.regiaoTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(celularLabel);
            this.Controls.Add(expedienteLabel);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.admin_sistemaBindingNavigator);
            this.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApeNo - Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form6_FormClosed);
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apeNoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_sistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_sistemaBindingNavigator)).EndInit();
            this.admin_sistemaBindingNavigator.ResumeLayout(false);
            this.admin_sistemaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prti_topicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ApeNoDataSet apeNoDataSet;
        private System.Windows.Forms.BindingSource admin_sistemaBindingSource;
        private ApeNoDataSetTableAdapters.admin_sistemaTableAdapter admin_sistemaTableAdapter;
        private ApeNoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator admin_sistemaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton admin_sistemaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_adminTextBox;
        private System.Windows.Forms.TextBox nomeadminTextBox;
        private System.Windows.Forms.TextBox regiaoTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.BindingSource prti_topicoBindingSource;
        private ApeNoDataSetTableAdapters.prti_topicoTableAdapter prti_topicoTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox1;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.TextBox expedienteTextBox;
    }
}
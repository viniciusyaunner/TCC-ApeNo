namespace apeno
{
    partial class Form7
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
            System.Windows.Forms.Label id_topicLabel;
            System.Windows.Forms.Label nometopicoLabel;
            System.Windows.Forms.Label numparticipantesLabel;
            System.Windows.Forms.Label qte_adminLabel;
            System.Windows.Forms.Label assuntoLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label criadorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.apeNoDataSet = new apeno.ApeNoDataSet();
            this.topicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topicoTableAdapter = new apeno.ApeNoDataSetTableAdapters.topicoTableAdapter();
            this.tableAdapterManager = new apeno.ApeNoDataSetTableAdapters.TableAdapterManager();
            this.prti_topicoTableAdapter = new apeno.ApeNoDataSetTableAdapters.prti_topicoTableAdapter();
            this.topicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.topicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_topicTextBox = new System.Windows.Forms.TextBox();
            this.nometopicoTextBox = new System.Windows.Forms.TextBox();
            this.numparticipantesTextBox = new System.Windows.Forms.TextBox();
            this.qte_adminTextBox = new System.Windows.Forms.TextBox();
            this.assuntoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.criadorTextBox = new System.Windows.Forms.TextBox();
            this.prti_topicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prti_topicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            id_topicLabel = new System.Windows.Forms.Label();
            nometopicoLabel = new System.Windows.Forms.Label();
            numparticipantesLabel = new System.Windows.Forms.Label();
            qte_adminLabel = new System.Windows.Forms.Label();
            assuntoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            criadorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.apeNoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicoBindingNavigator)).BeginInit();
            this.topicoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prti_topicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prti_topicoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_topicLabel
            // 
            id_topicLabel.AutoSize = true;
            id_topicLabel.BackColor = System.Drawing.Color.Transparent;
            id_topicLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            id_topicLabel.Location = new System.Drawing.Point(125, 94);
            id_topicLabel.Name = "id_topicLabel";
            id_topicLabel.Size = new System.Drawing.Size(89, 17);
            id_topicLabel.TabIndex = 1;
            id_topicLabel.Text = "id topic:";
            id_topicLabel.Click += new System.EventHandler(this.id_topicLabel_Click);
            // 
            // nometopicoLabel
            // 
            nometopicoLabel.AutoSize = true;
            nometopicoLabel.BackColor = System.Drawing.Color.Transparent;
            nometopicoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nometopicoLabel.Location = new System.Drawing.Point(71, 126);
            nometopicoLabel.Name = "nometopicoLabel";
            nometopicoLabel.Size = new System.Drawing.Size(143, 17);
            nometopicoLabel.TabIndex = 3;
            nometopicoLabel.Text = "nome do tópico:";
            // 
            // numparticipantesLabel
            // 
            numparticipantesLabel.AutoSize = true;
            numparticipantesLabel.BackColor = System.Drawing.Color.Transparent;
            numparticipantesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            numparticipantesLabel.Location = new System.Drawing.Point(26, 155);
            numparticipantesLabel.Name = "numparticipantesLabel";
            numparticipantesLabel.Size = new System.Drawing.Size(188, 17);
            numparticipantesLabel.TabIndex = 5;
            numparticipantesLabel.Text = "nº de participantes:";
            // 
            // qte_adminLabel
            // 
            qte_adminLabel.AutoSize = true;
            qte_adminLabel.BackColor = System.Drawing.Color.Transparent;
            qte_adminLabel.ForeColor = System.Drawing.SystemColors.Control;
            qte_adminLabel.Location = new System.Drawing.Point(456, 94);
            qte_adminLabel.Name = "qte_adminLabel";
            qte_adminLabel.Size = new System.Drawing.Size(98, 17);
            qte_adminLabel.TabIndex = 7;
            qte_adminLabel.Text = "qte admin:";
            // 
            // assuntoLabel
            // 
            assuntoLabel.AutoSize = true;
            assuntoLabel.BackColor = System.Drawing.Color.Transparent;
            assuntoLabel.ForeColor = System.Drawing.SystemColors.Control;
            assuntoLabel.Location = new System.Drawing.Point(474, 120);
            assuntoLabel.Name = "assuntoLabel";
            assuntoLabel.Size = new System.Drawing.Size(80, 17);
            assuntoLabel.TabIndex = 9;
            assuntoLabel.Text = "assunto:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.BackColor = System.Drawing.Color.Transparent;
            descricaoLabel.ForeColor = System.Drawing.SystemColors.Control;
            descricaoLabel.Location = new System.Drawing.Point(456, 149);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(98, 17);
            descricaoLabel.TabIndex = 11;
            descricaoLabel.Text = "descricão:";
            // 
            // criadorLabel
            // 
            criadorLabel.AutoSize = true;
            criadorLabel.BackColor = System.Drawing.Color.Transparent;
            criadorLabel.ForeColor = System.Drawing.SystemColors.Control;
            criadorLabel.Location = new System.Drawing.Point(474, 175);
            criadorLabel.Name = "criadorLabel";
            criadorLabel.Size = new System.Drawing.Size(80, 17);
            criadorLabel.TabIndex = 13;
            criadorLabel.Text = "criador:";
            // 
            // apeNoDataSet
            // 
            this.apeNoDataSet.DataSetName = "ApeNoDataSet";
            this.apeNoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // topicoBindingSource
            // 
            this.topicoBindingSource.DataMember = "topico";
            this.topicoBindingSource.DataSource = this.apeNoDataSet;
            // 
            // topicoTableAdapter
            // 
            this.topicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.admin_sistemaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.controle_erroTableAdapter = null;
            this.tableAdapterManager.desenvolvedoresTableAdapter = null;
            this.tableAdapterManager.prti_topicoTableAdapter = this.prti_topicoTableAdapter;
            this.tableAdapterManager.reportTableAdapter = null;
            this.tableAdapterManager.topicoTableAdapter = this.topicoTableAdapter;
            this.tableAdapterManager.UpdateOrder = apeno.ApeNoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // prti_topicoTableAdapter
            // 
            this.prti_topicoTableAdapter.ClearBeforeFill = true;
            // 
            // topicoBindingNavigator
            // 
            this.topicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.topicoBindingNavigator.BindingSource = this.topicoBindingSource;
            this.topicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.topicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.topicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.topicoBindingNavigatorSaveItem});
            this.topicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.topicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.topicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.topicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.topicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.topicoBindingNavigator.Name = "topicoBindingNavigator";
            this.topicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.topicoBindingNavigator.Size = new System.Drawing.Size(704, 25);
            this.topicoBindingNavigator.TabIndex = 0;
            this.topicoBindingNavigator.Text = "bindingNavigator1";
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
            // topicoBindingNavigatorSaveItem
            // 
            this.topicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("topicoBindingNavigatorSaveItem.Image")));
            this.topicoBindingNavigatorSaveItem.Name = "topicoBindingNavigatorSaveItem";
            this.topicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.topicoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.topicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.topicoBindingNavigatorSaveItem_Click);
            // 
            // id_topicTextBox
            // 
            this.id_topicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.topicoBindingSource, "id_topic", true));
            this.id_topicTextBox.Location = new System.Drawing.Point(220, 91);
            this.id_topicTextBox.Name = "id_topicTextBox";
            this.id_topicTextBox.Size = new System.Drawing.Size(130, 23);
            this.id_topicTextBox.TabIndex = 2;
            // 
            // nometopicoTextBox
            // 
            this.nometopicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.topicoBindingSource, "nometopico", true));
            this.nometopicoTextBox.Location = new System.Drawing.Point(220, 120);
            this.nometopicoTextBox.Name = "nometopicoTextBox";
            this.nometopicoTextBox.Size = new System.Drawing.Size(130, 23);
            this.nometopicoTextBox.TabIndex = 4;
            this.nometopicoTextBox.TextChanged += new System.EventHandler(this.nometopicoTextBox_TextChanged);
            // 
            // numparticipantesTextBox
            // 
            this.numparticipantesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.topicoBindingSource, "numparticipantes", true));
            this.numparticipantesTextBox.Location = new System.Drawing.Point(220, 149);
            this.numparticipantesTextBox.Name = "numparticipantesTextBox";
            this.numparticipantesTextBox.Size = new System.Drawing.Size(130, 23);
            this.numparticipantesTextBox.TabIndex = 6;
            // 
            // qte_adminTextBox
            // 
            this.qte_adminTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.topicoBindingSource, "qte_admin", true));
            this.qte_adminTextBox.Location = new System.Drawing.Point(560, 88);
            this.qte_adminTextBox.Name = "qte_adminTextBox";
            this.qte_adminTextBox.Size = new System.Drawing.Size(121, 23);
            this.qte_adminTextBox.TabIndex = 8;
            // 
            // assuntoTextBox
            // 
            this.assuntoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.topicoBindingSource, "assunto", true));
            this.assuntoTextBox.Location = new System.Drawing.Point(560, 117);
            this.assuntoTextBox.Name = "assuntoTextBox";
            this.assuntoTextBox.Size = new System.Drawing.Size(121, 23);
            this.assuntoTextBox.TabIndex = 10;
            this.assuntoTextBox.TextChanged += new System.EventHandler(this.assuntoTextBox_TextChanged);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.topicoBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(560, 146);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(121, 23);
            this.descricaoTextBox.TabIndex = 12;
            this.descricaoTextBox.TextChanged += new System.EventHandler(this.descricaoTextBox_TextChanged);
            // 
            // criadorTextBox
            // 
            this.criadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.topicoBindingSource, "criador", true));
            this.criadorTextBox.Location = new System.Drawing.Point(560, 175);
            this.criadorTextBox.Name = "criadorTextBox";
            this.criadorTextBox.Size = new System.Drawing.Size(121, 23);
            this.criadorTextBox.TabIndex = 14;
            this.criadorTextBox.TextChanged += new System.EventHandler(this.criadorTextBox_TextChanged);
            // 
            // prti_topicoBindingSource
            // 
            this.prti_topicoBindingSource.DataMember = "topicoprti_topico";
            this.prti_topicoBindingSource.DataSource = this.topicoBindingSource;
            // 
            // prti_topicoDataGridView
            // 
            this.prti_topicoDataGridView.AutoGenerateColumns = false;
            this.prti_topicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prti_topicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.prti_topicoDataGridView.DataSource = this.prti_topicoBindingSource;
            this.prti_topicoDataGridView.Location = new System.Drawing.Point(343, 225);
            this.prti_topicoDataGridView.Name = "prti_topicoDataGridView";
            this.prti_topicoDataGridView.Size = new System.Drawing.Size(349, 204);
            this.prti_topicoDataGridView.TabIndex = 15;
            this.prti_topicoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prti_topicoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_us";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_us";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_topic";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_topic";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nickname";
            this.dataGridViewTextBoxColumn3.HeaderText = "nickname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 23);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar nickname";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(197, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 19;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::apeno.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.prti_topicoDataGridView);
            this.Controls.Add(id_topicLabel);
            this.Controls.Add(this.id_topicTextBox);
            this.Controls.Add(nometopicoLabel);
            this.Controls.Add(this.nometopicoTextBox);
            this.Controls.Add(numparticipantesLabel);
            this.Controls.Add(this.numparticipantesTextBox);
            this.Controls.Add(qte_adminLabel);
            this.Controls.Add(this.qte_adminTextBox);
            this.Controls.Add(assuntoLabel);
            this.Controls.Add(this.assuntoTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(criadorLabel);
            this.Controls.Add(this.criadorTextBox);
            this.Controls.Add(this.topicoBindingNavigator);
            this.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApeNo - Topico";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apeNoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicoBindingNavigator)).EndInit();
            this.topicoBindingNavigator.ResumeLayout(false);
            this.topicoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prti_topicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prti_topicoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ApeNoDataSet apeNoDataSet;
        private System.Windows.Forms.BindingSource topicoBindingSource;
        private ApeNoDataSetTableAdapters.topicoTableAdapter topicoTableAdapter;
        private ApeNoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator topicoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton topicoBindingNavigatorSaveItem;
        private ApeNoDataSetTableAdapters.prti_topicoTableAdapter prti_topicoTableAdapter;
        private System.Windows.Forms.TextBox id_topicTextBox;
        private System.Windows.Forms.TextBox nometopicoTextBox;
        private System.Windows.Forms.TextBox numparticipantesTextBox;
        private System.Windows.Forms.TextBox qte_adminTextBox;
        private System.Windows.Forms.TextBox assuntoTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox criadorTextBox;
        private System.Windows.Forms.BindingSource prti_topicoBindingSource;
        private System.Windows.Forms.DataGridView prti_topicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;




    }
}
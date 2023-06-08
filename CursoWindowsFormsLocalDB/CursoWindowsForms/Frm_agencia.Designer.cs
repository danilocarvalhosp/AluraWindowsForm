namespace CursoWindowsForms
{
    partial class Frm_agencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_agencia));
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.ApagatoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.byteBankDataSet = new CursoWindowsForms.ByteBankDataSet();
            this.tb_agenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_agenciaTableAdapter = new CursoWindowsForms.ByteBankDataSetTableAdapters.tb_agenciaTableAdapter();
            this.tableAdapterManager = new CursoWindowsForms.ByteBankDataSetTableAdapters.TableAdapterManager();
            this.tb_agenciaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tb_agenciaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tb_agenciaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tls_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.byteBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_agenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_agenciaBindingNavigator)).BeginInit();
            this.tb_agenciaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_agenciaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApagatoolStripButton});
            this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal.Name = "Tls_Principal";
            this.Tls_Principal.Size = new System.Drawing.Size(429, 25);
            this.Tls_Principal.TabIndex = 57;
            this.Tls_Principal.Text = "toolStrip1";
            // 
            // ApagatoolStripButton
            // 
            this.ApagatoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ApagatoolStripButton.Image = global::CursoWindowsForms.Properties.Resources.ExcluirBarra;
            this.ApagatoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ApagatoolStripButton.Name = "ApagatoolStripButton";
            this.ApagatoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ApagatoolStripButton.Text = "toolStripButton1";
            this.ApagatoolStripButton.Click += new System.EventHandler(this.ApagatoolStripButton_Click);
            // 
            // byteBankDataSet
            // 
            this.byteBankDataSet.DataSetName = "ByteBankDataSet";
            this.byteBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_agenciaBindingSource
            // 
            this.tb_agenciaBindingSource.DataMember = "tb_agencia";
            this.tb_agenciaBindingSource.DataSource = this.byteBankDataSet;
            // 
            // tb_agenciaTableAdapter
            // 
            this.tb_agenciaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_agenciaTableAdapter = this.tb_agenciaTableAdapter;
            this.tableAdapterManager.tb_clienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CursoWindowsForms.ByteBankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_agenciaBindingNavigator
            // 
            this.tb_agenciaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_agenciaBindingNavigator.BindingSource = this.tb_agenciaBindingSource;
            this.tb_agenciaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_agenciaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_agenciaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tb_agenciaBindingNavigatorSaveItem});
            this.tb_agenciaBindingNavigator.Location = new System.Drawing.Point(0, 25);
            this.tb_agenciaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_agenciaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_agenciaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_agenciaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_agenciaBindingNavigator.Name = "tb_agenciaBindingNavigator";
            this.tb_agenciaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_agenciaBindingNavigator.Size = new System.Drawing.Size(429, 25);
            this.tb_agenciaBindingNavigator.TabIndex = 58;
            this.tb_agenciaBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // tb_agenciaBindingNavigatorSaveItem
            // 
            this.tb_agenciaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_agenciaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_agenciaBindingNavigatorSaveItem.Image")));
            this.tb_agenciaBindingNavigatorSaveItem.Name = "tb_agenciaBindingNavigatorSaveItem";
            this.tb_agenciaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tb_agenciaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tb_agenciaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_agenciaBindingNavigatorSaveItem_Click);
            // 
            // tb_agenciaDataGridView
            // 
            this.tb_agenciaDataGridView.AutoGenerateColumns = false;
            this.tb_agenciaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_agenciaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tb_agenciaDataGridView.DataSource = this.tb_agenciaBindingSource;
            this.tb_agenciaDataGridView.Location = new System.Drawing.Point(12, 67);
            this.tb_agenciaDataGridView.Name = "tb_agenciaDataGridView";
            this.tb_agenciaDataGridView.Size = new System.Drawing.Size(405, 286);
            this.tb_agenciaDataGridView.TabIndex = 58;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Agencia";
            this.dataGridViewTextBoxColumn1.FillWeight = 150F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Código da Agência";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.FillWeight = 280F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome da Agência";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 230;
            // 
            // Frm_agencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 365);
            this.Controls.Add(this.tb_agenciaDataGridView);
            this.Controls.Add(this.tb_agenciaBindingNavigator);
            this.Controls.Add(this.Tls_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_agencia";
            this.Text = "Frm_Busca";
            this.Load += new System.EventHandler(this.Frm_agencia_Load);
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.byteBankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_agenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_agenciaBindingNavigator)).EndInit();
            this.tb_agenciaBindingNavigator.ResumeLayout(false);
            this.tb_agenciaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_agenciaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tls_Principal;
        private System.Windows.Forms.ToolStripButton ApagatoolStripButton;
        private ByteBankDataSet byteBankDataSet;
        private System.Windows.Forms.BindingSource tb_agenciaBindingSource;
        private ByteBankDataSetTableAdapters.tb_agenciaTableAdapter tb_agenciaTableAdapter;
        private ByteBankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_agenciaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tb_agenciaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tb_agenciaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
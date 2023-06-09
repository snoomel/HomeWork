
namespace Таксопарки
{
    partial class FormParksList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParksList));
            this.таксопаркиDataSet = new Таксопарки.ТаксопаркиDataSet();
            this.таксопаркBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.таксопаркTableAdapter = new Таксопарки.ТаксопаркиDataSetTableAdapters.ТаксопаркTableAdapter();
            this.tableAdapterManager = new Таксопарки.ТаксопаркиDataSetTableAdapters.TableAdapterManager();
            this.таксопаркBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.таксопаркBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.таксопаркDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.таксопаркиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таксопаркBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таксопаркBindingNavigator)).BeginInit();
            this.таксопаркBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.таксопаркDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // таксопаркиDataSet
            // 
            this.таксопаркиDataSet.DataSetName = "ТаксопаркиDataSet";
            this.таксопаркиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // таксопаркBindingSource
            // 
            this.таксопаркBindingSource.DataMember = "Таксопарк";
            this.таксопаркBindingSource.DataSource = this.таксопаркиDataSet;
            // 
            // таксопаркTableAdapter
            // 
            this.таксопаркTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Таксопарки.ТаксопаркиDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВодительTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ТаксопаркTableAdapter = this.таксопаркTableAdapter;
            // 
            // таксопаркBindingNavigator
            // 
            this.таксопаркBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.таксопаркBindingNavigator.BindingSource = this.таксопаркBindingSource;
            this.таксопаркBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.таксопаркBindingNavigator.CountItemFormat = "из {0}";
            this.таксопаркBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.таксопаркBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.таксопаркBindingNavigatorSaveItem});
            this.таксопаркBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.таксопаркBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.таксопаркBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.таксопаркBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.таксопаркBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.таксопаркBindingNavigator.Name = "таксопаркBindingNavigator";
            this.таксопаркBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.таксопаркBindingNavigator.Size = new System.Drawing.Size(282, 25);
            this.таксопаркBindingNavigator.TabIndex = 0;
            this.таксопаркBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
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
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // таксопаркBindingNavigatorSaveItem
            // 
            this.таксопаркBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.таксопаркBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("таксопаркBindingNavigatorSaveItem.Image")));
            this.таксопаркBindingNavigatorSaveItem.Name = "таксопаркBindingNavigatorSaveItem";
            this.таксопаркBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.таксопаркBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.таксопаркBindingNavigatorSaveItem.Click += new System.EventHandler(this.таксопаркBindingNavigatorSaveItem_Click);
            // 
            // таксопаркDataGridView
            // 
            this.таксопаркDataGridView.AutoGenerateColumns = false;
            this.таксопаркDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.таксопаркDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.таксопаркDataGridView.DataSource = this.таксопаркBindingSource;
            this.таксопаркDataGridView.Location = new System.Drawing.Point(0, 28);
            this.таксопаркDataGridView.Name = "таксопаркDataGridView";
            this.таксопаркDataGridView.Size = new System.Drawing.Size(284, 306);
            this.таксопаркDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_таксопарка";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_таксопарка";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn2.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // FormParksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 334);
            this.Controls.Add(this.таксопаркDataGridView);
            this.Controls.Add(this.таксопаркBindingNavigator);
            this.Name = "FormParksList";
            this.Text = "Информация о таксопарках";
            this.Load += new System.EventHandler(this.FormParksList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.таксопаркиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таксопаркBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таксопаркBindingNavigator)).EndInit();
            this.таксопаркBindingNavigator.ResumeLayout(false);
            this.таксопаркBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.таксопаркDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ТаксопаркиDataSet таксопаркиDataSet;
        private System.Windows.Forms.BindingSource таксопаркBindingSource;
        private ТаксопаркиDataSetTableAdapters.ТаксопаркTableAdapter таксопаркTableAdapter;
        private ТаксопаркиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator таксопаркBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton таксопаркBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView таксопаркDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
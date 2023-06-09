
namespace Таксопарки
{
    partial class FormNewOrder
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
            System.Windows.Forms.Label начальная_точкаLabel;
            System.Windows.Forms.Label конечная_точкаLabel;
            System.Windows.Forms.Label комментарий_к_заказуLabel;
            System.Windows.Forms.Label тарифLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewOrder));
            this.таксопаркиDataSet = new Таксопарки.ТаксопаркиDataSet();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new Таксопарки.ТаксопаркиDataSetTableAdapters.ЗаказTableAdapter();
            this.tableAdapterManager = new Таксопарки.ТаксопаркиDataSetTableAdapters.TableAdapterManager();
            this.заказBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.заказBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_заказаTextBox = new System.Windows.Forms.TextBox();
            this.id_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.id_водителяTextBox = new System.Windows.Forms.TextBox();
            this.начальная_точкаTextBox = new System.Windows.Forms.TextBox();
            this.конечная_точкаTextBox = new System.Windows.Forms.TextBox();
            this.оплата_по_картеCheckBox = new System.Windows.Forms.CheckBox();
            this.комментарий_к_заказуTextBox = new System.Windows.Forms.TextBox();
            this.тарифComboBox = new System.Windows.Forms.ComboBox();
            this.стоимость_заказаTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            начальная_точкаLabel = new System.Windows.Forms.Label();
            конечная_точкаLabel = new System.Windows.Forms.Label();
            комментарий_к_заказуLabel = new System.Windows.Forms.Label();
            тарифLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.таксопаркиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingNavigator)).BeginInit();
            this.заказBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // начальная_точкаLabel
            // 
            начальная_точкаLabel.AutoSize = true;
            начальная_точкаLabel.Location = new System.Drawing.Point(12, 46);
            начальная_точкаLabel.Name = "начальная_точкаLabel";
            начальная_точкаLabel.Size = new System.Drawing.Size(96, 13);
            начальная_точкаLabel.TabIndex = 7;
            начальная_точкаLabel.Text = "Начальная точка:";
            // 
            // конечная_точкаLabel
            // 
            конечная_точкаLabel.AutoSize = true;
            конечная_точкаLabel.Location = new System.Drawing.Point(12, 72);
            конечная_точкаLabel.Name = "конечная_точкаLabel";
            конечная_точкаLabel.Size = new System.Drawing.Size(89, 13);
            конечная_точкаLabel.TabIndex = 9;
            конечная_точкаLabel.Text = "Конечная точка:";
            // 
            // комментарий_к_заказуLabel
            // 
            комментарий_к_заказуLabel.AutoSize = true;
            комментарий_к_заказуLabel.Location = new System.Drawing.Point(12, 173);
            комментарий_к_заказуLabel.Name = "комментарий_к_заказуLabel";
            комментарий_к_заказуLabel.Size = new System.Drawing.Size(127, 13);
            комментарий_к_заказуLabel.TabIndex = 15;
            комментарий_к_заказуLabel.Text = "Комментарий к заказу:";
            // 
            // тарифLabel
            // 
            тарифLabel.AutoSize = true;
            тарифLabel.Location = new System.Drawing.Point(12, 106);
            тарифLabel.Name = "тарифLabel";
            тарифLabel.Size = new System.Drawing.Size(43, 13);
            тарифLabel.TabIndex = 17;
            тарифLabel.Text = "Тариф:";
            // 
            // таксопаркиDataSet
            // 
            this.таксопаркиDataSet.DataSetName = "ТаксопаркиDataSet";
            this.таксопаркиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.таксопаркиDataSet;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Таксопарки.ТаксопаркиDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВодительTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = this.заказTableAdapter;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.ТаксопаркTableAdapter = null;
            // 
            // заказBindingNavigator
            // 
            this.заказBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заказBindingNavigator.BindingSource = this.заказBindingSource;
            this.заказBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заказBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заказBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.заказBindingNavigatorSaveItem});
            this.заказBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заказBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заказBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заказBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заказBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заказBindingNavigator.Name = "заказBindingNavigator";
            this.заказBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заказBindingNavigator.Size = new System.Drawing.Size(364, 25);
            this.заказBindingNavigator.TabIndex = 0;
            this.заказBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // заказBindingNavigatorSaveItem
            // 
            this.заказBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заказBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказBindingNavigatorSaveItem.Image")));
            this.заказBindingNavigatorSaveItem.Name = "заказBindingNavigatorSaveItem";
            this.заказBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заказBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заказBindingNavigatorSaveItem.Click += new System.EventHandler(this.заказBindingNavigatorSaveItem_Click);
            // 
            // id_заказаTextBox
            // 
            this.id_заказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "id_заказа", true));
            this.id_заказаTextBox.Location = new System.Drawing.Point(326, 39);
            this.id_заказаTextBox.Name = "id_заказаTextBox";
            this.id_заказаTextBox.Size = new System.Drawing.Size(17, 20);
            this.id_заказаTextBox.TabIndex = 2;
            // 
            // id_клиентаTextBox
            // 
            this.id_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "id_клиента", true));
            this.id_клиентаTextBox.Location = new System.Drawing.Point(326, 69);
            this.id_клиентаTextBox.Name = "id_клиентаTextBox";
            this.id_клиентаTextBox.Size = new System.Drawing.Size(17, 20);
            this.id_клиентаTextBox.TabIndex = 4;
            // 
            // id_водителяTextBox
            // 
            this.id_водителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "id_водителя", true));
            this.id_водителяTextBox.Location = new System.Drawing.Point(326, 95);
            this.id_водителяTextBox.Name = "id_водителяTextBox";
            this.id_водителяTextBox.Size = new System.Drawing.Size(17, 20);
            this.id_водителяTextBox.TabIndex = 6;
            // 
            // начальная_точкаTextBox
            // 
            this.начальная_точкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Начальная_точка", true));
            this.начальная_точкаTextBox.Location = new System.Drawing.Point(145, 43);
            this.начальная_точкаTextBox.Name = "начальная_точкаTextBox";
            this.начальная_точкаTextBox.Size = new System.Drawing.Size(121, 20);
            this.начальная_точкаTextBox.TabIndex = 8;
            // 
            // конечная_точкаTextBox
            // 
            this.конечная_точкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Конечная_точка", true));
            this.конечная_точкаTextBox.Location = new System.Drawing.Point(145, 69);
            this.конечная_точкаTextBox.Name = "конечная_точкаTextBox";
            this.конечная_точкаTextBox.Size = new System.Drawing.Size(121, 20);
            this.конечная_точкаTextBox.TabIndex = 10;
            // 
            // оплата_по_картеCheckBox
            // 
            this.оплата_по_картеCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.заказBindingSource, "Оплата по карте", true));
            this.оплата_по_картеCheckBox.Location = new System.Drawing.Point(145, 139);
            this.оплата_по_картеCheckBox.Name = "оплата_по_картеCheckBox";
            this.оплата_по_картеCheckBox.Size = new System.Drawing.Size(121, 24);
            this.оплата_по_картеCheckBox.TabIndex = 12;
            this.оплата_по_картеCheckBox.Text = "Оплата по карте";
            this.оплата_по_картеCheckBox.UseVisualStyleBackColor = true;
            // 
            // комментарий_к_заказуTextBox
            // 
            this.комментарий_к_заказуTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Комментарий к заказу", true));
            this.комментарий_к_заказуTextBox.Location = new System.Drawing.Point(145, 170);
            this.комментарий_к_заказуTextBox.Multiline = true;
            this.комментарий_к_заказуTextBox.Name = "комментарий_к_заказуTextBox";
            this.комментарий_к_заказуTextBox.Size = new System.Drawing.Size(121, 64);
            this.комментарий_к_заказуTextBox.TabIndex = 16;
            // 
            // тарифComboBox
            // 
            this.тарифComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Тариф", true));
            this.тарифComboBox.FormattingEnabled = true;
            this.тарифComboBox.Items.AddRange(new object[] {
            "Эконом",
            "Комфорт",
            "Комфорт+"});
            this.тарифComboBox.Location = new System.Drawing.Point(145, 103);
            this.тарифComboBox.Name = "тарифComboBox";
            this.тарифComboBox.Size = new System.Drawing.Size(121, 21);
            this.тарифComboBox.TabIndex = 18;
            // 
            // стоимость_заказаTextBox
            // 
            this.стоимость_заказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Стоимость заказа", true));
            this.стоимость_заказаTextBox.Location = new System.Drawing.Point(326, 121);
            this.стоимость_заказаTextBox.Name = "стоимость_заказаTextBox";
            this.стоимость_заказаTextBox.Size = new System.Drawing.Size(10, 20);
            this.стоимость_заказаTextBox.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 206);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(326, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 123);
            this.panel2.TabIndex = 21;
            // 
            // FormNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 254);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.стоимость_заказаTextBox);
            this.Controls.Add(this.id_заказаTextBox);
            this.Controls.Add(this.id_клиентаTextBox);
            this.Controls.Add(this.id_водителяTextBox);
            this.Controls.Add(начальная_точкаLabel);
            this.Controls.Add(this.начальная_точкаTextBox);
            this.Controls.Add(конечная_точкаLabel);
            this.Controls.Add(this.конечная_точкаTextBox);
            this.Controls.Add(this.оплата_по_картеCheckBox);
            this.Controls.Add(комментарий_к_заказуLabel);
            this.Controls.Add(this.комментарий_к_заказуTextBox);
            this.Controls.Add(тарифLabel);
            this.Controls.Add(this.тарифComboBox);
            this.Controls.Add(this.заказBindingNavigator);
            this.Name = "FormNewOrder";
            this.Text = "Новый заказ";
            this.Load += new System.EventHandler(this.FormNewOrder_Load);
            this.Shown += new System.EventHandler(this.FormNewOrder_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.таксопаркиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingNavigator)).EndInit();
            this.заказBindingNavigator.ResumeLayout(false);
            this.заказBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ТаксопаркиDataSet таксопаркиDataSet;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private ТаксопаркиDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private ТаксопаркиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заказBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton заказBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_заказаTextBox;
        private System.Windows.Forms.TextBox id_клиентаTextBox;
        private System.Windows.Forms.TextBox id_водителяTextBox;
        private System.Windows.Forms.TextBox начальная_точкаTextBox;
        private System.Windows.Forms.TextBox конечная_точкаTextBox;
        private System.Windows.Forms.CheckBox оплата_по_картеCheckBox;
        private System.Windows.Forms.TextBox комментарий_к_заказуTextBox;
        private System.Windows.Forms.ComboBox тарифComboBox;
        private System.Windows.Forms.TextBox стоимость_заказаTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
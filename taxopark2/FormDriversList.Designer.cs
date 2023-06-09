
namespace Таксопарки
{
    partial class FormDriversList
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
            System.Windows.Forms.Label id_водителяLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label праваLabel;
            System.Windows.Forms.Label номер_телефонаLabel;
            System.Windows.Forms.Label автомобильLabel;
            System.Windows.Forms.Label id_таксопаркаLabel;
            System.Windows.Forms.Label адрес_таксопаркаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDriversList));
            this.таксопаркиDataSet = new Таксопарки.ТаксопаркиDataSet();
            this.водительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.водительTableAdapter = new Таксопарки.ТаксопаркиDataSetTableAdapters.ВодительTableAdapter();
            this.tableAdapterManager = new Таксопарки.ТаксопаркиDataSetTableAdapters.TableAdapterManager();
            this.водительBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.водительBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_водителяTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.праваTextBox = new System.Windows.Forms.TextBox();
            this.номер_телефонаTextBox = new System.Windows.Forms.TextBox();
            this.автомобильComboBox = new System.Windows.Forms.ComboBox();
            this.id_таксопаркаTextBox = new System.Windows.Forms.TextBox();
            this.фотографияPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonOpenPhoto = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            this.адрес_таксопаркаLabel1 = new System.Windows.Forms.Label();
            this.таксопаркBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.таксопаркTableAdapter = new Таксопарки.ТаксопаркиDataSetTableAdapters.ТаксопаркTableAdapter();
            this.о_водителеLabel1 = new System.Windows.Forms.Label();
            id_водителяLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            праваLabel = new System.Windows.Forms.Label();
            номер_телефонаLabel = new System.Windows.Forms.Label();
            автомобильLabel = new System.Windows.Forms.Label();
            id_таксопаркаLabel = new System.Windows.Forms.Label();
            адрес_таксопаркаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.таксопаркиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.водительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.водительBindingNavigator)).BeginInit();
            this.водительBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотографияPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таксопаркBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_водителяLabel
            // 
            id_водителяLabel.AutoSize = true;
            id_водителяLabel.Location = new System.Drawing.Point(12, 96);
            id_водителяLabel.Name = "id_водителяLabel";
            id_водителяLabel.Size = new System.Drawing.Size(68, 13);
            id_водителяLabel.TabIndex = 1;
            id_водителяLabel.Text = "id водителя:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(12, 122);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 3;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(12, 148);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 5;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(12, 174);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(57, 13);
            отчествоLabel.TabIndex = 7;
            отчествоLabel.Text = "Отчество:";
            // 
            // праваLabel
            // 
            праваLabel.AutoSize = true;
            праваLabel.Location = new System.Drawing.Point(12, 200);
            праваLabel.Name = "праваLabel";
            праваLabel.Size = new System.Drawing.Size(42, 13);
            праваLabel.TabIndex = 9;
            праваLabel.Text = "Права:";
            // 
            // номер_телефонаLabel
            // 
            номер_телефонаLabel.AutoSize = true;
            номер_телефонаLabel.Location = new System.Drawing.Point(12, 226);
            номер_телефонаLabel.Name = "номер_телефонаLabel";
            номер_телефонаLabel.Size = new System.Drawing.Size(96, 13);
            номер_телефонаLabel.TabIndex = 11;
            номер_телефонаLabel.Text = "Номер телефона:";
            // 
            // автомобильLabel
            // 
            автомобильLabel.AutoSize = true;
            автомобильLabel.Location = new System.Drawing.Point(12, 255);
            автомобильLabel.Name = "автомобильLabel";
            автомобильLabel.Size = new System.Drawing.Size(72, 13);
            автомобильLabel.TabIndex = 13;
            автомобильLabel.Text = "Автомобиль:";
            // 
            // id_таксопаркаLabel
            // 
            id_таксопаркаLabel.AutoSize = true;
            id_таксопаркаLabel.Location = new System.Drawing.Point(12, 284);
            id_таксопаркаLabel.Name = "id_таксопаркаLabel";
            id_таксопаркаLabel.Size = new System.Drawing.Size(80, 13);
            id_таксопаркаLabel.TabIndex = 15;
            id_таксопаркаLabel.Text = "id таксопарка:";
            // 
            // адрес_таксопаркаLabel
            // 
            адрес_таксопаркаLabel.AutoSize = true;
            адрес_таксопаркаLabel.Location = new System.Drawing.Point(12, 312);
            адрес_таксопаркаLabel.Name = "адрес_таксопаркаLabel";
            адрес_таксопаркаLabel.Size = new System.Drawing.Size(103, 13);
            адрес_таксопаркаLabel.TabIndex = 20;
            адрес_таксопаркаLabel.Text = "Адрес таксопарка:";
            // 
            // таксопаркиDataSet
            // 
            this.таксопаркиDataSet.DataSetName = "ТаксопаркиDataSet";
            this.таксопаркиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // водительBindingSource
            // 
            this.водительBindingSource.DataMember = "Водитель";
            this.водительBindingSource.DataSource = this.таксопаркиDataSet;
            // 
            // водительTableAdapter
            // 
            this.водительTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Таксопарки.ТаксопаркиDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВодительTableAdapter = this.водительTableAdapter;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.ТаксопаркTableAdapter = null;
            // 
            // водительBindingNavigator
            // 
            this.водительBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.водительBindingNavigator.BindingSource = this.водительBindingSource;
            this.водительBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.водительBindingNavigator.CountItemFormat = "из {0}";
            this.водительBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.водительBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.водительBindingNavigatorSaveItem});
            this.водительBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.водительBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.водительBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.водительBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.водительBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.водительBindingNavigator.Name = "водительBindingNavigator";
            this.водительBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.водительBindingNavigator.Size = new System.Drawing.Size(407, 25);
            this.водительBindingNavigator.TabIndex = 0;
            this.водительBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
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
            // водительBindingNavigatorSaveItem
            // 
            this.водительBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.водительBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("водительBindingNavigatorSaveItem.Image")));
            this.водительBindingNavigatorSaveItem.Name = "водительBindingNavigatorSaveItem";
            this.водительBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.водительBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.водительBindingNavigatorSaveItem.Click += new System.EventHandler(this.водительBindingNavigatorSaveItem_Click);
            // 
            // id_водителяTextBox
            // 
            this.id_водителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водительBindingSource, "id_водителя", true));
            this.id_водителяTextBox.Location = new System.Drawing.Point(114, 93);
            this.id_водителяTextBox.Name = "id_водителяTextBox";
            this.id_водителяTextBox.Size = new System.Drawing.Size(121, 20);
            this.id_водителяTextBox.TabIndex = 2;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водительBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(114, 119);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(121, 20);
            this.фамилияTextBox.TabIndex = 4;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водительBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(114, 145);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(121, 20);
            this.имяTextBox.TabIndex = 6;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водительBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(114, 171);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(121, 20);
            this.отчествоTextBox.TabIndex = 8;
            // 
            // праваTextBox
            // 
            this.праваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водительBindingSource, "Права", true));
            this.праваTextBox.Location = new System.Drawing.Point(114, 197);
            this.праваTextBox.Name = "праваTextBox";
            this.праваTextBox.Size = new System.Drawing.Size(121, 20);
            this.праваTextBox.TabIndex = 10;
            // 
            // номер_телефонаTextBox
            // 
            this.номер_телефонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водительBindingSource, "Номер_телефона", true));
            this.номер_телефонаTextBox.Location = new System.Drawing.Point(114, 223);
            this.номер_телефонаTextBox.Name = "номер_телефонаTextBox";
            this.номер_телефонаTextBox.Size = new System.Drawing.Size(121, 20);
            this.номер_телефонаTextBox.TabIndex = 12;
            // 
            // автомобильComboBox
            // 
            this.автомобильComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водительBindingSource, "Автомобиль", true));
            this.автомобильComboBox.FormattingEnabled = true;
            this.автомобильComboBox.Items.AddRange(new object[] {
            "Kia Rio",
            "Ford Focus",
            "Hyundai Solaris",
            "Volkswagen Polo",
            "Skoda Octavia",
            "Lada Largus"});
            this.автомобильComboBox.Location = new System.Drawing.Point(114, 252);
            this.автомобильComboBox.Name = "автомобильComboBox";
            this.автомобильComboBox.Size = new System.Drawing.Size(121, 21);
            this.автомобильComboBox.TabIndex = 14;
            // 
            // id_таксопаркаTextBox
            // 
            this.id_таксопаркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водительBindingSource, "id_таксопарка", true));
            this.id_таксопаркаTextBox.Location = new System.Drawing.Point(114, 281);
            this.id_таксопаркаTextBox.Name = "id_таксопаркаTextBox";
            this.id_таксопаркаTextBox.Size = new System.Drawing.Size(121, 20);
            this.id_таксопаркаTextBox.TabIndex = 16;
            // 
            // фотографияPictureBox
            // 
            this.фотографияPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.водительBindingSource, "Фотография", true));
            this.фотографияPictureBox.Location = new System.Drawing.Point(261, 123);
            this.фотографияPictureBox.Name = "фотографияPictureBox";
            this.фотографияPictureBox.Size = new System.Drawing.Size(126, 150);
            this.фотографияPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.фотографияPictureBox.TabIndex = 18;
            this.фотографияPictureBox.TabStop = false;
            // 
            // buttonOpenPhoto
            // 
            this.buttonOpenPhoto.Location = new System.Drawing.Point(261, 93);
            this.buttonOpenPhoto.Name = "buttonOpenPhoto";
            this.buttonOpenPhoto.Size = new System.Drawing.Size(126, 23);
            this.buttonOpenPhoto.TabIndex = 19;
            this.buttonOpenPhoto.Text = "Открыть фото";
            this.buttonOpenPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto.Click += new System.EventHandler(this.buttonOpenPhoto_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // адрес_таксопаркаLabel1
            // 
            this.адрес_таксопаркаLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водительBindingSource, "Адрес_таксопарка", true));
            this.адрес_таксопаркаLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.адрес_таксопаркаLabel1.Location = new System.Drawing.Point(121, 312);
            this.адрес_таксопаркаLabel1.Name = "адрес_таксопаркаLabel1";
            this.адрес_таксопаркаLabel1.Size = new System.Drawing.Size(142, 23);
            this.адрес_таксопаркаLabel1.TabIndex = 21;
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
            // о_водителеLabel1
            // 
            this.о_водителеLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водительBindingSource, "О_водителе", true));
            this.о_водителеLabel1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.о_водителеLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.о_водителеLabel1.Location = new System.Drawing.Point(15, 41);
            this.о_водителеLabel1.Name = "о_водителеLabel1";
            this.о_водителеLabel1.Size = new System.Drawing.Size(372, 23);
            this.о_водителеLabel1.TabIndex = 22;
            // 
            // FormDriversList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 355);
            this.Controls.Add(this.о_водителеLabel1);
            this.Controls.Add(адрес_таксопаркаLabel);
            this.Controls.Add(this.адрес_таксопаркаLabel1);
            this.Controls.Add(this.buttonOpenPhoto);
            this.Controls.Add(id_водителяLabel);
            this.Controls.Add(this.id_водителяTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(праваLabel);
            this.Controls.Add(this.праваTextBox);
            this.Controls.Add(номер_телефонаLabel);
            this.Controls.Add(this.номер_телефонаTextBox);
            this.Controls.Add(автомобильLabel);
            this.Controls.Add(this.автомобильComboBox);
            this.Controls.Add(id_таксопаркаLabel);
            this.Controls.Add(this.id_таксопаркаTextBox);
            this.Controls.Add(this.фотографияPictureBox);
            this.Controls.Add(this.водительBindingNavigator);
            this.Name = "FormDriversList";
            this.Text = "Информация о водителях";
            this.Load += new System.EventHandler(this.FormDriversList_Load);
            this.Shown += new System.EventHandler(this.FormDriversList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.таксопаркиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.водительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.водительBindingNavigator)).EndInit();
            this.водительBindingNavigator.ResumeLayout(false);
            this.водительBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.фотографияPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таксопаркBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ТаксопаркиDataSet таксопаркиDataSet;
        private System.Windows.Forms.BindingSource водительBindingSource;
        private ТаксопаркиDataSetTableAdapters.ВодительTableAdapter водительTableAdapter;
        private ТаксопаркиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator водительBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton водительBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_водителяTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox праваTextBox;
        private System.Windows.Forms.TextBox номер_телефонаTextBox;
        private System.Windows.Forms.ComboBox автомобильComboBox;
        private System.Windows.Forms.TextBox id_таксопаркаTextBox;
        private System.Windows.Forms.PictureBox фотографияPictureBox;
        private System.Windows.Forms.Button buttonOpenPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
        private System.Windows.Forms.Label адрес_таксопаркаLabel1;
        private System.Windows.Forms.BindingSource таксопаркBindingSource;
        private ТаксопаркиDataSetTableAdapters.ТаксопаркTableAdapter таксопаркTableAdapter;
        private System.Windows.Forms.Label о_водителеLabel1;
    }
}
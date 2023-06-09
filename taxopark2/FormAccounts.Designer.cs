
namespace Таксопарки
{
    partial class FormAccounts
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
            this.radioButtonINS = new System.Windows.Forms.RadioButton();
            this.radioButtonUPD = new System.Windows.Forms.RadioButton();
            this.radioButtonDEL = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.dataGridViewREG = new System.Windows.Forms.DataGridView();
            this.таксопаркиDataSet = new Таксопарки.ТаксопаркиDataSet();
            this.пользователиTableAdapter = new Таксопарки.ТаксопаркиDataSetTableAdapters.ПользователиTableAdapter();
            this.tableAdapterManager = new Таксопарки.ТаксопаркиDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewREG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таксопаркиDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonINS
            // 
            this.radioButtonINS.AutoSize = true;
            this.radioButtonINS.Location = new System.Drawing.Point(34, 27);
            this.radioButtonINS.Name = "radioButtonINS";
            this.radioButtonINS.Size = new System.Drawing.Size(75, 17);
            this.radioButtonINS.TabIndex = 0;
            this.radioButtonINS.TabStop = true;
            this.radioButtonINS.Text = "Добавить";
            this.radioButtonINS.UseVisualStyleBackColor = true;
            // 
            // radioButtonUPD
            // 
            this.radioButtonUPD.AutoSize = true;
            this.radioButtonUPD.Location = new System.Drawing.Point(34, 50);
            this.radioButtonUPD.Name = "radioButtonUPD";
            this.radioButtonUPD.Size = new System.Drawing.Size(76, 17);
            this.radioButtonUPD.TabIndex = 1;
            this.radioButtonUPD.TabStop = true;
            this.radioButtonUPD.Text = "Изменить";
            this.radioButtonUPD.UseVisualStyleBackColor = true;
            // 
            // radioButtonDEL
            // 
            this.radioButtonDEL.AutoSize = true;
            this.radioButtonDEL.Location = new System.Drawing.Point(34, 73);
            this.radioButtonDEL.Name = "radioButtonDEL";
            this.radioButtonDEL.Size = new System.Drawing.Size(68, 17);
            this.radioButtonDEL.TabIndex = 2;
            this.radioButtonDEL.TabStop = true;
            this.radioButtonDEL.Text = "Удалить";
            this.radioButtonDEL.UseVisualStyleBackColor = true;
            this.radioButtonDEL.CheckedChanged += new System.EventHandler(this.radioButtonDEL_CheckedChanged_2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxRole);
            this.panel1.Controls.Add(this.textBoxPass);
            this.panel1.Location = new System.Drawing.Point(236, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 68);
            this.panel1.TabIndex = 4;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Клиент",
            "Оператор",
            "Администратор"});
            this.comboBoxRole.Location = new System.Drawing.Point(3, 35);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRole.TabIndex = 7;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(3, 9);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(121, 20);
            this.textBoxPass.TabIndex = 6;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(237, 27);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(121, 20);
            this.textBoxLog.TabIndex = 5;
            // 
            // dataGridViewREG
            // 
            this.dataGridViewREG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewREG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewREG.Location = new System.Drawing.Point(0, 142);
            this.dataGridViewREG.Name = "dataGridViewREG";
            this.dataGridViewREG.Size = new System.Drawing.Size(443, 197);
            this.dataGridViewREG.TabIndex = 6;
            // 
            // таксопаркиDataSet
            // 
            this.таксопаркиDataSet.DataSetName = "ТаксопаркиDataSet";
            this.таксопаркиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Таксопарки.ТаксопаркиDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВодительTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = this.пользователиTableAdapter;
            this.tableAdapterManager.ТаксопаркTableAdapter = null;
            // 
            // FormAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 339);
            this.Controls.Add(this.dataGridViewREG);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonDEL);
            this.Controls.Add(this.radioButtonUPD);
            this.Controls.Add(this.radioButtonINS);
            this.Name = "FormAccounts";
            this.Text = "Учетные записи";
            this.Load += new System.EventHandler(this.FormAccounts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewREG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таксопаркиDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonINS;
        private System.Windows.Forms.RadioButton radioButtonUPD;
        private System.Windows.Forms.RadioButton radioButtonDEL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.DataGridView dataGridViewREG;
        private ТаксопаркиDataSet таксопаркиDataSet;
        private ТаксопаркиDataSetTableAdapters.ПользователиTableAdapter пользователиTableAdapter;
        private ТаксопаркиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
namespace kurcach
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
            System.Windows.Forms.Label nazv_otdelaLabel;
            System.Windows.Forms.Label id_upravLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.dB_KuDataSet = new kurcach.DB_KuDataSet();
            this.otdelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdelTableAdapter = new kurcach.DB_KuDataSetTableAdapters.otdelTableAdapter();
            this.tableAdapterManager = new kurcach.DB_KuDataSetTableAdapters.TableAdapterManager();
            this.otdelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.otdelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nazv_otdelaTextBox = new System.Windows.Forms.TextBox();
            this.otdelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_KuDataSet1 = new kurcach.DB_KuDataSet1();
            this.otdelTableAdapter1 = new kurcach.DB_KuDataSet1TableAdapters.otdelTableAdapter();
            this.tableAdapterManager1 = new kurcach.DB_KuDataSet1TableAdapters.TableAdapterManager();
            this.id_upravComboBox = new System.Windows.Forms.ComboBox();
            this.sotrudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudTableAdapter = new kurcach.DB_KuDataSet1TableAdapters.SotrudTableAdapter();
            nazv_otdelaLabel = new System.Windows.Forms.Label();
            id_upravLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingNavigator)).BeginInit();
            this.otdelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nazv_otdelaLabel
            // 
            nazv_otdelaLabel.AutoSize = true;
            nazv_otdelaLabel.Location = new System.Drawing.Point(110, 55);
            nazv_otdelaLabel.Name = "nazv_otdelaLabel";
            nazv_otdelaLabel.Size = new System.Drawing.Size(98, 13);
            nazv_otdelaLabel.TabIndex = 1;
            nazv_otdelaLabel.Text = "Название отдела:";
            // 
            // id_upravLabel
            // 
            id_upravLabel.AutoSize = true;
            id_upravLabel.Location = new System.Drawing.Point(40, 114);
            id_upravLabel.Name = "id_upravLabel";
            id_upravLabel.Size = new System.Drawing.Size(229, 13);
            id_upravLabel.TabIndex = 3;
            id_upravLabel.Text = "Номер сотрудника управляющего отделом:";
            // 
            // dB_KuDataSet
            // 
            this.dB_KuDataSet.DataSetName = "DB_KuDataSet";
            this.dB_KuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otdelBindingSource
            // 
            this.otdelBindingSource.DataMember = "otdel";
            this.otdelBindingSource.DataSource = this.dB_KuDataSet;
            // 
            // otdelTableAdapter
            // 
            this.otdelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilialTableAdapter = null;
            this.tableAdapterManager.otdelTableAdapter = this.otdelTableAdapter;
            this.tableAdapterManager.SotrudTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kurcach.DB_KuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZatratTableAdapter = null;
            // 
            // otdelBindingNavigator
            // 
            this.otdelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.otdelBindingNavigator.BindingSource = this.otdelBindingSource;
            this.otdelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.otdelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.otdelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.otdelBindingNavigatorSaveItem});
            this.otdelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.otdelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.otdelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.otdelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.otdelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.otdelBindingNavigator.Name = "otdelBindingNavigator";
            this.otdelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.otdelBindingNavigator.Size = new System.Drawing.Size(315, 25);
            this.otdelBindingNavigator.TabIndex = 0;
            this.otdelBindingNavigator.Text = "bindingNavigator1";
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
            // otdelBindingNavigatorSaveItem
            // 
            this.otdelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.otdelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("otdelBindingNavigatorSaveItem.Image")));
            this.otdelBindingNavigatorSaveItem.Name = "otdelBindingNavigatorSaveItem";
            this.otdelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.otdelBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.otdelBindingNavigatorSaveItem.Click += new System.EventHandler(this.otdelBindingNavigatorSaveItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(113, 183);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 22);
            this.button1.TabIndex = 27;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nazv_otdelaTextBox
            // 
            this.nazv_otdelaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.otdelBindingSource1, "Nazv_otdela", true));
            this.nazv_otdelaTextBox.Location = new System.Drawing.Point(29, 80);
            this.nazv_otdelaTextBox.Name = "nazv_otdelaTextBox";
            this.nazv_otdelaTextBox.Size = new System.Drawing.Size(255, 20);
            this.nazv_otdelaTextBox.TabIndex = 29;
            // 
            // otdelBindingSource1
            // 
            this.otdelBindingSource1.DataMember = "otdel";
            this.otdelBindingSource1.DataSource = this.dB_KuDataSet1;
            // 
            // dB_KuDataSet1
            // 
            this.dB_KuDataSet1.DataSetName = "DB_KuDataSet1";
            this.dB_KuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otdelTableAdapter1
            // 
            this.otdelTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.FilialTableAdapter = null;
            this.tableAdapterManager1.otdelTableAdapter = this.otdelTableAdapter1;
            this.tableAdapterManager1.SotrudTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = kurcach.DB_KuDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ZatratTableAdapter = null;
            // 
            // id_upravComboBox
            // 
            this.id_upravComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.otdelBindingSource1, "id_uprav", true));
            this.id_upravComboBox.DataSource = this.sotrudBindingSource;
            this.id_upravComboBox.DisplayMember = "id";
            this.id_upravComboBox.FormattingEnabled = true;
            this.id_upravComboBox.Location = new System.Drawing.Point(29, 142);
            this.id_upravComboBox.Name = "id_upravComboBox";
            this.id_upravComboBox.Size = new System.Drawing.Size(255, 21);
            this.id_upravComboBox.TabIndex = 30;
            // 
            // sotrudBindingSource
            // 
            this.sotrudBindingSource.DataMember = "Sotrud";
            this.sotrudBindingSource.DataSource = this.dB_KuDataSet1;
            // 
            // sotrudTableAdapter
            // 
            this.sotrudTableAdapter.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 256);
            this.Controls.Add(this.id_upravComboBox);
            this.Controls.Add(this.nazv_otdelaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_upravLabel);
            this.Controls.Add(nazv_otdelaLabel);
            this.Controls.Add(this.otdelBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.Text = "Отделы";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_KuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingNavigator)).EndInit();
            this.otdelBindingNavigator.ResumeLayout(false);
            this.otdelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otdelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_KuDataSet dB_KuDataSet;
        private System.Windows.Forms.BindingSource otdelBindingSource;
        private DB_KuDataSetTableAdapters.otdelTableAdapter otdelTableAdapter;
        private DB_KuDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator otdelBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton otdelBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private DB_KuDataSet1 dB_KuDataSet1;
        private System.Windows.Forms.BindingSource otdelBindingSource1;
        private DB_KuDataSet1TableAdapters.otdelTableAdapter otdelTableAdapter1;
        private DB_KuDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox nazv_otdelaTextBox;
        private System.Windows.Forms.ComboBox id_upravComboBox;
        private System.Windows.Forms.BindingSource sotrudBindingSource;
        private DB_KuDataSet1TableAdapters.SotrudTableAdapter sotrudTableAdapter;
    }
}
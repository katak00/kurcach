namespace kurcach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            System.Windows.Forms.Label vid_zatratLabel;
            System.Windows.Forms.Label stoimLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label id_FGLabel;
            this.dB_KuDataSet1 = new kurcach.DB_KuDataSet1();
            this.zatratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zatratTableAdapter = new kurcach.DB_KuDataSet1TableAdapters.ZatratTableAdapter();
            this.tableAdapterManager = new kurcach.DB_KuDataSet1TableAdapters.TableAdapterManager();
            this.zatratBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.zatratBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vid_zatratTextBox = new System.Windows.Forms.TextBox();
            this.stoimTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.filialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filialTableAdapter = new kurcach.DB_KuDataSet1TableAdapters.FilialTableAdapter();
            this.id_FGComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            vid_zatratLabel = new System.Windows.Forms.Label();
            stoimLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            id_FGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zatratBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zatratBindingNavigator)).BeginInit();
            this.zatratBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_KuDataSet1
            // 
            this.dB_KuDataSet1.DataSetName = "DB_KuDataSet1";
            this.dB_KuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zatratBindingSource
            // 
            this.zatratBindingSource.DataMember = "Zatrat";
            this.zatratBindingSource.DataSource = this.dB_KuDataSet1;
            // 
            // zatratTableAdapter
            // 
            this.zatratTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilialTableAdapter = this.filialTableAdapter;
            this.tableAdapterManager.otdelTableAdapter = null;
            this.tableAdapterManager.SotrudTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kurcach.DB_KuDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZatratTableAdapter = this.zatratTableAdapter;
            // 
            // zatratBindingNavigator
            // 
            this.zatratBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zatratBindingNavigator.BindingSource = this.zatratBindingSource;
            this.zatratBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zatratBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zatratBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.zatratBindingNavigatorSaveItem});
            this.zatratBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zatratBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zatratBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zatratBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zatratBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zatratBindingNavigator.Name = "zatratBindingNavigator";
            this.zatratBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zatratBindingNavigator.Size = new System.Drawing.Size(357, 25);
            this.zatratBindingNavigator.TabIndex = 0;
            this.zatratBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
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
            // zatratBindingNavigatorSaveItem
            // 
            this.zatratBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zatratBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zatratBindingNavigatorSaveItem.Image")));
            this.zatratBindingNavigatorSaveItem.Name = "zatratBindingNavigatorSaveItem";
            this.zatratBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.zatratBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.zatratBindingNavigatorSaveItem.Click += new System.EventHandler(this.zatratBindingNavigatorSaveItem_Click);
            // 
            // vid_zatratLabel
            // 
            vid_zatratLabel.AutoSize = true;
            vid_zatratLabel.Location = new System.Drawing.Point(28, 75);
            vid_zatratLabel.Name = "vid_zatratLabel";
            vid_zatratLabel.Size = new System.Drawing.Size(66, 13);
            vid_zatratLabel.TabIndex = 1;
            vid_zatratLabel.Text = "Вид затрат:";
            // 
            // vid_zatratTextBox
            // 
            this.vid_zatratTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zatratBindingSource, "vid_zatrat", true));
            this.vid_zatratTextBox.Location = new System.Drawing.Point(128, 75);
            this.vid_zatratTextBox.Name = "vid_zatratTextBox";
            this.vid_zatratTextBox.Size = new System.Drawing.Size(200, 20);
            this.vid_zatratTextBox.TabIndex = 2;
            // 
            // stoimLabel
            // 
            stoimLabel.AutoSize = true;
            stoimLabel.Location = new System.Drawing.Point(28, 109);
            stoimLabel.Name = "stoimLabel";
            stoimLabel.Size = new System.Drawing.Size(94, 13);
            stoimLabel.TabIndex = 3;
            stoimLabel.Text = "Стоимость (руб.):";
            // 
            // stoimTextBox
            // 
            this.stoimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zatratBindingSource, "Stoim", true));
            this.stoimTextBox.Location = new System.Drawing.Point(128, 102);
            this.stoimTextBox.Name = "stoimTextBox";
            this.stoimTextBox.Size = new System.Drawing.Size(200, 20);
            this.stoimTextBox.TabIndex = 4;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(28, 141);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(36, 13);
            dataLabel.TabIndex = 5;
            dataLabel.Text = "Дата:";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zatratBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(128, 135);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 6;
            // 
            // id_FGLabel
            // 
            id_FGLabel.AutoSize = true;
            id_FGLabel.Location = new System.Drawing.Point(28, 175);
            id_FGLabel.Name = "id_FGLabel";
            id_FGLabel.Size = new System.Drawing.Size(91, 13);
            id_FGLabel.TabIndex = 7;
            id_FGLabel.Text = "Номер филиала:";
            // 
            // filialBindingSource
            // 
            this.filialBindingSource.DataMember = "FK_Filial_Zatrat";
            this.filialBindingSource.DataSource = this.zatratBindingSource;
            // 
            // filialTableAdapter
            // 
            this.filialTableAdapter.ClearBeforeFill = true;
            // 
            // id_FGComboBox
            // 
            this.id_FGComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zatratBindingSource, "Id_FG", true));
            this.id_FGComboBox.DataSource = this.zatratBindingSource;
            this.id_FGComboBox.DisplayMember = "Id_FG";
            this.id_FGComboBox.FormattingEnabled = true;
            this.id_FGComboBox.Location = new System.Drawing.Point(128, 175);
            this.id_FGComboBox.Name = "id_FGComboBox";
            this.id_FGComboBox.Size = new System.Drawing.Size(200, 21);
            this.id_FGComboBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(138, 218);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 22);
            this.button1.TabIndex = 29;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id_FGComboBox);
            this.Controls.Add(id_FGLabel);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(stoimLabel);
            this.Controls.Add(this.stoimTextBox);
            this.Controls.Add(vid_zatratLabel);
            this.Controls.Add(this.vid_zatratTextBox);
            this.Controls.Add(this.zatratBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form8";
            this.Text = "Добавление затрат ";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_KuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zatratBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zatratBindingNavigator)).EndInit();
            this.zatratBindingNavigator.ResumeLayout(false);
            this.zatratBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_KuDataSet1 dB_KuDataSet1;
        private System.Windows.Forms.BindingSource zatratBindingSource;
        private DB_KuDataSet1TableAdapters.ZatratTableAdapter zatratTableAdapter;
        private DB_KuDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator zatratBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton zatratBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox vid_zatratTextBox;
        private System.Windows.Forms.TextBox stoimTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private DB_KuDataSet1TableAdapters.FilialTableAdapter filialTableAdapter;
        private System.Windows.Forms.BindingSource filialBindingSource;
        private System.Windows.Forms.ComboBox id_FGComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
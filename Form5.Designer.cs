namespace kurcach
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label fLabel;
            System.Windows.Forms.Label iLabel;
            System.Windows.Forms.Label otLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label stashLabel;
            this.dB_KuDataSet = new kurcach.DB_KuDataSet();
            this.sotrudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudTableAdapter = new kurcach.DB_KuDataSetTableAdapters.SotrudTableAdapter();
            this.tableAdapterManager = new kurcach.DB_KuDataSetTableAdapters.TableAdapterManager();
            this.sotrudBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sotrudBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fTextBox = new System.Windows.Forms.TextBox();
            this.iTextBox = new System.Windows.Forms.TextBox();
            this.otTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.stashTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            fLabel = new System.Windows.Forms.Label();
            iLabel = new System.Windows.Forms.Label();
            otLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            stashLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudBindingNavigator)).BeginInit();
            this.sotrudBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dB_KuDataSet
            // 
            this.dB_KuDataSet.DataSetName = "DB_KuDataSet";
            this.dB_KuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudBindingSource
            // 
            this.sotrudBindingSource.DataMember = "Sotrud";
            this.sotrudBindingSource.DataSource = this.dB_KuDataSet;
            // 
            // sotrudTableAdapter
            // 
            this.sotrudTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilialTableAdapter = null;
            this.tableAdapterManager.otdelTableAdapter = null;
            this.tableAdapterManager.SotrudTableAdapter = this.sotrudTableAdapter;
            this.tableAdapterManager.UpdateOrder = kurcach.DB_KuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZatratTableAdapter = null;
            // 
            // sotrudBindingNavigator
            // 
            this.sotrudBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sotrudBindingNavigator.BindingSource = this.sotrudBindingSource;
            this.sotrudBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sotrudBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sotrudBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sotrudBindingNavigatorSaveItem});
            this.sotrudBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sotrudBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sotrudBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sotrudBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sotrudBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sotrudBindingNavigator.Name = "sotrudBindingNavigator";
            this.sotrudBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sotrudBindingNavigator.Size = new System.Drawing.Size(631, 25);
            this.sotrudBindingNavigator.TabIndex = 0;
            this.sotrudBindingNavigator.Text = "bindingNavigator1";
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
            // sotrudBindingNavigatorSaveItem
            // 
            this.sotrudBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sotrudBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sotrudBindingNavigatorSaveItem.Image")));
            this.sotrudBindingNavigatorSaveItem.Name = "sotrudBindingNavigatorSaveItem";
            this.sotrudBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sotrudBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.sotrudBindingNavigatorSaveItem.Click += new System.EventHandler(this.sotrudBindingNavigatorSaveItem_Click);
            // 
            // fLabel
            // 
            fLabel.AutoSize = true;
            fLabel.Location = new System.Drawing.Point(32, 67);
            fLabel.Name = "fLabel";
            fLabel.Size = new System.Drawing.Size(59, 13);
            fLabel.TabIndex = 1;
            fLabel.Text = "Фамилия:";
            // 
            // fTextBox
            // 
            this.fTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudBindingSource, "F", true));
            this.fTextBox.Location = new System.Drawing.Point(97, 63);
            this.fTextBox.Name = "fTextBox";
            this.fTextBox.Size = new System.Drawing.Size(158, 20);
            this.fTextBox.TabIndex = 2;
            // 
            // iLabel
            // 
            iLabel.AutoSize = true;
            iLabel.Location = new System.Drawing.Point(32, 94);
            iLabel.Name = "iLabel";
            iLabel.Size = new System.Drawing.Size(32, 13);
            iLabel.TabIndex = 3;
            iLabel.Text = "Имя:";
            // 
            // iTextBox
            // 
            this.iTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudBindingSource, "I", true));
            this.iTextBox.Location = new System.Drawing.Point(97, 90);
            this.iTextBox.Name = "iTextBox";
            this.iTextBox.Size = new System.Drawing.Size(158, 20);
            this.iTextBox.TabIndex = 4;
            // 
            // otLabel
            // 
            otLabel.AutoSize = true;
            otLabel.Location = new System.Drawing.Point(33, 117);
            otLabel.Name = "otLabel";
            otLabel.Size = new System.Drawing.Size(57, 13);
            otLabel.TabIndex = 5;
            otLabel.Text = "Отчество:";
            // 
            // otTextBox
            // 
            this.otTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudBindingSource, "Ot", true));
            this.otTextBox.Location = new System.Drawing.Point(97, 117);
            this.otTextBox.Name = "otTextBox";
            this.otTextBox.Size = new System.Drawing.Size(158, 20);
            this.otTextBox.TabIndex = 6;
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new System.Drawing.Point(329, 66);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(55, 13);
            telLabel.TabIndex = 7;
            telLabel.Text = "Телефон:";
            // 
            // telTextBox
            // 
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudBindingSource, "Tel", true));
            this.telTextBox.Location = new System.Drawing.Point(411, 64);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(163, 20);
            this.telTextBox.TabIndex = 8;
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(329, 90);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(41, 13);
            adressLabel.TabIndex = 9;
            adressLabel.Text = "Адрес:";
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudBindingSource, "Adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(411, 90);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(163, 20);
            this.adressTextBox.TabIndex = 10;
            // 
            // stashLabel
            // 
            stashLabel.AutoSize = true;
            stashLabel.Location = new System.Drawing.Point(329, 117);
            stashLabel.Name = "stashLabel";
            stashLabel.Size = new System.Drawing.Size(76, 13);
            stashLabel.TabIndex = 11;
            stashLabel.Text = "Стаж работы:";
            // 
            // stashTextBox
            // 
            this.stashTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sotrudBindingSource, "Stash", true));
            this.stashTextBox.Location = new System.Drawing.Point(411, 117);
            this.stashTextBox.Name = "stashTextBox";
            this.stashTextBox.Size = new System.Drawing.Size(163, 20);
            this.stashTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(256, 181);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 22);
            this.button1.TabIndex = 27;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(stashLabel);
            this.Controls.Add(this.stashTextBox);
            this.Controls.Add(adressLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(telLabel);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(otLabel);
            this.Controls.Add(this.otTextBox);
            this.Controls.Add(iLabel);
            this.Controls.Add(this.iTextBox);
            this.Controls.Add(fLabel);
            this.Controls.Add(this.fTextBox);
            this.Controls.Add(this.sotrudBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Личное дело сотрудника";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_KuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudBindingNavigator)).EndInit();
            this.sotrudBindingNavigator.ResumeLayout(false);
            this.sotrudBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_KuDataSet dB_KuDataSet;
        private System.Windows.Forms.BindingSource sotrudBindingSource;
        private DB_KuDataSetTableAdapters.SotrudTableAdapter sotrudTableAdapter;
        private DB_KuDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sotrudBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sotrudBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox fTextBox;
        private System.Windows.Forms.TextBox iTextBox;
        private System.Windows.Forms.TextBox otTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox stashTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
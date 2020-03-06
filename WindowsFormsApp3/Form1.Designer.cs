namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label date_sheduleLabel;
            System.Windows.Forms.Label train_idLabel;
            System.Windows.Forms.Label isTicketsLabel;
            System.Windows.Forms.Label price_ticketLabel;
            System.Windows.Forms.Label time_sendLabel;
            System.Windows.Forms.Label time_boardLabel;
            System.Windows.Forms.Label station_beginLabel;
            System.Windows.Forms.Label station_endLabel;
            System.Windows.Forms.Label quantityLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shedule_bdDataSet = new WindowsFormsApp3.shedule_bdDataSet();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationTableAdapter = new WindowsFormsApp3.shedule_bdDataSetTableAdapters.stationTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.shedule_bdDataSetTableAdapters.TableAdapterManager();
            this.stationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.stationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timetableTableAdapter = new WindowsFormsApp3.shedule_bdDataSetTableAdapters.timetableTableAdapter();
            this.date_sheduleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.train_idTextBox = new System.Windows.Forms.TextBox();
            this.isTicketsCheckBox = new System.Windows.Forms.CheckBox();
            this.price_ticketTextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainsTableAdapter = new WindowsFormsApp3.shedule_bdDataSetTableAdapters.trainsTableAdapter();
            this.time_sendDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.time_boardTextBox = new System.Windows.Forms.TextBox();
            this.station_beginTextBox = new System.Windows.Forms.TextBox();
            this.station_endTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            date_sheduleLabel = new System.Windows.Forms.Label();
            train_idLabel = new System.Windows.Forms.Label();
            isTicketsLabel = new System.Windows.Forms.Label();
            price_ticketLabel = new System.Windows.Forms.Label();
            time_sendLabel = new System.Windows.Forms.Label();
            time_boardLabel = new System.Windows.Forms.Label();
            station_beginLabel = new System.Windows.Forms.Label();
            station_endLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shedule_bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingNavigator)).BeginInit();
            this.stationBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(countryLabel);
            this.groupBox1.Controls.Add(this.countryTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Станция";
            // 
            // shedule_bdDataSet
            // 
            this.shedule_bdDataSet.DataSetName = "shedule_bdDataSet";
            this.shedule_bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataMember = "station";
            this.stationBindingSource.DataSource = this.shedule_bdDataSet;
            // 
            // stationTableAdapter
            // 
            this.stationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.stationTableAdapter = this.stationTableAdapter;
            this.tableAdapterManager.timetableTableAdapter = this.timetableTableAdapter;
            this.tableAdapterManager.trainsTableAdapter = this.trainsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.shedule_bdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stationBindingNavigator
            // 
            this.stationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stationBindingNavigator.BindingSource = this.stationBindingSource;
            this.stationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.stationBindingNavigatorSaveItem});
            this.stationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stationBindingNavigator.Name = "stationBindingNavigator";
            this.stationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stationBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.stationBindingNavigator.TabIndex = 1;
            this.stationBindingNavigator.Text = "bindingNavigator1";
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
            // stationBindingNavigatorSaveItem
            // 
            this.stationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stationBindingNavigatorSaveItem.Image")));
            this.stationBindingNavigatorSaveItem.Name = "stationBindingNavigatorSaveItem";
            this.stationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.stationBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.stationBindingNavigatorSaveItem.Click += new System.EventHandler(this.stationBindingNavigatorSaveItem_Click_1);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 22);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stationBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(58, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(7, 57);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(45, 13);
            countryLabel.TabIndex = 2;
            countryLabel.Text = "country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stationBindingSource, "country", true));
            this.countryTextBox.Location = new System.Drawing.Point(58, 54);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 21);
            this.button2.TabIndex = 5;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(88, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 22);
            this.button3.TabIndex = 6;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(177, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(177, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(price_ticketLabel);
            this.groupBox2.Controls.Add(this.price_ticketTextBox);
            this.groupBox2.Controls.Add(isTicketsLabel);
            this.groupBox2.Controls.Add(this.isTicketsCheckBox);
            this.groupBox2.Controls.Add(train_idLabel);
            this.groupBox2.Controls.Add(this.train_idTextBox);
            this.groupBox2.Controls.Add(date_sheduleLabel);
            this.groupBox2.Controls.Add(this.date_sheduleDateTimePicker);
            this.groupBox2.Location = new System.Drawing.Point(346, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 192);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // timetableBindingSource
            // 
            this.timetableBindingSource.DataMember = "timetable";
            this.timetableBindingSource.DataSource = this.shedule_bdDataSet;
            // 
            // timetableTableAdapter
            // 
            this.timetableTableAdapter.ClearBeforeFill = true;
            // 
            // date_sheduleLabel
            // 
            date_sheduleLabel.AutoSize = true;
            date_sheduleLabel.Location = new System.Drawing.Point(10, 23);
            date_sheduleLabel.Name = "date_sheduleLabel";
            date_sheduleLabel.Size = new System.Drawing.Size(71, 13);
            date_sheduleLabel.TabIndex = 0;
            date_sheduleLabel.Text = "date shedule:";
            // 
            // date_sheduleDateTimePicker
            // 
            this.date_sheduleDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.timetableBindingSource, "date_shedule", true));
            this.date_sheduleDateTimePicker.Location = new System.Drawing.Point(87, 19);
            this.date_sheduleDateTimePicker.Name = "date_sheduleDateTimePicker";
            this.date_sheduleDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_sheduleDateTimePicker.TabIndex = 1;
            // 
            // train_idLabel
            // 
            train_idLabel.AutoSize = true;
            train_idLabel.Location = new System.Drawing.Point(22, 64);
            train_idLabel.Name = "train_idLabel";
            train_idLabel.Size = new System.Drawing.Size(41, 13);
            train_idLabel.TabIndex = 2;
            train_idLabel.Text = "train id:";
            // 
            // train_idTextBox
            // 
            this.train_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.timetableBindingSource, "train_id", true));
            this.train_idTextBox.Location = new System.Drawing.Point(69, 61);
            this.train_idTextBox.Name = "train_idTextBox";
            this.train_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.train_idTextBox.TabIndex = 3;
            // 
            // isTicketsLabel
            // 
            isTicketsLabel.AutoSize = true;
            isTicketsLabel.Location = new System.Drawing.Point(22, 137);
            isTicketsLabel.Name = "isTicketsLabel";
            isTicketsLabel.Size = new System.Drawing.Size(55, 13);
            isTicketsLabel.TabIndex = 4;
            isTicketsLabel.Text = "is Tickets:";
            // 
            // isTicketsCheckBox
            // 
            this.isTicketsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.timetableBindingSource, "isTickets", true));
            this.isTicketsCheckBox.Location = new System.Drawing.Point(80, 132);
            this.isTicketsCheckBox.Name = "isTicketsCheckBox";
            this.isTicketsCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isTicketsCheckBox.TabIndex = 5;
            this.isTicketsCheckBox.Text = "checkBox1";
            this.isTicketsCheckBox.UseVisualStyleBackColor = true;
            // 
            // price_ticketLabel
            // 
            price_ticketLabel.AutoSize = true;
            price_ticketLabel.Location = new System.Drawing.Point(19, 104);
            price_ticketLabel.Name = "price_ticketLabel";
            price_ticketLabel.Size = new System.Drawing.Size(62, 13);
            price_ticketLabel.TabIndex = 6;
            price_ticketLabel.Text = "price ticket:";
            // 
            // price_ticketTextBox
            // 
            this.price_ticketTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.timetableBindingSource, "price_ticket", true));
            this.price_ticketTextBox.Location = new System.Drawing.Point(87, 101);
            this.price_ticketTextBox.Name = "price_ticketTextBox";
            this.price_ticketTextBox.Size = new System.Drawing.Size(100, 20);
            this.price_ticketTextBox.TabIndex = 7;
            this.price_ticketTextBox.TextChanged += new System.EventHandler(this.price_ticketTextBox_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(370, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 21);
            this.button6.TabIndex = 8;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 162);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 21);
            this.button7.TabIndex = 9;
            this.button7.Text = "<";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(167, 161);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 22);
            this.button8.TabIndex = 10;
            this.button8.Text = "Добавить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(328, 23);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "Сохранить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(328, 64);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(70, 23);
            this.button10.TabIndex = 12;
            this.button10.Text = "Удалить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button15);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(quantityLabel);
            this.groupBox3.Controls.Add(this.quantityTextBox);
            this.groupBox3.Controls.Add(station_endLabel);
            this.groupBox3.Controls.Add(this.station_endTextBox);
            this.groupBox3.Controls.Add(station_beginLabel);
            this.groupBox3.Controls.Add(this.station_beginTextBox);
            this.groupBox3.Controls.Add(time_boardLabel);
            this.groupBox3.Controls.Add(this.time_boardTextBox);
            this.groupBox3.Controls.Add(time_sendLabel);
            this.groupBox3.Controls.Add(this.time_sendDateTimePicker);
            this.groupBox3.Location = new System.Drawing.Point(12, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 261);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // trainsBindingSource
            // 
            this.trainsBindingSource.DataMember = "trains";
            this.trainsBindingSource.DataSource = this.shedule_bdDataSet;
            // 
            // trainsTableAdapter
            // 
            this.trainsTableAdapter.ClearBeforeFill = true;
            // 
            // time_sendLabel
            // 
            time_sendLabel.AutoSize = true;
            time_sendLabel.Location = new System.Drawing.Point(11, 40);
            time_sendLabel.Name = "time_sendLabel";
            time_sendLabel.Size = new System.Drawing.Size(55, 13);
            time_sendLabel.TabIndex = 0;
            time_sendLabel.Text = "time send:";
            // 
            // time_sendDateTimePicker
            // 
            this.time_sendDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.trainsBindingSource, "time_send", true));
            this.time_sendDateTimePicker.Location = new System.Drawing.Point(79, 34);
            this.time_sendDateTimePicker.Name = "time_sendDateTimePicker";
            this.time_sendDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.time_sendDateTimePicker.TabIndex = 1;
            // 
            // time_boardLabel
            // 
            time_boardLabel.AutoSize = true;
            time_boardLabel.Location = new System.Drawing.Point(11, 76);
            time_boardLabel.Name = "time_boardLabel";
            time_boardLabel.Size = new System.Drawing.Size(59, 13);
            time_boardLabel.TabIndex = 2;
            time_boardLabel.Text = "time board:";
            // 
            // time_boardTextBox
            // 
            this.time_boardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainsBindingSource, "time_board", true));
            this.time_boardTextBox.Location = new System.Drawing.Point(87, 73);
            this.time_boardTextBox.Name = "time_boardTextBox";
            this.time_boardTextBox.Size = new System.Drawing.Size(100, 20);
            this.time_boardTextBox.TabIndex = 3;
            // 
            // station_beginLabel
            // 
            station_beginLabel.AutoSize = true;
            station_beginLabel.Location = new System.Drawing.Point(11, 109);
            station_beginLabel.Name = "station_beginLabel";
            station_beginLabel.Size = new System.Drawing.Size(70, 13);
            station_beginLabel.TabIndex = 4;
            station_beginLabel.Text = "station begin:";
            // 
            // station_beginTextBox
            // 
            this.station_beginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainsBindingSource, "station_begin", true));
            this.station_beginTextBox.Location = new System.Drawing.Point(87, 106);
            this.station_beginTextBox.Name = "station_beginTextBox";
            this.station_beginTextBox.Size = new System.Drawing.Size(100, 20);
            this.station_beginTextBox.TabIndex = 5;
            // 
            // station_endLabel
            // 
            station_endLabel.AutoSize = true;
            station_endLabel.Location = new System.Drawing.Point(11, 138);
            station_endLabel.Name = "station_endLabel";
            station_endLabel.Size = new System.Drawing.Size(62, 13);
            station_endLabel.TabIndex = 6;
            station_endLabel.Text = "station end:";
            // 
            // station_endTextBox
            // 
            this.station_endTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainsBindingSource, "station_end", true));
            this.station_endTextBox.Location = new System.Drawing.Point(88, 135);
            this.station_endTextBox.Name = "station_endTextBox";
            this.station_endTextBox.Size = new System.Drawing.Size(100, 20);
            this.station_endTextBox.TabIndex = 7;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(11, 174);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(47, 13);
            quantityLabel.TabIndex = 8;
            quantityLabel.Text = "quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trainsBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(88, 171);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 9;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(327, 66);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(70, 23);
            this.button11.TabIndex = 12;
            this.button11.Text = "Сохранить";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(327, 103);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(70, 23);
            this.button12.TabIndex = 13;
            this.button12.Text = "Удалить";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(177, 233);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(70, 22);
            this.button13.TabIndex = 14;
            this.button13.Text = "Добавить";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(6, 234);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(28, 21);
            this.button14.TabIndex = 15;
            this.button14.Text = "<";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(387, 234);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(28, 21);
            this.button15.TabIndex = 16;
            this.button15.Text = ">";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.stationBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shedule_bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingNavigator)).EndInit();
            this.stationBindingNavigator.ResumeLayout(false);
            this.stationBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private shedule_bdDataSet shedule_bdDataSet;
        private System.Windows.Forms.BindingSource stationBindingSource;
        private shedule_bdDataSetTableAdapters.stationTableAdapter stationTableAdapter;
        private shedule_bdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton stationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private shedule_bdDataSetTableAdapters.timetableTableAdapter timetableTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource timetableBindingSource;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox price_ticketTextBox;
        private System.Windows.Forms.CheckBox isTicketsCheckBox;
        private System.Windows.Forms.TextBox train_idTextBox;
        private System.Windows.Forms.DateTimePicker date_sheduleDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox3;
        private shedule_bdDataSetTableAdapters.trainsTableAdapter trainsTableAdapter;
        private System.Windows.Forms.BindingSource trainsBindingSource;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox station_endTextBox;
        private System.Windows.Forms.TextBox station_beginTextBox;
        private System.Windows.Forms.TextBox time_boardTextBox;
        private System.Windows.Forms.DateTimePicker time_sendDateTimePicker;
    }
}


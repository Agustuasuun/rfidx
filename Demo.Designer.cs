namespace Demo
{
    partial class dlgDemo
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tabCtrlDemo = new System.Windows.Forms.TabControl();
            this.tp_setparam = new System.Windows.Forms.TabPage();
            this.readerContainer = new System.Windows.Forms.TableLayoutPanel();
            this.gb_setparam_led = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_sp_led_set = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.lb_sp_led_time = new System.Windows.Forms.Label();
            this.tb_sp_led_time = new System.Windows.Forms.TextBox();
            this.tb_sp_led_num = new System.Windows.Forms.TextBox();
            this.gb_setparam_buzzer = new System.Windows.Forms.GroupBox();
            this.setBuzzerContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tb_sp_buzzer_num = new System.Windows.Forms.TextBox();
            this.lb_sp_buzzer_num = new System.Windows.Forms.Label();
            this.tb_sp_buzzer_time = new System.Windows.Forms.TextBox();
            this.btn_sp_buzzer_set = new System.Windows.Forms.Button();
            this.lb_sp_buzzer_time = new System.Windows.Forms.Label();
            this.gb_setparam_setaddress = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cob_sp_address = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.btn_setparam_setaddress = new System.Windows.Forms.Button();
            this.btn14443_get = new System.Windows.Forms.TabPage();
            this.cardContainer = new System.Windows.Forms.TableLayoutPanel();
            this.gb14443A_getsn = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.copySnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cob14443A_mode_get = new System.Windows.Forms.ComboBox();
            this.lb14443A_mode_get = new System.Windows.Forms.Label();
            this.lb14443A_halt = new System.Windows.Forms.Label();
            this.cob14443A_halt = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.serialNumberLabel = new System.Windows.Forms.Label();
            this.connectionContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btn_setparam_clear = new System.Windows.Forms.Button();
            this.connectionActionContainer = new System.Windows.Forms.TableLayoutPanel();
            this.addressComboBox = new System.Windows.Forms.ComboBox();
            this.btn_setparam_read = new System.Windows.Forms.Button();
            this.gb_setparam_pm = new System.Windows.Forms.GroupBox();
            this.tb_sp_message = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContainer.SuspendLayout();
            this.tabCtrlDemo.SuspendLayout();
            this.tp_setparam.SuspendLayout();
            this.readerContainer.SuspendLayout();
            this.gb_setparam_led.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gb_setparam_buzzer.SuspendLayout();
            this.setBuzzerContainer.SuspendLayout();
            this.gb_setparam_setaddress.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.btn14443_get.SuspendLayout();
            this.cardContainer.SuspendLayout();
            this.gb14443A_getsn.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.connectionContainer.SuspendLayout();
            this.connectionActionContainer.SuspendLayout();
            this.gb_setparam_pm.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.ColumnCount = 1;
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainContainer.Controls.Add(this.tabCtrlDemo, 0, 1);
            this.mainContainer.Controls.Add(this.connectionContainer, 0, 1);
            this.mainContainer.Controls.Add(this.menuStrip1, 0, 0);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.RowCount = 3;
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainContainer.Size = new System.Drawing.Size(692, 313);
            this.mainContainer.TabIndex = 0;
            // 
            // tabCtrlDemo
            // 
            this.tabCtrlDemo.Controls.Add(this.tp_setparam);
            this.tabCtrlDemo.Controls.Add(this.btn14443_get);
            this.tabCtrlDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlDemo.Location = new System.Drawing.Point(3, 27);
            this.tabCtrlDemo.Name = "tabCtrlDemo";
            this.tabCtrlDemo.SelectedIndex = 0;
            this.tabCtrlDemo.Size = new System.Drawing.Size(686, 128);
            this.tabCtrlDemo.TabIndex = 1;
            // 
            // tp_setparam
            // 
            this.tp_setparam.Controls.Add(this.readerContainer);
            this.tp_setparam.Location = new System.Drawing.Point(4, 22);
            this.tp_setparam.Name = "tp_setparam";
            this.tp_setparam.Padding = new System.Windows.Forms.Padding(3);
            this.tp_setparam.Size = new System.Drawing.Size(678, 102);
            this.tp_setparam.TabIndex = 3;
            this.tp_setparam.Text = "Reader";
            this.tp_setparam.UseVisualStyleBackColor = true;
            // 
            // readerContainer
            // 
            this.readerContainer.ColumnCount = 3;
            this.readerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.readerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.readerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.readerContainer.Controls.Add(this.gb_setparam_led, 0, 0);
            this.readerContainer.Controls.Add(this.gb_setparam_buzzer, 1, 0);
            this.readerContainer.Controls.Add(this.gb_setparam_setaddress, 2, 0);
            this.readerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readerContainer.Location = new System.Drawing.Point(3, 3);
            this.readerContainer.Name = "readerContainer";
            this.readerContainer.RowCount = 1;
            this.readerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.readerContainer.Size = new System.Drawing.Size(672, 96);
            this.readerContainer.TabIndex = 0;
            // 
            // gb_setparam_led
            // 
            this.gb_setparam_led.Controls.Add(this.tableLayoutPanel2);
            this.gb_setparam_led.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_setparam_led.Location = new System.Drawing.Point(3, 3);
            this.gb_setparam_led.Name = "gb_setparam_led";
            this.gb_setparam_led.Size = new System.Drawing.Size(218, 90);
            this.gb_setparam_led.TabIndex = 8;
            this.gb_setparam_led.TabStop = false;
            this.gb_setparam_led.Text = "Set LED";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btn_sp_led_set, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label35, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_sp_led_time, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_sp_led_time, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_sp_led_num, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // btn_sp_led_set
            // 
            this.btn_sp_led_set.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_sp_led_set.Location = new System.Drawing.Point(132, 5);
            this.btn_sp_led_set.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btn_sp_led_set.Name = "btn_sp_led_set";
            this.btn_sp_led_set.Size = new System.Drawing.Size(75, 25);
            this.btn_sp_led_set.TabIndex = 5;
            this.btn_sp_led_set.Text = "Set";
            this.btn_sp_led_set.UseVisualStyleBackColor = true;
            this.btn_sp_led_set.Click += new System.EventHandler(this.btn_sp_led_set_Click);
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label35.Location = new System.Drawing.Point(5, 46);
            this.label35.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(47, 13);
            this.label35.TabIndex = 1;
            this.label35.Text = "Number:";
            // 
            // lb_sp_led_time
            // 
            this.lb_sp_led_time.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_sp_led_time.Location = new System.Drawing.Point(5, 11);
            this.lb_sp_led_time.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_sp_led_time.Name = "lb_sp_led_time";
            this.lb_sp_led_time.Size = new System.Drawing.Size(47, 13);
            this.lb_sp_led_time.TabIndex = 0;
            this.lb_sp_led_time.Text = "Time:";
            // 
            // tb_sp_led_time
            // 
            this.tb_sp_led_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_sp_led_time.Location = new System.Drawing.Point(67, 7);
            this.tb_sp_led_time.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.tb_sp_led_time.Name = "tb_sp_led_time";
            this.tb_sp_led_time.Size = new System.Drawing.Size(50, 20);
            this.tb_sp_led_time.TabIndex = 2;
            // 
            // tb_sp_led_num
            // 
            this.tb_sp_led_num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_sp_led_num.Location = new System.Drawing.Point(67, 43);
            this.tb_sp_led_num.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.tb_sp_led_num.Name = "tb_sp_led_num";
            this.tb_sp_led_num.Size = new System.Drawing.Size(50, 20);
            this.tb_sp_led_num.TabIndex = 3;
            // 
            // gb_setparam_buzzer
            // 
            this.gb_setparam_buzzer.Controls.Add(this.setBuzzerContainer);
            this.gb_setparam_buzzer.Location = new System.Drawing.Point(227, 3);
            this.gb_setparam_buzzer.Name = "gb_setparam_buzzer";
            this.gb_setparam_buzzer.Size = new System.Drawing.Size(218, 90);
            this.gb_setparam_buzzer.TabIndex = 7;
            this.gb_setparam_buzzer.TabStop = false;
            this.gb_setparam_buzzer.Text = "Set Buzzer";
            // 
            // setBuzzerContainer
            // 
            this.setBuzzerContainer.ColumnCount = 3;
            this.setBuzzerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.setBuzzerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.setBuzzerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.setBuzzerContainer.Controls.Add(this.tb_sp_buzzer_num, 1, 1);
            this.setBuzzerContainer.Controls.Add(this.lb_sp_buzzer_num, 0, 1);
            this.setBuzzerContainer.Controls.Add(this.tb_sp_buzzer_time, 1, 0);
            this.setBuzzerContainer.Controls.Add(this.btn_sp_buzzer_set, 2, 0);
            this.setBuzzerContainer.Controls.Add(this.lb_sp_buzzer_time, 0, 0);
            this.setBuzzerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setBuzzerContainer.Location = new System.Drawing.Point(3, 16);
            this.setBuzzerContainer.Name = "setBuzzerContainer";
            this.setBuzzerContainer.RowCount = 2;
            this.setBuzzerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.setBuzzerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.setBuzzerContainer.Size = new System.Drawing.Size(212, 71);
            this.setBuzzerContainer.TabIndex = 0;
            // 
            // tb_sp_buzzer_num
            // 
            this.tb_sp_buzzer_num.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_sp_buzzer_num.Location = new System.Drawing.Point(67, 43);
            this.tb_sp_buzzer_num.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.tb_sp_buzzer_num.Name = "tb_sp_buzzer_num";
            this.tb_sp_buzzer_num.Size = new System.Drawing.Size(50, 20);
            this.tb_sp_buzzer_num.TabIndex = 3;
            // 
            // lb_sp_buzzer_num
            // 
            this.lb_sp_buzzer_num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_sp_buzzer_num.Location = new System.Drawing.Point(5, 46);
            this.lb_sp_buzzer_num.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_sp_buzzer_num.Name = "lb_sp_buzzer_num";
            this.lb_sp_buzzer_num.Size = new System.Drawing.Size(47, 13);
            this.lb_sp_buzzer_num.TabIndex = 1;
            this.lb_sp_buzzer_num.Text = "Number:";
            // 
            // tb_sp_buzzer_time
            // 
            this.tb_sp_buzzer_time.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_sp_buzzer_time.Location = new System.Drawing.Point(67, 7);
            this.tb_sp_buzzer_time.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.tb_sp_buzzer_time.Name = "tb_sp_buzzer_time";
            this.tb_sp_buzzer_time.Size = new System.Drawing.Size(50, 20);
            this.tb_sp_buzzer_time.TabIndex = 2;
            // 
            // btn_sp_buzzer_set
            // 
            this.btn_sp_buzzer_set.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_sp_buzzer_set.Location = new System.Drawing.Point(132, 5);
            this.btn_sp_buzzer_set.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btn_sp_buzzer_set.Name = "btn_sp_buzzer_set";
            this.btn_sp_buzzer_set.Size = new System.Drawing.Size(75, 25);
            this.btn_sp_buzzer_set.TabIndex = 5;
            this.btn_sp_buzzer_set.Text = "Set";
            this.btn_sp_buzzer_set.UseVisualStyleBackColor = true;
            this.btn_sp_buzzer_set.Click += new System.EventHandler(this.btn_sp_buzzer_set_Click);
            // 
            // lb_sp_buzzer_time
            // 
            this.lb_sp_buzzer_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_sp_buzzer_time.Location = new System.Drawing.Point(5, 11);
            this.lb_sp_buzzer_time.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_sp_buzzer_time.Name = "lb_sp_buzzer_time";
            this.lb_sp_buzzer_time.Size = new System.Drawing.Size(47, 13);
            this.lb_sp_buzzer_time.TabIndex = 0;
            this.lb_sp_buzzer_time.Text = "Time:";
            // 
            // gb_setparam_setaddress
            // 
            this.gb_setparam_setaddress.Controls.Add(this.tableLayoutPanel3);
            this.gb_setparam_setaddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_setparam_setaddress.Location = new System.Drawing.Point(451, 3);
            this.gb_setparam_setaddress.Name = "gb_setparam_setaddress";
            this.gb_setparam_setaddress.Size = new System.Drawing.Size(218, 90);
            this.gb_setparam_setaddress.TabIndex = 4;
            this.gb_setparam_setaddress.TabStop = false;
            this.gb_setparam_setaddress.Text = "Set Address";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.cob_sp_address, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label34, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_setparam_setaddress, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(212, 41);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // cob_sp_address
            // 
            this.cob_sp_address.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cob_sp_address.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_sp_address.FormattingEnabled = true;
            this.cob_sp_address.Location = new System.Drawing.Point(65, 10);
            this.cob_sp_address.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.cob_sp_address.Name = "cob_sp_address";
            this.cob_sp_address.Size = new System.Drawing.Size(50, 21);
            this.cob_sp_address.TabIndex = 4;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.Location = new System.Drawing.Point(3, 14);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(49, 13);
            this.label34.TabIndex = 3;
            this.label34.Text = "Address:";
            // 
            // btn_setparam_setaddress
            // 
            this.btn_setparam_setaddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_setparam_setaddress.Location = new System.Drawing.Point(132, 8);
            this.btn_setparam_setaddress.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btn_setparam_setaddress.Name = "btn_setparam_setaddress";
            this.btn_setparam_setaddress.Size = new System.Drawing.Size(75, 25);
            this.btn_setparam_setaddress.TabIndex = 5;
            this.btn_setparam_setaddress.Text = "Set";
            this.btn_setparam_setaddress.UseVisualStyleBackColor = true;
            this.btn_setparam_setaddress.Click += new System.EventHandler(this.btn_setparam_setaddress_Click);
            // 
            // btn14443_get
            // 
            this.btn14443_get.Controls.Add(this.cardContainer);
            this.btn14443_get.Location = new System.Drawing.Point(4, 22);
            this.btn14443_get.Name = "btn14443_get";
            this.btn14443_get.Padding = new System.Windows.Forms.Padding(3);
            this.btn14443_get.Size = new System.Drawing.Size(678, 102);
            this.btn14443_get.TabIndex = 2;
            this.btn14443_get.Text = "ISO 14443 A Card";
            this.btn14443_get.UseVisualStyleBackColor = true;
            // 
            // cardContainer
            // 
            this.cardContainer.ColumnCount = 1;
            this.cardContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardContainer.Controls.Add(this.gb14443A_getsn, 0, 1);
            this.cardContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardContainer.Location = new System.Drawing.Point(3, 3);
            this.cardContainer.Name = "cardContainer";
            this.cardContainer.RowCount = 2;
            this.cardContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.cardContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.cardContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.cardContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.cardContainer.Size = new System.Drawing.Size(672, 96);
            this.cardContainer.TabIndex = 9;
            // 
            // gb14443A_getsn
            // 
            this.gb14443A_getsn.Controls.Add(this.tableLayoutPanel1);
            this.gb14443A_getsn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb14443A_getsn.Location = new System.Drawing.Point(3, 3);
            this.gb14443A_getsn.Name = "gb14443A_getsn";
            this.gb14443A_getsn.Size = new System.Drawing.Size(666, 90);
            this.gb14443A_getsn.TabIndex = 10;
            this.gb14443A_getsn.TabStop = false;
            this.gb14443A_getsn.Text = "Get Serial Number";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.copySnButton, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cob14443A_mode_get, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb14443A_mode_get, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb14443A_halt, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cob14443A_halt, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.serialNumberLabel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 74);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // copySnButton
            // 
            this.copySnButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.copySnButton.Enabled = false;
            this.copySnButton.Location = new System.Drawing.Point(259, 43);
            this.copySnButton.Margin = new System.Windows.Forms.Padding(5);
            this.copySnButton.Name = "copySnButton";
            this.copySnButton.Size = new System.Drawing.Size(102, 25);
            this.copySnButton.TabIndex = 8;
            this.copySnButton.Text = "Copy to clipboard";
            this.copySnButton.UseVisualStyleBackColor = true;
            this.copySnButton.Click += new System.EventHandler(this.copySnButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SN:";
            // 
            // cob14443A_mode_get
            // 
            this.cob14443A_mode_get.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cob14443A_mode_get.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob14443A_mode_get.FormattingEnabled = true;
            this.cob14443A_mode_get.Location = new System.Drawing.Point(53, 8);
            this.cob14443A_mode_get.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.cob14443A_mode_get.Name = "cob14443A_mode_get";
            this.cob14443A_mode_get.Size = new System.Drawing.Size(79, 21);
            this.cob14443A_mode_get.TabIndex = 1;
            // 
            // lb14443A_mode_get
            // 
            this.lb14443A_mode_get.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb14443A_mode_get.AutoSize = true;
            this.lb14443A_mode_get.Location = new System.Drawing.Point(3, 12);
            this.lb14443A_mode_get.Name = "lb14443A_mode_get";
            this.lb14443A_mode_get.Size = new System.Drawing.Size(37, 13);
            this.lb14443A_mode_get.TabIndex = 0;
            this.lb14443A_mode_get.Text = "Mode:";
            // 
            // lb14443A_halt
            // 
            this.lb14443A_halt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb14443A_halt.AutoSize = true;
            this.lb14443A_halt.Location = new System.Drawing.Point(140, 12);
            this.lb14443A_halt.Name = "lb14443A_halt";
            this.lb14443A_halt.Size = new System.Drawing.Size(29, 13);
            this.lb14443A_halt.TabIndex = 3;
            this.lb14443A_halt.Text = "Halt:";
            // 
            // cob14443A_halt
            // 
            this.cob14443A_halt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cob14443A_halt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob14443A_halt.FormattingEnabled = true;
            this.cob14443A_halt.Location = new System.Drawing.Point(182, 8);
            this.cob14443A_halt.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.cob14443A_halt.Name = "cob14443A_halt";
            this.cob14443A_halt.Size = new System.Drawing.Size(67, 21);
            this.cob14443A_halt.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(259, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "GET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialNumberLabel
            // 
            this.serialNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.serialNumberLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.serialNumberLabel, 3);
            this.serialNumberLabel.Location = new System.Drawing.Point(53, 49);
            this.serialNumberLabel.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.serialNumberLabel.Name = "serialNumberLabel";
            this.serialNumberLabel.Size = new System.Drawing.Size(196, 13);
            this.serialNumberLabel.TabIndex = 7;
            this.serialNumberLabel.TextChanged += new System.EventHandler(this.serialNumberLabel_TextChanged);
            // 
            // connectionContainer
            // 
            this.connectionContainer.ColumnCount = 3;
            this.connectionContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.connectionContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.connectionContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.connectionContainer.Controls.Add(this.btn_setparam_clear, 2, 0);
            this.connectionContainer.Controls.Add(this.connectionActionContainer, 0, 0);
            this.connectionContainer.Controls.Add(this.gb_setparam_pm, 1, 0);
            this.connectionContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionContainer.Location = new System.Drawing.Point(3, 161);
            this.connectionContainer.Name = "connectionContainer";
            this.connectionContainer.RowCount = 1;
            this.connectionContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.connectionContainer.Size = new System.Drawing.Size(686, 149);
            this.connectionContainer.TabIndex = 9;
            // 
            // btn_setparam_clear
            // 
            this.btn_setparam_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_setparam_clear.Location = new System.Drawing.Point(607, 121);
            this.btn_setparam_clear.Name = "btn_setparam_clear";
            this.btn_setparam_clear.Size = new System.Drawing.Size(75, 25);
            this.btn_setparam_clear.TabIndex = 5;
            this.btn_setparam_clear.Text = "Clear";
            this.btn_setparam_clear.UseVisualStyleBackColor = true;
            this.btn_setparam_clear.Click += new System.EventHandler(this.btn_setparam_clear_Click);
            // 
            // connectionActionContainer
            // 
            this.connectionActionContainer.ColumnCount = 2;
            this.connectionActionContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectionActionContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectionActionContainer.Controls.Add(this.addressComboBox, 0, 0);
            this.connectionActionContainer.Controls.Add(this.btn_setparam_read, 1, 0);
            this.connectionActionContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectionActionContainer.Location = new System.Drawing.Point(3, 3);
            this.connectionActionContainer.Name = "connectionActionContainer";
            this.connectionActionContainer.RowCount = 3;
            this.connectionActionContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.connectionActionContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.connectionActionContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.connectionActionContainer.Size = new System.Drawing.Size(175, 100);
            this.connectionActionContainer.TabIndex = 0;
            // 
            // addressComboBox
            // 
            this.addressComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addressComboBox.FormattingEnabled = true;
            this.addressComboBox.Location = new System.Drawing.Point(3, 6);
            this.addressComboBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.addressComboBox.Name = "addressComboBox";
            this.addressComboBox.Size = new System.Drawing.Size(81, 21);
            this.addressComboBox.TabIndex = 4;
            // 
            // btn_setparam_read
            // 
            this.btn_setparam_read.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_setparam_read.Location = new System.Drawing.Point(90, 3);
            this.btn_setparam_read.Name = "btn_setparam_read";
            this.btn_setparam_read.Size = new System.Drawing.Size(82, 27);
            this.btn_setparam_read.TabIndex = 2;
            this.btn_setparam_read.Text = "Read";
            this.btn_setparam_read.UseVisualStyleBackColor = true;
            this.btn_setparam_read.Click += new System.EventHandler(this.btn_setparam_read_Click);
            // 
            // gb_setparam_pm
            // 
            this.gb_setparam_pm.Controls.Add(this.tb_sp_message);
            this.gb_setparam_pm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_setparam_pm.Location = new System.Drawing.Point(184, 3);
            this.gb_setparam_pm.Name = "gb_setparam_pm";
            this.gb_setparam_pm.Size = new System.Drawing.Size(417, 143);
            this.gb_setparam_pm.TabIndex = 4;
            this.gb_setparam_pm.TabStop = false;
            this.gb_setparam_pm.Text = "Output";
            // 
            // tb_sp_message
            // 
            this.tb_sp_message.BackColor = System.Drawing.SystemColors.Control;
            this.tb_sp_message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_sp_message.Location = new System.Drawing.Point(3, 16);
            this.tb_sp_message.Margin = new System.Windows.Forms.Padding(5);
            this.tb_sp_message.Multiline = true;
            this.tb_sp_message.Name = "tb_sp_message";
            this.tb_sp_message.ReadOnly = true;
            this.tb_sp_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_sp_message.Size = new System.Drawing.Size(411, 124);
            this.tb_sp_message.TabIndex = 0;
            this.tb_sp_message.TextChanged += new System.EventHandler(this.tb_sp_message_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(180, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // dlgDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 313);
            this.Controls.Add(this.mainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "dlgDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NFC Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.dlgDemo_FormClosed);
            this.Load += new System.EventHandler(this.dlgDemo_Load);
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.tabCtrlDemo.ResumeLayout(false);
            this.tp_setparam.ResumeLayout(false);
            this.readerContainer.ResumeLayout(false);
            this.gb_setparam_led.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gb_setparam_buzzer.ResumeLayout(false);
            this.setBuzzerContainer.ResumeLayout(false);
            this.setBuzzerContainer.PerformLayout();
            this.gb_setparam_setaddress.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.btn14443_get.ResumeLayout(false);
            this.cardContainer.ResumeLayout(false);
            this.gb14443A_getsn.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.connectionContainer.ResumeLayout(false);
            this.connectionActionContainer.ResumeLayout(false);
            this.gb_setparam_pm.ResumeLayout(false);
            this.gb_setparam_pm.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainContainer;
        private System.Windows.Forms.TabControl tabCtrlDemo;
        private System.Windows.Forms.TabPage tp_setparam;
        private System.Windows.Forms.TableLayoutPanel readerContainer;
        private System.Windows.Forms.GroupBox gb_setparam_led;
        private System.Windows.Forms.Label lb_sp_led_time;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tb_sp_led_num;
        private System.Windows.Forms.TextBox tb_sp_led_time;
        private System.Windows.Forms.Button btn_sp_led_set;
        private System.Windows.Forms.GroupBox gb_setparam_buzzer;
        private System.Windows.Forms.TableLayoutPanel setBuzzerContainer;
        private System.Windows.Forms.Button btn_sp_buzzer_set;
        private System.Windows.Forms.TextBox tb_sp_buzzer_num;
        private System.Windows.Forms.Label lb_sp_buzzer_num;
        private System.Windows.Forms.Label lb_sp_buzzer_time;
        private System.Windows.Forms.TextBox tb_sp_buzzer_time;
        private System.Windows.Forms.GroupBox gb_setparam_setaddress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cob_sp_address;
        private System.Windows.Forms.Button btn_setparam_setaddress;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TableLayoutPanel connectionContainer;
        private System.Windows.Forms.Button btn_setparam_clear;
        private System.Windows.Forms.TableLayoutPanel connectionActionContainer;
        private System.Windows.Forms.ComboBox addressComboBox;
        private System.Windows.Forms.Button btn_setparam_read;
        private System.Windows.Forms.GroupBox gb_setparam_pm;
        private System.Windows.Forms.TextBox tb_sp_message;
        private System.Windows.Forms.TabPage btn14443_get;
        private System.Windows.Forms.TableLayoutPanel cardContainer;
        private System.Windows.Forms.GroupBox gb14443A_getsn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cob14443A_mode_get;
        private System.Windows.Forms.Label lb14443A_mode_get;
        private System.Windows.Forms.Label lb14443A_halt;
        private System.Windows.Forms.ComboBox cob14443A_halt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button copySnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label serialNumberLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}


namespace Peer_Reviewer
{
    partial class frm_Employees
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TabPage7 = new System.Windows.Forms.TabPage();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.Label46 = new System.Windows.Forms.Label();
            this.txtempsearch = new System.Windows.Forms.TextBox();
            this.dtgemplist = new System.Windows.Forms.DataGridView();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.btnempupdate = new System.Windows.Forms.Button();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.GroupBox10 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.txtdrate = new System.Windows.Forms.TextBox();
            this.dtpdhired = new System.Windows.Forms.DateTimePicker();
            this.txtpmethod = new System.Windows.Forms.ComboBox();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.txtbplace = new System.Windows.Forms.RichTextBox();
            this.txtaddress = new System.Windows.Forms.RichTextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.dtpdbirth = new System.Windows.Forms.DateTimePicker();
            this.Label22 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.txtemerg = new System.Windows.Forms.TextBox();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.ComboBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.btnempnew = new System.Windows.Forms.Button();
            this.btnempsave = new System.Windows.Forms.Button();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.TabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).BeginInit();
            this.TabPage6.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(839, 436);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "SCORE";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(40, 16);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "MODULE";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(731, 331);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "GRADES";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // TabPage7
            // 
            this.TabPage7.Controls.Add(this.btn_edit);
            this.TabPage7.Controls.Add(this.btndelete);
            this.TabPage7.Controls.Add(this.Label46);
            this.TabPage7.Controls.Add(this.txtempsearch);
            this.TabPage7.Controls.Add(this.dtgemplist);
            this.TabPage7.Location = new System.Drawing.Point(4, 22);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage7.Size = new System.Drawing.Size(839, 436);
            this.TabPage7.TabIndex = 1;
            this.TabPage7.Text = "FEEDBACK";
            this.TabPage7.UseVisualStyleBackColor = true;
            this.TabPage7.Click += new System.EventHandler(this.TabPage7_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(572, 369);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(129, 23);
            this.btn_edit.TabIndex = 23;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(707, 369);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(129, 23);
            this.btndelete.TabIndex = 22;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Label46
            // 
            this.Label46.AutoSize = true;
            this.Label46.Location = new System.Drawing.Point(625, 58);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(47, 13);
            this.Label46.TabIndex = 3;
            this.Label46.Text = "Search :";
            this.Label46.Click += new System.EventHandler(this.Label46_Click);
            // 
            // txtempsearch
            // 
            this.txtempsearch.Location = new System.Drawing.Point(673, 54);
            this.txtempsearch.Name = "txtempsearch";
            this.txtempsearch.Size = new System.Drawing.Size(163, 20);
            this.txtempsearch.TabIndex = 2;
            this.txtempsearch.TextChanged += new System.EventHandler(this.txtempsearch_TextChanged);
            // 
            // dtgemplist
            // 
            this.dtgemplist.AllowUserToAddRows = false;
            this.dtgemplist.AllowUserToDeleteRows = false;
            this.dtgemplist.AllowUserToResizeColumns = false;
            this.dtgemplist.AllowUserToResizeRows = false;
            this.dtgemplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgemplist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgemplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgemplist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgemplist.Location = new System.Drawing.Point(3, 80);
            this.dtgemplist.Name = "dtgemplist";
            this.dtgemplist.RowHeadersVisible = false;
            this.dtgemplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgemplist.ShowCellToolTips = false;
            this.dtgemplist.Size = new System.Drawing.Size(836, 283);
            this.dtgemplist.TabIndex = 0;
            this.dtgemplist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgemplist_CellContentClick);
            // 
            // TabPage6
            // 
            this.TabPage6.Controls.Add(this.btnempupdate);
            this.TabPage6.Controls.Add(this.txtcode);
            this.TabPage6.Controls.Add(this.Label20);
            this.TabPage6.Controls.Add(this.GroupBox10);
            this.TabPage6.Controls.Add(this.GroupBox9);
            this.TabPage6.Controls.Add(this.btnempnew);
            this.TabPage6.Controls.Add(this.btnempsave);
            this.TabPage6.Location = new System.Drawing.Point(4, 22);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage6.Size = new System.Drawing.Size(839, 436);
            this.TabPage6.TabIndex = 0;
            this.TabPage6.Text = "WORK";
            this.TabPage6.UseVisualStyleBackColor = true;
            this.TabPage6.Click += new System.EventHandler(this.TabPage6_Click);
            // 
            // btnempupdate
            // 
            this.btnempupdate.Location = new System.Drawing.Point(406, 370);
            this.btnempupdate.Name = "btnempupdate";
            this.btnempupdate.Size = new System.Drawing.Size(75, 32);
            this.btnempupdate.TabIndex = 21;
            this.btnempupdate.Text = "Update";
            this.btnempupdate.UseVisualStyleBackColor = true;
            this.btnempupdate.Click += new System.EventHandler(this.btnempupdate_Click);
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(116, 21);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(200, 20);
            this.txtcode.TabIndex = 15;
            this.txtcode.TextChanged += new System.EventHandler(this.txtcode_TextChanged);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(37, 24);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(71, 13);
            this.Label20.TabIndex = 16;
            this.Label20.Text = "Assign code :";
            this.Label20.Click += new System.EventHandler(this.Label20_Click);
            // 
            // GroupBox10
            // 
            this.GroupBox10.Controls.Add(this.richTextBox1);
            this.GroupBox10.Controls.Add(this.Label37);
            this.GroupBox10.Controls.Add(this.Label36);
            this.GroupBox10.Controls.Add(this.Label34);
            this.GroupBox10.Controls.Add(this.Label33);
            this.GroupBox10.Controls.Add(this.txtdrate);
            this.GroupBox10.Controls.Add(this.dtpdhired);
            this.GroupBox10.Controls.Add(this.txtpmethod);
            this.GroupBox10.Location = new System.Drawing.Point(31, 242);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new System.Drawing.Size(785, 111);
            this.GroupBox10.TabIndex = 19;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "Review Information";
            this.GroupBox10.Enter += new System.EventHandler(this.GroupBox10_Enter);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(353, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(166, 86);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Location = new System.Drawing.Point(22, 22);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(55, 13);
            this.Label37.TabIndex = 7;
            this.Label37.Text = "work title :";
            this.Label37.Click += new System.EventHandler(this.Label37_Click);
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Location = new System.Drawing.Point(289, 26);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(57, 13);
            this.Label36.TabIndex = 6;
            this.Label36.Text = "Comment :";
            this.Label36.Click += new System.EventHandler(this.Label36_Click);
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Location = new System.Drawing.Point(14, 50);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(55, 13);
            this.Label34.TabIndex = 4;
            this.Label34.Text = "Speciality:";
            this.Label34.Click += new System.EventHandler(this.Label34_Click);
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.Location = new System.Drawing.Point(531, 21);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(39, 13);
            this.Label33.TabIndex = 3;
            this.Label33.Text = "Date  :";
            this.Label33.Click += new System.EventHandler(this.Label33_Click);
            // 
            // txtdrate
            // 
            this.txtdrate.Location = new System.Drawing.Point(90, 19);
            this.txtdrate.MaxLength = 3;
            this.txtdrate.Name = "txtdrate";
            this.txtdrate.Size = new System.Drawing.Size(154, 20);
            this.txtdrate.TabIndex = 2;
            this.txtdrate.TextChanged += new System.EventHandler(this.txtdrate_TextChanged);
            // 
            // dtpdhired
            // 
            this.dtpdhired.CustomFormat = "yyyy-MM-dd";
            this.dtpdhired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdhired.Location = new System.Drawing.Point(601, 19);
            this.dtpdhired.Name = "dtpdhired";
            this.dtpdhired.Size = new System.Drawing.Size(154, 20);
            this.dtpdhired.TabIndex = 1;
            this.dtpdhired.ValueChanged += new System.EventHandler(this.dtpdhired_ValueChanged);
            // 
            // txtpmethod
            // 
            this.txtpmethod.FormattingEnabled = true;
            this.txtpmethod.Items.AddRange(new object[] {
            "Food Security",
            "Child Security"});
            this.txtpmethod.Location = new System.Drawing.Point(90, 50);
            this.txtpmethod.Name = "txtpmethod";
            this.txtpmethod.Size = new System.Drawing.Size(154, 21);
            this.txtpmethod.TabIndex = 0;
            this.txtpmethod.Text = "Science";
            this.txtpmethod.SelectedIndexChanged += new System.EventHandler(this.txtpmethod_SelectedIndexChanged);
            // 
            // GroupBox9
            // 
            this.GroupBox9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox9.Controls.Add(this.txtbplace);
            this.GroupBox9.Controls.Add(this.txtaddress);
            this.GroupBox9.Controls.Add(this.Label21);
            this.GroupBox9.Controls.Add(this.dtpdbirth);
            this.GroupBox9.Controls.Add(this.Label22);
            this.GroupBox9.Controls.Add(this.txtlname);
            this.GroupBox9.Controls.Add(this.Label23);
            this.GroupBox9.Controls.Add(this.txtcontact);
            this.GroupBox9.Controls.Add(this.txtage);
            this.GroupBox9.Controls.Add(this.txtfname);
            this.GroupBox9.Controls.Add(this.Label24);
            this.GroupBox9.Controls.Add(this.txtmname);
            this.GroupBox9.Controls.Add(this.rdofemale);
            this.GroupBox9.Controls.Add(this.txtemerg);
            this.GroupBox9.Controls.Add(this.rdomale);
            this.GroupBox9.Controls.Add(this.Label25);
            this.GroupBox9.Controls.Add(this.Label26);
            this.GroupBox9.Controls.Add(this.Label27);
            this.GroupBox9.Controls.Add(this.txtstatus);
            this.GroupBox9.Controls.Add(this.Label28);
            this.GroupBox9.Controls.Add(this.Label29);
            this.GroupBox9.Controls.Add(this.Label30);
            this.GroupBox9.Controls.Add(this.Label31);
            this.GroupBox9.Location = new System.Drawing.Point(31, 47);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new System.Drawing.Size(791, 189);
            this.GroupBox9.TabIndex = 18;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "Reviewer Information";
            this.GroupBox9.Enter += new System.EventHandler(this.GroupBox9_Enter);
            // 
            // txtbplace
            // 
            this.txtbplace.Location = new System.Drawing.Point(85, 127);
            this.txtbplace.Name = "txtbplace";
            this.txtbplace.Size = new System.Drawing.Size(166, 24);
            this.txtbplace.TabIndex = 17;
            this.txtbplace.Text = "";
            this.txtbplace.TextChanged += new System.EventHandler(this.txtbplace_TextChanged);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(85, 61);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(166, 18);
            this.txtaddress.TabIndex = 17;
            this.txtaddress.Text = "";
            this.txtaddress.TextChanged += new System.EventHandler(this.txtaddress_TextChanged);
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(3, 130);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(70, 13);
            this.Label21.TabIndex = 14;
            this.Label21.Text = "Place of Birth";
            this.Label21.Click += new System.EventHandler(this.Label21_Click);
            // 
            // dtpdbirth
            // 
            this.dtpdbirth.CustomFormat = "yyyy-MM-dd";
            this.dtpdbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdbirth.Location = new System.Drawing.Point(626, 95);
            this.dtpdbirth.Name = "dtpdbirth";
            this.dtpdbirth.Size = new System.Drawing.Size(121, 20);
            this.dtpdbirth.TabIndex = 12;
            this.dtpdbirth.ValueChanged += new System.EventHandler(this.dtpdbirth_ValueChanged);
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(551, 100);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(66, 13);
            this.Label22.TabIndex = 11;
            this.Label22.Text = "Date of Birth";
            this.Label22.Click += new System.EventHandler(this.Label22_Click);
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(353, 32);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(178, 20);
            this.txtlname.TabIndex = 0;
            this.txtlname.TextChanged += new System.EventHandler(this.txtlname_TextChanged);
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(321, 135);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(26, 13);
            this.Label23.TabIndex = 9;
            this.Label23.Text = "Age";
            this.Label23.Click += new System.EventHandler(this.Label23_Click);
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(353, 59);
            this.txtcontact.MaxLength = 11;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(178, 20);
            this.txtcontact.TabIndex = 0;
            this.txtcontact.TextChanged += new System.EventHandler(this.txtcontact_TextChanged);
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(353, 131);
            this.txtage.MaxLength = 2;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(58, 20);
            this.txtage.TabIndex = 8;
            this.txtage.TextChanged += new System.EventHandler(this.txtage_TextChanged);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(85, 32);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(170, 20);
            this.txtfname.TabIndex = 0;
            this.txtfname.TextChanged += new System.EventHandler(this.txtfname_TextChanged);
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(321, 100);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(25, 13);
            this.Label24.TabIndex = 7;
            this.Label24.Text = "Sex";
            this.Label24.Click += new System.EventHandler(this.Label24_Click);
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(626, 32);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(156, 20);
            this.txtmname.TabIndex = 0;
            this.txtmname.TextChanged += new System.EventHandler(this.txtmname_TextChanged);
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(406, 98);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(59, 17);
            this.rdofemale.TabIndex = 6;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            this.rdofemale.CheckedChanged += new System.EventHandler(this.rdofemale_CheckedChanged);
            // 
            // txtemerg
            // 
            this.txtemerg.Location = new System.Drawing.Point(626, 131);
            this.txtemerg.MaxLength = 11;
            this.txtemerg.Name = "txtemerg";
            this.txtemerg.Size = new System.Drawing.Size(155, 20);
            this.txtemerg.TabIndex = 0;
            this.txtemerg.TextChanged += new System.EventHandler(this.txtemerg_TextChanged);
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(352, 98);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(48, 17);
            this.rdomale.TabIndex = 6;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = true;
            this.rdomale.CheckedChanged += new System.EventHandler(this.rdomale_CheckedChanged);
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(263, 61);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(84, 13);
            this.Label25.TabIndex = 1;
            this.Label25.Text = "Contact Number";
            this.Label25.Click += new System.EventHandler(this.Label25_Click);
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(22, 35);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(57, 13);
            this.Label26.TabIndex = 1;
            this.Label26.Text = "First Name";
            this.Label26.Click += new System.EventHandler(this.Label26_Click);
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(583, 61);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(37, 13);
            this.Label27.TabIndex = 1;
            this.Label27.Text = "Status";
            this.Label27.Click += new System.EventHandler(this.Label27_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Items.AddRange(new object[] {
            "Married",
            "Single",
            "Widow"});
            this.txtstatus.Location = new System.Drawing.Point(626, 58);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(121, 21);
            this.txtstatus.TabIndex = 2;
            this.txtstatus.Text = "Single";
            this.txtstatus.SelectedIndexChanged += new System.EventHandler(this.txtstatus_SelectedIndexChanged);
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(289, 35);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(58, 13);
            this.Label28.TabIndex = 1;
            this.Label28.Text = "Last Name";
            this.Label28.Click += new System.EventHandler(this.Label28_Click);
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(34, 61);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(45, 13);
            this.Label29.TabIndex = 1;
            this.Label29.Text = "Address";
            this.Label29.Click += new System.EventHandler(this.Label29_Click);
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Location = new System.Drawing.Point(453, 135);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(167, 13);
            this.Label30.TabIndex = 1;
            this.Label30.Text = "Contact no. [ case of emergency ]";
            this.Label30.Click += new System.EventHandler(this.Label30_Click);
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(551, 35);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(69, 13);
            this.Label31.TabIndex = 1;
            this.Label31.Text = "Middle Name";
            this.Label31.Click += new System.EventHandler(this.Label31_Click);
            // 
            // btnempnew
            // 
            this.btnempnew.Location = new System.Drawing.Point(487, 370);
            this.btnempnew.Name = "btnempnew";
            this.btnempnew.Size = new System.Drawing.Size(75, 32);
            this.btnempnew.TabIndex = 15;
            this.btnempnew.Text = "New";
            this.btnempnew.UseVisualStyleBackColor = true;
            this.btnempnew.Click += new System.EventHandler(this.btnempnew_Click);
            // 
            // btnempsave
            // 
            this.btnempsave.Location = new System.Drawing.Point(325, 370);
            this.btnempsave.Name = "btnempsave";
            this.btnempsave.Size = new System.Drawing.Size(75, 32);
            this.btnempsave.TabIndex = 16;
            this.btnempsave.Text = "Save";
            this.btnempsave.UseVisualStyleBackColor = true;
            this.btnempsave.Click += new System.EventHandler(this.btnempsave_Click);
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage6);
            this.TabControl2.Controls.Add(this.TabPage7);
            this.TabControl2.Controls.Add(this.tabPage1);
            this.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl2.Location = new System.Drawing.Point(0, 0);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(847, 462);
            this.TabControl2.TabIndex = 2;
            this.TabControl2.SelectedIndexChanged += new System.EventHandler(this.TabControl2_SelectedIndexChanged);
            // 
            // frm_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 462);
            this.Controls.Add(this.TabControl2);
            this.Name = "frm_Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REVIEWER";
            this.Load += new System.EventHandler(this.frm_Employees_Load);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.TabPage7.ResumeLayout(false);
            this.TabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).EndInit();
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.TabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl2;
        internal System.Windows.Forms.Button btnempsave;
        internal System.Windows.Forms.Button btnempnew;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.Label Label30;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.ComboBox txtstatus;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.RadioButton rdomale;
        internal System.Windows.Forms.TextBox txtemerg;
        internal System.Windows.Forms.RadioButton rdofemale;
        internal System.Windows.Forms.TextBox txtmname;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox txtfname;
        internal System.Windows.Forms.TextBox txtage;
        internal System.Windows.Forms.TextBox txtcontact;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.TextBox txtlname;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.DateTimePicker dtpdbirth;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.RichTextBox txtaddress;
        internal System.Windows.Forms.RichTextBox txtbplace;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.ComboBox txtpmethod;
        internal System.Windows.Forms.DateTimePicker dtpdhired;
        internal System.Windows.Forms.TextBox txtdrate;
        internal System.Windows.Forms.Label Label33;
        internal System.Windows.Forms.Label Label34;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.Label Label37;
        internal System.Windows.Forms.RichTextBox richTextBox1;
        internal System.Windows.Forms.GroupBox GroupBox10;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.TextBox txtcode;
        internal System.Windows.Forms.Button btnempupdate;
        internal System.Windows.Forms.TabPage TabPage6;
        internal System.Windows.Forms.DataGridView dtgemplist;
        internal System.Windows.Forms.TextBox txtempsearch;
        internal System.Windows.Forms.Label Label46;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Button btn_edit;
        internal System.Windows.Forms.TabPage TabPage7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}
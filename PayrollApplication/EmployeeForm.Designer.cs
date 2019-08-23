namespace PayrollApplication
{
    partial class EmployeeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmpInfo = new System.Windows.Forms.GroupBox();
            this.memberCheck = new System.Windows.Forms.CheckBox();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.insuaranceText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maritalStatusGrp = new System.Windows.Forms.GroupBox();
            this.singleRadioBtn = new System.Windows.Forms.RadioButton();
            this.marriedRadioBtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.genderGrp = new System.Windows.Forms.GroupBox();
            this.femaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.maleRadioBtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpContDet = new System.Windows.Forms.GroupBox();
            this.countryCombo = new System.Windows.Forms.ComboBox();
            this.noteText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.postTeext = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.previewBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nINumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isMemberDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollSystemDBDataSet = new PayrollApplication.PayrollSystemDBDataSet();
            this.tblEmployeeTableAdapter = new PayrollApplication.PayrollSystemDBDataSetTableAdapters.tblEmployeeTableAdapter();
            this.EmpInfo.SuspendLayout();
            this.maritalStatusGrp.SuspendLayout();
            this.genderGrp.SuspendLayout();
            this.EmpContDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollSystemDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpInfo
            // 
            this.EmpInfo.Controls.Add(this.memberCheck);
            this.EmpInfo.Controls.Add(this.dateOfBirthPicker);
            this.EmpInfo.Controls.Add(this.insuaranceText);
            this.EmpInfo.Controls.Add(this.lastNameText);
            this.EmpInfo.Controls.Add(this.FirstNameText);
            this.EmpInfo.Controls.Add(this.idText);
            this.EmpInfo.Controls.Add(this.label6);
            this.EmpInfo.Controls.Add(this.maritalStatusGrp);
            this.EmpInfo.Controls.Add(this.label5);
            this.EmpInfo.Controls.Add(this.genderGrp);
            this.EmpInfo.Controls.Add(this.label4);
            this.EmpInfo.Controls.Add(this.label3);
            this.EmpInfo.Controls.Add(this.label2);
            this.EmpInfo.Controls.Add(this.label1);
            this.EmpInfo.Location = new System.Drawing.Point(12, 12);
            this.EmpInfo.Name = "EmpInfo";
            this.EmpInfo.Size = new System.Drawing.Size(388, 425);
            this.EmpInfo.TabIndex = 0;
            this.EmpInfo.TabStop = false;
            this.EmpInfo.Text = "Employee Information";
            // 
            // memberCheck
            // 
            this.memberCheck.AutoSize = true;
            this.memberCheck.Location = new System.Drawing.Point(142, 384);
            this.memberCheck.Name = "memberCheck";
            this.memberCheck.Size = new System.Drawing.Size(72, 17);
            this.memberCheck.TabIndex = 10;
            this.memberCheck.Text = "IsMember";
            this.memberCheck.UseVisualStyleBackColor = true;
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Location = new System.Drawing.Point(142, 265);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(205, 20);
            this.dateOfBirthPicker.TabIndex = 7;
            // 
            // insuaranceText
            // 
            this.insuaranceText.Location = new System.Drawing.Point(142, 227);
            this.insuaranceText.Name = "insuaranceText";
            this.insuaranceText.Size = new System.Drawing.Size(205, 20);
            this.insuaranceText.TabIndex = 6;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(142, 116);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(205, 20);
            this.lastNameText.TabIndex = 2;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(142, 83);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(205, 20);
            this.FirstNameText.TabIndex = 1;
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(142, 53);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(205, 20);
            this.idText.TabIndex = 0;
            this.idText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idText_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Union Membership :";
            // 
            // maritalStatusGrp
            // 
            this.maritalStatusGrp.Controls.Add(this.singleRadioBtn);
            this.maritalStatusGrp.Controls.Add(this.marriedRadioBtn);
            this.maritalStatusGrp.Location = new System.Drawing.Point(18, 302);
            this.maritalStatusGrp.Name = "maritalStatusGrp";
            this.maritalStatusGrp.Size = new System.Drawing.Size(329, 64);
            this.maritalStatusGrp.TabIndex = 6;
            this.maritalStatusGrp.TabStop = false;
            this.maritalStatusGrp.Text = "Marital Status";
            // 
            // singleRadioBtn
            // 
            this.singleRadioBtn.AutoSize = true;
            this.singleRadioBtn.Location = new System.Drawing.Point(169, 29);
            this.singleRadioBtn.Name = "singleRadioBtn";
            this.singleRadioBtn.Size = new System.Drawing.Size(54, 17);
            this.singleRadioBtn.TabIndex = 9;
            this.singleRadioBtn.TabStop = true;
            this.singleRadioBtn.Text = "Single";
            this.singleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // marriedRadioBtn
            // 
            this.marriedRadioBtn.AutoSize = true;
            this.marriedRadioBtn.Location = new System.Drawing.Point(32, 29);
            this.marriedRadioBtn.Name = "marriedRadioBtn";
            this.marriedRadioBtn.Size = new System.Drawing.Size(60, 17);
            this.marriedRadioBtn.TabIndex = 8;
            this.marriedRadioBtn.TabStop = true;
            this.marriedRadioBtn.Text = "Married";
            this.marriedRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date Of Birth :";
            // 
            // genderGrp
            // 
            this.genderGrp.Controls.Add(this.femaleRadioBtn);
            this.genderGrp.Controls.Add(this.maleRadioBtn);
            this.genderGrp.Location = new System.Drawing.Point(27, 153);
            this.genderGrp.Name = "genderGrp";
            this.genderGrp.Size = new System.Drawing.Size(320, 58);
            this.genderGrp.TabIndex = 3;
            this.genderGrp.TabStop = false;
            this.genderGrp.Text = "Gender";
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Location = new System.Drawing.Point(160, 29);
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioBtn.TabIndex = 5;
            this.femaleRadioBtn.TabStop = true;
            this.femaleRadioBtn.Text = "Female";
            this.femaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Location = new System.Drawing.Point(23, 29);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(48, 17);
            this.maleRadioBtn.TabIndex = 4;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "National Insuarance No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID :";
            // 
            // EmpContDet
            // 
            this.EmpContDet.Controls.Add(this.countryCombo);
            this.EmpContDet.Controls.Add(this.noteText);
            this.EmpContDet.Controls.Add(this.emailText);
            this.EmpContDet.Controls.Add(this.phoneText);
            this.EmpContDet.Controls.Add(this.postTeext);
            this.EmpContDet.Controls.Add(this.cityText);
            this.EmpContDet.Controls.Add(this.addressText);
            this.EmpContDet.Controls.Add(this.label13);
            this.EmpContDet.Controls.Add(this.label12);
            this.EmpContDet.Controls.Add(this.label11);
            this.EmpContDet.Controls.Add(this.label10);
            this.EmpContDet.Controls.Add(this.label9);
            this.EmpContDet.Controls.Add(this.label8);
            this.EmpContDet.Controls.Add(this.label7);
            this.EmpContDet.Location = new System.Drawing.Point(421, 12);
            this.EmpContDet.Name = "EmpContDet";
            this.EmpContDet.Size = new System.Drawing.Size(367, 425);
            this.EmpContDet.TabIndex = 1;
            this.EmpContDet.TabStop = false;
            this.EmpContDet.Text = "Employee Contact Details";
            // 
            // countryCombo
            // 
            this.countryCombo.FormattingEnabled = true;
            this.countryCombo.Items.AddRange(new object[] {
            "Afghanistan",
            "Bangladesh",
            "Canada",
            "Denmark",
            "Ethiopia",
            "Finland",
            "Gahana",
            "Haiti",
            "Iraq",
            "Japan",
            "Kenya",
            "Libya",
            "Mongolia",
            "Nepal",
            "Portugal",
            "Russia",
            "Sri Lanka",
            "Turky",
            "Ukrain",
            "Vietnam",
            "Yeman",
            "Zimbabwe"});
            this.countryCombo.Location = new System.Drawing.Point(152, 202);
            this.countryCombo.Name = "countryCombo";
            this.countryCombo.Size = new System.Drawing.Size(190, 21);
            this.countryCombo.TabIndex = 14;
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(152, 346);
            this.noteText.Multiline = true;
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(190, 55);
            this.noteText.TabIndex = 17;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(152, 302);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(190, 20);
            this.emailText.TabIndex = 16;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(152, 248);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(190, 20);
            this.phoneText.TabIndex = 15;
            this.phoneText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneText_KeyPress);
            // 
            // postTeext
            // 
            this.postTeext.Location = new System.Drawing.Point(152, 153);
            this.postTeext.Name = "postTeext";
            this.postTeext.Size = new System.Drawing.Size(190, 20);
            this.postTeext.TabIndex = 13;
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(152, 100);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(190, 20);
            this.cityText.TabIndex = 12;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(152, 57);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(190, 20);
            this.addressText.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Notes :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Email Address :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Phone Number :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Country :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Post Code :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "City :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Address :";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(671, 487);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(117, 43);
            this.exitBtn.TabIndex = 23;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(534, 489);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(107, 41);
            this.previewBtn.TabIndex = 22;
            this.previewBtn.Text = "Preview";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(395, 489);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(107, 41);
            this.resetBtn.TabIndex = 21;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(272, 487);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(107, 41);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Delete Employee";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(146, 487);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(107, 41);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update Employee";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(15, 489);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(107, 41);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "Add Employee";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.nINumberDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.maritalStatusDataGridViewTextBoxColumn,
            this.isMemberDataGridViewCheckBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.postCodeDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEmployeeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 530);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(898, 150);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nINumberDataGridViewTextBoxColumn
            // 
            this.nINumberDataGridViewTextBoxColumn.DataPropertyName = "NINumber";
            this.nINumberDataGridViewTextBoxColumn.HeaderText = "NINumber";
            this.nINumberDataGridViewTextBoxColumn.Name = "nINumberDataGridViewTextBoxColumn";
            this.nINumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maritalStatusDataGridViewTextBoxColumn
            // 
            this.maritalStatusDataGridViewTextBoxColumn.DataPropertyName = "MaritalStatus";
            this.maritalStatusDataGridViewTextBoxColumn.HeaderText = "MaritalStatus";
            this.maritalStatusDataGridViewTextBoxColumn.Name = "maritalStatusDataGridViewTextBoxColumn";
            this.maritalStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isMemberDataGridViewCheckBoxColumn
            // 
            this.isMemberDataGridViewCheckBoxColumn.DataPropertyName = "IsMember";
            this.isMemberDataGridViewCheckBoxColumn.HeaderText = "IsMember";
            this.isMemberDataGridViewCheckBoxColumn.Name = "isMemberDataGridViewCheckBoxColumn";
            this.isMemberDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postCodeDataGridViewTextBoxColumn
            // 
            this.postCodeDataGridViewTextBoxColumn.DataPropertyName = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.HeaderText = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.Name = "postCodeDataGridViewTextBoxColumn";
            this.postCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblEmployeeBindingSource
            // 
            this.tblEmployeeBindingSource.DataMember = "tblEmployee";
            this.tblEmployeeBindingSource.DataSource = this.payrollSystemDBDataSet;
            this.tblEmployeeBindingSource.CurrentChanged += new System.EventHandler(this.tblEmployeeBindingSource_CurrentChanged);
            // 
            // payrollSystemDBDataSet
            // 
            this.payrollSystemDBDataSet.DataSetName = "PayrollSystemDBDataSet";
            this.payrollSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmployeeTableAdapter
            // 
            this.tblEmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(915, 629);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.EmpContDet);
            this.Controls.Add(this.EmpInfo);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Employee";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.EmpInfo.ResumeLayout(false);
            this.EmpInfo.PerformLayout();
            this.maritalStatusGrp.ResumeLayout(false);
            this.maritalStatusGrp.PerformLayout();
            this.genderGrp.ResumeLayout(false);
            this.genderGrp.PerformLayout();
            this.EmpContDet.ResumeLayout(false);
            this.EmpContDet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollSystemDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EmpInfo;
        private System.Windows.Forms.GroupBox EmpContDet;
        private System.Windows.Forms.CheckBox memberCheck;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.TextBox insuaranceText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox maritalStatusGrp;
        private System.Windows.Forms.RadioButton singleRadioBtn;
        private System.Windows.Forms.RadioButton marriedRadioBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox genderGrp;
        private System.Windows.Forms.RadioButton femaleRadioBtn;
        private System.Windows.Forms.RadioButton maleRadioBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox countryCombo;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox postTeext;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PayrollSystemDBDataSet payrollSystemDBDataSet;
        private System.Windows.Forms.BindingSource tblEmployeeBindingSource;
        private PayrollSystemDBDataSetTableAdapters.tblEmployeeTableAdapter tblEmployeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nINumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMemberDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}


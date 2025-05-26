namespace EmployeeDataApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.gbBirthDate = new System.Windows.Forms.GroupBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.gbLocation = new System.Windows.Forms.GroupBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.gbExperience = new System.Windows.Forms.GroupBox();
            this.rbExpLess1 = new System.Windows.Forms.RadioButton();
            this.rbExp10plus = new System.Windows.Forms.RadioButton();
            this.rbExp5to9 = new System.Windows.Forms.RadioButton();
            this.rbExp1to5 = new System.Windows.Forms.RadioButton();
            this.rbExpNone = new System.Windows.Forms.RadioButton();
            this.gbOtherInfo = new System.Windows.Forms.GroupBox();
            this.chkCategoryD = new System.Windows.Forms.CheckBox();
            this.chkCategoryC = new System.Windows.Forms.CheckBox();
            this.chkCategoryB = new System.Windows.Forms.CheckBox();
            this.chkCategoryA = new System.Windows.Forms.CheckBox();
            this.lblLicenseCategory = new System.Windows.Forms.Label();
            this.chkHasLicense = new System.Windows.Forms.CheckBox();
            this.chkHasCar = new System.Windows.Forms.CheckBox();
            this.gbSalary = new System.Windows.Forms.GroupBox();
            this.numSalaryTo = new System.Windows.Forms.NumericUpDown();
            this.numSalaryFrom = new System.Windows.Forms.NumericUpDown();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.gbWorkSchedule = new System.Windows.Forms.GroupBox();
            this.rbShiftWork = new System.Windows.Forms.RadioButton();
            this.rbHomeWork = new System.Windows.Forms.RadioButton();
            this.rbPartTime = new System.Windows.Forms.RadioButton();
            this.rbFullTime = new System.Windows.Forms.RadioButton();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbBirthDate.SuspendLayout();
            this.gbLocation.SuspendLayout();
            this.gbExperience.SuspendLayout();
            this.gbOtherInfo.SuspendLayout();
            this.gbSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalaryTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalaryFrom)).BeginInit();
            this.gbWorkSchedule.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(317, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Анкетные данные сотрудника";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 60);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 16);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Фамилия";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(120, 57);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 90);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(33, 16);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "Имя";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 87);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(20, 120);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(70, 16);
            this.lblMiddleName.TabIndex = 5;
            this.lblMiddleName.Text = "Отчество";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(120, 117);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(200, 22);
            this.txtMiddleName.TabIndex = 3;
            // 
            // gbBirthDate
            // 
            this.gbBirthDate.Controls.Add(this.lblDay);
            this.gbBirthDate.Controls.Add(this.txtDay);
            this.gbBirthDate.Controls.Add(this.lblMonth);
            this.gbBirthDate.Controls.Add(this.cmbMonth);
            this.gbBirthDate.Controls.Add(this.lblYear);
            this.gbBirthDate.Controls.Add(this.txtYear);
            this.gbBirthDate.Location = new System.Drawing.Point(20, 150);
            this.gbBirthDate.Name = "gbBirthDate";
            this.gbBirthDate.Size = new System.Drawing.Size(300, 120);
            this.gbBirthDate.TabIndex = 4;
            this.gbBirthDate.TabStop = false;
            this.gbBirthDate.Text = "Дата рождения";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(10, 30);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(39, 16);
            this.lblDay.TabIndex = 8;
            this.lblDay.Text = "День";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(100, 27);
            this.txtDay.MaxLength = 2;
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(50, 22);
            this.txtDay.TabIndex = 1;
            this.txtDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(10, 60);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(48, 16);
            this.lblMonth.TabIndex = 10;
            this.lblMonth.Text = "Месяц";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.cmbMonth.Location = new System.Drawing.Point(100, 57);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(180, 24);
            this.cmbMonth.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(10, 90);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(30, 16);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Год";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(100, 87);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(70, 22);
            this.txtYear.TabIndex = 3;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // gbLocation
            // 
            this.gbLocation.Controls.Add(this.txtLocation);
            this.gbLocation.Controls.Add(this.lblEmail);
            this.gbLocation.Controls.Add(this.txtEmail);
            this.gbLocation.Controls.Add(this.lblPhone);
            this.gbLocation.Controls.Add(this.cmbOperator);
            this.gbLocation.Controls.Add(this.txtPhone);
            this.gbLocation.Location = new System.Drawing.Point(20, 280);
            this.gbLocation.Name = "gbLocation";
            this.gbLocation.Size = new System.Drawing.Size(300, 150);
            this.gbLocation.TabIndex = 5;
            this.gbLocation.TabStop = false;
            this.gbLocation.Text = "Место проживания";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(10, 30);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(270, 22);
            this.txtLocation.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(179, 16);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Адрес электронной почты";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(10, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(10, 110);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(143, 16);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Мобильный телефон";
            // 
            // cmbOperator
            // 
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "MTC",
            "A1",
            "Life"});
            this.cmbOperator.Location = new System.Drawing.Point(10, 130);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(80, 24);
            this.cmbOperator.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(100, 130);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(180, 22);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // gbExperience
            // 
            this.gbExperience.Controls.Add(this.rbExpLess1);
            this.gbExperience.Controls.Add(this.rbExp10plus);
            this.gbExperience.Controls.Add(this.rbExp5to9);
            this.gbExperience.Controls.Add(this.rbExp1to5);
            this.gbExperience.Controls.Add(this.rbExpNone);
            this.gbExperience.Location = new System.Drawing.Point(20, 440);
            this.gbExperience.Name = "gbExperience";
            this.gbExperience.Size = new System.Drawing.Size(300, 150);
            this.gbExperience.TabIndex = 6;
            this.gbExperience.TabStop = false;
            this.gbExperience.Text = "Опыт работы";
            // 
            // rbExpLess1
            // 
            this.rbExpLess1.AutoSize = true;
            this.rbExpLess1.Location = new System.Drawing.Point(10, 120);
            this.rbExpLess1.Name = "rbExpLess1";
            this.rbExpLess1.Size = new System.Drawing.Size(122, 20);
            this.rbExpLess1.TabIndex = 4;
            this.rbExpLess1.TabStop = true;
            this.rbExpLess1.Text = "Меньше 1 года";
            this.rbExpLess1.UseVisualStyleBackColor = true;
            // 
            // rbExp10plus
            // 
            this.rbExp10plus.AutoSize = true;
            this.rbExp10plus.Location = new System.Drawing.Point(10, 95);
            this.rbExp10plus.Name = "rbExp10plus";
            this.rbExp10plus.Size = new System.Drawing.Size(122, 20);
            this.rbExp10plus.TabIndex = 3;
            this.rbExp10plus.TabStop = true;
            this.rbExp10plus.Text = "10 лет и более";
            this.rbExp10plus.UseVisualStyleBackColor = true;
            // 
            // rbExp5to9
            // 
            this.rbExp5to9.AutoSize = true;
            this.rbExp5to9.Location = new System.Drawing.Point(10, 70);
            this.rbExp5to9.Name = "rbExp5to9";
            this.rbExp5to9.Size = new System.Drawing.Size(110, 20);
            this.rbExp5to9.TabIndex = 2;
            this.rbExp5to9.TabStop = true;
            this.rbExp5to9.Text = "От 5 до 9 лет";
            this.rbExp5to9.UseVisualStyleBackColor = true;
            // 
            // rbExp1to5
            // 
            this.rbExp1to5.AutoSize = true;
            this.rbExp1to5.Location = new System.Drawing.Point(10, 45);
            this.rbExp1to5.Name = "rbExp1to5";
            this.rbExp1to5.Size = new System.Drawing.Size(143, 20);
            this.rbExp1to5.TabIndex = 1;
            this.rbExp1to5.TabStop = true;
            this.rbExp1to5.Text = "От 1 года до 5 лет";
            this.rbExp1to5.UseVisualStyleBackColor = true;
            // 
            // rbExpNone
            // 
            this.rbExpNone.AutoSize = true;
            this.rbExpNone.Location = new System.Drawing.Point(10, 20);
            this.rbExpNone.Name = "rbExpNone";
            this.rbExpNone.Size = new System.Drawing.Size(156, 20);
            this.rbExpNone.TabIndex = 0;
            this.rbExpNone.TabStop = true;
            this.rbExpNone.Text = "Прежде не работал";
            this.rbExpNone.UseVisualStyleBackColor = true;
            // 
            // gbOtherInfo
            // 
            this.gbOtherInfo.Controls.Add(this.chkCategoryD);
            this.gbOtherInfo.Controls.Add(this.chkCategoryC);
            this.gbOtherInfo.Controls.Add(this.chkCategoryB);
            this.gbOtherInfo.Controls.Add(this.chkCategoryA);
            this.gbOtherInfo.Controls.Add(this.lblLicenseCategory);
            this.gbOtherInfo.Controls.Add(this.chkHasLicense);
            this.gbOtherInfo.Controls.Add(this.chkHasCar);
            this.gbOtherInfo.Location = new System.Drawing.Point(340, 60);
            this.gbOtherInfo.Name = "gbOtherInfo";
            this.gbOtherInfo.Size = new System.Drawing.Size(300, 150);
            this.gbOtherInfo.TabIndex = 7;
            this.gbOtherInfo.TabStop = false;
            this.gbOtherInfo.Text = "Другие сведения";
            // 
            // chkCategoryD
            // 
            this.chkCategoryD.AutoSize = true;
            this.chkCategoryD.Location = new System.Drawing.Point(240, 110);
            this.chkCategoryD.Name = "chkCategoryD";
            this.chkCategoryD.Size = new System.Drawing.Size(39, 20);
            this.chkCategoryD.TabIndex = 6;
            this.chkCategoryD.Text = "D";
            this.chkCategoryD.UseVisualStyleBackColor = true;
            // 
            // chkCategoryC
            // 
            this.chkCategoryC.AutoSize = true;
            this.chkCategoryC.Location = new System.Drawing.Point(190, 110);
            this.chkCategoryC.Name = "chkCategoryC";
            this.chkCategoryC.Size = new System.Drawing.Size(38, 20);
            this.chkCategoryC.TabIndex = 5;
            this.chkCategoryC.Text = "C";
            this.chkCategoryC.UseVisualStyleBackColor = true;
            // 
            // chkCategoryB
            // 
            this.chkCategoryB.AutoSize = true;
            this.chkCategoryB.Location = new System.Drawing.Point(140, 110);
            this.chkCategoryB.Name = "chkCategoryB";
            this.chkCategoryB.Size = new System.Drawing.Size(38, 20);
            this.chkCategoryB.TabIndex = 4;
            this.chkCategoryB.Text = "B";
            this.chkCategoryB.UseVisualStyleBackColor = true;
            // 
            // chkCategoryA
            // 
            this.chkCategoryA.AutoSize = true;
            this.chkCategoryA.Location = new System.Drawing.Point(90, 110);
            this.chkCategoryA.Name = "chkCategoryA";
            this.chkCategoryA.Size = new System.Drawing.Size(38, 20);
            this.chkCategoryA.TabIndex = 3;
            this.chkCategoryA.Text = "A";
            this.chkCategoryA.UseVisualStyleBackColor = true;
            // 
            // lblLicenseCategory
            // 
            this.lblLicenseCategory.AutoSize = true;
            this.lblLicenseCategory.Location = new System.Drawing.Point(10, 110);
            this.lblLicenseCategory.Name = "lblLicenseCategory";
            this.lblLicenseCategory.Size = new System.Drawing.Size(110, 16);
            this.lblLicenseCategory.TabIndex = 2;
            this.lblLicenseCategory.Text = "Категория прав";
            // 
            // chkHasLicense
            // 
            this.chkHasLicense.AutoSize = true;
            this.chkHasLicense.Location = new System.Drawing.Point(10, 70);
            this.chkHasLicense.Name = "chkHasLicense";
            this.chkHasLicense.Size = new System.Drawing.Size(227, 20);
            this.chkHasLicense.TabIndex = 1;
            this.chkHasLicense.Text = "Водительское удостоверение";
            this.chkHasLicense.UseVisualStyleBackColor = true;
            // 
            // chkHasCar
            // 
            this.chkHasCar.AutoSize = true;
            this.chkHasCar.Location = new System.Drawing.Point(10, 40);
            this.chkHasCar.Name = "chkHasCar";
            this.chkHasCar.Size = new System.Drawing.Size(178, 20);
            this.chkHasCar.TabIndex = 0;
            this.chkHasCar.Text = "Наличие личного авто";
            this.chkHasCar.UseVisualStyleBackColor = true;
            // 
            // gbSalary
            // 
            this.gbSalary.Controls.Add(this.numSalaryTo);
            this.gbSalary.Controls.Add(this.numSalaryFrom);
            this.gbSalary.Controls.Add(this.lblTo);
            this.gbSalary.Controls.Add(this.lblFrom);
            this.gbSalary.Location = new System.Drawing.Point(340, 220);
            this.gbSalary.Name = "gbSalary";
            this.gbSalary.Size = new System.Drawing.Size(300, 80);
            this.gbSalary.TabIndex = 8;
            this.gbSalary.TabStop = false;
            this.gbSalary.Text = "Объем заработной платы";
            // 
            // numSalaryTo
            // 
            this.numSalaryTo.Location = new System.Drawing.Point(190, 40);
            this.numSalaryTo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSalaryTo.Minimum = new decimal(new int[] {
            523,
            0,
            0,
            0});
            this.numSalaryTo.Name = "numSalaryTo";
            this.numSalaryTo.Size = new System.Drawing.Size(100, 22);
            this.numSalaryTo.TabIndex = 3;
            this.numSalaryTo.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // numSalaryFrom
            // 
            this.numSalaryFrom.Location = new System.Drawing.Point(40, 40);
            this.numSalaryFrom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSalaryFrom.Minimum = new decimal(new int[] {
            523,
            0,
            0,
            0});
            this.numSalaryFrom.Name = "numSalaryFrom";
            this.numSalaryFrom.Size = new System.Drawing.Size(100, 22);
            this.numSalaryFrom.TabIndex = 1;
            this.numSalaryFrom.Value = new decimal(new int[] {
            523,
            0,
            0,
            0});
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(160, 45);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 16);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "До";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(10, 45);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(24, 16);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "От";
            // 
            // gbWorkSchedule
            // 
            this.gbWorkSchedule.Controls.Add(this.rbShiftWork);
            this.gbWorkSchedule.Controls.Add(this.rbHomeWork);
            this.gbWorkSchedule.Controls.Add(this.rbPartTime);
            this.gbWorkSchedule.Controls.Add(this.rbFullTime);
            this.gbWorkSchedule.Location = new System.Drawing.Point(340, 310);
            this.gbWorkSchedule.Name = "gbWorkSchedule";
            this.gbWorkSchedule.Size = new System.Drawing.Size(300, 150);
            this.gbWorkSchedule.TabIndex = 9;
            this.gbWorkSchedule.TabStop = false;
            this.gbWorkSchedule.Text = "Предпочитаемый график работы";
            // 
            // rbShiftWork
            // 
            this.rbShiftWork.AutoSize = true;
            this.rbShiftWork.Location = new System.Drawing.Point(10, 120);
            this.rbShiftWork.Name = "rbShiftWork";
            this.rbShiftWork.Size = new System.Drawing.Size(149, 20);
            this.rbShiftWork.TabIndex = 3;
            this.rbShiftWork.TabStop = true;
            this.rbShiftWork.Text = "посменная работа";
            this.rbShiftWork.UseVisualStyleBackColor = true;
            // 
            // rbHomeWork
            // 
            this.rbHomeWork.AutoSize = true;
            this.rbHomeWork.Location = new System.Drawing.Point(10, 90);
            this.rbHomeWork.Name = "rbHomeWork";
            this.rbHomeWork.Size = new System.Drawing.Size(130, 20);
            this.rbHomeWork.TabIndex = 2;
            this.rbHomeWork.TabStop = true;
            this.rbHomeWork.Text = "работа на дому";
            this.rbHomeWork.UseVisualStyleBackColor = true;
            // 
            // rbPartTime
            // 
            this.rbPartTime.AutoSize = true;
            this.rbPartTime.Location = new System.Drawing.Point(10, 60);
            this.rbPartTime.Name = "rbPartTime";
            this.rbPartTime.Size = new System.Drawing.Size(167, 20);
            this.rbPartTime.TabIndex = 1;
            this.rbPartTime.TabStop = true;
            this.rbPartTime.Text = "частичная занятость";
            this.rbPartTime.UseVisualStyleBackColor = true;
            // 
            // rbFullTime
            // 
            this.rbFullTime.AutoSize = true;
            this.rbFullTime.Location = new System.Drawing.Point(10, 30);
            this.rbFullTime.Name = "rbFullTime";
            this.rbFullTime.Size = new System.Drawing.Size(145, 20);
            this.rbFullTime.TabIndex = 0;
            this.rbFullTime.TabStop = true;
            this.rbFullTime.Text = "полная занятость";
            this.rbFullTime.UseVisualStyleBackColor = true;
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.txtSummary);
            this.gbSummary.Location = new System.Drawing.Point(340, 470);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(300, 150);
            this.gbSummary.TabIndex = 10;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Краткое резюме";
            // 
            // txtSummary
            // 
            this.txtSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSummary.Location = new System.Drawing.Point(3, 18);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(294, 129);
            this.txtSummary.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(50, 640);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить данные";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(250, 640);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Очистить форму";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(450, 640);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Help";
            this.toolTip1.SetToolTip(this.button1, "откроется подсказка");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Visder\\OneDrive\\Desktop\\практика кпияп\\Тема 1\\22 Topic\\22 Topic\\Employee" +
    "DataApp\\bin\\Debug\\Help.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.gbWorkSchedule);
            this.Controls.Add(this.gbSalary);
            this.Controls.Add(this.gbOtherInfo);
            this.Controls.Add(this.gbExperience);
            this.Controls.Add(this.gbLocation);
            this.Controls.Add(this.gbBirthDate);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анкетные данные сотрудника";
            this.gbBirthDate.ResumeLayout(false);
            this.gbBirthDate.PerformLayout();
            this.gbLocation.ResumeLayout(false);
            this.gbLocation.PerformLayout();
            this.gbExperience.ResumeLayout(false);
            this.gbExperience.PerformLayout();
            this.gbOtherInfo.ResumeLayout(false);
            this.gbOtherInfo.PerformLayout();
            this.gbSalary.ResumeLayout(false);
            this.gbSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalaryTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalaryFrom)).EndInit();
            this.gbWorkSchedule.ResumeLayout(false);
            this.gbWorkSchedule.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.GroupBox gbBirthDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.GroupBox gbLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.GroupBox gbExperience;
        private System.Windows.Forms.RadioButton rbExpLess1;
        private System.Windows.Forms.RadioButton rbExp10plus;
        private System.Windows.Forms.RadioButton rbExp5to9;
        private System.Windows.Forms.RadioButton rbExp1to5;
        private System.Windows.Forms.RadioButton rbExpNone;
        private System.Windows.Forms.GroupBox gbOtherInfo;
        private System.Windows.Forms.CheckBox chkCategoryD;
        private System.Windows.Forms.CheckBox chkCategoryC;
        private System.Windows.Forms.CheckBox chkCategoryB;
        private System.Windows.Forms.CheckBox chkCategoryA;
        private System.Windows.Forms.Label lblLicenseCategory;
        private System.Windows.Forms.CheckBox chkHasLicense;
        private System.Windows.Forms.CheckBox chkHasCar;
        private System.Windows.Forms.GroupBox gbSalary;
        private System.Windows.Forms.NumericUpDown numSalaryTo;
        private System.Windows.Forms.NumericUpDown numSalaryFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.GroupBox gbWorkSchedule;
        private System.Windows.Forms.RadioButton rbShiftWork;
        private System.Windows.Forms.RadioButton rbHomeWork;
        private System.Windows.Forms.RadioButton rbPartTime;
        private System.Windows.Forms.RadioButton rbFullTime;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
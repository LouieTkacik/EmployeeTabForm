namespace TKACIKChapterTen
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.employeeTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeButt = new System.Windows.Forms.Button();
            this.employeeOutput = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.productionWorkerTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.productionButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.productionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prodNameText = new System.Windows.Forms.TextBox();
            this.prodPayRateText = new System.Windows.Forms.TextBox();
            this.prodNumText = new System.Windows.Forms.TextBox();
            this.prodShiftNumberText = new System.Windows.Forms.TextBox();
            this.supervisorTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.supervisorBonus = new System.Windows.Forms.TextBox();
            this.supervisorSalary = new System.Windows.Forms.TextBox();
            this.supervisorName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.supervisorButton = new System.Windows.Forms.Button();
            this.supervisorOutput = new System.Windows.Forms.Label();
            this.supervisorNumber = new System.Windows.Forms.TextBox();
            this.teamLeadTab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tlHours = new System.Windows.Forms.TextBox();
            this.tlBonus = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tlButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tlOutput = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tlName = new System.Windows.Forms.TextBox();
            this.tlPayrate = new System.Windows.Forms.TextBox();
            this.tlNumber = new System.Windows.Forms.TextBox();
            this.tlShiftNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.employeeTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.productionWorkerTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.supervisorTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.teamLeadTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.employeeTab);
            this.tabControl1.Controls.Add(this.productionWorkerTab);
            this.tabControl1.Controls.Add(this.supervisorTab);
            this.tabControl1.Controls.Add(this.teamLeadTab);
            this.tabControl1.Location = new System.Drawing.Point(23, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(496, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // employeeTab
            // 
            this.employeeTab.Controls.Add(this.groupBox1);
            this.employeeTab.Location = new System.Drawing.Point(4, 22);
            this.employeeTab.Name = "employeeTab";
            this.employeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.employeeTab.Size = new System.Drawing.Size(488, 321);
            this.employeeTab.TabIndex = 0;
            this.employeeTab.Text = "Employee Object";
            this.employeeTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.employeeButt);
            this.groupBox1.Controls.Add(this.employeeOutput);
            this.groupBox1.Controls.Add(this.numberInput);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 312);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(162, 25);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 26);
            this.nameInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee Number";
            // 
            // employeeButt
            // 
            this.employeeButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeButt.Location = new System.Drawing.Point(6, 213);
            this.employeeButt.Name = "employeeButt";
            this.employeeButt.Size = new System.Drawing.Size(104, 70);
            this.employeeButt.TabIndex = 5;
            this.employeeButt.Text = "Create Employee";
            this.employeeButt.UseVisualStyleBackColor = true;
            this.employeeButt.Click += new System.EventHandler(this.employeeButt_Click);
            // 
            // employeeOutput
            // 
            this.employeeOutput.BackColor = System.Drawing.Color.LightGray;
            this.employeeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeOutput.Location = new System.Drawing.Point(162, 213);
            this.employeeOutput.Name = "employeeOutput";
            this.employeeOutput.Size = new System.Drawing.Size(116, 70);
            this.employeeOutput.TabIndex = 6;
            // 
            // numberInput
            // 
            this.numberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberInput.Location = new System.Drawing.Point(162, 64);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(100, 26);
            this.numberInput.TabIndex = 4;
            // 
            // productionWorkerTab
            // 
            this.productionWorkerTab.Controls.Add(this.groupBox3);
            this.productionWorkerTab.Location = new System.Drawing.Point(4, 22);
            this.productionWorkerTab.Name = "productionWorkerTab";
            this.productionWorkerTab.Padding = new System.Windows.Forms.Padding(3);
            this.productionWorkerTab.Size = new System.Drawing.Size(488, 321);
            this.productionWorkerTab.TabIndex = 1;
            this.productionWorkerTab.Text = "Production Worker";
            this.productionWorkerTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.productionButton);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.productionLabel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.prodNameText);
            this.groupBox3.Controls.Add(this.prodPayRateText);
            this.groupBox3.Controls.Add(this.prodNumText);
            this.groupBox3.Controls.Add(this.prodShiftNumberText);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 324);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Employee Payrate";
            // 
            // productionButton
            // 
            this.productionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionButton.Location = new System.Drawing.Point(10, 201);
            this.productionButton.Name = "productionButton";
            this.productionButton.Size = new System.Drawing.Size(104, 70);
            this.productionButton.TabIndex = 10;
            this.productionButton.Text = "Create Production Employee";
            this.productionButton.UseVisualStyleBackColor = true;
            this.productionButton.Click += new System.EventHandler(this.productionButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Employee Shift Number";
            // 
            // productionLabel
            // 
            this.productionLabel.BackColor = System.Drawing.Color.LightGray;
            this.productionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productionLabel.Location = new System.Drawing.Point(209, 201);
            this.productionLabel.Name = "productionLabel";
            this.productionLabel.Size = new System.Drawing.Size(116, 70);
            this.productionLabel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Employee Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // prodNameText
            // 
            this.prodNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNameText.Location = new System.Drawing.Point(209, 30);
            this.prodNameText.Name = "prodNameText";
            this.prodNameText.Size = new System.Drawing.Size(100, 26);
            this.prodNameText.TabIndex = 4;
            // 
            // prodPayRateText
            // 
            this.prodPayRateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodPayRateText.Location = new System.Drawing.Point(209, 157);
            this.prodPayRateText.Name = "prodPayRateText";
            this.prodPayRateText.Size = new System.Drawing.Size(100, 26);
            this.prodPayRateText.TabIndex = 9;
            // 
            // prodNumText
            // 
            this.prodNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNumText.Location = new System.Drawing.Point(209, 73);
            this.prodNumText.Name = "prodNumText";
            this.prodNumText.Size = new System.Drawing.Size(100, 26);
            this.prodNumText.TabIndex = 5;
            // 
            // prodShiftNumberText
            // 
            this.prodShiftNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodShiftNumberText.Location = new System.Drawing.Point(209, 113);
            this.prodShiftNumberText.Name = "prodShiftNumberText";
            this.prodShiftNumberText.Size = new System.Drawing.Size(100, 26);
            this.prodShiftNumberText.TabIndex = 8;
            // 
            // supervisorTab
            // 
            this.supervisorTab.Controls.Add(this.groupBox2);
            this.supervisorTab.Location = new System.Drawing.Point(4, 22);
            this.supervisorTab.Name = "supervisorTab";
            this.supervisorTab.Size = new System.Drawing.Size(488, 321);
            this.supervisorTab.TabIndex = 2;
            this.supervisorTab.Text = "Shift Supervisor";
            this.supervisorTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.supervisorBonus);
            this.groupBox2.Controls.Add(this.supervisorSalary);
            this.groupBox2.Controls.Add(this.supervisorName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.supervisorButton);
            this.groupBox2.Controls.Add(this.supervisorOutput);
            this.groupBox2.Controls.Add(this.supervisorNumber);
            this.groupBox2.Location = new System.Drawing.Point(6, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 312);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Employee Bonus";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "Employee Salary";
            // 
            // supervisorBonus
            // 
            this.supervisorBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisorBonus.Location = new System.Drawing.Point(162, 128);
            this.supervisorBonus.Name = "supervisorBonus";
            this.supervisorBonus.Size = new System.Drawing.Size(100, 26);
            this.supervisorBonus.TabIndex = 8;
            // 
            // supervisorSalary
            // 
            this.supervisorSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisorSalary.Location = new System.Drawing.Point(162, 96);
            this.supervisorSalary.Name = "supervisorSalary";
            this.supervisorSalary.Size = new System.Drawing.Size(100, 26);
            this.supervisorSalary.TabIndex = 7;
            // 
            // supervisorName
            // 
            this.supervisorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisorName.Location = new System.Drawing.Point(162, 25);
            this.supervisorName.Name = "supervisorName";
            this.supervisorName.Size = new System.Drawing.Size(100, 26);
            this.supervisorName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Employee Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Employee Number";
            // 
            // supervisorButton
            // 
            this.supervisorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisorButton.Location = new System.Drawing.Point(6, 213);
            this.supervisorButton.Name = "supervisorButton";
            this.supervisorButton.Size = new System.Drawing.Size(104, 70);
            this.supervisorButton.TabIndex = 5;
            this.supervisorButton.Text = "Create Supervisor";
            this.supervisorButton.UseVisualStyleBackColor = true;
            // 
            // supervisorOutput
            // 
            this.supervisorOutput.BackColor = System.Drawing.Color.LightGray;
            this.supervisorOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.supervisorOutput.Location = new System.Drawing.Point(162, 213);
            this.supervisorOutput.Name = "supervisorOutput";
            this.supervisorOutput.Size = new System.Drawing.Size(116, 70);
            this.supervisorOutput.TabIndex = 6;
            // 
            // supervisorNumber
            // 
            this.supervisorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisorNumber.Location = new System.Drawing.Point(162, 64);
            this.supervisorNumber.Name = "supervisorNumber";
            this.supervisorNumber.Size = new System.Drawing.Size(100, 26);
            this.supervisorNumber.TabIndex = 4;
            // 
            // teamLeadTab
            // 
            this.teamLeadTab.Controls.Add(this.groupBox4);
            this.teamLeadTab.Location = new System.Drawing.Point(4, 22);
            this.teamLeadTab.Name = "teamLeadTab";
            this.teamLeadTab.Size = new System.Drawing.Size(488, 321);
            this.teamLeadTab.TabIndex = 3;
            this.teamLeadTab.Text = "Team Leader";
            this.teamLeadTab.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tlHours);
            this.groupBox4.Controls.Add(this.tlBonus);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.tlButton);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tlOutput);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.tlName);
            this.groupBox4.Controls.Add(this.tlPayrate);
            this.groupBox4.Controls.Add(this.tlNumber);
            this.groupBox4.Controls.Add(this.tlShiftNumber);
            this.groupBox4.Location = new System.Drawing.Point(-4, -2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(508, 327);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // tlHours
            // 
            this.tlHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlHours.Location = new System.Drawing.Point(209, 176);
            this.tlHours.Name = "tlHours";
            this.tlHours.Size = new System.Drawing.Size(100, 26);
            this.tlHours.TabIndex = 15;
            // 
            // tlBonus
            // 
            this.tlBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlBonus.Location = new System.Drawing.Point(209, 144);
            this.tlBonus.Name = "tlBonus";
            this.tlBonus.Size = new System.Drawing.Size(100, 26);
            this.tlBonus.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(19, 176);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 20);
            this.label17.TabIndex = 13;
            this.label17.Text = "Employee Hours";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "Employee Bonus";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Employee Payrate";
            // 
            // tlButton
            // 
            this.tlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlButton.Location = new System.Drawing.Point(12, 220);
            this.tlButton.Name = "tlButton";
            this.tlButton.Size = new System.Drawing.Size(104, 70);
            this.tlButton.TabIndex = 10;
            this.tlButton.Text = "Create Teamleader";
            this.tlButton.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Employee Shift Number";
            // 
            // tlOutput
            // 
            this.tlOutput.BackColor = System.Drawing.Color.LightGray;
            this.tlOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlOutput.Location = new System.Drawing.Point(209, 220);
            this.tlOutput.Name = "tlOutput";
            this.tlOutput.Size = new System.Drawing.Size(116, 70);
            this.tlOutput.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Employee Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Employee Name";
            // 
            // tlName
            // 
            this.tlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlName.Location = new System.Drawing.Point(209, 16);
            this.tlName.Name = "tlName";
            this.tlName.Size = new System.Drawing.Size(100, 26);
            this.tlName.TabIndex = 4;
            // 
            // tlPayrate
            // 
            this.tlPayrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlPayrate.Location = new System.Drawing.Point(209, 112);
            this.tlPayrate.Name = "tlPayrate";
            this.tlPayrate.Size = new System.Drawing.Size(100, 26);
            this.tlPayrate.TabIndex = 9;
            // 
            // tlNumber
            // 
            this.tlNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlNumber.Location = new System.Drawing.Point(209, 48);
            this.tlNumber.Name = "tlNumber";
            this.tlNumber.Size = new System.Drawing.Size(100, 26);
            this.tlNumber.TabIndex = 5;
            // 
            // tlShiftNumber
            // 
            this.tlShiftNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlShiftNumber.Location = new System.Drawing.Point(209, 80);
            this.tlShiftNumber.Name = "tlShiftNumber";
            this.tlShiftNumber.Size = new System.Drawing.Size(100, 26);
            this.tlShiftNumber.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(537, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 191);
            this.button1.TabIndex = 1;
            this.button1.Text = "CLOSE ALL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.tabControl1.ResumeLayout(false);
            this.employeeTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.productionWorkerTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.supervisorTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.teamLeadTab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage employeeTab;
        private System.Windows.Forms.TabPage productionWorkerTab;
        private System.Windows.Forms.Label employeeOutput;
        private System.Windows.Forms.Button employeeButt;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label productionLabel;
        private System.Windows.Forms.Button productionButton;
        private System.Windows.Forms.TextBox prodPayRateText;
        private System.Windows.Forms.TextBox prodShiftNumberText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prodNumText;
        private System.Windows.Forms.TextBox prodNameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage supervisorTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox supervisorBonus;
        private System.Windows.Forms.TextBox supervisorSalary;
        private System.Windows.Forms.TextBox supervisorName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button supervisorButton;
        private System.Windows.Forms.Label supervisorOutput;
        private System.Windows.Forms.TextBox supervisorNumber;
        private System.Windows.Forms.TabPage teamLeadTab;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tlHours;
        private System.Windows.Forms.TextBox tlBonus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button tlButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tlOutput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tlName;
        private System.Windows.Forms.TextBox tlPayrate;
        private System.Windows.Forms.TextBox tlNumber;
        private System.Windows.Forms.TextBox tlShiftNumber;
    }
}


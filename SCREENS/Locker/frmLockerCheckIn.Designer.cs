﻿namespace SGMOSOL.SCREENS
{
    partial class frmLockerCheckIn
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
            this.txtOldReceipt = new System.Windows.Forms.TextBox();
            this.lblFreeReceipt = new System.Windows.Forms.Label();
            this.chkAllowFreeReceipt = new System.Windows.Forms.CheckBox();
            this.txtRoomSrch = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtLkrAvlbleCt = new System.Windows.Forms.TextBox();
            this.lbAvailableLkrCt = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtmobno = new System.Windows.Forms.TextBox();
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.dtpCheckOutTime = new System.Windows.Forms.DateTimePicker();
            this.Label10 = new System.Windows.Forms.Label();
            this.dtpCheckInTime = new System.Windows.Forms.DateTimePicker();
            this.txtNoOfLockers = new System.Windows.Forms.TextBox();
            this.nudRent = new System.Windows.Forms.NumericUpDown();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.Label6 = new System.Windows.Forms.Label();
            this.chkLockers = new System.Windows.Forms.CheckedListBox();
            this.lblRent = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtVchNo = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.Label9 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.nudAdvance = new System.Windows.Forms.NumericUpDown();
            this.txtDays = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdvance)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOldReceipt
            // 
            this.txtOldReceipt.BackColor = System.Drawing.Color.White;
            this.txtOldReceipt.Location = new System.Drawing.Point(371, 51);
            this.txtOldReceipt.MaxLength = 15;
            this.txtOldReceipt.Name = "txtOldReceipt";
            this.txtOldReceipt.Size = new System.Drawing.Size(89, 20);
            this.txtOldReceipt.TabIndex = 114;
            // 
            // lblFreeReceipt
            // 
            this.lblFreeReceipt.AutoSize = true;
            this.lblFreeReceipt.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.lblFreeReceipt.Location = new System.Drawing.Point(252, 51);
            this.lblFreeReceipt.Name = "lblFreeReceipt";
            this.lblFreeReceipt.Size = new System.Drawing.Size(107, 18);
            this.lblFreeReceipt.TabIndex = 113;
            this.lblFreeReceipt.Text = "Re-Use Receipt";
            this.lblFreeReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkAllowFreeReceipt
            // 
            this.chkAllowFreeReceipt.AutoSize = true;
            this.chkAllowFreeReceipt.Location = new System.Drawing.Point(228, 55);
            this.chkAllowFreeReceipt.Name = "chkAllowFreeReceipt";
            this.chkAllowFreeReceipt.Size = new System.Drawing.Size(15, 14);
            this.chkAllowFreeReceipt.TabIndex = 112;
            this.chkAllowFreeReceipt.UseVisualStyleBackColor = true;
            this.chkAllowFreeReceipt.CheckedChanged += new System.EventHandler(this.chkAllowFreeReceipt_CheckedChanged);
            // 
            // txtRoomSrch
            // 
            this.txtRoomSrch.BackColor = System.Drawing.Color.White;
            this.txtRoomSrch.Location = new System.Drawing.Point(544, 53);
            this.txtRoomSrch.MaxLength = 3;
            this.txtRoomSrch.Name = "txtRoomSrch";
            this.txtRoomSrch.Size = new System.Drawing.Size(219, 20);
            this.txtRoomSrch.TabIndex = 93;
            this.txtRoomSrch.TextChanged += new System.EventHandler(this.txtRoomSrch_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Label2.Location = new System.Drawing.Point(481, 53);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(50, 18);
            this.Label2.TabIndex = 111;
            this.Label2.Text = "Locker";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLkrAvlbleCt
            // 
            this.txtLkrAvlbleCt.BackColor = System.Drawing.Color.White;
            this.txtLkrAvlbleCt.Enabled = false;
            this.txtLkrAvlbleCt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLkrAvlbleCt.Location = new System.Drawing.Point(674, 12);
            this.txtLkrAvlbleCt.Name = "txtLkrAvlbleCt";
            this.txtLkrAvlbleCt.ReadOnly = true;
            this.txtLkrAvlbleCt.Size = new System.Drawing.Size(89, 22);
            this.txtLkrAvlbleCt.TabIndex = 110;
            this.txtLkrAvlbleCt.TabStop = false;
            // 
            // lbAvailableLkrCt
            // 
            this.lbAvailableLkrCt.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.lbAvailableLkrCt.Location = new System.Drawing.Point(481, 13);
            this.lbAvailableLkrCt.Name = "lbAvailableLkrCt";
            this.lbAvailableLkrCt.Size = new System.Drawing.Size(187, 21);
            this.lbAvailableLkrCt.TabIndex = 109;
            this.lbAvailableLkrCt.Text = "Available No.of Lockers";
            this.lbAvailableLkrCt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Label15.Location = new System.Drawing.Point(15, 174);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(59, 18);
            this.Label15.TabIndex = 79;
            this.Label15.Text = "Mob No";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtmobno
            // 
            this.txtmobno.BackColor = System.Drawing.Color.White;
            this.txtmobno.Location = new System.Drawing.Point(116, 170);
            this.txtmobno.MaxLength = 100;
            this.txtmobno.Name = "txtmobno";
            this.txtmobno.Size = new System.Drawing.Size(157, 20);
            this.txtmobno.TabIndex = 80;
            this.txtmobno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobno_KeyPress);
            // 
            // txtCounter
            // 
            this.txtCounter.BackColor = System.Drawing.Color.White;
            this.txtCounter.Enabled = false;
            this.txtCounter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounter.Location = new System.Drawing.Point(371, 11);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.ReadOnly = true;
            this.txtCounter.Size = new System.Drawing.Size(89, 22);
            this.txtCounter.TabIndex = 108;
            this.txtCounter.TabStop = false;
            // 
            // Label13
            // 
            this.Label13.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Label13.Location = new System.Drawing.Point(291, 12);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(74, 21);
            this.Label13.TabIndex = 107;
            this.Label13.Text = "Counter";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Label14.Location = new System.Drawing.Point(13, 16);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(38, 18);
            this.Label14.TabIndex = 105;
            this.Label14.Text = "User";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Enabled = false;
            this.txtUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(117, 12);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(84, 22);
            this.txtUser.TabIndex = 106;
            this.txtUser.TabStop = false;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Label12.ForeColor = System.Drawing.Color.Black;
            this.Label12.Location = new System.Drawing.Point(13, 454);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(41, 18);
            this.Label12.TabIndex = 96;
            this.Label12.Text = "Time";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpCheckOutTime
            // 
            this.dtpCheckOutTime.Checked = false;
            this.dtpCheckOutTime.CustomFormat = "hh:mm tt";
            this.dtpCheckOutTime.Enabled = false;
            this.dtpCheckOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOutTime.Location = new System.Drawing.Point(116, 450);
            this.dtpCheckOutTime.Name = "dtpCheckOutTime";
            this.dtpCheckOutTime.Size = new System.Drawing.Size(100, 20);
            this.dtpCheckOutTime.TabIndex = 98;
            this.dtpCheckOutTime.Value = new System.DateTime(2005, 9, 20, 0, 0, 0, 0);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Label10.Location = new System.Drawing.Point(293, 97);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(41, 18);
            this.Label10.TabIndex = 104;
            this.Label10.Text = "Time";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpCheckInTime
            // 
            this.dtpCheckInTime.Checked = false;
            this.dtpCheckInTime.CustomFormat = "hh:mm tt";
            this.dtpCheckInTime.Enabled = false;
            this.dtpCheckInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckInTime.Location = new System.Drawing.Point(371, 93);
            this.dtpCheckInTime.Name = "dtpCheckInTime";
            this.dtpCheckInTime.Size = new System.Drawing.Size(90, 20);
            this.dtpCheckInTime.TabIndex = 76;
            this.dtpCheckInTime.Value = new System.DateTime(2013, 8, 24, 0, 0, 0, 0);
            // 
            // txtNoOfLockers
            // 
            this.txtNoOfLockers.BackColor = System.Drawing.Color.White;
            this.txtNoOfLockers.Location = new System.Drawing.Point(116, 288);
            this.txtNoOfLockers.MaxLength = 3;
            this.txtNoOfLockers.Name = "txtNoOfLockers";
            this.txtNoOfLockers.Size = new System.Drawing.Size(100, 20);
            this.txtNoOfLockers.TabIndex = 87;
            this.txtNoOfLockers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNoOfLockers.TextChanged += new System.EventHandler(this.txtNoOfLockers_TextChanged);
            this.txtNoOfLockers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfLockers_KeyPress);
            // 
            // nudRent
            // 
            this.nudRent.DecimalPlaces = 2;
            this.nudRent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRent.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudRent.Location = new System.Drawing.Point(116, 369);
            this.nudRent.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nudRent.Name = "nudRent";
            this.nudRent.ReadOnly = true;
            this.nudRent.Size = new System.Drawing.Size(100, 22);
            this.nudRent.TabIndex = 91;
            this.nudRent.TabStop = false;
            this.nudRent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Checked = false;
            this.dtpCheckOut.CustomFormat = "dd/MM/yyyy";
            this.dtpCheckOut.Enabled = false;
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut.Location = new System.Drawing.Point(116, 410);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(100, 20);
            this.dtpCheckOut.TabIndex = 94;
            this.dtpCheckOut.Value = new System.DateTime(2005, 9, 20, 0, 0, 0, 0);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Label6.Location = new System.Drawing.Point(481, 93);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(57, 18);
            this.Label6.TabIndex = 95;
            this.Label6.Text = "Lockers";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkLockers
            // 
            this.chkLockers.CheckOnClick = true;
            this.chkLockers.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.chkLockers.FormattingEnabled = true;
            this.chkLockers.Location = new System.Drawing.Point(544, 100);
            this.chkLockers.MultiColumn = true;
            this.chkLockers.Name = "chkLockers";
            this.chkLockers.Size = new System.Drawing.Size(219, 340);
            this.chkLockers.TabIndex = 97;
            this.chkLockers.SelectedIndexChanged += new System.EventHandler(this.chkLockers_SelectedIndexChanged);
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.lblRent.Location = new System.Drawing.Point(13, 373);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(44, 18);
            this.lblRent.TabIndex = 90;
            this.lblRent.Text = "Dengi";
            this.lblRent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Label7.Location = new System.Drawing.Point(13, 414);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(68, 18);
            this.Label7.TabIndex = 92;
            this.Label7.Text = "Out Date";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Label5.Location = new System.Drawing.Point(13, 333);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 18);
            this.Label5.TabIndex = 88;
            this.Label5.Text = "Advance";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Label4.Location = new System.Drawing.Point(13, 292);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(98, 18);
            this.Label4.TabIndex = 85;
            this.Label4.Text = "No of Lockers";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Label3.Location = new System.Drawing.Point(14, 253);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(41, 18);
            this.Label3.TabIndex = 83;
            this.Label3.Text = "Days";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Label1.Location = new System.Drawing.Point(14, 215);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 18);
            this.Label1.TabIndex = 81;
            this.Label1.Text = "Place";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPlace
            // 
            this.txtPlace.BackColor = System.Drawing.Color.White;
            this.txtPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlace.Location = new System.Drawing.Point(117, 210);
            this.txtPlace.MaxLength = 100;
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(157, 26);
            this.txtPlace.TabIndex = 82;
            this.txtPlace.TextChanged += new System.EventHandler(this.txtPlace_TextChanged);
            this.txtPlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlace_KeyPress);
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.lblRemarks.Location = new System.Drawing.Point(14, 136);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(47, 18);
            this.lblRemarks.TabIndex = 77;
            this.lblRemarks.Text = "Name";
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(116, 132);
            this.txtName.MaxLength = 120;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(345, 26);
            this.txtName.TabIndex = 78;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtVchNo
            // 
            this.txtVchNo.BackColor = System.Drawing.Color.White;
            this.txtVchNo.Enabled = false;
            this.txtVchNo.Location = new System.Drawing.Point(117, 53);
            this.txtVchNo.Name = "txtVchNo";
            this.txtVchNo.ReadOnly = true;
            this.txtVchNo.Size = new System.Drawing.Size(84, 20);
            this.txtVchNo.TabIndex = 73;
            this.txtVchNo.TabStop = false;
            this.txtVchNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVchNo.TextChanged += new System.EventHandler(this.txtVchNo_TextChanged);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Label11.Location = new System.Drawing.Point(13, 57);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(78, 18);
            this.Label11.TabIndex = 72;
            this.Label11.Text = "Receipt No";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Checked = false;
            this.dtpCheckIn.CustomFormat = "dd/MM/yyyy";
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn.Location = new System.Drawing.Point(117, 93);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(99, 20);
            this.dtpCheckIn.TabIndex = 75;
            this.dtpCheckIn.Value = new System.DateTime(2013, 8, 24, 0, 0, 0, 0);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Label9.ForeColor = System.Drawing.Color.Black;
            this.Label9.Location = new System.Drawing.Point(14, 97);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(39, 18);
            this.Label9.TabIndex = 74;
            this.Label9.Text = "Date";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::SGMOSOL.ResourceMain.Search;
            this.btnSearch.Location = new System.Drawing.Point(25, 484);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 46);
            this.btnSearch.TabIndex = 115;
            this.btnSearch.Text = "&Find /\r\nSearch";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.CausesValidation = false;
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::SGMOSOL.ResourceMain._new;
            this.btnNew.Location = new System.Drawing.Point(284, 484);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(97, 46);
            this.btnNew.TabIndex = 116;
            this.btnNew.Text = "&New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SGMOSOL.ResourceMain.Save;
            this.btnSave.Location = new System.Drawing.Point(411, 484);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 46);
            this.btnSave.TabIndex = 117;
            this.btnSave.Text = "&Save\r\n / Print";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::SGMOSOL.ResourceMain.Close;
            this.btnClose.Location = new System.Drawing.Point(663, 484);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 46);
            this.btnClose.TabIndex = 119;
            this.btnClose.Text = "&Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::SGMOSOL.ResourceMain.Print;
            this.btnPrint.Location = new System.Drawing.Point(544, 484);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(87, 46);
            this.btnPrint.TabIndex = 118;
            this.btnPrint.Text = "&Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // nudAdvance
            // 
            this.nudAdvance.DecimalPlaces = 2;
            this.nudAdvance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAdvance.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudAdvance.Location = new System.Drawing.Point(116, 329);
            this.nudAdvance.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nudAdvance.Name = "nudAdvance";
            this.nudAdvance.ReadOnly = true;
            this.nudAdvance.Size = new System.Drawing.Size(100, 22);
            this.nudAdvance.TabIndex = 89;
            this.nudAdvance.TabStop = false;
            this.nudAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDays
            // 
            this.txtDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDays.FormattingEnabled = true;
            this.txtDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.txtDays.Location = new System.Drawing.Point(116, 253);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 21);
            this.txtDays.TabIndex = 84;
            this.txtDays.SelectedIndexChanged += new System.EventHandler(this.txtDays_SelectedIndexChanged);
            this.txtDays.Enter += new System.EventHandler(this.txtDays_Enter);
            // 
            // frmLockerCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 540);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.nudAdvance);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtOldReceipt);
            this.Controls.Add(this.lblFreeReceipt);
            this.Controls.Add(this.chkAllowFreeReceipt);
            this.Controls.Add(this.txtRoomSrch);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtLkrAvlbleCt);
            this.Controls.Add(this.lbAvailableLkrCt);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.txtmobno);
            this.Controls.Add(this.txtCounter);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.dtpCheckOutTime);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.dtpCheckInTime);
            this.Controls.Add(this.txtNoOfLockers);
            this.Controls.Add(this.nudRent);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.chkLockers);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtVchNo);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.Label9);
            this.Name = "frmLockerCheckIn";
            this.Text = "Locker In-Time";
            this.Load += new System.EventHandler(this.frmLockerCheckIn_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLockerCheckIn_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmLockerCheckIn_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.nudRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdvance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtOldReceipt;
        internal System.Windows.Forms.Label lblFreeReceipt;
        internal System.Windows.Forms.CheckBox chkAllowFreeReceipt;
        internal System.Windows.Forms.TextBox txtRoomSrch;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtLkrAvlbleCt;
        internal System.Windows.Forms.Label lbAvailableLkrCt;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtmobno;
        internal System.Windows.Forms.TextBox txtCounter;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.TextBox txtUser;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.DateTimePicker dtpCheckOutTime;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.DateTimePicker dtpCheckInTime;
        internal System.Windows.Forms.TextBox txtNoOfLockers;
        internal System.Windows.Forms.NumericUpDown nudRent;
        internal System.Windows.Forms.DateTimePicker dtpCheckOut;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.CheckedListBox chkLockers;
        internal System.Windows.Forms.Label lblRent;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtPlace;
        internal System.Windows.Forms.Label lblRemarks;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtVchNo;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.DateTimePicker dtpCheckIn;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.NumericUpDown nudAdvance;
        private System.Windows.Forms.ComboBox txtDays;
    }
}
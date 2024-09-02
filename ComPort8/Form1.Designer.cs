namespace ComPort
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chBoxRTSEnable = new System.Windows.Forms.CheckBox();
            this.chBoxDtrEnable = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxComPort = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSendData = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblDataOutLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lblDataInLength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBoxDataIN = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToTxtFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_appendOrOverwriteText = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox_writeLineOrwriteText = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLOSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transmiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.receiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.dataPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveToDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.DataScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBoxRTSEnable);
            this.groupBox1.Controls.Add(this.chBoxDtrEnable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBoxComPort);
            this.groupBox1.Location = new System.Drawing.Point(3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "포트 설정";
            // 
            // chBoxRTSEnable
            // 
            this.chBoxRTSEnable.AutoSize = true;
            this.chBoxRTSEnable.Font = new System.Drawing.Font("굴림", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chBoxRTSEnable.Location = new System.Drawing.Point(112, 155);
            this.chBoxRTSEnable.Name = "chBoxRTSEnable";
            this.chBoxRTSEnable.Size = new System.Drawing.Size(83, 14);
            this.chBoxRTSEnable.TabIndex = 10;
            this.chBoxRTSEnable.Text = "RTS ENABLE";
            this.chBoxRTSEnable.UseVisualStyleBackColor = true;
            this.chBoxRTSEnable.CheckedChanged += new System.EventHandler(this.chBoxRTSEnable_CheckedChanged);
            // 
            // chBoxDtrEnable
            // 
            this.chBoxDtrEnable.AutoSize = true;
            this.chBoxDtrEnable.Font = new System.Drawing.Font("굴림", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chBoxDtrEnable.Location = new System.Drawing.Point(17, 155);
            this.chBoxDtrEnable.Name = "chBoxDtrEnable";
            this.chBoxDtrEnable.Size = new System.Drawing.Size(84, 14);
            this.chBoxDtrEnable.TabIndex = 10;
            this.chBoxDtrEnable.Text = "DTR ENABLE";
            this.chBoxDtrEnable.UseVisualStyleBackColor = true;
            this.chBoxDtrEnable.CheckedChanged += new System.EventHandler(this.chBoxDtrEnable_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 8);
            this.label5.TabIndex = 9;
            this.label5.Text = "패리트비트";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 8);
            this.label4.TabIndex = 8;
            this.label4.Text = "정지비트";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 8);
            this.label3.TabIndex = 7;
            this.label3.Text = "데이터길이";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 8);
            this.label2.TabIndex = 6;
            this.label2.Text = "전송 속도";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "포트 번호";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "38400",
            "57600",
            "115200"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(103, 45);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(91, 20);
            this.cBoxBaudRate.TabIndex = 4;
            this.cBoxBaudRate.Text = "9600";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(103, 71);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(91, 20);
            this.cBoxDataBits.TabIndex = 3;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "ONE",
            "TWO"});
            this.cBoxStopBits.Location = new System.Drawing.Point(103, 97);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(91, 20);
            this.cBoxStopBits.TabIndex = 2;
            this.cBoxStopBits.Text = "One";
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(103, 123);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(91, 20);
            this.cBoxParityBits.TabIndex = 1;
            this.cBoxParityBits.Text = "None";
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.Location = new System.Drawing.Point(103, 19);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(91, 20);
            this.cBoxComPort.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(211, 31);
            this.progressBar1.TabIndex = 1;
            // 
            // btnSendData
            // 
            this.btnSendData.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendData.Location = new System.Drawing.Point(332, 0);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(71, 23);
            this.btnSendData.TabIndex = 2;
            this.btnSendData.Text = "보내기";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBoxDataOut.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tBoxDataOut.Location = new System.Drawing.Point(0, 0);
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(332, 23);
            this.tBoxDataOut.TabIndex = 3;
            this.tBoxDataOut.TextChanged += new System.EventHandler(this.tBoxDataOut_TextChanged);
            this.tBoxDataOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxDataOut_KeyDown);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblDataOutLength);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(258, -3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(149, 30);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            // 
            // lblDataOutLength
            // 
            this.lblDataOutLength.AutoSize = true;
            this.lblDataOutLength.Location = new System.Drawing.Point(128, 13);
            this.lblDataOutLength.Name = "lblDataOutLength";
            this.lblDataOutLength.Size = new System.Drawing.Size(17, 12);
            this.lblDataOutLength.TabIndex = 6;
            this.lblDataOutLength.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 8);
            this.label6.TabIndex = 5;
            this.label6.Text = "보낸 데이터 길이  :";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lblDataInLength);
            this.groupBox11.Controls.Add(this.label8);
            this.groupBox11.Location = new System.Drawing.Point(436, -3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(149, 30);
            this.groupBox11.TabIndex = 4;
            this.groupBox11.TabStop = false;
            // 
            // lblDataInLength
            // 
            this.lblDataInLength.AutoSize = true;
            this.lblDataInLength.Location = new System.Drawing.Point(118, 13);
            this.lblDataInLength.Name = "lblDataInLength";
            this.lblDataInLength.Size = new System.Drawing.Size(17, 12);
            this.lblDataInLength.TabIndex = 6;
            this.lblDataInLength.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 8);
            this.label8.TabIndex = 5;
            this.label8.Text = "받은 데이터 길이 :";
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tBoxDataIN.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tBoxDataIN.Location = new System.Drawing.Point(3, 48);
            this.tBoxDataIN.Multiline = true;
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBoxDataIN.Size = new System.Drawing.Size(403, 133);
            this.tBoxDataIN.TabIndex = 3;
            this.tBoxDataIN.WordWrap = false;
            this.tBoxDataIN.TextChanged += new System.EventHandler(this.tBoxDataOut_TextChanged);
            this.tBoxDataIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxDataOut_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cOMControlToolStripMenuItem,
            this.transmiterToolStripMenuItem,
            this.receiverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToTxtFileToolStripMenuItem,
            this.SaveToDatabase,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
            this.fileToolStripMenuItem.Text = "파일";
            // 
            // saveToTxtFileToolStripMenuItem
            // 
            this.saveToTxtFileToolStripMenuItem.Checked = true;
            this.saveToTxtFileToolStripMenuItem.CheckOnClick = true;
            this.saveToTxtFileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveToTxtFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_appendOrOverwriteText,
            this.toolStripComboBox_writeLineOrwriteText});
            this.saveToTxtFileToolStripMenuItem.Name = "saveToTxtFileToolStripMenuItem";
            this.saveToTxtFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToTxtFileToolStripMenuItem.Text = "저장 방식 설정";
            // 
            // toolStripComboBox_appendOrOverwriteText
            // 
            this.toolStripComboBox_appendOrOverwriteText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_appendOrOverwriteText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_appendOrOverwriteText.Items.AddRange(new object[] {
            "데이터 추가",
            "데이터 새로 저장"});
            this.toolStripComboBox_appendOrOverwriteText.Name = "toolStripComboBox_appendOrOverwriteText";
            this.toolStripComboBox_appendOrOverwriteText.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox_appendOrOverwriteText.DropDownClosed += new System.EventHandler(this.toolStripComboBox_appendOrOverwriteText_DropDownClosed);
            // 
            // toolStripComboBox_writeLineOrwriteText
            // 
            this.toolStripComboBox_writeLineOrwriteText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_writeLineOrwriteText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_writeLineOrwriteText.Items.AddRange(new object[] {
            "줄바꿈",
            "쓰기"});
            this.toolStripComboBox_writeLineOrwriteText.Name = "toolStripComboBox_writeLineOrwriteText";
            this.toolStripComboBox_writeLineOrwriteText.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "종료";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cOMControlToolStripMenuItem
            // 
            this.cOMControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPENToolStripMenuItem,
            this.cLOSEToolStripMenuItem});
            this.cOMControlToolStripMenuItem.Name = "cOMControlToolStripMenuItem";
            this.cOMControlToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.cOMControlToolStripMenuItem.Text = "연결 관리";
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oPENToolStripMenuItem.Text = "연결";
            this.oPENToolStripMenuItem.Click += new System.EventHandler(this.oPENToolStripMenuItem_Click);
            // 
            // cLOSEToolStripMenuItem
            // 
            this.cLOSEToolStripMenuItem.Name = "cLOSEToolStripMenuItem";
            this.cLOSEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cLOSEToolStripMenuItem.Text = "연결 종료";
            this.cLOSEToolStripMenuItem.Click += new System.EventHandler(this.cLOSEToolStripMenuItem_Click);
            // 
            // transmiterToolStripMenuItem
            // 
            this.transmiterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.endLineToolStripMenuItem});
            this.transmiterToolStripMenuItem.Name = "transmiterToolStripMenuItem";
            this.transmiterToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.transmiterToolStripMenuItem.Text = "전송 관리";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "비우기";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // endLineToolStripMenuItem
            // 
            this.endLineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.endLineToolStripMenuItem.Name = "endLineToolStripMenuItem";
            this.endLineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.endLineToolStripMenuItem.Text = "라인 관리";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "없음",
            "둘다",
            "새 라인",
            "가장 앞으로"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox2.DropDownClosed += new System.EventHandler(this.toolStripComboBox2_DropDownClosed);
            // 
            // receiverToolStripMenuItem
            // 
            this.receiverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem1,
            this.showDataToolStripMenuItem,
            this.dataPositionToolStripMenuItem});
            this.receiverToolStripMenuItem.Name = "receiverToolStripMenuItem";
            this.receiverToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.receiverToolStripMenuItem.Text = "응답 관리";
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem1.Text = "지우기";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
            // 
            // showDataToolStripMenuItem
            // 
            this.showDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.showDataToolStripMenuItem.Name = "showDataToolStripMenuItem";
            this.showDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showDataToolStripMenuItem.Text = "보여주는 방식";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "항상 새로고침",
            "기존 데이터에 추가"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // dataPositionToolStripMenuItem
            // 
            this.dataPositionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox3});
            this.dataPositionToolStripMenuItem.Name = "dataPositionToolStripMenuItem";
            this.dataPositionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataPositionToolStripMenuItem.Text = "새 데이터 위치";
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox3.Items.AddRange(new object[] {
            "위",
            "아래"});
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 23);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.panel3);
            this.groupBox12.Controls.Add(this.tBoxDataIN);
            this.groupBox12.Location = new System.Drawing.Point(220, 5);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(409, 184);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "화면";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tBoxDataOut);
            this.panel3.Controls.Add(this.btnSendData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 23);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.panel1.Size = new System.Drawing.Size(639, 230);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.groupBox7);
            this.panel2.Controls.Add(this.groupBox11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 31);
            this.panel2.TabIndex = 8;
            // 
            // SaveToDatabase
            // 
            this.SaveToDatabase.Checked = true;
            this.SaveToDatabase.CheckOnClick = true;
            this.SaveToDatabase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveToDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataScreenToolStripMenuItem});
            this.SaveToDatabase.Name = "SaveToDatabase";
            this.SaveToDatabase.Size = new System.Drawing.Size(180, 22);
            this.SaveToDatabase.Text = "데이터베이스";
            // 
            // DataScreenToolStripMenuItem
            // 
            this.DataScreenToolStripMenuItem.Name = "DataScreenToolStripMenuItem";
            this.DataScreenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DataScreenToolStripMenuItem.Text = "데이터 창";
            this.DataScreenToolStripMenuItem.Click += new System.EventHandler(this.DataScreenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 255);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1033, 609);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(655, 294);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "시리얼 통신";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxComPort;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chBoxRTSEnable;
        private System.Windows.Forms.CheckBox chBoxDtrEnable;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblDataOutLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label lblDataInLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLOSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transmiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ToolStripMenuItem dataPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem saveToTxtFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_appendOrOverwriteText;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_writeLineOrwriteText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveToDatabase;
        private System.Windows.Forms.ToolStripMenuItem DataScreenToolStripMenuItem;
    }
}


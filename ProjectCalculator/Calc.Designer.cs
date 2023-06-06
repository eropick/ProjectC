namespace ProjectCalculator
{
    partial class formCalc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCalc));
            this.txtCalcLine = new System.Windows.Forms.TextBox();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmView = new System.Windows.Forms.ToolStripMenuItem();
            this.txtResultLine = new System.Windows.Forms.TextBox();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbArc = new System.Windows.Forms.RadioButton();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.rbDegToRad = new System.Windows.Forms.RadioButton();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnLogE = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnLBracket = new System.Windows.Forms.Button();
            this.btnRBracket = new System.Windows.Forms.Button();
            this.btn1DivideX = new System.Windows.Forms.Button();
            this.btnEpowN = new System.Windows.Forms.Button();
            this.btnXpow2 = new System.Windows.Forms.Button();
            this.btnXpowN = new System.Windows.Forms.Button();
            this.btnAbsX = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.stripTime = new System.Windows.Forms.StatusStrip();
            this.presentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbTri = new System.Windows.Forms.GroupBox();
            this.gbAngle = new System.Windows.Forms.GroupBox();
            this.rbRadToDeg = new System.Windows.Forms.RadioButton();
            this.presentTimer = new System.Windows.Forms.Timer(this.components);
            this.ofdLoad = new System.Windows.Forms.OpenFileDialog();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.msMenu.SuspendLayout();
            this.stripTime.SuspendLayout();
            this.gbTri.SuspendLayout();
            this.gbAngle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCalcLine
            // 
            this.txtCalcLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCalcLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCalcLine.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCalcLine.Location = new System.Drawing.Point(12, 36);
            this.txtCalcLine.Multiline = true;
            this.txtCalcLine.Name = "txtCalcLine";
            this.txtCalcLine.ReadOnly = true;
            this.txtCalcLine.Size = new System.Drawing.Size(669, 141);
            this.txtCalcLine.TabIndex = 0;
            this.txtCalcLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmHistory});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(693, 33);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLoadFile,
            this.tsmSaveFile});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(55, 29);
            this.tsmFile.Text = "File";
            // 
            // tsmLoadFile
            // 
            this.tsmLoadFile.Name = "tsmLoadFile";
            this.tsmLoadFile.Size = new System.Drawing.Size(232, 34);
            this.tsmLoadFile.Text = "Load Calc File ";
            this.tsmLoadFile.Click += new System.EventHandler(this.tsmLoadFile_Click);
            // 
            // tsmSaveFile
            // 
            this.tsmSaveFile.Name = "tsmSaveFile";
            this.tsmSaveFile.Size = new System.Drawing.Size(232, 34);
            this.tsmSaveFile.Text = "Save Calc File";
            this.tsmSaveFile.Click += new System.EventHandler(this.tsmSaveFile_Click);
            // 
            // tsmHistory
            // 
            this.tsmHistory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmView});
            this.tsmHistory.Name = "tsmHistory";
            this.tsmHistory.Size = new System.Drawing.Size(85, 29);
            this.tsmHistory.Text = "History";
            // 
            // tsmView
            // 
            this.tsmView.Name = "tsmView";
            this.tsmView.Size = new System.Drawing.Size(215, 34);
            this.tsmView.Text = "View History";
            this.tsmView.Click += new System.EventHandler(this.tsmView_Click);
            // 
            // txtResultLine
            // 
            this.txtResultLine.BackColor = System.Drawing.SystemColors.Info;
            this.txtResultLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultLine.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultLine.Location = new System.Drawing.Point(12, 183);
            this.txtResultLine.Multiline = true;
            this.txtResultLine.Name = "txtResultLine";
            this.txtResultLine.ReadOnly = true;
            this.txtResultLine.Size = new System.Drawing.Size(669, 58);
            this.txtResultLine.TabIndex = 2;
            this.txtResultLine.Text = "=";
            this.txtResultLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(6, 39);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(97, 29);
            this.rbNormal.TabIndex = 3;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // rbArc
            // 
            this.rbArc.AutoSize = true;
            this.rbArc.Location = new System.Drawing.Point(168, 39);
            this.rbArc.Name = "rbArc";
            this.rbArc.Size = new System.Drawing.Size(64, 29);
            this.rbArc.TabIndex = 4;
            this.rbArc.Text = "Arc";
            this.rbArc.UseVisualStyleBackColor = true;
            this.rbArc.CheckedChanged += new System.EventHandler(this.rbArc_CheckedChanged);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(402, 540);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(77, 70);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(500, 540);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(77, 70);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(597, 540);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(77, 70);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(402, 633);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(77, 70);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(500, 633);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(77, 70);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(597, 633);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(77, 70);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(402, 728);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(77, 70);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(500, 728);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(77, 70);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(597, 728);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(77, 70);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(500, 448);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(77, 70);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDot.Location = new System.Drawing.Point(597, 448);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(77, 70);
            this.btnDot.TabIndex = 15;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSign.Location = new System.Drawing.Point(402, 448);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(77, 70);
            this.btnSign.TabIndex = 16;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.IndianRed;
            this.btnEqual.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.Location = new System.Drawing.Point(597, 361);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(77, 70);
            this.btnEqual.TabIndex = 17;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancle.Location = new System.Drawing.Point(402, 361);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(77, 70);
            this.btnCancle.TabIndex = 18;
            this.btnCancle.Text = "C";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(500, 361);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 70);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Del";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(305, 361);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 70);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rbDegToRad
            // 
            this.rbDegToRad.AutoSize = true;
            this.rbDegToRad.Location = new System.Drawing.Point(154, 39);
            this.rbDegToRad.Name = "rbDegToRad";
            this.rbDegToRad.Size = new System.Drawing.Size(68, 29);
            this.rbDegToRad.TabIndex = 21;
            this.rbDegToRad.Text = "Rad";
            this.rbDegToRad.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(305, 448);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(77, 70);
            this.btnPlus.TabIndex = 22;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(305, 540);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(77, 70);
            this.btnMinus.TabIndex = 23;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(305, 633);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(77, 70);
            this.btnMultiply.TabIndex = 24;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(305, 728);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(77, 70);
            this.btnDivide.TabIndex = 25;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTan.Location = new System.Drawing.Point(210, 448);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(77, 70);
            this.btnTan.TabIndex = 26;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCos.Location = new System.Drawing.Point(115, 448);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(77, 70);
            this.btnCos.TabIndex = 27;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSin.Location = new System.Drawing.Point(16, 448);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(77, 70);
            this.btnSin.TabIndex = 28;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnRoot
            // 
            this.btnRoot.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRoot.Location = new System.Drawing.Point(16, 361);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(77, 70);
            this.btnRoot.TabIndex = 29;
            this.btnRoot.Text = "√";
            this.btnRoot.UseVisualStyleBackColor = true;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // btnLogE
            // 
            this.btnLogE.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogE.Location = new System.Drawing.Point(16, 540);
            this.btnLogE.Name = "btnLogE";
            this.btnLogE.Size = new System.Drawing.Size(77, 70);
            this.btnLogE.TabIndex = 30;
            this.btnLogE.Text = "ln";
            this.btnLogE.UseVisualStyleBackColor = true;
            this.btnLogE.Click += new System.EventHandler(this.btnLogE_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLog.Location = new System.Drawing.Point(115, 540);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(77, 70);
            this.btnLog.TabIndex = 31;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnLBracket
            // 
            this.btnLBracket.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLBracket.Location = new System.Drawing.Point(115, 361);
            this.btnLBracket.Name = "btnLBracket";
            this.btnLBracket.Size = new System.Drawing.Size(77, 70);
            this.btnLBracket.TabIndex = 32;
            this.btnLBracket.Text = "(";
            this.btnLBracket.UseVisualStyleBackColor = true;
            this.btnLBracket.Click += new System.EventHandler(this.btnLBracket_Click);
            // 
            // btnRBracket
            // 
            this.btnRBracket.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRBracket.Location = new System.Drawing.Point(210, 361);
            this.btnRBracket.Name = "btnRBracket";
            this.btnRBracket.Size = new System.Drawing.Size(77, 70);
            this.btnRBracket.TabIndex = 33;
            this.btnRBracket.Text = ")";
            this.btnRBracket.UseVisualStyleBackColor = true;
            this.btnRBracket.Click += new System.EventHandler(this.btnRBracket_Click);
            // 
            // btn1DivideX
            // 
            this.btn1DivideX.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1DivideX.Location = new System.Drawing.Point(210, 540);
            this.btn1DivideX.Name = "btn1DivideX";
            this.btn1DivideX.Size = new System.Drawing.Size(77, 70);
            this.btn1DivideX.TabIndex = 34;
            this.btn1DivideX.Text = "1/x";
            this.btn1DivideX.UseVisualStyleBackColor = true;
            this.btn1DivideX.Click += new System.EventHandler(this.btn1DivideX_Click);
            // 
            // btnEpowN
            // 
            this.btnEpowN.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEpowN.Location = new System.Drawing.Point(16, 633);
            this.btnEpowN.Name = "btnEpowN";
            this.btnEpowN.Size = new System.Drawing.Size(77, 70);
            this.btnEpowN.TabIndex = 35;
            this.btnEpowN.Text = "e^n";
            this.btnEpowN.UseVisualStyleBackColor = true;
            this.btnEpowN.Click += new System.EventHandler(this.btnEpowN_Click);
            // 
            // btnXpow2
            // 
            this.btnXpow2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXpow2.Location = new System.Drawing.Point(115, 633);
            this.btnXpow2.Name = "btnXpow2";
            this.btnXpow2.Size = new System.Drawing.Size(77, 70);
            this.btnXpow2.TabIndex = 36;
            this.btnXpow2.Text = "x^2";
            this.btnXpow2.UseVisualStyleBackColor = true;
            this.btnXpow2.Click += new System.EventHandler(this.btnXpow2_Click);
            // 
            // btnXpowN
            // 
            this.btnXpowN.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXpowN.Location = new System.Drawing.Point(210, 633);
            this.btnXpowN.Name = "btnXpowN";
            this.btnXpowN.Size = new System.Drawing.Size(77, 70);
            this.btnXpowN.TabIndex = 37;
            this.btnXpowN.Text = "x^n";
            this.btnXpowN.UseVisualStyleBackColor = true;
            this.btnXpowN.Click += new System.EventHandler(this.btnXpowN_Click);
            // 
            // btnAbsX
            // 
            this.btnAbsX.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbsX.Location = new System.Drawing.Point(16, 728);
            this.btnAbsX.Name = "btnAbsX";
            this.btnAbsX.Size = new System.Drawing.Size(77, 70);
            this.btnAbsX.TabIndex = 38;
            this.btnAbsX.Text = "|x|";
            this.btnAbsX.UseVisualStyleBackColor = true;
            this.btnAbsX.Click += new System.EventHandler(this.btnAbsX_Click);
            // 
            // btnPi
            // 
            this.btnPi.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPi.Location = new System.Drawing.Point(115, 728);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(77, 70);
            this.btnPi.TabIndex = 39;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnE.Location = new System.Drawing.Point(210, 728);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(77, 70);
            this.btnE.TabIndex = 40;
            this.btnE.Text = "e";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // stripTime
            // 
            this.stripTime.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stripTime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presentTime});
            this.stripTime.Location = new System.Drawing.Point(0, 816);
            this.stripTime.Name = "stripTime";
            this.stripTime.Size = new System.Drawing.Size(693, 32);
            this.stripTime.TabIndex = 41;
            this.stripTime.Text = "statusStrip1";
            // 
            // presentTime
            // 
            this.presentTime.Name = "presentTime";
            this.presentTime.Size = new System.Drawing.Size(84, 25);
            this.presentTime.Text = "시간표시";
            // 
            // gbTri
            // 
            this.gbTri.Controls.Add(this.rbArc);
            this.gbTri.Controls.Add(this.rbNormal);
            this.gbTri.Location = new System.Drawing.Point(16, 260);
            this.gbTri.Name = "gbTri";
            this.gbTri.Size = new System.Drawing.Size(305, 83);
            this.gbTri.TabIndex = 42;
            this.gbTri.TabStop = false;
            this.gbTri.Text = "Tri_Func";
            // 
            // gbAngle
            // 
            this.gbAngle.Controls.Add(this.rbRadToDeg);
            this.gbAngle.Controls.Add(this.rbDegToRad);
            this.gbAngle.Location = new System.Drawing.Point(352, 260);
            this.gbAngle.Name = "gbAngle";
            this.gbAngle.Size = new System.Drawing.Size(319, 83);
            this.gbAngle.TabIndex = 43;
            this.gbAngle.TabStop = false;
            this.gbAngle.Text = "Angle_Type";
            // 
            // rbRadToDeg
            // 
            this.rbRadToDeg.AutoSize = true;
            this.rbRadToDeg.Checked = true;
            this.rbRadToDeg.Location = new System.Drawing.Point(6, 39);
            this.rbRadToDeg.Name = "rbRadToDeg";
            this.rbRadToDeg.Size = new System.Drawing.Size(71, 29);
            this.rbRadToDeg.TabIndex = 22;
            this.rbRadToDeg.TabStop = true;
            this.rbRadToDeg.Text = "Deg";
            this.rbRadToDeg.UseVisualStyleBackColor = true;
            // 
            // presentTimer
            // 
            this.presentTimer.Interval = 1000;
            this.presentTimer.Tick += new System.EventHandler(this.presentTimer_Tick);
            // 
            // ofdLoad
            // 
            this.ofdLoad.FileName = "Calc_History.chis";
            // 
            // sfdSave
            // 
            this.sfdSave.FileName = "Calc_History";
            this.sfdSave.Filter = "기록 파일(*.chis)|*.chis";
            // 
            // formCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 848);
            this.Controls.Add(this.gbAngle);
            this.Controls.Add(this.gbTri);
            this.Controls.Add(this.stripTime);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnAbsX);
            this.Controls.Add(this.btnXpowN);
            this.Controls.Add(this.btnXpow2);
            this.Controls.Add(this.btnEpowN);
            this.Controls.Add(this.btn1DivideX);
            this.Controls.Add(this.btnRBracket);
            this.Controls.Add(this.btnLBracket);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnLogE);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtResultLine);
            this.Controls.Add(this.txtCalcLine);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.formCalc_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.stripTime.ResumeLayout(false);
            this.stripTime.PerformLayout();
            this.gbTri.ResumeLayout(false);
            this.gbTri.PerformLayout();
            this.gbAngle.ResumeLayout(false);
            this.gbAngle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCalcLine;
        private MenuStrip msMenu;
        private ToolStripMenuItem tsmFile;
        private ToolStripMenuItem tsmLoadFile;
        private ToolStripMenuItem tsmSaveFile;
        private ToolStripMenuItem tsmHistory;
        private ToolStripMenuItem tsmView;
        private TextBox txtResultLine;
        private RadioButton rbNormal;
        private RadioButton rbArc;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btnDot;
        private Button btnSign;
        private Button btnEqual;
        private Button btnCancle;
        private Button btnDelete;
        private Button btnBack;
        private RadioButton rbDegToRad;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnTan;
        private Button btnCos;
        private Button btnSin;
        private Button btnRoot;
        private Button btnLogE;
        private Button btnLog;
        private Button btnLBracket;
        private Button btnRBracket;
        private Button btn1DivideX;
        private Button btnEpowN;
        private Button btnXpow2;
        private Button btnXpowN;
        private Button btnAbsX;
        private Button btnPi;
        private Button btnE;
        private StatusStrip stripTime;
        private ToolStripStatusLabel presentTime;
        private GroupBox gbTri;
        private GroupBox gbAngle;
        private RadioButton rbRadToDeg;
        private System.Windows.Forms.Timer presentTimer;
        private OpenFileDialog ofdLoad;
        private SaveFileDialog sfdSave;
    }
}
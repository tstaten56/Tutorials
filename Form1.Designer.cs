namespace SampleServiceUI2
{
    partial class ServiceControl
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
            this.startService = new System.Windows.Forms.Button();
            this.stopService = new System.Windows.Forms.Button();
            this.pauseService = new System.Windows.Forms.Button();
            this.currentStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.continueService = new System.Windows.Forms.Button();
            this.leftNum = new System.Windows.Forms.TextBox();
            this.equals = new System.Windows.Forms.Button();
            this.rightNum = new System.Windows.Forms.TextBox();
            this.opSelect = new System.Windows.Forms.ComboBox();
            this.operationResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startService
            // 
            this.startService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startService.Location = new System.Drawing.Point(86, 67);
            this.startService.Name = "startService";
            this.startService.Size = new System.Drawing.Size(113, 23);
            this.startService.TabIndex = 0;
            this.startService.Text = "Start Service";
            this.startService.UseVisualStyleBackColor = true;
            this.startService.Click += new System.EventHandler(this.startService_Click);
            // 
            // stopService
            // 
            this.stopService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopService.Location = new System.Drawing.Point(86, 184);
            this.stopService.Name = "stopService";
            this.stopService.Size = new System.Drawing.Size(113, 23);
            this.stopService.TabIndex = 1;
            this.stopService.Text = "Stop Service";
            this.stopService.UseVisualStyleBackColor = true;
            this.stopService.Click += new System.EventHandler(this.stopService_Click);
            // 
            // pauseService
            // 
            this.pauseService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pauseService.Location = new System.Drawing.Point(86, 105);
            this.pauseService.Name = "pauseService";
            this.pauseService.Size = new System.Drawing.Size(113, 23);
            this.pauseService.TabIndex = 2;
            this.pauseService.Text = "Pause Service";
            this.pauseService.UseVisualStyleBackColor = true;
            this.pauseService.Click += new System.EventHandler(this.pauseService_Click);
            // 
            // currentStatus
            // 
            this.currentStatus.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.currentStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currentStatus.Location = new System.Drawing.Point(86, 27);
            this.currentStatus.Name = "currentStatus";
            this.currentStatus.ReadOnly = true;
            this.currentStatus.Size = new System.Drawing.Size(113, 20);
            this.currentStatus.TabIndex = 3;
            this.currentStatus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorMsg
            // 
            this.errorMsg.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.errorMsg.Location = new System.Drawing.Point(7, 328);
            this.errorMsg.Multiline = true;
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.ReadOnly = true;
            this.errorMsg.Size = new System.Drawing.Size(265, 73);
            this.errorMsg.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Errors:";
            // 
            // continueService
            // 
            this.continueService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.continueService.Location = new System.Drawing.Point(86, 145);
            this.continueService.Name = "continueService";
            this.continueService.Size = new System.Drawing.Size(113, 23);
            this.continueService.TabIndex = 7;
            this.continueService.Text = "Continue Service";
            this.continueService.UseVisualStyleBackColor = true;
            this.continueService.Click += new System.EventHandler(this.continueService_Click);
            // 
            // leftNum
            // 
            this.leftNum.BackColor = System.Drawing.Color.YellowGreen;
            this.leftNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftNum.Location = new System.Drawing.Point(33, 230);
            this.leftNum.Name = "leftNum";
            this.leftNum.Size = new System.Drawing.Size(51, 20);
            this.leftNum.TabIndex = 8;
            // 
            // equals
            // 
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equals.Location = new System.Drawing.Point(86, 256);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(113, 23);
            this.equals.TabIndex = 9;
            this.equals.Text = "Equals";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // rightNum
            // 
            this.rightNum.BackColor = System.Drawing.Color.YellowGreen;
            this.rightNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightNum.Location = new System.Drawing.Point(90, 230);
            this.rightNum.Name = "rightNum";
            this.rightNum.Size = new System.Drawing.Size(56, 20);
            this.rightNum.TabIndex = 10;
            // 
            // opSelect
            // 
            this.opSelect.FormattingEnabled = true;
            this.opSelect.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.opSelect.Location = new System.Drawing.Point(152, 229);
            this.opSelect.Name = "opSelect";
            this.opSelect.Size = new System.Drawing.Size(66, 21);
            this.opSelect.TabIndex = 11;
            this.opSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // operationResult
            // 
            this.operationResult.BackColor = System.Drawing.Color.YellowGreen;
            this.operationResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.operationResult.Location = new System.Drawing.Point(114, 285);
            this.operationResult.Name = "operationResult";
            this.operationResult.Size = new System.Drawing.Size(56, 20);
            this.operationResult.TabIndex = 12;
            // 
            // ServiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(284, 413);
            this.Controls.Add(this.operationResult);
            this.Controls.Add(this.opSelect);
            this.Controls.Add(this.rightNum);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.leftNum);
            this.Controls.Add(this.continueService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentStatus);
            this.Controls.Add(this.pauseService);
            this.Controls.Add(this.stopService);
            this.Controls.Add(this.startService);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "ServiceControl";
            this.Text = "Service Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startService;
        private System.Windows.Forms.Button stopService;
        private System.Windows.Forms.Button pauseService;
        private System.Windows.Forms.TextBox currentStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox errorMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button continueService;
        private System.Windows.Forms.TextBox leftNum;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.TextBox rightNum;
        private System.Windows.Forms.ComboBox opSelect;
        private System.Windows.Forms.TextBox operationResult;
    }
}


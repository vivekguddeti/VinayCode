namespace Microproject2
{
    partial class Change_Password
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
            this.OptoldPwd = new System.Windows.Forms.RadioButton();
            this.OptHQuestion = new System.Windows.Forms.RadioButton();
            this.lblHintQuestion = new System.Windows.Forms.Label();
            this.lblHintAns = new System.Windows.Forms.Label();
            this.lblOldPwd = new System.Windows.Forms.Label();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.lblRePwd = new System.Windows.Forms.Label();
            this.CmbHQuestion = new System.Windows.Forms.ComboBox();
            this.txtHintAns = new System.Windows.Forms.TextBox();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtRePwd = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Login_UserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OptoldPwd
            // 
            this.OptoldPwd.AutoSize = true;
            this.OptoldPwd.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OptoldPwd.Location = new System.Drawing.Point(138, 87);
            this.OptoldPwd.Name = "OptoldPwd";
            this.OptoldPwd.Size = new System.Drawing.Size(210, 22);
            this.OptoldPwd.TabIndex = 0;
            this.OptoldPwd.TabStop = true;
            this.OptoldPwd.Text = "Using Old Password";
            this.OptoldPwd.UseVisualStyleBackColor = true;
            this.OptoldPwd.CheckedChanged += new System.EventHandler(this.OptoldPwd_CheckedChanged);
            // 
            // OptHQuestion
            // 
            this.OptHQuestion.AutoSize = true;
            this.OptHQuestion.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OptHQuestion.Location = new System.Drawing.Point(423, 87);
            this.OptHQuestion.Name = "OptHQuestion";
            this.OptHQuestion.Size = new System.Drawing.Size(208, 22);
            this.OptHQuestion.TabIndex = 1;
            this.OptHQuestion.TabStop = true;
            this.OptHQuestion.Text = "Using Hint Question";
            this.OptHQuestion.UseVisualStyleBackColor = true;
            this.OptHQuestion.CheckedChanged += new System.EventHandler(this.OptHQuestion_CheckedChanged);
            // 
            // lblHintQuestion
            // 
            this.lblHintQuestion.AutoSize = true;
            this.lblHintQuestion.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblHintQuestion.Location = new System.Drawing.Point(164, 134);
            this.lblHintQuestion.Name = "lblHintQuestion";
            this.lblHintQuestion.Size = new System.Drawing.Size(184, 18);
            this.lblHintQuestion.TabIndex = 2;
            this.lblHintQuestion.Text = "Select Hint Questions";
            // 
            // lblHintAns
            // 
            this.lblHintAns.AutoSize = true;
            this.lblHintAns.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblHintAns.Location = new System.Drawing.Point(164, 188);
            this.lblHintAns.Name = "lblHintAns";
            this.lblHintAns.Size = new System.Drawing.Size(159, 18);
            this.lblHintAns.TabIndex = 3;
            this.lblHintAns.Text = "Enter Hint Answer";
            // 
            // lblOldPwd
            // 
            this.lblOldPwd.AutoSize = true;
            this.lblOldPwd.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblOldPwd.Location = new System.Drawing.Point(164, 244);
            this.lblOldPwd.Name = "lblOldPwd";
            this.lblOldPwd.Size = new System.Drawing.Size(174, 18);
            this.lblOldPwd.TabIndex = 4;
            this.lblOldPwd.Text = "Enter Old Password";
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNewPwd.Location = new System.Drawing.Point(164, 306);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(179, 18);
            this.lblNewPwd.TabIndex = 5;
            this.lblNewPwd.Text = "Enter New Password";
            // 
            // lblRePwd
            // 
            this.lblRePwd.AutoSize = true;
            this.lblRePwd.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblRePwd.Location = new System.Drawing.Point(164, 365);
            this.lblRePwd.Name = "lblRePwd";
            this.lblRePwd.Size = new System.Drawing.Size(166, 18);
            this.lblRePwd.TabIndex = 6;
            this.lblRePwd.Text = "Re-Enter Password";
            // 
            // CmbHQuestion
            // 
            this.CmbHQuestion.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CmbHQuestion.FormattingEnabled = true;
            this.CmbHQuestion.Location = new System.Drawing.Point(432, 134);
            this.CmbHQuestion.Name = "CmbHQuestion";
            this.CmbHQuestion.Size = new System.Drawing.Size(151, 28);
            this.CmbHQuestion.TabIndex = 7;
            this.CmbHQuestion.Text = "Select Hint Question";
            this.CmbHQuestion.SelectedIndexChanged += new System.EventHandler(this.CmbHQuestion_SelectedIndexChanged);
            // 
            // txtHintAns
            // 
            this.txtHintAns.Location = new System.Drawing.Point(432, 185);
            this.txtHintAns.Name = "txtHintAns";
            this.txtHintAns.Size = new System.Drawing.Size(125, 27);
            this.txtHintAns.TabIndex = 8;
            this.txtHintAns.TextChanged += new System.EventHandler(this.txtHintAns_TextChanged);
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(432, 237);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Size = new System.Drawing.Size(125, 27);
            this.txtOldPwd.TabIndex = 9;
            this.txtOldPwd.Leave += new System.EventHandler(this.txtOldPwd_Leave);
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(432, 299);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(125, 27);
            this.txtNewPwd.TabIndex = 10;
            // 
            // txtRePwd
            // 
            this.txtRePwd.Location = new System.Drawing.Point(432, 358);
            this.txtRePwd.Name = "txtRePwd";
            this.txtRePwd.Size = new System.Drawing.Size(125, 27);
            this.txtRePwd.TabIndex = 11;
            this.txtRePwd.Leave += new System.EventHandler(this.txtRePwd_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(164, 446);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 39);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(463, 446);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 39);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Login_UserName
            // 
            this.Login_UserName.AutoSize = true;
            this.Login_UserName.Font = new System.Drawing.Font("Showcard Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Login_UserName.Location = new System.Drawing.Point(286, 23);
            this.Login_UserName.Name = "Login_UserName";
            this.Login_UserName.Size = new System.Drawing.Size(215, 37);
            this.Login_UserName.TabIndex = 14;
            this.Login_UserName.Text = "Select Type";
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 513);
            this.Controls.Add(this.Login_UserName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtRePwd);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.txtHintAns);
            this.Controls.Add(this.CmbHQuestion);
            this.Controls.Add(this.lblRePwd);
            this.Controls.Add(this.lblNewPwd);
            this.Controls.Add(this.lblOldPwd);
            this.Controls.Add(this.lblHintAns);
            this.Controls.Add(this.lblHintQuestion);
            this.Controls.Add(this.OptHQuestion);
            this.Controls.Add(this.OptoldPwd);
            this.Name = "Change_Password";
            this.Text = "Change_Password";
            this.Load += new System.EventHandler(this.Change_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton OptoldPwd;
        private RadioButton OptHQuestion;
        private Label lblHintQuestion;
        private Label lblHintAns;
        private Label lblOldPwd;
        private Label lblNewPwd;
        private Label lblRePwd;
        private ComboBox CmbHQuestion;
        private TextBox txtHintAns;
        private TextBox txtOldPwd;
        private TextBox txtNewPwd;
        private TextBox txtRePwd;
        private Button btnSubmit;
        private Button btnClose;
        private Label Login_UserName;
    }
}
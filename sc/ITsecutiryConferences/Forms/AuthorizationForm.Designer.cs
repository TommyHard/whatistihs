namespace ITsecutiryConferences.Forms
{
    partial class AuthorizationForm
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
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.ButtonToAuthorization = new System.Windows.Forms.Button();
            this.TextBoxUserID = new System.Windows.Forms.TextBox();
            this.LabelAuthorization = new System.Windows.Forms.Label();
            this.LabelUserID = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelCaptcha = new System.Windows.Forms.Label();
            this.TextBoxCaptcha = new System.Windows.Forms.TextBox();
            this.ButtonAuthorization = new System.Windows.Forms.Button();
            this.LabelCaptchaValue = new System.Windows.Forms.Label();
            this.ButtonUpdateCaptcha = new System.Windows.Forms.LinkLabel();
            this.CheckBoxSaveLogin = new System.Windows.Forms.CheckBox();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelHeader.Controls.Add(this.LabelAuthorization);
            this.PanelHeader.Controls.Add(this.ButtonToAuthorization);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(309, 100);
            this.PanelHeader.TabIndex = 0;
            // 
            // ButtonToAuthorization
            // 
            this.ButtonToAuthorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonToAuthorization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.ButtonToAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonToAuthorization.Location = new System.Drawing.Point(12, 12);
            this.ButtonToAuthorization.Name = "ButtonToAuthorization";
            this.ButtonToAuthorization.Size = new System.Drawing.Size(124, 23);
            this.ButtonToAuthorization.TabIndex = 0;
            this.ButtonToAuthorization.Text = "К авторизации";
            this.ButtonToAuthorization.UseVisualStyleBackColor = true;
            this.ButtonToAuthorization.Click += new System.EventHandler(this.ButtonToAuthorization_Click);
            // 
            // TextBoxUserID
            // 
            this.TextBoxUserID.Location = new System.Drawing.Point(59, 153);
            this.TextBoxUserID.Name = "TextBoxUserID";
            this.TextBoxUserID.Size = new System.Drawing.Size(190, 23);
            this.TextBoxUserID.TabIndex = 1;
            // 
            // LabelAuthorization
            // 
            this.LabelAuthorization.AutoSize = true;
            this.LabelAuthorization.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAuthorization.Location = new System.Drawing.Point(83, 54);
            this.LabelAuthorization.Name = "LabelAuthorization";
            this.LabelAuthorization.Size = new System.Drawing.Size(143, 29);
            this.LabelAuthorization.TabIndex = 1;
            this.LabelAuthorization.Text = "Авторизация";
            // 
            // LabelUserID
            // 
            this.LabelUserID.AutoSize = true;
            this.LabelUserID.Location = new System.Drawing.Point(66, 139);
            this.LabelUserID.Name = "LabelUserID";
            this.LabelUserID.Size = new System.Drawing.Size(99, 15);
            this.LabelUserID.TabIndex = 3;
            this.LabelUserID.Text = "ID-пользователя";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(66, 185);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(48, 15);
            this.LabelPassword.TabIndex = 5;
            this.LabelPassword.Text = "Пароль";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(59, 199);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(190, 23);
            this.TextBoxPassword.TabIndex = 4;
            // 
            // LabelCaptcha
            // 
            this.LabelCaptcha.AutoSize = true;
            this.LabelCaptcha.Location = new System.Drawing.Point(66, 299);
            this.LabelCaptcha.Name = "LabelCaptcha";
            this.LabelCaptcha.Size = new System.Drawing.Size(44, 15);
            this.LabelCaptcha.TabIndex = 7;
            this.LabelCaptcha.Text = "Каптча";
            // 
            // TextBoxCaptcha
            // 
            this.TextBoxCaptcha.Location = new System.Drawing.Point(59, 313);
            this.TextBoxCaptcha.Name = "TextBoxCaptcha";
            this.TextBoxCaptcha.Size = new System.Drawing.Size(190, 23);
            this.TextBoxCaptcha.TabIndex = 6;
            // 
            // ButtonAuthorization
            // 
            this.ButtonAuthorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAuthorization.Location = new System.Drawing.Point(59, 365);
            this.ButtonAuthorization.Name = "ButtonAuthorization";
            this.ButtonAuthorization.Size = new System.Drawing.Size(190, 40);
            this.ButtonAuthorization.TabIndex = 8;
            this.ButtonAuthorization.Text = "Авторизоваться";
            this.ButtonAuthorization.UseVisualStyleBackColor = true;
            this.ButtonAuthorization.Click += new System.EventHandler(this.ButtonAuthorization_Click);
            // 
            // LabelCaptchaValue
            // 
            this.LabelCaptchaValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCaptchaValue.Enabled = false;
            this.LabelCaptchaValue.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCaptchaValue.Location = new System.Drawing.Point(59, 225);
            this.LabelCaptchaValue.Name = "LabelCaptchaValue";
            this.LabelCaptchaValue.Size = new System.Drawing.Size(190, 74);
            this.LabelCaptchaValue.TabIndex = 9;
            this.LabelCaptchaValue.Text = "0000";
            this.LabelCaptchaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonUpdateCaptcha
            // 
            this.ButtonUpdateCaptcha.ActiveLinkColor = System.Drawing.Color.White;
            this.ButtonUpdateCaptcha.AutoSize = true;
            this.ButtonUpdateCaptcha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpdateCaptcha.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ButtonUpdateCaptcha.LinkColor = System.Drawing.Color.Black;
            this.ButtonUpdateCaptcha.Location = new System.Drawing.Point(197, 283);
            this.ButtonUpdateCaptcha.Name = "ButtonUpdateCaptcha";
            this.ButtonUpdateCaptcha.Size = new System.Drawing.Size(51, 15);
            this.ButtonUpdateCaptcha.TabIndex = 10;
            this.ButtonUpdateCaptcha.TabStop = true;
            this.ButtonUpdateCaptcha.Text = "Не вижу";
            this.ButtonUpdateCaptcha.VisitedLinkColor = System.Drawing.Color.White;
            this.ButtonUpdateCaptcha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ButtonUpdateCaptcha_LinkClicked);
            // 
            // CheckBoxSaveLogin
            // 
            this.CheckBoxSaveLogin.AutoSize = true;
            this.CheckBoxSaveLogin.Location = new System.Drawing.Point(95, 342);
            this.CheckBoxSaveLogin.Name = "CheckBoxSaveLogin";
            this.CheckBoxSaveLogin.Size = new System.Drawing.Size(119, 19);
            this.CheckBoxSaveLogin.TabIndex = 11;
            this.CheckBoxSaveLogin.Text = "Запомнить логин";
            this.CheckBoxSaveLogin.UseVisualStyleBackColor = true;
            this.CheckBoxSaveLogin.CheckedChanged += new System.EventHandler(this.CheckBoxSaveLogin_CheckedChanged);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(309, 431);
            this.Controls.Add(this.CheckBoxSaveLogin);
            this.Controls.Add(this.ButtonUpdateCaptcha);
            this.Controls.Add(this.LabelCaptchaValue);
            this.Controls.Add(this.ButtonAuthorization);
            this.Controls.Add(this.LabelCaptcha);
            this.Controls.Add(this.TextBoxCaptcha);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.LabelUserID);
            this.Controls.Add(this.TextBoxUserID);
            this.Controls.Add(this.PanelHeader);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(325, 470);
            this.MinimumSize = new System.Drawing.Size(325, 470);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthorizationForm_FormClosing);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button ButtonToAuthorization;
        private System.Windows.Forms.Label LabelAuthorization;
        private System.Windows.Forms.TextBox TextBoxUserID;
        private System.Windows.Forms.Label LabelUserID;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelCaptcha;
        private System.Windows.Forms.TextBox TextBoxCaptcha;
        private System.Windows.Forms.Button ButtonAuthorization;
        private System.Windows.Forms.Label LabelCaptchaValue;
        private System.Windows.Forms.LinkLabel ButtonUpdateCaptcha;
        private System.Windows.Forms.CheckBox CheckBoxSaveLogin;
    }
}
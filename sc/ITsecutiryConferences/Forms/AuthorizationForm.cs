using ITsecutiryConferences.DataBase;
using ITsecutiryConferences.Entities;
using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITsecutiryConferences.Forms
{
    public partial class AuthorizationForm : Form
    {
        private Timer ResetLock;

        private static string CaptchaValue;
        private byte CaptchaErrors = 0;

        public AuthorizationForm()
        {
            InitializeComponent();
            UpdateCaptcha();
            CheckRememberMe();
            //
            this.Icon = Properties.Resources.icon;
            //
            ResetLock = new Timer()
            {
                Interval = 10000,
            };
            //
            ResetLock.Tick += ResetLock_Tick;
        }

        #region Authorize Process
        private void ButtonAuthorization_Click(object sender, EventArgs e)
        {
            if (CaptchaRestriction() == false)
            {
                if (string.IsNullOrEmpty(TextBoxUserID.Text) == false && string.IsNullOrEmpty(TextBoxPassword.Text) == false)
                {

                    if (TextBoxCaptcha.Text == CaptchaValue)
                    {
                        try
                        {
                            if (CheckMatches("Jury", TextBoxUserID.Text, TextBoxPassword.Text))
                            {
                                MessageBox.Show("ты жюри");
                            }
                            else if (CheckMatches("Members", TextBoxUserID.Text, TextBoxPassword.Text))
                            {
                                MessageBox.Show("ты пользователь");
                            }
                            else if (CheckMatches("Moderators", TextBoxUserID.Text, TextBoxPassword.Text))
                            {
                                MessageBox.Show("ты модер");
                            }
                            else if (CheckMatches("Organizers", TextBoxUserID.Text, TextBoxPassword.Text))
                            {
                                MessageBox.Show("ты организатор");
                            }
                            else
                            {
                                MessageBox.Show("Пользователь по указанным данным не найден", "Ошибка", MessageBoxButtons.OK);
                                //
                                CaptchaErrors++;
                                UpdateCaptcha();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Непредвиденная ошибка при авторизации. Попробуйте позже.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        CaptchaErrors++;
                        //
                        CaptchaRestriction();
                        //
                        UpdateCaptcha();
                    }
                }
                else
                {
                    CaptchaErrors++;
                }
            }
        }
        #endregion

        #region Authorization
        private static bool CheckMatches(string TableName, string Login, string Password)
        {
            using (var Connection = new SqlConnection(ConfigurationData.DbConnect))
            {
                Connection.Open();
                //
                using (var CheckMatch = new SqlCommand(
                    "SELECT * FROM " +
                    $"{TableName} " +
                    "WHERE ID = @ID AND Password = @Password", Connection))
                {
                    CheckMatch.Parameters.AddWithValue("@ID", Login);
                    CheckMatch.Parameters.AddWithValue("@Password", Password);
                    //
                    using (var ReadMatches = CheckMatch.ExecuteReader())
                    {
                        while(ReadMatches.Read())
                        {
                            User.Name = ReadMatches["Name"].ToString();
                            User.Surname = ReadMatches["Surname"].ToString();
                            User.Patronymic = ReadMatches["Patronymic"].ToString();
                            //
                            return true;
                        }
                    }
                }
            }
            //
            return false;
        }
        #endregion

        #region Captcha
        private void UpdateCaptcha()
        {
            LabelCaptchaValue.Text = CaptchaValue = Guid.NewGuid().ToString().Substring(0, 4);
        }

        private void ButtonUpdateCaptcha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateCaptcha();
        }

        private void ResetLock_Tick(object sender, EventArgs e)
        {
            ResetLock.Enabled = false;
            //
            ButtonAuthorization.Enabled = true;
            CaptchaErrors = 0;
            //
            UpdateCaptcha();
        }

        private bool CaptchaRestriction()
        {
            if (CaptchaErrors == 3)
            {
                ButtonAuthorization.Enabled = false;
                //
                MessageBox.Show("Лимит попыток исчерпан. Повторите через 10 секунд.", "Ограничение попыток", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //
                ResetLock.Start();
                //
                return true;
            }
            //
            return false;
        }
        #endregion

        #region Redirect to Menu
        private void ButtonToAuthorization_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            //
            this.Close();
        }
        #endregion

        #region Close Application
        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Remember Me
        private void CheckRememberMe()
        {
            TextBoxUserID.Text = Registry.CurrentUser.OpenSubKey(@"Software\ITsecutiryConferences\AutoLogin")?.GetValue("Login")?.ToString();
            //
            if (TextBoxUserID.Text.Length > 0)
            {
                CheckBoxSaveLogin.Checked = true;
            }
        }

        private void CheckBoxSaveLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxSaveLogin.Checked && string.IsNullOrEmpty(TextBoxUserID.Text) == false)
            {
                Registry.CurrentUser.CreateSubKey(@"Software\ITsecutiryConferences\AutoLogin", true).SetValue("Login", TextBoxUserID.Text);
            }
            else
            {
                Registry.CurrentUser.OpenSubKey(@"Software\ITsecutiryConferences", true)?.DeleteSubKeyTree("AutoLogin", false);
            }
        }
        #endregion
    }
}
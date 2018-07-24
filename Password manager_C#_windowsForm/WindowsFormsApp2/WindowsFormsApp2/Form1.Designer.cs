namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.SignUpNewButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ApplicationPanel = new System.Windows.Forms.Panel();
            this.ResultListView = new System.Windows.Forms.ListView();
            this.ModifyAccountButton = new System.Windows.Forms.Button();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.ShowPasswordButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.SignupPanel = new System.Windows.Forms.Panel();
            this.SignupUsernameTextBox = new System.Windows.Forms.TextBox();
            this.LoginBackButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SignupPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ModifyAccountPanel = new System.Windows.Forms.Panel();
            this.EnterPasswordLabel = new System.Windows.Forms.Label();
            this.CancelModifyPanelButton = new System.Windows.Forms.Button();
            this.ModifyAccountTextBox = new System.Windows.Forms.TextBox();
            this.ModifyAccountLabel = new System.Windows.Forms.Label();
            this.ModifyPasswordLabel = new System.Windows.Forms.Label();
            this.ModifyUsernameLabel = new System.Windows.Forms.Label();
            this.ClearModifyPanelButton = new System.Windows.Forms.Button();
            this.SaveModifyPanelButton = new System.Windows.Forms.Button();
            this.ChangePasswordTextBox = new System.Windows.Forms.TextBox();
            this.ModifyUsernameTextBox = new System.Windows.Forms.TextBox();
            this.AddAccountPanel = new System.Windows.Forms.Panel();
            this.EnterDetailsLabel = new System.Windows.Forms.Label();
            this.AccountTypeLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AccountTextBox = new System.Windows.Forms.TextBox();
            this.AddAccountTypeLabel = new System.Windows.Forms.Label();
            this.AddAccountPasswordLabel7 = new System.Windows.Forms.Label();
            this.AddAccountUsernameLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AccountPasswordTextBox = new System.Windows.Forms.TextBox();
            this.AccountIDTextBox = new System.Windows.Forms.TextBox();
            this.LoginPanel.SuspendLayout();
            this.ApplicationPanel.SuspendLayout();
            this.SignupPanel.SuspendLayout();
            this.ModifyAccountPanel.SuspendLayout();
            this.AddAccountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password Manager";
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.SignUpNewButton);
            this.LoginPanel.Controls.Add(this.userTextBox);
            this.LoginPanel.Controls.Add(this.label3);
            this.LoginPanel.Controls.Add(this.loginbutton);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.LoginPasswordTextBox);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Location = new System.Drawing.Point(210, 83);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(257, 257);
            this.LoginPanel.TabIndex = 6;
            // 
            // SignUpNewButton
            // 
            this.SignUpNewButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.SignUpNewButton.FlatAppearance.BorderSize = 0;
            this.SignUpNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpNewButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpNewButton.ForeColor = System.Drawing.Color.White;
            this.SignUpNewButton.Location = new System.Drawing.Point(51, 213);
            this.SignUpNewButton.Name = "SignUpNewButton";
            this.SignUpNewButton.Size = new System.Drawing.Size(192, 33);
            this.SignUpNewButton.TabIndex = 12;
            this.SignUpNewButton.Text = "Sign up for Password Vault";
            this.SignUpNewButton.UseVisualStyleBackColor = false;
            this.SignUpNewButton.Click += new System.EventHandler(this.SignUpNewButton_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(147, 81);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(106, 20);
            this.userTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Username";
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(202, 168);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(50, 21);
            this.loginbutton.TabIndex = 8;
            this.loginbutton.Text = "Submit";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // LoginPasswordTextBox
            // 
            this.LoginPasswordTextBox.Location = new System.Drawing.Point(147, 122);
            this.LoginPasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            this.LoginPasswordTextBox.PasswordChar = '*';
            this.LoginPasswordTextBox.Size = new System.Drawing.Size(106, 20);
            this.LoginPasswordTextBox.TabIndex = 6;
            // 
            // ApplicationPanel
            // 
            this.ApplicationPanel.Controls.Add(this.ResultListView);
            this.ApplicationPanel.Controls.Add(this.ModifyAccountButton);
            this.ApplicationPanel.Controls.Add(this.DeleteAccountButton);
            this.ApplicationPanel.Controls.Add(this.ShowPasswordButton);
            this.ApplicationPanel.Controls.Add(this.LogoutButton);
            this.ApplicationPanel.Controls.Add(this.AddAccountButton);
            this.ApplicationPanel.Location = new System.Drawing.Point(28, 37);
            this.ApplicationPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ApplicationPanel.Name = "ApplicationPanel";
            this.ApplicationPanel.Size = new System.Drawing.Size(672, 266);
            this.ApplicationPanel.TabIndex = 7;
            // 
            // ResultListView
            // 
            this.ResultListView.BackColor = System.Drawing.Color.MidnightBlue;
            this.ResultListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultListView.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultListView.ForeColor = System.Drawing.SystemColors.Info;
            this.ResultListView.FullRowSelect = true;
            this.ResultListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ResultListView.Location = new System.Drawing.Point(145, 73);
            this.ResultListView.MultiSelect = false;
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.Size = new System.Drawing.Size(350, 151);
            this.ResultListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ResultListView.TabIndex = 13;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.View = System.Windows.Forms.View.Details;
            // 
            // ModifyAccountButton
            // 
            this.ModifyAccountButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ModifyAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ModifyAccountButton.FlatAppearance.BorderSize = 0;
            this.ModifyAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyAccountButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyAccountButton.Location = new System.Drawing.Point(152, 9);
            this.ModifyAccountButton.Name = "ModifyAccountButton";
            this.ModifyAccountButton.Size = new System.Drawing.Size(124, 29);
            this.ModifyAccountButton.TabIndex = 12;
            this.ModifyAccountButton.Text = "Modify";
            this.ModifyAccountButton.UseVisualStyleBackColor = false;
            this.ModifyAccountButton.Click += new System.EventHandler(this.ModifyAccountButton_Click);
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteAccountButton.FlatAppearance.BorderSize = 0;
            this.DeleteAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAccountButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAccountButton.Location = new System.Drawing.Point(281, 9);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(124, 29);
            this.DeleteAccountButton.TabIndex = 11;
            this.DeleteAccountButton.Text = "Delete";
            this.DeleteAccountButton.UseVisualStyleBackColor = false;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteAccountButton_Click);
            // 
            // ShowPasswordButton
            // 
            this.ShowPasswordButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ShowPasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ShowPasswordButton.FlatAppearance.BorderSize = 0;
            this.ShowPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPasswordButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPasswordButton.Location = new System.Drawing.Point(411, 9);
            this.ShowPasswordButton.Name = "ShowPasswordButton";
            this.ShowPasswordButton.Size = new System.Drawing.Size(124, 29);
            this.ShowPasswordButton.TabIndex = 10;
            this.ShowPasswordButton.Text = "Show Password";
            this.ShowPasswordButton.UseVisualStyleBackColor = false;
            this.ShowPasswordButton.Click += new System.EventHandler(this.ShowPasswordButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(540, 9);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(117, 29);
            this.LogoutButton.TabIndex = 9;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddAccountButton.FlatAppearance.BorderSize = 0;
            this.AddAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAccountButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAccountButton.Location = new System.Drawing.Point(23, 9);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(124, 29);
            this.AddAccountButton.TabIndex = 8;
            this.AddAccountButton.Text = "Add";
            this.AddAccountButton.UseVisualStyleBackColor = false;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // SignupPanel
            // 
            this.SignupPanel.Controls.Add(this.SignupUsernameTextBox);
            this.SignupPanel.Controls.Add(this.LoginBackButton);
            this.SignupPanel.Controls.Add(this.label4);
            this.SignupPanel.Controls.Add(this.SignUpButton);
            this.SignupPanel.Controls.Add(this.label5);
            this.SignupPanel.Controls.Add(this.SignupPasswordTextBox);
            this.SignupPanel.Controls.Add(this.label6);
            this.SignupPanel.Location = new System.Drawing.Point(183, 82);
            this.SignupPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignupPanel.Name = "SignupPanel";
            this.SignupPanel.Size = new System.Drawing.Size(285, 269);
            this.SignupPanel.TabIndex = 11;
            // 
            // SignupUsernameTextBox
            // 
            this.SignupUsernameTextBox.Location = new System.Drawing.Point(147, 81);
            this.SignupUsernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignupUsernameTextBox.Name = "SignupUsernameTextBox";
            this.SignupUsernameTextBox.Size = new System.Drawing.Size(106, 20);
            this.SignupUsernameTextBox.TabIndex = 10;
            // 
            // LoginBackButton
            // 
            this.LoginBackButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.LoginBackButton.FlatAppearance.BorderSize = 0;
            this.LoginBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBackButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBackButton.ForeColor = System.Drawing.Color.White;
            this.LoginBackButton.Location = new System.Drawing.Point(64, 204);
            this.LoginBackButton.Name = "LoginBackButton";
            this.LoginBackButton.Size = new System.Drawing.Size(137, 33);
            this.LoginBackButton.TabIndex = 11;
            this.LoginBackButton.Text = "Back to Login";
            this.LoginBackButton.UseVisualStyleBackColor = false;
            this.LoginBackButton.Click += new System.EventHandler(this.LoginBackButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username";
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(202, 168);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(50, 21);
            this.SignUpButton.TabIndex = 8;
            this.SignUpButton.Text = "Submit";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // SignupPasswordTextBox
            // 
            this.SignupPasswordTextBox.Location = new System.Drawing.Point(147, 122);
            this.SignupPasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignupPasswordTextBox.Name = "SignupPasswordTextBox";
            this.SignupPasswordTextBox.PasswordChar = '*';
            this.SignupPasswordTextBox.Size = new System.Drawing.Size(106, 20);
            this.SignupPasswordTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password Manager";
            // 
            // ModifyAccountPanel
            // 
            this.ModifyAccountPanel.BackColor = System.Drawing.Color.Transparent;
            this.ModifyAccountPanel.Controls.Add(this.EnterPasswordLabel);
            this.ModifyAccountPanel.Controls.Add(this.CancelModifyPanelButton);
            this.ModifyAccountPanel.Controls.Add(this.ModifyAccountTextBox);
            this.ModifyAccountPanel.Controls.Add(this.ModifyAccountLabel);
            this.ModifyAccountPanel.Controls.Add(this.ModifyPasswordLabel);
            this.ModifyAccountPanel.Controls.Add(this.ModifyUsernameLabel);
            this.ModifyAccountPanel.Controls.Add(this.ClearModifyPanelButton);
            this.ModifyAccountPanel.Controls.Add(this.SaveModifyPanelButton);
            this.ModifyAccountPanel.Controls.Add(this.ChangePasswordTextBox);
            this.ModifyAccountPanel.Controls.Add(this.ModifyUsernameTextBox);
            this.ModifyAccountPanel.Location = new System.Drawing.Point(102, 6);
            this.ModifyAccountPanel.Name = "ModifyAccountPanel";
            this.ModifyAccountPanel.Size = new System.Drawing.Size(523, 359);
            this.ModifyAccountPanel.TabIndex = 20;
            // 
            // EnterPasswordLabel
            // 
            this.EnterPasswordLabel.AutoSize = true;
            this.EnterPasswordLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPasswordLabel.Location = new System.Drawing.Point(123, 26);
            this.EnterPasswordLabel.Name = "EnterPasswordLabel";
            this.EnterPasswordLabel.Size = new System.Drawing.Size(305, 33);
            this.EnterPasswordLabel.TabIndex = 18;
            this.EnterPasswordLabel.Text = "Enter new password";
            // 
            // CancelModifyPanelButton
            // 
            this.CancelModifyPanelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CancelModifyPanelButton.FlatAppearance.BorderSize = 0;
            this.CancelModifyPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelModifyPanelButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelModifyPanelButton.Location = new System.Drawing.Point(3, 283);
            this.CancelModifyPanelButton.Name = "CancelModifyPanelButton";
            this.CancelModifyPanelButton.Size = new System.Drawing.Size(150, 29);
            this.CancelModifyPanelButton.TabIndex = 16;
            this.CancelModifyPanelButton.Text = "Cancel";
            this.CancelModifyPanelButton.UseVisualStyleBackColor = false;
            this.CancelModifyPanelButton.Click += new System.EventHandler(this.CancelModifyPanelButton_Click);
            // 
            // ModifyAccountTextBox
            // 
            this.ModifyAccountTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.ModifyAccountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModifyAccountTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyAccountTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.ModifyAccountTextBox.Location = new System.Drawing.Point(129, 98);
            this.ModifyAccountTextBox.Name = "ModifyAccountTextBox";
            this.ModifyAccountTextBox.ReadOnly = true;
            this.ModifyAccountTextBox.Size = new System.Drawing.Size(298, 26);
            this.ModifyAccountTextBox.TabIndex = 15;
            // 
            // ModifyAccountLabel
            // 
            this.ModifyAccountLabel.AutoSize = true;
            this.ModifyAccountLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyAccountLabel.Location = new System.Drawing.Point(31, 106);
            this.ModifyAccountLabel.Name = "ModifyAccountLabel";
            this.ModifyAccountLabel.Size = new System.Drawing.Size(61, 15);
            this.ModifyAccountLabel.TabIndex = 14;
            this.ModifyAccountLabel.Text = "Account";
            // 
            // ModifyPasswordLabel
            // 
            this.ModifyPasswordLabel.AutoSize = true;
            this.ModifyPasswordLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPasswordLabel.Location = new System.Drawing.Point(30, 205);
            this.ModifyPasswordLabel.Name = "ModifyPasswordLabel";
            this.ModifyPasswordLabel.Size = new System.Drawing.Size(71, 15);
            this.ModifyPasswordLabel.TabIndex = 13;
            this.ModifyPasswordLabel.Text = "Password";
            // 
            // ModifyUsernameLabel
            // 
            this.ModifyUsernameLabel.AutoSize = true;
            this.ModifyUsernameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyUsernameLabel.Location = new System.Drawing.Point(27, 154);
            this.ModifyUsernameLabel.Name = "ModifyUsernameLabel";
            this.ModifyUsernameLabel.Size = new System.Drawing.Size(74, 15);
            this.ModifyUsernameLabel.TabIndex = 12;
            this.ModifyUsernameLabel.Text = "Username";
            // 
            // ClearModifyPanelButton
            // 
            this.ClearModifyPanelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClearModifyPanelButton.FlatAppearance.BorderSize = 0;
            this.ClearModifyPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearModifyPanelButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearModifyPanelButton.Location = new System.Drawing.Point(185, 283);
            this.ClearModifyPanelButton.Name = "ClearModifyPanelButton";
            this.ClearModifyPanelButton.Size = new System.Drawing.Size(150, 29);
            this.ClearModifyPanelButton.TabIndex = 7;
            this.ClearModifyPanelButton.Text = "Clear";
            this.ClearModifyPanelButton.UseVisualStyleBackColor = false;
            this.ClearModifyPanelButton.Click += new System.EventHandler(this.ClearModifyPanelButton_Click);
            // 
            // SaveModifyPanelButton
            // 
            this.SaveModifyPanelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SaveModifyPanelButton.FlatAppearance.BorderSize = 0;
            this.SaveModifyPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveModifyPanelButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveModifyPanelButton.Location = new System.Drawing.Point(363, 283);
            this.SaveModifyPanelButton.Name = "SaveModifyPanelButton";
            this.SaveModifyPanelButton.Size = new System.Drawing.Size(150, 29);
            this.SaveModifyPanelButton.TabIndex = 6;
            this.SaveModifyPanelButton.Text = "Save";
            this.SaveModifyPanelButton.UseVisualStyleBackColor = false;
            this.SaveModifyPanelButton.Click += new System.EventHandler(this.SaveModifyPanelButton_Click);
            // 
            // ChangePasswordTextBox
            // 
            this.ChangePasswordTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.ChangePasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChangePasswordTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.ChangePasswordTextBox.Location = new System.Drawing.Point(129, 198);
            this.ChangePasswordTextBox.Name = "ChangePasswordTextBox";
            this.ChangePasswordTextBox.PasswordChar = '*';
            this.ChangePasswordTextBox.Size = new System.Drawing.Size(298, 26);
            this.ChangePasswordTextBox.TabIndex = 4;
            // 
            // ModifyUsernameTextBox
            // 
            this.ModifyUsernameTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.ModifyUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModifyUsernameTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyUsernameTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.ModifyUsernameTextBox.Location = new System.Drawing.Point(129, 146);
            this.ModifyUsernameTextBox.Name = "ModifyUsernameTextBox";
            this.ModifyUsernameTextBox.ReadOnly = true;
            this.ModifyUsernameTextBox.Size = new System.Drawing.Size(298, 26);
            this.ModifyUsernameTextBox.TabIndex = 3;
            // 
            // AddAccountPanel
            // 
            this.AddAccountPanel.BackColor = System.Drawing.Color.Transparent;
            this.AddAccountPanel.Controls.Add(this.EnterDetailsLabel);
            this.AddAccountPanel.Controls.Add(this.AccountTypeLabel);
            this.AddAccountPanel.Controls.Add(this.CancelButton);
            this.AddAccountPanel.Controls.Add(this.AccountTextBox);
            this.AddAccountPanel.Controls.Add(this.AddAccountTypeLabel);
            this.AddAccountPanel.Controls.Add(this.AddAccountPasswordLabel7);
            this.AddAccountPanel.Controls.Add(this.AddAccountUsernameLabel);
            this.AddAccountPanel.Controls.Add(this.ClearButton);
            this.AddAccountPanel.Controls.Add(this.SaveButton);
            this.AddAccountPanel.Controls.Add(this.AccountPasswordTextBox);
            this.AddAccountPanel.Controls.Add(this.AccountIDTextBox);
            this.AddAccountPanel.Location = new System.Drawing.Point(65, 10);
            this.AddAccountPanel.Name = "AddAccountPanel";
            this.AddAccountPanel.Size = new System.Drawing.Size(591, 352);
            this.AddAccountPanel.TabIndex = 21;
            this.AddAccountPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddAccountPanel_Paint);
            // 
            // EnterDetailsLabel
            // 
            this.EnterDetailsLabel.AutoSize = true;
            this.EnterDetailsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterDetailsLabel.Location = new System.Drawing.Point(157, 42);
            this.EnterDetailsLabel.Name = "EnterDetailsLabel";
            this.EnterDetailsLabel.Size = new System.Drawing.Size(315, 33);
            this.EnterDetailsLabel.TabIndex = 18;
            this.EnterDetailsLabel.Text = "Enter account details";
            // 
            // AccountTypeLabel
            // 
            this.AccountTypeLabel.AutoSize = true;
            this.AccountTypeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypeLabel.Location = new System.Drawing.Point(221, 110);
            this.AccountTypeLabel.Name = "AccountTypeLabel";
            this.AccountTypeLabel.Size = new System.Drawing.Size(193, 12);
            this.AccountTypeLabel.TabIndex = 17;
            this.AccountTypeLabel.Text = "(Google, Facebook, Outlook, etc.,)";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(80, 306);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 29);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AccountTextBox
            // 
            this.AccountTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.AccountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.AccountTextBox.Location = new System.Drawing.Point(154, 126);
            this.AccountTextBox.Name = "AccountTextBox";
            this.AccountTextBox.Size = new System.Drawing.Size(298, 26);
            this.AccountTextBox.TabIndex = 15;
            // 
            // AddAccountTypeLabel
            // 
            this.AddAccountTypeLabel.AutoSize = true;
            this.AddAccountTypeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAccountTypeLabel.Location = new System.Drawing.Point(157, 108);
            this.AddAccountTypeLabel.Name = "AddAccountTypeLabel";
            this.AddAccountTypeLabel.Size = new System.Drawing.Size(61, 15);
            this.AddAccountTypeLabel.TabIndex = 14;
            this.AddAccountTypeLabel.Text = "Account";
            // 
            // AddAccountPasswordLabel7
            // 
            this.AddAccountPasswordLabel7.AutoSize = true;
            this.AddAccountPasswordLabel7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAccountPasswordLabel7.Location = new System.Drawing.Point(157, 217);
            this.AddAccountPasswordLabel7.Name = "AddAccountPasswordLabel7";
            this.AddAccountPasswordLabel7.Size = new System.Drawing.Size(71, 15);
            this.AddAccountPasswordLabel7.TabIndex = 13;
            this.AddAccountPasswordLabel7.Text = "Password";
            // 
            // AddAccountUsernameLabel
            // 
            this.AddAccountUsernameLabel.AutoSize = true;
            this.AddAccountUsernameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAccountUsernameLabel.Location = new System.Drawing.Point(157, 167);
            this.AddAccountUsernameLabel.Name = "AddAccountUsernameLabel";
            this.AddAccountUsernameLabel.Size = new System.Drawing.Size(74, 15);
            this.AddAccountUsernameLabel.TabIndex = 12;
            this.AddAccountUsernameLabel.Text = "Username";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(232, 306);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(150, 29);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(384, 306);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 29);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AccountPasswordTextBox
            // 
            this.AccountPasswordTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.AccountPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountPasswordTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountPasswordTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.AccountPasswordTextBox.Location = new System.Drawing.Point(154, 235);
            this.AccountPasswordTextBox.Name = "AccountPasswordTextBox";
            this.AccountPasswordTextBox.PasswordChar = '*';
            this.AccountPasswordTextBox.Size = new System.Drawing.Size(298, 26);
            this.AccountPasswordTextBox.TabIndex = 4;
            // 
            // AccountIDTextBox
            // 
            this.AccountIDTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.AccountIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountIDTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountIDTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.AccountIDTextBox.Location = new System.Drawing.Point(154, 184);
            this.AccountIDTextBox.Name = "AccountIDTextBox";
            this.AccountIDTextBox.Size = new System.Drawing.Size(298, 26);
            this.AccountIDTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 376);
            this.Controls.Add(this.AddAccountPanel);
            this.Controls.Add(this.ModifyAccountPanel);
            this.Controls.Add(this.ApplicationPanel);
            this.Controls.Add(this.SignupPanel);
            this.Controls.Add(this.LoginPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ApplicationPanel.ResumeLayout(false);
            this.SignupPanel.ResumeLayout(false);
            this.SignupPanel.PerformLayout();
            this.ModifyAccountPanel.ResumeLayout(false);
            this.ModifyAccountPanel.PerformLayout();
            this.AddAccountPanel.ResumeLayout(false);
            this.AddAccountPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginPasswordTextBox;
        private System.Windows.Forms.Panel ApplicationPanel;
        private System.Windows.Forms.ListView ResultListView;
        private System.Windows.Forms.Button ModifyAccountButton;
        private System.Windows.Forms.Button DeleteAccountButton;
        private System.Windows.Forms.Button ShowPasswordButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Panel SignupPanel;
        private System.Windows.Forms.TextBox SignupUsernameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SignupPasswordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LoginBackButton;
        private System.Windows.Forms.Button SignUpNewButton;
        private System.Windows.Forms.Panel ModifyAccountPanel;
        private System.Windows.Forms.Label EnterPasswordLabel;
        private System.Windows.Forms.Button CancelModifyPanelButton;
        private System.Windows.Forms.TextBox ModifyAccountTextBox;
        private System.Windows.Forms.Label ModifyAccountLabel;
        private System.Windows.Forms.Label ModifyPasswordLabel;
        private System.Windows.Forms.Label ModifyUsernameLabel;
        private System.Windows.Forms.Button ClearModifyPanelButton;
        private System.Windows.Forms.Button SaveModifyPanelButton;
        private System.Windows.Forms.TextBox ChangePasswordTextBox;
        private System.Windows.Forms.TextBox ModifyUsernameTextBox;
        private System.Windows.Forms.Panel AddAccountPanel;
        private System.Windows.Forms.Label EnterDetailsLabel;
        private System.Windows.Forms.Label AccountTypeLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox AccountTextBox;
        private System.Windows.Forms.Label AddAccountTypeLabel;
        private System.Windows.Forms.Label AddAccountPasswordLabel7;
        private System.Windows.Forms.Label AddAccountUsernameLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox AccountPasswordTextBox;
        private System.Windows.Forms.TextBox AccountIDTextBox;
    }
}


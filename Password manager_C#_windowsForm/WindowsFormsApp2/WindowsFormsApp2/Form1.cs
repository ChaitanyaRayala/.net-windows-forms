using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public static List<Logins> loginsList = new List<Logins>();             // List to store values from file
        public static List<Accounts> accountsList = new List<Accounts>();       // List to store values from file
        public static List<Accounts> deleteList = new List<Accounts>();         // List to store values from file
        public static List<Accounts> modifyList = new List<Accounts>();         // List to store values from file
        //
        //To intialize the form
        //
        public Form1()
        {
            InitializeComponent();
        }

        
        private void DisplayList(string filename, List<Accounts> list)
        {
            Accounts accounts = new Accounts();
            String path = Directory.GetCurrentDirectory();                                  //and the data in the list is written to the data file
            string file = filename + ".txt";
            string pathString = Path.Combine(path, file);
            list.Clear();
            using (StreamReader SR = new StreamReader(pathString))              // StreamReader to read values from file
            {
                int i = 0;
                Logins logins = new Logins();
                String S = SR.ReadLine();
                while (S != null)
                {
                    i++;
                    if (i == 1)
                    {
                        accounts.Type = S;
                    }
                    else if (i == 2)
                    {
                        accounts.Username = S;
                    }
                    else if (i == 3)
                    {
                        accounts.Password = S;
                        list.Add(new Accounts(accounts.Type, accounts.Username, accounts.Password));
                        i = 0;
                        accounts = new Accounts();
                    }
                    S = SR.ReadLine();
                }
            }

            ResultListView.Clear();
            ResultListView.Columns.Add("Account", 120);
            ResultListView.Columns.Add("User ID", 230);
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem item1 = new ListViewItem(list[i].Type, 0);             //Add the list items into the view
                item1.SubItems.Add(list[i].Username);
                ResultListView.Items.AddRange(new ListViewItem[] { item1 });
            }
        }
        
        //Method for opening the file and loading the values into the list 
        private void LoadList(List<Logins> list)
        {
            String path = Directory.GetCurrentDirectory();
            //Reads values from the file
            using (StreamReader SR = new StreamReader(path + "\\login.txt"))              // StreamReader to read values from file
            {
                int i = 0;
                Logins logins = new Logins();
                String S = SR.ReadLine();
                while (S != null)
                {
                    i++;
                    if (i == 1)
                    {
                        logins.Username = S;                // Takes first value as Username
                    }
                    else if (i == 2)
                    {
                        logins.Password = S;                // Takes second values as Password
                        list.Add(new Logins(logins.Username, logins.Password));         // Adds the new values to logins list
                        i = 0;
                        logins = new Logins();
                    }
                    S = SR.ReadLine();
                }
            }
        }
       
        //Method to clear text boxes in the form
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>                                //lambda function
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();           //clears the text boxes
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void HidePanels()
        {
            LoginPanel.Visible = false;
            SignupPanel.Visible = false;
            ApplicationPanel.Visible = false;
            AddAccountPanel.Visible = false;
            ModifyAccountPanel.Visible = false;
        }

        private static string EncryptDecrypt(string input)
        {
            char[] key = { 'V', 'A', 'I', 'S', 'H', 'N', 'A', 'V' };                         //Any chars will work, in an array of any size
            char[] output = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                output[i] = (char)(input[i] ^ key[i % key.Length]);
            }

            return new string(output);
        }
        
        //Method for creating file for newly signed up user
        private void CreateFile(String filename)
        {
            string file = filename + ".txt";                // Creating a .txt file on Username
            String path = Directory.GetCurrentDirectory();
            string pathString = Path.Combine(path, file);
            var newFile = File.CreateText(pathString);
            newFile.Close();
        }
        
        //Method for writing the new login values into the file 
        private void WriteList(List<Logins> list, string Username, string Password)
        {
            Logins logins = new Logins();
            logins.Username = Username;
            logins.Password = Password;
            list.Add(new Logins(logins.Username, logins.Password));         //the new entry is added to the list
            String path = Directory.GetCurrentDirectory();                                  //and the data in the list is 
                                                                                            //written to the data file
            using (TextWriter TW = new StreamWriter(path + "\\login.txt"))
            {                                                                               //Textwriter writes the values into the data file
                for (int k = 0; k < list.Count; k++)
                {
                    TW.WriteLine(loginsList[k].Username);
                    TW.WriteLine(loginsList[k].Password);
                }
            }
        }
        
        //Method for writing the new values into the list
        private void WriteAccountList(string filename, List<Accounts> list, string Type, string Username, string Password)
        {
            Accounts accounts = new Accounts();
            accounts.Type = Type;
            accounts.Username = Username;
            accounts.Password = Password;
            if (accounts.Type != "" && accounts.Username != "" && accounts.Password != "")
            {
                list.Add(new Accounts(accounts.Type, accounts.Username, accounts.Password));         //the new entry is added to the list
                Writefile(filename, list);
            }
            else
            {
                MessageBox.Show("Complete all the fields");
            }
        }
        
        //Method for writing the new values into the file 
        private void Writefile(String filename, List<Accounts> list)
        {
            String path = Directory.GetCurrentDirectory();
            string file = filename + ".txt";
            string pathString = Path.Combine(path, file);
            using (TextWriter TW = new StreamWriter(pathString))
            {                                                                               //Textwriter writes the values into the data file
                for (int k = 0; k < list.Count; k++)
                {
                    TW.WriteLine(list[k].Type);
                    TW.WriteLine(list[k].Username);
                    TW.WriteLine(list[k].Password);
                }
            }
        }
        
        //AddAccountButton_Click event to open add new account panel
        public class Logins
        {
            String username, password;
            //Accessor methods
            public String Username
            {
                get { return username; }
                set { username = value; }
            }
            public String Password
            {
                get { return password; }
                set { password = value; }
            }
            //Default constructor
            public Logins()
            {
                username = "";
                password = "";
            }
            //Constructor to intiliaze the values of Username and Password
            public Logins(String Username, String Password)
            {
                username = Username;
                password = Password;
            }
            public bool FindUsername(string s)                 //It compares the Username passed in the arguments with Username in the object and returns username if found 
            {
                return Username.ToLower().Equals(s.ToLower());
            }
            public bool FindPassword(string s)               //It compares the Password passed in the arguments with Password in the object and returns password if found 
            {
                return Password.ToLower().Equals(s.ToLower());
            }
        }
       
        //Class Accounts to implement the accesor methods
        public class Accounts
        {
            String type, username, password;
            //Accessor methods
            public String Type
            {
                get { return type; }
                set { type = value; }
            }
            public String Username
            {
                get { return username; }
                set { username = value; }
            }
            public String Password
            {
                get { return password; }
                set { password = value; }
            }
            //Default constructor
            public Accounts()
            {
                type = "";
                username = "";
                password = "";
            }
            //Constructor to intiliaze the values of Type, Username, Password
            public Accounts(String Type, String Username, String Password)
            {
                type = Type;
                username = Username;
                password = Password;
            }
            public bool FindType(string s)                      //It compares the type passed in the arguments with Type in the object and returns type if found
            {
                return Type.ToLower().Equals(s.ToLower());
            }
            public bool FindUsername(string s)                 //It compares the Username passed in the arguments with Username in the object and returns username if found 
            {
                return Username.ToLower().Equals(s.ToLower());
            }
            public bool FindPassword(string s)               //It compares the Password passed in the arguments with Password in the object and returns password if found 
            {
                return Password.ToLower().Equals(s.ToLower());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            HidePanels();
            LoginPanel.Visible = true;
            userTextBox.Focus();
            LoadList(loginsList);
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string loginEntered = SignupUsernameTextBox.Text;
            string passwordEntered = EncryptDecrypt(SignupPasswordTextBox.Text);            // Encrypt the entered password
            if (SignupPasswordTextBox.Text.Length >= 8 && SignupPasswordTextBox.Text.Any(char.IsUpper) && SignupPasswordTextBox.Text.Any(char.IsDigit) && SignupPasswordTextBox.Text.Any(char.IsLower))
            {
                if (loginEntered != "" && passwordEntered != "")                // Check if the values are entered into the Username and Password fields
                {
                    for (int i = 0; i < loginsList.Count; i++)
                    {
                        if (loginsList[i].FindUsername(loginEntered))           // Check if entered username already exists
                        {
                            flag = 1;
                        }
                    }
                    if (flag == 0)                                              // If new username is entered create the account
                    {
                        WriteList(loginsList, loginEntered, passwordEntered);   // Writes the logins and passwords into setup file
                        CreateFile(loginEntered);                               // Creating file on username to store passwords
                        MessageBox.Show("Sign up successful \nPlease log in back to use Password Vault!");
                        HidePanels();
                        LoginPanel.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Username already exists");
                        ClearTextBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("Complete all the fields");
                }
            }
            else
                MessageBox.Show("Password must be of atleast 8 characters with atleast one uppercase, one lowercase and one digit characters");

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string loginEntered = userTextBox.Text;
            string passwordEntered = EncryptDecrypt(LoginPasswordTextBox.Text);         // Encrypt the entered password
            if (LoginPasswordTextBox.Text.Length >= 8 && LoginPasswordTextBox.Text.Any(char.IsUpper) && LoginPasswordTextBox.Text.Any(char.IsDigit) && LoginPasswordTextBox.Text.Any(char.IsLower))
            {
                if (loginEntered != "" && passwordEntered != "")                    // Check values entered into the Username and Password fields
                {
                    for (int i = 0; i < loginsList.Count; i++)
                    {
                        if (loginsList[i].FindUsername(loginEntered) && loginsList[i].FindPassword(passwordEntered))        // Check if the Username and Passwords match
                        {
                            flag = 1;
                        }
                    }
                    if (flag == 1)                                          // If matched enter into the User's profile
                    {
                        HidePanels();
                        ApplicationPanel.Visible = true;
                        DisplayList(loginEntered, accountsList);
                    }
                    else
                    {
                        MessageBox.Show("Username and password doesn't match");
                        ClearTextBoxes();
                    }
                }

                else
                {
                    MessageBox.Show("Complete all the fields");
                }
            }
            else
                MessageBox.Show("Password must be of atleast 8 characters with atleast one uppercase, one lowercase and one digit characters");
        }

        private void SignUpNewButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            ClearTextBoxes();
            SignupPanel.Visible = true;
            SignupUsernameTextBox.Focus();
        }

        private void LoginBackButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            ClearTextBoxes();
            LoginPanel.Visible = true;
            userTextBox.Focus();
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            AddAccountPanel.Visible = true;
            AccountTextBox.Focus();
        }

        private void ModifyAccountButton_Click(object sender, EventArgs e)
        {
            if (ResultListView.SelectedItems.Count > 0)                     // Check if a item is selected from the result view
            {
                HidePanels();
                ModifyAccountPanel.Visible = true;
                ListViewItem item = ResultListView.SelectedItems[0];
                ModifyAccountTextBox.Text = item.SubItems[0].Text;          // Set values to ModifyAccountTextBox 
                ModifyUsernameTextBox.Text = item.SubItems[1].Text;         // Set values to ModifyUsernameTextBox
                ChangePasswordTextBox.Clear();
                ChangePasswordTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Select any account from the list");
            }
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string filename = userTextBox.Text;
            if (ResultListView.SelectedItems.Count > 0)                 // Check if a item is selected from the result view
            {
                ListViewItem item = ResultListView.SelectedItems[0];
                Accounts accounts = new Accounts();                     // Get values from the selected items in result view
                accounts.Type = item.SubItems[0].Text;
                accounts.Username = item.SubItems[1].Text;
                for (int i = 0; i < accountsList.Count; i++)
                {
                    if (accountsList[i].FindType(accounts.Type) && accountsList[i].FindUsername(accounts.Username))        // To find the index value of selected item in accounts list
                    {
                        flag = i;
                    }
                }
                deleteList = accountsList;
                deleteList.RemoveAt(flag);                              // Delete the account from the list
                Writefile(filename, deleteList);                        // Overwrite the file with new accounts
                DisplayList(filename, deleteList);
            }
            else
            {
                MessageBox.Show("Select any account from the list");
            }
        }

        private void ShowPasswordButton_Click(object sender, EventArgs e)
        {
            if (ResultListView.SelectedItems.Count > 0)                     // Check if a item is selected from the result view
            {
                ListViewItem item = ResultListView.SelectedItems[0];
                string account = item.SubItems[0].Text;
                string userid = item.SubItems[1].Text;                      // Get values from the selected items in result view
                string password = "";
                for (int i = 0; i < accountsList.Count; i++)
                {
                    if (accountsList[i].FindType(account) && accountsList[i].FindUsername(userid))                 // Look for the selected username in the list
                    {
                       
                        password = accountsList[i].Password;                // Return the password for the username
                    }
                }                                     
                string message = "User ID is:" + userid + "\n" + "Password is:" + "**********" + "\n \n" + "Do you want to view the password?";
                if (MessageBox.Show(message, "Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)        // Message box to show the password after decrypting for a few seconds
                {
                    AutoClosingMessageBox.Show(EncryptDecrypt(password), account + "password :", 1500);
                }
            }
            else
            {
                MessageBox.Show("Select any account from the list");
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            LoginPanel.Visible = true;
            userTextBox.Focus();
            ClearTextBoxes();
        }

        private void CancelModifyPanelButton_Click(object sender, EventArgs e)
        {
            HidePanels();
            ApplicationPanel.Visible = true;
        }

        private void ClearModifyPanelButton_Click(object sender, EventArgs e)
        {
            ChangePasswordTextBox.Clear();
        }

        private void SaveModifyPanelButton_Click(object sender, EventArgs e)
        {
            modifyList = accountsList;
            int flag = 0, index = 0;
            String filename = userTextBox.Text;
            ListViewItem item = ResultListView.SelectedItems[0];
            string account = item.SubItems[0].Text;
            string userid = item.SubItems[1].Text;
            string password = EncryptDecrypt(ChangePasswordTextBox.Text);           // Encrypt the entered password
            if (ChangePasswordTextBox.Text.Length >= 8 && ChangePasswordTextBox.Text.Any(char.IsUpper) && ChangePasswordTextBox.Text.Any(char.IsDigit) && ChangePasswordTextBox.Text.Any(char.IsLower))
            {
                if (password != "")                                     // Check if the value is entered into password field
                {
                    for (int i = 0; i < modifyList.Count; i++)
                    {
                        if (modifyList[i].FindUsername(userid))        // To find the index value of selected item in accounts list
                        {
                            flag = 1;
                            index = i;
                        }
                    }
                    modifyList.RemoveAt(index);                              // Delete the account from the list
                    WriteAccountList(filename, modifyList, account, userid, password);
                    Writefile(filename, modifyList);                        // Overwrite the file with new accounts
                }
                else
                {
                    MessageBox.Show("Enter new password and click on save");
                }
            }
            else
                MessageBox.Show("Password must be of atleast 8 characters with atleast one uppercase, one lowercase and one digit characters");
        

            if (flag == 1)
            {
                MessageBox.Show("The password is successfully changed");
                HidePanels();
                ApplicationPanel.Visible = true;
                DisplayList(filename, modifyList);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            HidePanels();
            ApplicationPanel.Visible = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            AccountTextBox.Focus();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string filename = userTextBox.Text;                // Get required values from textboxes
            string accountType = AccountTextBox.Text;
            string accountName = AccountIDTextBox.Text;
            string accountPassword = EncryptDecrypt(AccountPasswordTextBox.Text);           // Encrypt the entered password
            if (AccountPasswordTextBox.Text.Length >= 8 && AccountPasswordTextBox.Text.Any(char.IsUpper) && AccountPasswordTextBox.Text.Any(char.IsDigit) && AccountPasswordTextBox.Text.Any(char.IsLower))
            {
                if (accountType != "" && accountName != "" && accountPassword != "")                // Check if all values are entered
                {
                    WriteAccountList(filename, accountsList, accountType, accountName, accountPassword);
                    MessageBox.Show("New entry successful");
                    ClearTextBoxes();
                    HidePanels();
                    ApplicationPanel.Visible = true;
                    DisplayList(filename, accountsList);
                }
                else
                {
                    MessageBox.Show("Complete all the fields");
                }
            }
            else
                MessageBox.Show("Password must be of atleast 8 characters with atleast one uppercase, one lowercase and one digit characters");
        }

        private void AddAccountPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}




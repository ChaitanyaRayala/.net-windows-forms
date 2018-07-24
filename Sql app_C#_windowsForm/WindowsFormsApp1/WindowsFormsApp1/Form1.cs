using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Assign3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // MySqlConnection to declare the server address, id, password, database
                using (MySqlConnection Connection = new MySqlConnection("server=10.158.56.53;uid=csci473g58;pwd=wordpass58;database=csci473g58;"))
                {
                    Connection.Open();          // Opens the connection to perfrom MySql operations
        
                    MySqlCommand DropClassCommand = new MySqlCommand("DROP TABLE IF EXISTS ClassTable", Connection);
                    DropClassCommand.ExecuteNonQuery();
                    MySqlCommand DropRoomCommand = new MySqlCommand("DROP TABLE IF EXISTS RoomTable", Connection);
                    DropRoomCommand.ExecuteNonQuery();
                    MySqlCommand DropOfficeCommand = new MySqlCommand("DROP TABLE IF EXISTS OfficeTable", Connection);
                    DropOfficeCommand.ExecuteNonQuery();
                    MySqlCommand CreateRoomCommand = new MySqlCommand("CREATE TABLE RoomTable(Room INT, Capacity INT, Smart CHAR(1), PRIMARY KEY (Room))", Connection);
                    CreateRoomCommand.ExecuteNonQuery();
                    MySqlCommand CreateOfficeCommand = new MySqlCommand("CREATE TABLE OfficeTable(Teacher CHAR(20), Office INT, PRIMARY KEY (Teacher))", Connection);
                    CreateOfficeCommand.ExecuteNonQuery();
                    MySqlCommand CreateClassCommand = new MySqlCommand("CREATE TABLE ClassTable(Class INT, Section INT, Teacher CHAR(20), Room INT, Time CHAR(5), Days CHAR(5), Enrollment INT, FOREIGN KEY (Teacher) REFERENCES OfficeTable(Teacher), FOREIGN KEY (Room) REFERENCES RoomTable(Room))", Connection);
                    CreateClassCommand.ExecuteNonQuery();
                    String Path = Directory.GetCurrentDirectory();
                    //Reads values from the file
                    using (StreamReader SR = new StreamReader(Path + "\\Room.txt"))         // StreamReader to read values from file
                    {
                        String S = SR.ReadLine();
                        while (S != null)
                        {
                            String[] sub = S.Split(',');            
                            int Room = Convert.ToInt32(sub[0]);     
                            int Capacity = Convert.ToInt32(sub[1]); 
                            MySqlCommand InsertRoomCommand = new MySqlCommand("INSERT INTO RoomTable (Room, Capacity, Smart) VALUES (" + Room.ToString() + "," + Capacity.ToString() + ",'" + sub[2] + "')", Connection);
                            InsertRoomCommand.ExecuteNonQuery();    // Execute the insert command
                            S = SR.ReadLine();
                        }
                    } 
                    using (StreamReader SR = new StreamReader(Path + "\\Office.txt"))        // StreamReader to read values from file
                    {
                        String S = SR.ReadLine();
                        while (S != null)
                        {
                            String[] sub = S.Split(',');            
                            int Office = Convert.ToInt32(sub[1]);   
                            //MySqlCommand to insert values into OfficeTable
                            MySqlCommand InsertOfficeCommand = new MySqlCommand("INSERT INTO OfficeTable (Teacher, Office) VALUES ('" + sub[0] + "'," + Office.ToString() + ")", Connection);
                            InsertOfficeCommand.ExecuteNonQuery(); 
                            S = SR.ReadLine();
                        }
                    }
                    using (StreamReader SR = new StreamReader(Path + "\\Class.txt"))        //StreamReader to read values from file
                    {
                        String S = SR.ReadLine();
                        while (S != null)
                        {
                            String[] sub = S.Split(',');           
                            string subtext = sub[0];
                            String[] text = subtext.Split('-');
                            int Class = Convert.ToInt32(text[0]);    
                            int Section = Convert.ToInt32(text[1]);  
                            int Enrollment = Convert.ToInt32(sub[5]);   
                            if (sub[2] == "null")
                            {
                                MySqlCommand InsertClassCommand = new MySqlCommand("INSERT INTO ClassTable (Class, Section, Teacher, Room, Time, Days, Enrollment) VALUES (" + Class.ToString() + "," + Section.ToString() + ",'" + sub[1] + "'," + sub[2] + ",'" + sub[3] + "','" + sub[4] + "'," + Enrollment.ToString() + ")", Connection);
                                InsertClassCommand.ExecuteNonQuery();   
                            }
                            else
                            {
                                int Room = Convert.ToInt32(sub[2]);     
                                MySqlCommand InsertClassCommand = new MySqlCommand("INSERT INTO ClassTable (Class, Section, Teacher, Room, Time, Days, Enrollment) VALUES (" + Class.ToString() + "," + Section.ToString() + ",'" + sub[1] + "'," + Room.ToString() + ",'" + sub[3] + "','" + sub[4] + "'," + Enrollment.ToString() + ")", Connection);
                                InsertClassCommand.ExecuteNonQuery();   
                            }
                            S = SR.ReadLine();
                        }
                    }


                    Connection.Close();         // Closes the connection
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection is not established \n" + ex);     // Shows the exception if the connection is not established
                Application.Exit();
            }
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            Result.Items.Clear();
            try
            {
                // MySqlConnection to declare the server address, id, password, database
                using (MySqlConnection Connection = new MySqlConnection("server=10.158.56.53;uid=csci473g58;pwd=wordpass58;database=csci473g58;"))
                {
                    Connection.Open();              // Opens the connection to perfrom MySql operations
                    MySqlCommand QueryCommand = new MySqlCommand(MySqlStatementTextBox.Text, Connection);
                    string query = MySqlStatementTextBox.Text.Substring(0, 6);       // Gets the first 6 letters of the query text box
                    // If the query is select command
                    if (query.ToLower() == "select")
                    {
                        try
                        {
                            MySqlDataReader Reader = QueryCommand.ExecuteReader();      // MySqlReader to execute the select command
                            WriteColumn((IDataRecord)Reader);            // ReadColumn() to add the column names to the Result
                            while (Reader.Read())
                            {
                                WriteSingleRow((IDataRecord)Reader);         // Calls the ReadSingleRow() to add the result to the Result
                            }
                            Reader.Close();
                            MySqlStatementTextBox.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error in query entered \n" + ex);      // When the query is not executed due to error, exception is shown
                            MySqlStatementTextBox.Clear();
                        }
                    }
                    // If the query is insert command
                    else if (query.ToLower() == "insert")
                    {
                        try
                        {
                            QueryCommand.ExecuteNonQuery();         // Executes the insert query
                            Result.Items.Add("New record is added");
                            MySqlStatementTextBox.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Record is not inserted \n" + ex);      // When the query is not executed due to error, exception is shown
                            MySqlStatementTextBox.Clear();
                        }
                    }
                    // If the query is something else
                    else
                    {
                        Result.Items.Clear();
                        Result.Items.Add("The entered MySql command is not yet implemented");
                        MySqlStatementTextBox.Clear();
                    }
                    Connection.Close();         // Closes the connection
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection is not established \n" + ex);       // Shows the exception if the connection is not established
                Application.Exit();
            }
        }
        // WriteColumn() to add the column names to Result
        private void WriteColumn(IDataRecord reader)
        {
            string columns = null, lines = null;
            for (int i = 0; i < reader.FieldCount; i++)
            {
                columns += reader.GetName(i).PadRight(8) + "| ";      // Add the names of columns to string columns
                lines += "----------";                              // Add lines after column names
            }
            Result.Items.Add(columns);
            Result.Items.Add(lines);
        }
        // WriteSingleRow() to read the result of the query and add the result to Result
        private void WriteSingleRow(IDataRecord reader)
        {
            string result = null;
            for (int i = 0; i < reader.FieldCount; i++)
            {
                result += reader[i].ToString().PadRight(8) + "| ";   // Add the result values to string result
            }
            Result.Items.Add(result);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            MySqlStatementTextBox.Clear();
            Result.Items.Clear();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }





}


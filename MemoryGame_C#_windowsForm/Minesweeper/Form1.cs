using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        int count = 0;
        List<string> icons = new List<string>               // List of icons to be matched on UI
        {
            "a","a","!","!","d","d","m","m",
            "g","g","l","l","x","x","#","#"
        };
        Label firstClicked, secondClicked;

        public Form1()                                      // Initial form view 
        {
            InitializeComponent();
            panel1.Visible = true;
            tableLayoutPanel1.Visible = false;
            AssignIcons();
        }

        private void label_click(object sender, EventArgs e)     // When a Icon is clicked 
        {
            if (firstClicked != null && secondClicked != null)   // Checks if both clicks are empty and returns to start
                return;
            Label clickedLabel = sender as Label;

            if (clickedLabel == null)                       
                return;
            if (clickedLabel.ForeColor == Color.Black)
                return;

            if(firstClicked==null)                            // checks if clicked label is null and then assigns the clicked label to firstclicked and turn it black to be viewed on screen
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }
            
                secondClicked = clickedLabel;                // checks for the second click and assigns it the clicked label.
                secondClicked.ForeColor = Color.Black;

            CheckforWinner();                                 //Checks for winner condition
            if (firstClicked.Text == secondClicked.Text)      //checks if the icons match and lets te changed color stay the same way
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
                timer1.Start();                             // If icons do not match starts the timer.
        }

        private void CheckforWinner()                         //winner function
        {
            Label label;
            for(int i=0; i< tableLayoutPanel1.Controls.Count;i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;
                if (label != null && label.ForeColor == label.BackColor)                  // if all icons or labels do not turn black then not winner and continues the click label function
                    return;
            }
            
            MessageBox.Show("Matched all icons. Congrats! \n Number of failed attempts is "+count );
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)               //Timer fucntion required to stop the timer that has started and make the icons disappear in case they dint match
        {
            timer1.Stop();
             secondClicked.ForeColor = secondClicked.BackColor;
             firstClicked.ForeColor = firstClicked.BackColor;
            count++;


            firstClicked = null;
            secondClicked = null;
        }

        private void button1_Click(object sender, EventArgs e)             //On clicking the start button
        {
            tableLayoutPanel1.Visible = true;
            panel1.Visible = false;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void AssignIcons()                                       //Assigning icons to different cells randomly using the random function.
        {
            Label label;
            int randomNumber;

            for(int i=0; i< tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else
                    continue;

                randomNumber = random.Next(0, icons.Count);
                label.Text = icons[randomNumber];
                label.ForeColor = label.BackColor;

                icons.RemoveAt(randomNumber);
            }

        }

    }
}

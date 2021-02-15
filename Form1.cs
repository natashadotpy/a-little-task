using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyDialogs;

namespace a_little_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // the variable for the combination is initalised here so all the elements in the form can see it 
        string combo;

        private void setCombinationButton_Click(object sender, EventArgs e)
        {
            // this button sets the combination for the safe

            string combination;
            int length;

            // checks if the safe is locked
            if (safeStatusTextbox.Text == "Locked")
            {
                // tells user that the safe is locked and therefore they cannot set the combinations
                MessageBox.Show("You must unlock the safe before setting the combination");
            }

            // if the safe in unlocked this allows the user to set the combination
            else
            {
                do
                {
                    // asks the user for a combination
                    combination = My_Dialogs.InputBox("enter a combination for the safe");
                    
                    // calculates the length of the combination and stores to a variable
                    length = combination.Length;

                    // if the input length is less than 5 characters it raises an error and loops to the input box again
                    if (length < 5)
                    {
                        MessageBox.Show("Error!" + Environment.NewLine + "The combination must be at least five characters long");
                    }

                    // if the input is a suitable length the safe is locked, and the GUI change
                    else
                    {
                        safeStatusTextbox.Text = "Locked";
                        this.BackColor = Color.LightCoral;
                        safeStatusTextbox.BackColor = Color.LightCoral;
                        combo = combination;
                        keyTextbox.Focus();
                    }
                } while (length < 5);
            }
        }

        private void testKeyButton_Click(object sender, EventArgs e)
        {
           // this button does two things:
           // this button tests the input of the textbox, if it is the same as what is set as the combination the safe unlocks
           // if the safe is unlocked when the button is pressed it locks the safe 

            string keyEntered;

            // this checks if the safe is locked
            if (safeStatusTextbox.Text == "Locked")
            {
                // user inputs the combination in the textbox
                keyEntered = keyTextbox.Text;

                // it checks if the input matches the saved combination
                // if it does it unlocks the safe and changes GUI
                if (keyEntered == combo)
                {
                    safeStatusTextbox.Text = "Unlocked";
                    testKeyButton.Text = "Lock Safe";
                    safeStatusTextbox.BackColor = Color.LightGreen;
                    this.BackColor = Color.LightGreen;
                }

                // if the input does not match it raises an error box
                else
                {
                    MessageBox.Show("Invalid Key");
                }

                // clears the textbox after each input 
                keyTextbox.Text = "";
            }

            // this checks if the safe is unlocked, and if it is it locks it and changed GUI settings
            else if (safeStatusTextbox.Text == "Unlocked")
            {
                keyTextbox.Text = "";
                safeStatusTextbox.Text = "Locked";
                testKeyButton.Text = "Test Key";
                this.BackColor = Color.LightCoral;
                safeStatusTextbox.BackColor = Color.LightCoral;
            }

            // puts the curser in the input textbox after each interaction with the form
            keyTextbox.Focus();
        }
    }
}

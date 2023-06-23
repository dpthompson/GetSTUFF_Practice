using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetSTUFF.Forms
{
    public partial class GuessingGameFrm : Form
    {
   
        private Form1 _form1;
        private int IntInputValue;//value used to pass around
        private int IntGuessingVariable;// variabled computer uses to guess against

        public  GuessingGameFrm (Form1 form1)
        {
             InitializeComponent();
            _form1 = form1;
        }

        private void btnStartGuessing_Click(object sender, EventArgs e)
        {
            string numberGuess = txtbxNumber.Text;//sets textbox to string
            if (int.TryParse(numberGuess, out IntInputValue))//audits the texbox value to make sure its a valid input
                {
                    IntGuessingVariable = 50;
                    btnNo.Visible = true;
                    btnYes.Visible = true;
                    lblPrompt.Text = "Is your number 50?";
                    lblPrompt.Visible = true;
                    btnStartGuessing.Visible = false;
                    txtbxNumber.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Please input a whole number as " + txtbxNumber.Text + " is not a whole value, ex 2, 44, 66");
                }

        }

        private void GuessingGameFrm_Load(object sender, EventArgs e)
        {
            btnStartGuessing.Visible = true;
            lblPrompt.Visible = false;
            btnHigher.Visible = false;
            btnLower.Visible = false;
            IntGuessingVariable = 0;
            IntInputValue = 0;
            btnYes.Visible = false;
            btnNo.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtbxNumber.Text = "";
            lblPrompt.Visible = false;
            btnStartGuessing.Visible = true;
            btnHigher.Visible = false;
            btnLower.Visible = false;
            txtbxNumber.ReadOnly = false;
            IntGuessingVariable = 0;
            IntInputValue = 0;
            btnYes.Visible = false;
            btnNo.Visible = false;

        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            try
            {
                if (IntGuessingVariable == IntInputValue)
                {
                    MessageBox.Show("YOUR NUMBER WAS " + IntGuessingVariable);
                }
                else
                {
                    if (IntInputValue < IntGuessingVariable)
                    {
                        if( (IntGuessingVariable - IntInputValue) > 10)
                        {
                            IntGuessingVariable = IntGuessingVariable - 10;
                            //lblPrompt.Text = "Is your input value of " + IntInputValue + " higher or lower than" + IntGuessingVariable;\
                            lblPrompt.Text = "Is your value " + IntGuessingVariable;
                            btnYes.Visible = true;
                            btnNo.Visible = true;
                            btnLower.Visible = false;
                            btnHigher.Visible = false;
                        }
                        else
                        {
                            IntGuessingVariable = IntGuessingVariable - 1;
                            //lblPrompt.Text = "Is your input value of " + IntInputValue + " higher or lower than" + IntGuessingVariable;
                            lblPrompt.Text = "Is your value " + IntGuessingVariable;
                            btnYes.Visible = true;
                            btnNo.Visible = true;
                            btnLower.Visible = false;
                            btnHigher.Visible = false;

                        }

                    }
                    else
                    {
                        MessageBox.Show(IntInputValue + " is larger than " + IntGuessingVariable + " Choose the other option");
                    }
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        private void btnHigher_Click(object sender, EventArgs e)
        {
            try
            {
                if (IntGuessingVariable == IntInputValue)
                {
                    MessageBox.Show("YOUR NUMBER WAS " + IntGuessingVariable);
                }
                else
                {
                    if (IntInputValue > IntGuessingVariable)
                    {
                        if ((IntInputValue - IntGuessingVariable) > 10)
                        {
                            IntGuessingVariable = IntGuessingVariable + 10;

                            lblPrompt.Text = "Is your value " + IntGuessingVariable;
                            btnYes.Visible = true;
                            btnNo.Visible = true;
                            btnLower.Visible = false;
                            btnHigher.Visible = false;
                        }
                        else
                        {
                            IntGuessingVariable = IntGuessingVariable + 1;

                            lblPrompt.Text = "Is your value " + IntGuessingVariable;
                            btnYes.Visible = true;
                            btnNo.Visible = true;
                            btnLower.Visible = false;
                            btnHigher.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(IntInputValue + " is smaller than " + IntGuessingVariable + " Choose the other option");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (IntGuessingVariable == IntInputValue)
            {
                MessageBox.Show("WE GUESSED the value at " + IntInputValue);
            }

            else
            {
                btnYes.Visible = false;
                btnNo.Visible = false;
                lblPrompt.Text = "Good try, Is your input value of " + IntInputValue + " higher or lower than" + IntGuessingVariable;
                btnHigher.Visible = true;
                btnLower.Visible = true;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (IntGuessingVariable == IntInputValue)
            {
                MessageBox.Show(" Silly you...WE GUESSED the value at " + IntInputValue);
            }

            else
            {
                btnYes.Visible = false;
                btnNo.Visible = false;
                lblPrompt.Text = "Is your input value of " + IntInputValue + " higher or lower than" + IntGuessingVariable;
                btnHigher.Visible = true;
                btnLower.Visible = true;
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _form1.StartPosition = FormStartPosition.Manual; // Set the start position to manual
            _form1.Location = this.Location; // Set the location of EditingFrm to the same as Form1
            _form1.Show();
            this.Hide();
        }

        private static int GetGuess()
        {
            int guess = 0;
            try
            {
                guess = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You did not enter a valid guess.");
                guess = GetGuess();
            }
            return guess;
        }


    }
}

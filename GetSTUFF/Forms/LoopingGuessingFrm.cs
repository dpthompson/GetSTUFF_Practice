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
    public partial class LoopingGuessingFrm : Form
    {
        private Form1 _form1;
        private int IntLoopCNT = 0; //loop counter that user inputs
        private int internalcounter = 0;// loop counter that code updates
        private int guess = 0; //textbox that the user inputs their guess
        private int number = 0;//randomly generate number
        public LoopingGuessingFrm()
        {
            InitializeComponent();
        }

        public LoopingGuessingFrm(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void btnAtempts_Click(object sender, EventArgs e)
        {
            string inputvalue = txtbxGuessAtmpt.Text;
            if(int.TryParse(inputvalue, out IntLoopCNT))
            {
                Random rand = new Random();
                number = rand.Next(0, 100); //returns random number between 0-100
                label2.Text = "enter a value between 0 and 100";
                txtbxGuess.Visible = true;
                btnGuess.Visible = true;
                txtbxGuessAtmpt.Visible = false;
                btnAtempts.Visible = false;
                label1.Visible = false;
                label2.Visible = true;

            }
            else
            {
                MessageBox.Show("Please enter a whole number");
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            try
            {
                if(internalcounter < IntLoopCNT)//is internal counter less than how many atemps we are allowed
                {
                    //work can continue
                    string guesst = txtbxGuess.Text;
                      if(int.TryParse(guesst, out guess))//do we even have a correct input
                      {
                            if(guess == number )//checks to see if the guessed number equals out randomly gen number
                            {
                                //if guess = random number
                                MessageBox.Show("your guess was correct");
                            }
                            else
                            {
                                    //value if good
                                 if(guess>number)
                                 {
                                          //guess is higher
                                          MessageBox.Show("The hidden value is higher, try again");
                                          internalcounter += 1;
                                          priorAttempts.Add(new GuessAttempt { AttemptValue = guess, Outcome = "Too High" });
                                          txtbxGuess.Text = "";
                            }
                                 else
                                 {
                                          //guess is lower
                                         MessageBox.Show("The hidden value is lower, try again");
                                         internalcounter += 1;
                                         priorAttempts.Add(new GuessAttempt { AttemptValue = guess, Outcome = "Too Low" });
                                         txtbxGuess.Text = "";

                            }
                                 UpdateDataGridView();
                            }

                      }
                     else
                     {
                          //value if bad
                           MessageBox.Show("please enter a whole value");
                     }
                    
                }
                else
                {
                    MessageBox.Show("you are out of attempts");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("you messed up" + ex);
            }
        }
        public class GuessAttempt
        {
            public int AttemptValue { get; set; }
            public string Outcome { get; set; }
        }
        private void UpdateDataGridView()
        {
            dataGridView1.DataSource = null; // Clear the data source
            priorAttempts.Reverse();
            dataGridView1.DataSource = priorAttempts; // Set the data source to priorAttempts list
        }
        List<GuessAttempt> priorAttempts = new List<GuessAttempt>();

        private void LoopingGuessingFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            txtbxGuess.Visible = false;
            btnGuess.Visible = false;
            label2.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            txtbxGuess.Visible = false;
            btnGuess.Visible = false;
            txtbxGuessAtmpt.Visible = true;
            btnAtempts.Visible = true;
            txtbxGuess.Text = "";
            txtbxGuessAtmpt.Text = "";
            priorAttempts.Clear();
            internalcounter = 0;
            label1.Visible = true;
            label2.Visible = false;

        }
    }
}

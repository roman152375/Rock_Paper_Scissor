using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissor
{
   
    public partial class Rock_Paper_Scissor : Form
    {
        int Player1score = 0;
        int computerscore = 0;
        public Rock_Paper_Scissor()
        {
            InitializeComponent();
        }

        

        private void btnPaper_Click(object sender, EventArgs e)
        {
            int userinput = 2;
            int computerinput = 2;

            Random myRndNumber = new Random();
            computerinput = myRndNumber.Next(1, 4);
            if (userinput == 2 && computerinput == 1)
            {
                txtResult.Text = " You Win! ";
                Player1score += 1;
                txt1score.Text = Player1score.ToString();
            
    computerR.Visible = true;
                computerP.Visible = false;
                computerS.Visible = false;
            }

            else if (userinput == 2 && computerinput == 2)
            {
                txtResult.Text = " Game Draw!!! Try again! ";
            
    computerR.Visible = false;
                computerP.Visible = true;
                computerS.Visible = false;
            }

            else if (userinput == 2 && computerinput == 3)
            {
                txtResult.Text = " You Lose! ";
                computerscore += 1;
                txt2score.Text = computerscore.ToString();
            
    computerR.Visible = false;
                computerP.Visible = false;
                computerS.Visible = true;
            }
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            int userinput = 1;
            int computerinput = 1;

            Random myRndNumber = new Random();
            computerinput = myRndNumber.Next(1, 4);
            if (userinput == 1 && computerinput == 1)
            {
                txtResult.Text = "Game Draw!!! Try again! ";
                computerR.Visible = true;
                computerP.Visible = false;
                computerS.Visible = false;
            }

            else if (userinput == 1 && computerinput == 2)
            {
                txtResult.Text = " You Lose! ";
                computerR.Visible = false;
                computerP.Visible = true;
                computerS.Visible = false;
                computerscore += 1;
                txt2score.Text = computerscore.ToString();
            }
            else if (userinput == 1 && computerinput == 3)
            {
                txtResult.Text = " You Win! ";
                computerR.Visible = false;
                computerP.Visible = false;
                computerS.Visible = true;
                Player1score += 1;
                txt1score.Text = Player1score.ToString();
            }

        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            int userinput = 3;
            int computerinput = 3;

            Random myRndNumber = new Random();
            computerinput = myRndNumber.Next(1, 4);
            if (userinput == 3 && computerinput == 1)
            {
                txtResult.Text = " You Lose! ";
            
    computerR.Visible = true;
                computerP.Visible = false;
                computerS.Visible = false;
                computerscore += 1;
                txt2score.Text = computerscore.ToString();
            }

            else if (userinput == 3 && computerinput == 2)
            {
                txtResult.Text = " You Win! ";
            
    computerR.Visible = false;
                computerP.Visible = true;
                computerS.Visible = false;
                Player1score += 1;
                txt1score.Text = Player1score.ToString();
            }

            else if (userinput == 3 && computerinput == 3)
            {
                txtResult.Text = " Game Draw!!! Try again! ";
            
    computerR.Visible = false;
                computerP.Visible = false;
                computerS.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt1score_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

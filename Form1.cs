using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    //Student Id: C0804317
    //Student Name: Varij Rughani
    public partial class Form1 : Form
    {
        private int scoreTot = 0;
        private int scoreAvg = 0;
        private int Count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Enter to Add score and Escape to exit

            if (keyData == (Keys.Enter))
            {
                btn_add.PerformClick();//For Enter Button
                return true;
            }
            if (keyData == (Keys.Escape))
            {
                btn_exit.PerformClick();//For Escape Button
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //For Add Button

            //Taking Input from the User and Calculating it
            int scores = int.Parse(txt_score.Text);
            scoreTot += scores;
            Count++;
            scoreAvg = scoreTot / Count;

            //Printing Score Total, Score Count and Average 
            txt_stotal.Text = scoreTot.ToString();
            txt_scount.Text = Count.ToString();
            txt_avg.Text = scoreAvg.ToString();

            //Changing Focus to Diameter
            txt_score.Focus();

            txt_score.Text = "";

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            // For Exit Button
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //For Clear Button -> It makes all th field empty

            //Initializing variables as Null
            Count = 0;
            scoreTot = 0;
            scoreAvg = 0;
            txt_score.Text = "";
            txt_stotal.Text = "";
            txt_scount.Text = "";
            txt_avg.Text = "";

            //Changing Focus to Score
            txt_score.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Name: Natalia Andrea Herrera Espinosa
//Student ID: 2232086
//Date: 2023-12-18
//Final Exam

namespace FINAL_NataliaHerrera_2232086
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSecondForm_Click(object sender, EventArgs e)
        {
           
            // Validates the selected year. If invalid, shows an error message.
            if (!Validator.ValidateYear(txtYear.Text.Trim()))
            {

                MessageBox.Show($"This is not a valid Year: {txtYear.Text.Trim()}.\nPlease enter a valid year:\nValid years: 2020 to 2029", "Wrong Year");
                txtYear.Focus();


            }

            // Validates the selected session. If invalid, shows an error message.
            else if (!Validator.ValidateSession(txtSession.Text.Trim()))
            {
                MessageBox.Show($"This is not a valid Session: {txtSession.Text.Trim()}.\nPlease enter a valid session (Fall, Winter, Summer)", "Wrong Session");
                txtSession.Focus();


            }


            else 
            {
                Form2 obj = new Form2();
                obj.ShowDialog();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this app? ", "Exit ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                Application.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clears the text boxes for result and operation
            //reset to default values
            txtNameID.Text = "Natalia Andrea Herrera Espinosa   -  2232086";
            txtYear.Text = "2023";
            txtSession.Text = "Fall";
            txtYear.Focus();
        }

        

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            //change it to the button to do a validation otherwise in every input autovalidate doesnt let put the whole word
            /*
            int minimYear = 2020;
            int maxYear = 2029;

            // Validates the selected year. If invalid, shows an error message.
            if (!Validator.ValidateYear(txtYear.Text.Trim()))
            {

                MessageBox.Show($"Wrong Year: {txtYear.Text.Trim()}.\nPlease enter a valid year:\n{minimYear} to {maxYear}", "Wrong Year");
                txtYear.Focus();
            }
            */
        }

        private void txtSession_TextChanged(object sender, EventArgs e)
        {
            //change it to the button to do a validation
            /*
            // Validates the selected session. If invalid, shows an error message.
            if (!Validator.ValidateSession(txtSession.Text.Trim()))
            {
                MessageBox.Show($"Wrong Session: {txtSession.Text.Trim()}.\nPlease enter a valid session", "Wrong Session");
                txtSession.Focus();
            }
            */
        }




    }
}

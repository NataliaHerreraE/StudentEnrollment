using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Collections.Specialized.BitVector32;

//Name: Natalia Andrea Herrera Espinosa
//Student ID: 2232086
//Date: 2023-12-18
//Final Exam

namespace FINAL_NataliaHerrera_2232086
{
    public partial class Form2 : Form
    {

        // isntance of the class to do the grade calculations.
        CT2 finalGrades = new CT2();

        // File handling 
        FileStream fs = null;
        string dir = @"./Fall23"; // Directory for storing files.
        string fileTxt = "FExam.txt"; 
        string fileXml = "FExam.xml"; 

        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

            string path = Path.Combine(dir, fileTxt);
            // Checks if the directory exists. If not, creates it and a new file.
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                fs = new FileStream(path, FileMode.Create);
            }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to quit this app? ", "Exit ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                Application.Exit();
            }
        }


        private void textGradeMid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGradeProject_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGradeFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFinalGrade_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clearing the text fields and setting default values.
            txtMidterm.Text = "0";
            txtProject.Text = "0";
            txtFinal.Text = "0";
            txtGradeMidterm.Text = "0";
            txtGradeProject.Text = "0";
            txtGradeFinal.Text = "0";
            txtFinalGrade.Text = "0";
            txtGradeLetter.Text = "F";
        }
        private void txtGradeLetter_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            { // Validates each grade input and updates the corresponding fields.
              // If validation fails, it shows an error message and focuses on the invalid field.

                //first validation midterm
                if (!Validator.ValidateNumber(txtMidterm.Text.Trim())) // use the regex from Validator class to check if is a number under 100
                {
                    MessageBox.Show($"The grade {txtMidterm.Text} is not a valid number for the Midterm", "Please enter a number between 0-100");

                    txtMidterm.Focus();
                }
                else
                {
                    finalGrades.MidtermGrade = double.Parse(txtMidterm.Text.Trim());
                    //write the percentage calculating by the class CT2 into the textbox
                    txtGradeMidterm.Text = finalGrades.MidtermGrade.ToString();

                    txtMidterm.Focus();
                    
                    //second validation project
                    if (!Validator.ValidateNumber(txtProject.Text.Trim()))
                    {
                        MessageBox.Show($"The grade {txtProject.Text} is not a valid number for the Project", "Please enter a number between 0-100");
                        txtProject.Focus();
                    }
                    else
                    {
                        finalGrades.ProjectGrade = double.Parse(txtProject.Text.Trim());
                        //write the percentage calculating by the class CT2 into the textbox
                        txtGradeProject.Text = finalGrades.ProjectGrade.ToString();

                        txtProject.Focus();


                        //third validation final
                        if (!Validator.ValidateNumber(txtFinal.Text.Trim()))
                        {
                            MessageBox.Show($"The grade {txtFinal.Text} is not a valid number for the Final", "Please enter a number between 0-100");

                            txtFinal.Focus();
                        }
                        else
                        {
                            finalGrades.FinalGrade = double.Parse(txtFinal.Text.Trim());

                            txtGradeFinal.Text = finalGrades.FinalGrade.ToString();

                            txtFinalGrade.Text = finalGrades.TotalGrade().ToString();

                            txtGradeLetter.Text = finalGrades.Grade();
                    
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("IO Exception: " + ex.Message, "Exception Error");
            }
        }

     
        private void btnWriteTxt_Click(object sender, EventArgs e)
        {

            string path = Path.Combine(dir, fileTxt);
            string mid = txtMidterm.Text.Trim();
            string proj = txtProject.Text.Trim();
            string fin = txtFinal.Text.Trim();

            // Converts the calculated grades (after applying weightage) to strings for writing.
            string midterm = finalGrades.MidtermGrade.ToString();
            string project = finalGrades.ProjectGrade.ToString();
            string final = finalGrades.FinalGrade.ToString();
            string total = finalGrades.TotalGrade().ToString();
            string grade = finalGrades.Grade().ToString();
           

            // Tries to write the data to the file.
            try
            {
                // Opens or creates the file for appending text and obtains a StreamWriter.
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs);

                // data separated by a pipe '|'.
                writer.WriteLine($"{mid}|{proj}|{fin}|{midterm}|{project}|{final}|{total}|{grade}");

                // Closes the writer and the file stream.

                writer.Close();
                fs.Close();

                // Shows a message indicating successful data saving.
                MessageBox.Show($"Data succesfully saved into the txt file :{fileTxt}");

            }
            catch (IOException ex) 
            {
                MessageBox.Show(ex.Message, "IOException");
            }
            finally
            {
                // Ensures the file stream is closed even if an exception occurs.

                if (fs != null)
                    fs.Close();
            }
        }

        private void btnWriteXml_Click(object sender, EventArgs e)
        {
            // Defines paths for the text and XML files.
            // txt file
            string pathTxt = Path.Combine(dir, fileTxt);
            // xml file
            string pathXml = Path.Combine(dir, fileXml);

            try
            {
                // Opens the text file for reading.
                fs = new FileStream(pathTxt, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "";

                // Configures XML writer settings for indentation.
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = "  ";
                // Creates an XML writer for the XML file with the defined settings.
                XmlWriter xml = XmlWriter.Create(pathXml, settings);
                // Writes the start of the XML document.
                xml.WriteStartDocument();
                xml.WriteStartElement("Grades");

                string row = "";

                // Reads each line from the text file and writes it to the XML file.

                while (textIn.Peek() != -1)
                {
                    row = textIn.ReadLine();
                    textToPrint += row + "\n";

                    xml.WriteStartElement("Grade");
                    xml.WriteElementString("Info", row);
                    xml.WriteEndElement();
                }
                // Closes the text reader and the XML writer.
                textIn.Close();
                xml.WriteEndElement();
                xml.Close();

                // Shows a message indicating successful data saving.
                MessageBox.Show($"Data succesfully saved into the xml file : {fileXml}");
               
            }
            catch (IOException ex)
            {
                // If an IO exception occurs, it displays an error message.
                MessageBox.Show(ex.Message, "IOException");
            }
            finally
            {
                // make sure the file stream is closed even if an exception occurs.
                if (fs != null) { fs.Close(); }
                  
            }
        }

        private void btnReadXml_Click(object sender, EventArgs e)
        {

            // Defines the path for the XML file.
            string pathXml = Path.Combine(dir, fileXml);

            try
            {
                // Configures XML reader settings.
                XmlReaderSettings settings = new XmlReaderSettings();

                settings.IgnoreWhitespace = true;

                settings.IgnoreComments = true;

                // Creates an XML reader for the file with the
                XmlReader rdXml = XmlReader.Create(pathXml, settings);
                string temporal = "", row = "";

                if (rdXml.ReadToDescendant("Grade"))
                {
                    do
                    {
                        rdXml.ReadStartElement("Grade");


                        row = rdXml.ReadElementContentAsString();


                        temporal += row + "\n";

                    } while (rdXml.ReadToNextSibling("Grade"));
                }

                MessageBox.Show(temporal, "Waiting read");

                rdXml.Close();
            }

            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            }
        }

      
    }
}

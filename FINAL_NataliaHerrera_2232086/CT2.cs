using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_NataliaHerrera_2232086
{
    internal class CT2 : IFinal
    {

        // Private fields to hold the grades for midterm, project, and final.
        private double midtermGrade;
        private double projectGrade;
        private double finalGrade;



        // get /set accessors propierties
        // The getter returns the midterm grade after applying 30% weight and rounding it . 
        // is the same for the rest of operations implemented (midterm,project,final) with the specidy weight.
        public double MidtermGrade
        {

            get { return Math.Round((midtermGrade * 0.3), 2); }
            set { midtermGrade = value; }
        }

        public double ProjectGrade
        {
            get { return Math.Round((projectGrade * 0.3), 2); }
            set { projectGrade = value; }
        }

        public double FinalGrade
        {
            get { return Math.Round((finalGrade * 0.4), 2); }
            set { finalGrade = value; }
        }


        // Default constructor initializing all grades to 0.
        public CT2()
        {
            this.midtermGrade = 0;
            this.projectGrade = 0;
            this.finalGrade = 0;
        }

        // overloading constructor
        public CT2(double mid)
        {
            this.midtermGrade = mid;
            this.projectGrade = 0;
            this.finalGrade = 0;
        }
        public CT2(double mid, double proj)
        {
            this.midtermGrade = mid;
            this.projectGrade = proj;
            this.finalGrade = 0;
        }
        public CT2(double mid, double proj, double fin)
        {
            this.midtermGrade = mid;
            this.projectGrade = proj;
            this.finalGrade = fin;
        }



        // Method to calculate the total grade by summing the weighted grades of midterm, project, and final.
        public double TotalGrade()
        {
            double totalGrade = MidtermGrade + ProjectGrade + FinalGrade;
            return totalGrade;

        }

        // Method to determine the letter grade based on the total grade.
        public string Grade()
        {
            //initialized
            string grade = ""; 

            double total = TotalGrade();

            //  assign a letter grade based on the total grade.
            if (total >= 90 && total <= 100)
            {
                grade = "A";
            }

            else if (total >= 80 && total <= 89.9)
            {
                grade = "B";
            }


            else if (total >= 70 && total <= 79.9)
            {
                grade = "C";
            }


            else if (total >= 60 && total <= 69.9)
            {
                grade = "D";
            }

            else if (total >= 0 && total <= 59.9)
            {
                grade = "F";
            }


            else
            {
                grade = "NaG"; 
            }

            return grade;
        }

    



       
    }
}

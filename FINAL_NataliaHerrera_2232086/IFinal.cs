using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_NataliaHerrera_2232086
{
    internal interface IFinal
    {
        // Method to calculate the total grade by summing the weighted grades of midterm, project, and final.
        double TotalGrade();

        // Method to determine the letter grade based on the total grade.
        string Grade();

    }
}

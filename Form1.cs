using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSalaryReajust
{
    public partial class frmNetSalaryReajust : Form
    {
        public frmNetSalaryReajust()
        {
            InitializeComponent();
        }

        private void bttCalculate_Click(object sender, EventArgs e)
        {
            RadioButton rbnSelectedCategory = gbCategory.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
            RadioButton rbnSelectedWorkShift = gbWorkShift.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
            GetProcessing(rbnSelectedCategory, rbnSelectedWorkShift, Convert.ToDouble(txtMinimumWage.Text), Convert.ToDouble(txtWorkedHours.Text));
        }

        private void GetProcessing(RadioButton rbnSelectedCategory, RadioButton rbnSelectedWorkShift, double workedHours, double minimumWare)
        {
            double coeficientValue = GetCoeficient(rbnSelectedWorkShift);
            double gratificationValue = GetGratification(rbnSelectedWorkShift, workedHours);
            double grossSalary = workedHours * coeficientValue;
            double tax = GetTaxValue(rbnSelectedCategory, grossSalary);
            double foodAid = GetFoodAidValue(rbnSelectedCategory, grossSalary, minimumWare);
            double netSalaryValue = (grossSalary + (gratificationValue + foodAid)) - tax;
            ShowResult(coeficientValue, tax, gratificationValue, foodAid, netSalaryValue, grossSalary);
        }

        private void ShowResult(double coeficientValue, double tax, double gratificationValue, double foodAid, double netSalaryValue, double grossSalary)
        {
            txtBCategory.Text = GetInternSituation(netSalaryValue);
            lstInfo.Items.Add(String.Format("{0, -29}{1, 12:C}", "Coeficient value: ", coeficientValue));
            lstInfo.Items.Add(String.Format("{0, -29}{1, 12:C}", "Gross Salary: ", grossSalary));
            lstInfo.Items.Add(String.Format("{0, -29}{1, 12:C}", "Tax Value: ", tax));
            lstInfo.Items.Add(String.Format("{0, -29}{1, 12:C}", "Gratification value: ", gratificationValue));
            lstInfo.Items.Add(String.Format("{0, -29}{1, 12:C}", "Food aid value: ", foodAid));
            lstInfo.Items.Add(String.Format("{0, -29}{1, 12:C}", "Net salary", netSalaryValue));
        }

        private String GetInternSituation(double netSalaryValue)
        {
            if (netSalaryValue < 350)
                return "Ill-paid";
            else if (netSalaryValue < 600)
                return "Normal";
            else
                return "Well-paid";
        }

        private double GetFoodAidValue(RadioButton rbnSelectedCategory, double grossSalary, double minimumWare)
        {
            double foodAidValue = (grossSalary / 3) / 2;

            if (rbnSelectedCategory.Text.Equals("Freshman") && (grossSalary < minimumWare / 2))
                foodAidValue = (grossSalary / 3);
            return foodAidValue;
        }

        private double GetTaxValue(RadioButton rbnSelectedCategory, double grossSalary)
        {
            double taxValue = 0;

            switch (rbnSelectedCategory.Text)
            {
                case "Freshman":
                    if (grossSalary < 300)
                        taxValue = grossSalary * 0.01;
                    else
                        taxValue = grossSalary * 0.02;
                    break;
                case "Veteran":
                    if (grossSalary < 400)
                        taxValue = grossSalary * 0.03;
                    else
                        taxValue = grossSalary * 0.04;
                    break;
            }
            return taxValue;
        }

        private double GetGratification(RadioButton rbnSelectedWorkShift, double workedHours)
        {
            double gratificationValue = 30;

            if(rbnSelectedWorkShift.Text.Equals("Nocturnal") && workedHours > 80)
            {
                gratificationValue = 50;
            }

            return gratificationValue;
        }

        private double GetCoeficient(RadioButton rbnSelectedWorkShift)
        {
            var coeficientValue = 0.0;
            switch (rbnSelectedWorkShift.Text)
            {
                case "Morning":
                    coeficientValue = Convert.ToDouble(txtMinimumWage.Text) * 0.01;
                    break;
                case "Evening":
                    coeficientValue = Convert.ToDouble(txtMinimumWage.Text) * 0.02;
                    break;
                case "Nocturnal":
                    coeficientValue = Convert.ToDouble(txtMinimumWage.Text) * 0.03;
                    break;
            }
            return coeficientValue;
        }
    }
}

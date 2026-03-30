using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VILLANUEVA_ASSIGNMENT1_MIDTERM1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Declare variables for prelims
            //double passign1, passign2, precit1, precit2, psw1, psw2, totalpSW1, totalpSW2;
            //double plab1, plab2, plab3, plab4;
            //double pquiz1, pquiz2, pquiz3;
            //double plabExam1, plabExam2;
            //double pExam1, pFinalExamscore;
            //Declare for midterms
            //double massign1, massign2, mrecit1, mrecit2, msw1, msw2, totalmSW1, totalmSW2;
            double mlab1, mlab2, mlab3, mlab4;
            double mquiz1, mquiz2, mquiz3;
            double mlabExam1, mlabExam2;
            double mExam1, mFinalExamscore;
            //Declare for finals
            double fassign1, fassign2, frecit1, frecit2, fsw1, fsw2, totalfSW1, totalfSW2;
            double flab1, flab2, flab3, flab4;
            double fquiz1, fquiz2, fquiz3;
            double flabExam1, flabExam2;
            double fExam1, fFinalExamscore;
            // Using list for prelim to finals put inside and for code later
            List<double> prelimList_Seatwork = new List<double>();
            List<double> prelimList_Assignment = new List<double>();
            List<double> prelimList_Recitation = new List<double>();
            List<double> prelimList_Lab = new List<double>();
            //MIdterms
            //List<double> midtermList_Seatwork = new List<double>();
            //    List <double> midtermList_Assignment = new List<double>();
            //    List<double> midtermList_Recitation = new List<double>();
            //    List<double> midtermList_Lab = new List<double>();
            ////Finals
            //List<double> finalList_Seatwork = new List<double>();
            //    List<double> finalList_Assignment = new List<double>();
            //    List<double> finalList_Recitation = new List<double>();
            //    List<double> finalList_Lab = new List<double>();
            // using double tryparse to convert the textboxes to double and put it in the list for prelims
            //double.TryParse(txtPassign1.Text, out passign1);
            //double.TryParse(txtPassign2.Text, out passign2);
            //double.TryParse(txtPrecit1.Text, out precit1);
            //double.TryParse(txtPrecit2.Text, out precit2);
            //double.TryParse(txtPsw1.Text, out psw1);
            //double.TryParse(txtPsw2.Text, out psw2);
            //double.TryParse(txtPlab1.Text, out plab1);
            //double.TryParse(txtPlab2.Text, out plab2);
            //double.TryParse(txtPlab3.Text, out plab3);
            //double.TryParse(txtPlab4.Text, out plab4);
            //double.TryParse(txtPquiz1.Text, out pquiz1);
            //double.TryParse(txtPquiz2.Text, out pquiz2);
            //double.TryParse(txtPquiz3.Text, out pquiz3);
            //Using double tryparse to convert the textboxes to double and put it in the list for midterms
            //double.TryParse(txtMassign1.Text, out massign1);
            //double.TryParse(txtMassign2.Text, out massign2);
            //double.TryParse(txtMrecit1.Text, out mrecit1);
            //double.TryParse(txtMrecit2.Text, out mrecit2);
            //double.TryParse(txtMsw1.Text, out msw1);
            //double.TryParse(txtMsw2.Text, out msw2);
            double.TryParse(txtMlab1.Text, out mlab1);
            double.TryParse(txtMlab2.Text, out mlab2);
            double.TryParse(txtMlab3.Text, out mlab3);
            double.TryParse(txtMlab4.Text, out mlab4);
            double.TryParse(txtMquiz1.Text, out mquiz1);
            double.TryParse(txtMquiz2.Text, out mquiz2);
            double.TryParse(txtMquiz3.Text, out mquiz3);
            double.TryParse(txtMlabExam1.Text, out mlabExam1);
            double.TryParse(txtMlabExam2.Text, out mlabExam2);
            double.TryParse(txtmexam.Text, out mExam1);
            //Using double tryparse to convert the textboxes to double and put it in the list for finals
            double.TryParse(txtFassign1.Text, out fassign1);
            double.TryParse(txtFassign2.Text, out fassign2);
            double.TryParse(txtFrecit1.Text, out frecit1);
            double.TryParse(txtFrecit2.Text, out frecit2);
            double.TryParse(txtFsw1.Text, out fsw1);
            double.TryParse(txtFsw2.Text, out fsw2);
            double.TryParse(txtFlab1.Text, out flab1);
            double.TryParse(txtFlab2.Text, out flab2);
            double.TryParse(txtFlab3.Text, out flab3);
            double.TryParse(txtFlab4.Text, out flab4);
            //Adding into list for prelims









        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassign1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPassign2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPsw1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPsw2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPtotalscores1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPtotalscores2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPtotalRecit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPtotalRecit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttotalpSW1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttotalpSW2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPlab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPlab2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPlab3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPlab4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPquiz1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPquiz2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPquiz3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPlabExam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPlabExam2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMassign1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMassign2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMrecit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMrecit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMsw1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMsw2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMtotalscores1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMmtotalscores2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMtotalRecit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMtotalRecit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttotalmSW1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttotalmSW2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMquiz1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMquiz2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMquiz3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMlabExam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMlab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMlab2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMlab3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMlab4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFassign1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFassign2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFrecit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFrecit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFsw1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFsw2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFtotalscores1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFtotalscores2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFtotalRecit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFtotalRecit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttotalfSW1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttotalfSW2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFquiz1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFquiz2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFquiz3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox33_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtManuscript_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpresentation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFlab1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFlab2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFlab3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFlab4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GroupBox[] GB_LIST = { GB1, GB2, GB3, GB4, GB5, GB6, GB7, GB8, GB9, GB10, GB11, GB12, GB13, GB14, GB14 };
            foreach (GroupBox groupBox in GB_LIST)
            {
                foreach (Control control in groupBox.Controls)
                {
                    if (control is TextBox)
                    {
                        control.Text = string.Empty;
                    }
                }
            }
        }

        private void btncompute_Click(object sender, EventArgs e)
        {
            try
            {
                double prelim_final, midterm_final, final_final;
                double.TryParse(txtPFinalScore.Text, out prelim_final);
                double.TryParse(txtMFinalScore.Text, out midterm_final);
                double.TryParse(txtFfinalscore.Text, out final_final);
                List<double> Final_Grade = new List<double> { prelim_final, midterm_final, final_final };
                for (int i = 0; i < Final_Grade.Count; i++)
                {
                    
                    if(Final_Grade[i] > 0)
                    {
                        double finalGrade = (prelim_final * 0.33) + (midterm_final * 0.33) + (final_final * 0.33);
                        txtFinalOutput.Font = new Font(txtFinalOutput.Font.FontFamily, 18f);
                        txtFinalOutput.Text = finalGrade.ToString("0.00");
                        txtFinalOutput.BackColor = Color.LightGreen;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating the final grade: {ex}");
            }

        }

        private void txtPFINALCLASS_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CalculateClassPerformanceP(object sender, EventArgs e)
        {


        }

        private void txtClassperformance_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnPmax_Click(object sender, EventArgs e)
        {
            try
            {
                double passign1, passign2, precit1, precit2, psw1, psw2, pfinalclass;
                double Pmaxscore1, Pmaxscore2, PtotalRecit1, PtotalRecit2, totalpSW1, totalpSW2;
                //initial scores for prelim Class Performance
                double.TryParse(txtPassign1.Text, out passign1);
                double.TryParse(txtPassign2.Text, out passign2);
                double.TryParse(txtPrecit1.Text, out precit1);
                double.TryParse(txtPrecit2.Text, out precit2);
                double.TryParse(txtPsw1.Text, out psw1);
                double.TryParse(txtPsw2.Text, out psw2);
                //double tryparse for the max score and total recitation and total seatwork for prelims
                double.TryParse(txtPtotalscores1.Text, out Pmaxscore1);
                double.TryParse(txtPtotalscores2.Text, out Pmaxscore2);
                double.TryParse(txtPtotalRecit1.Text, out PtotalRecit1);
                double.TryParse(txtPtotalRecit2.Text, out PtotalRecit2);
                double.TryParse(txttotalpSW1.Text, out totalpSW1);
                double.TryParse(txttotalpSW2.Text, out totalpSW2);
                //textbox for the final class performance

                //reset number
                pfinalclass = 0;
                double itemCount = 0;
                //List for for loop
                List<double> prelimList_ClassPerformance = new List<double> { passign1, passign2, precit1, precit2, psw1, psw2 };
                List<double> postlimList_ClassPerformance = new List<double> { Pmaxscore1, Pmaxscore2, PtotalRecit1, PtotalRecit2, totalpSW1, totalpSW2 };
                // use for for loop
                for (int i = 0; i < prelimList_ClassPerformance.Count; i++)
                {
                    double score = prelimList_ClassPerformance[i];
                    double maxScore = postlimList_ClassPerformance[i];
                    if (maxScore > 0 && maxScore >= score)
                    {
                        double percentage = (score / maxScore) * 60 + 40;
                        pfinalclass += percentage;
                        itemCount++;
                    }

                }
                if (itemCount > 0)

                {
                    double finalGrade1 = pfinalclass / itemCount;
                    txtPFINALCLASS.Text = String.Format("{0:0.00}", finalGrade1);
                    txtPFINALCLASS.Text = finalGrade1.ToString("0.00");
                    txtPFINALCLASS.BackColor = Color.LightGreen;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("An error occurred while calculating the class performance: ");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("An error occurred while calculating the class performance: Division by zero is not allowed.");
            }
            //using Laboratory Exercise for prelims
            try
            {
                double plab1, plab2, plab3, plab4, Max_lab_scorePrelim;
                double.TryParse(txtPlab1.Text, out plab1);
                double.TryParse(txtPlab2.Text, out plab2);
                double.TryParse(txtPlab3.Text, out plab3);
                double.TryParse(txtPlab4.Text, out plab4);
                double.TryParse(txtLABMAXP.Text, out Max_lab_scorePrelim);
                double totalLabScore = plab1 + plab2 + plab3 + plab4;
                //use variables for for loop and adding after the loop and count for the number of lab exercises with scores greater than 0
                double plabfinal = 0;
                int labCount = 0;
                List<double> prelimList_Lab = new List<double> { plab1, plab2, plab3, plab4 };
                for (int i = 0; i < prelimList_Lab.Count; i++)
                {
                    double prelim = prelimList_Lab[i];
                    if (prelim > 0 && prelim <= 100)
                    {
                        double percentage = (prelim / 100) * 60 + 40;
                        plabfinal += percentage;
                        labCount++;
                    }
                }
                if (labCount > 0)
                {
                    double finalLabGrade = plabfinal / labCount;
                    txtLABMAXP.Text = finalLabGrade.ToString("0.00");
                    txtPFINALCLASS.BackColor = Color.LightGreen;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating the class performance {ex}, Error");
            }
            //Using this for grading quizzes
            try
            {
                double pquiz1, pquiz2, pquiz3;
                double.TryParse(txtPquiz1.Text, out pquiz1);
                double.TryParse(txtPquiz2.Text, out pquiz2);
                double.TryParse(txtPquiz3.Text, out pquiz3);
                List<double> prelimList_Quiz = new List<double> { pquiz1, pquiz2, pquiz3 };
                //Variables for adding the for loop results into one variable and counting the number of quizzes with scores greater than 0
                double quizfinal = 0;
                int quizCount = 0;
                //Looping for checking grades
                for (int i = 0; i < prelimList_Quiz.Count; i++)
                {
                    double quiz = prelimList_Quiz[i];
                    if (quiz > 0 && quiz <= 100)
                    {
                        double percentage = (quiz / 100) * 60 + 40;
                        quizfinal += percentage;
                        quizCount++;
                    }
                }
                if (quizCount > 0)
                {
                    double finalQuizGrade = quizfinal / quizCount;
                    txtQuizMaxP.Text = finalQuizGrade.ToString("0.00");
                    txtQuizMaxP.BackColor = Color.LightGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating the class performance {ex}, Error");
            }
            try
            {
                double plabExam1, plabExam2, Lab_Exam_Prelimmax;
                double.TryParse(txtPlabExam1.Text, out plabExam1);
                double.TryParse(txtPlabExam2.Text, out plabExam2);
                double.TryParse(txtLabexammaxP.Text, out Lab_Exam_Prelimmax);
                List<double> prelimList_LabExam = new List<double> { plabExam1, plabExam2 };
                //Variables for placing text into textbox
                double Lab_Exam_Prelimmax2 = 0;
                double Lab_Examcount = 0;
                //For loop for checking the lab exam grades and counting the number of lab exams with scores greater than 0
                for (int i = 0; i < prelimList_LabExam.Count; i++)
                {
                    double labExam = prelimList_LabExam[i];
                    if (labExam > 0 && labExam <= 100)
                    {
                        double percentage = (labExam / 100) * 60 + 40;
                        Lab_Exam_Prelimmax2 += percentage;
                        Lab_Examcount++;
                    }

                }
                if (Lab_Examcount > 0)
                {
                    double finalLabExamGrade = Lab_Exam_Prelimmax2 / Lab_Examcount;
                    txtLabexammaxP.Text = finalLabExamGrade.ToString("0.00");
                    txtLabexammaxP.BackColor = Color.LightGreen;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"An error occurred while calculating the class performance {error}");
            }
            // Computation of Prelim grades
            try
            {
                double pExam1, pFinalExamscore, Class_Performance_finalP, Lab_Ex_FinalP, Quizzes_FinalP, Lab_examfinalP;
                double.TryParse(txtPexam.Text, out pExam1);
                double.TryParse(txtPFINALCLASS.Text, out Class_Performance_finalP);
                double.TryParse(txtLABMAXP.Text, out Lab_Ex_FinalP);
                double.TryParse(txtQuizMaxP.Text, out Quizzes_FinalP);
                double.TryParse(txtLABMAXP.Text, out Lab_examfinalP);
                if (pExam1 > 0)
                {

                    pFinalExamscore = (pExam1 / 100) * 60 + 40;
                    double FINALGRADE_PRELIMS = (Class_Performance_finalP * 0.10) + (Lab_Ex_FinalP * 0.10) + (Quizzes_FinalP * 0.20) + (Lab_examfinalP * 0.20) + (pFinalExamscore * 0.40);
                    txtPFinalScore.Text = FINALGRADE_PRELIMS.ToString();


                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"An error occurred while calculating the class performance, {error}");
            }

        }

        private void txtQuizMaxP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMMAX_Click(object sender, EventArgs e)
        {
            try
            {
                double massign1, massign2, mrecit1, mrecit2, msw1, msw2;
                double Mmaxscore1, Mmaxscore2, MtotalRecit1, MtotalRecit2, totalmSW1, totalmSW2;
                double.TryParse(txtMassign1.Text, out massign1);
                double.TryParse(txtMassign2.Text, out massign2);
                double.TryParse(txtMrecit1.Text, out mrecit1);
                double.TryParse(txtMrecit2.Text, out mrecit2);
                double.TryParse(txtMsw1.Text, out msw1);
                double.TryParse(txtMsw2.Text, out msw2);
                double.TryParse(txtMtotalscores1.Text, out Mmaxscore1);
                double.TryParse(txtMmtotalscores2.Text, out Mmaxscore2);
                double.TryParse(txtMtotalRecit1.Text, out MtotalRecit1);
                double.TryParse(txtMtotalRecit2.Text, out MtotalRecit2);
                double.TryParse(txttotalmSW1.Text, out totalmSW1);
                double.TryParse(txttotalmSW2.Text, out totalmSW2);
                //variable for loop
                double MFINALCLASS = 0;
                double itemcount = 0;
                List<double> midtermList_ClassPerformance = new List<double> { massign1, massign2, mrecit1, mrecit2, msw1, msw2 };
                List<double> midtermList_ClassPerformanceMax = new List<double> { Mmaxscore1, Mmaxscore2, MtotalRecit1, MtotalRecit2, totalmSW1, totalmSW2 };
                //for looping
                for (int i = 0; i < midtermList_ClassPerformance.Count; i++)
                {
                    double score = midtermList_ClassPerformance[i];
                    double maxScore = midtermList_ClassPerformanceMax[i];
                    if (score > 0 && maxScore >= score)
                    {
                        double percentage = (score / maxScore) * 60 + 40;
                        MFINALCLASS += percentage;
                        itemcount++;
                    }
                }
                if (itemcount > 0)
                {
                    txtMFINALCLASS.Text = (MFINALCLASS / itemcount).ToString("0.00");
                    txtMFINALCLASS.BackColor = Color.LightGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating the class performance {ex}, Error");
            }
            try
            {
                double mlab1, mlab2, mlab3, mlab4;
                double.TryParse(txtMlab1.Text, out mlab1);
                double.TryParse(txtMlab2.Text, out mlab2);
                double.TryParse(txtMlab3.Text, out mlab3);
                double.TryParse(txtMlab4.Text, out mlab4);

                double totalLabScore = mlab1 + mlab2 + mlab3 + mlab4;
                //use variables for for loop and adding after the loop and count for the number of lab exercises with scores greater than 0
                double mlabfinal = 0;
                int labCount = 0;
                List<double> midtermList_Lab = new List<double> { mlab1, mlab2, mlab3, mlab4 };
                for (int i = 0; i < midtermList_Lab.Count; i++)
                {
                    double midterm = midtermList_Lab[i];
                    if (midterm > 0 && midterm <= 100)
                    {
                        double percentage = (midterm / 100) * 60 + 40;
                        mlabfinal += percentage;
                        labCount++;
                    }
                }
                if (labCount > 0)
                {
                    double finalLabGrade = mlabfinal / labCount;
                    txtLABMAXM.Text = finalLabGrade.ToString("0.00");
                    txtLABMAXM.BackColor = Color.LightGreen;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating the class performance {ex}, Error");
            }
            try
            {
                double mquiz1, mquiz2, mquiz3;
                double.TryParse(txtMquiz1.Text, out mquiz1);
                double.TryParse(txtMquiz2.Text, out mquiz2);
                double.TryParse(txtMquiz3.Text, out mquiz3);
                
                //use variables to show results
                double mquizfinal = 0;
                double itemcount = 0;
                List<double> midtermList_Quiz = new List<double> { mquiz1, mquiz2, mquiz3 };
                //for loop
                for (int i = 0; i < midtermList_Quiz.Count; i++)
                {
                    double midterm_quiz = midtermList_Quiz[i];
                    if (midterm_quiz >= 0 && midterm_quiz <= 100)
                    {
                        double percentage = (midterm_quiz /100) * 60 + 40;
                        mquizfinal += percentage;
                        itemcount++;
                    }
                }
                if (itemcount > 0)
                {
                    double quiz_final_text = mquizfinal / itemcount;
                    txtQuizMaxM.Text = quiz_final_text.ToString("0.00");
                    txtQuizMaxM.BackColor = Color.LightGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating the class performance");
            }
            try
            {
                double mlab_exam1, mlab_exam2;
                double.TryParse(txtMlabExam1.Text, out mlab_exam1);
                double.TryParse(txtMlabExam2.Text, out mlab_exam2);
             
                //use variables to show results
                double mlabfinal = 0;
                double itemcount_lab = 0;
                List<double> midtermListLabexam = new List<double> { mlab_exam1, mlab_exam2};
                //for loop
                for (int i = 0; i < midtermListLabexam.Count; i++)
                {
                    double midterm_quiz = midtermListLabexam[i];
                    if (midterm_quiz > 0 && midterm_quiz <= 100)
                    {
                        double percentage = (midterm_quiz / 100) * 60 + 40;
                        mlabfinal += percentage;
                        itemcount_lab++;
                    }
                }
                if (itemcount_lab > 0)
                {
                    double labexam_final_text = mlabfinal / itemcount_lab;
                    txtLabexammaxM.Text = labexam_final_text.ToString("0.00");
                    txtLabexammaxM.BackColor = Color.LightGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating the class performance {ex}");
            }
            try
            {
                double mExam1, mFinalExamscore, Class_Performance_finalM, Lab_Ex_FinalM, Quizzes_FinalM, Lab_examfinalM;
                double.TryParse(txtmexam.Text, out mExam1);
                double.TryParse(txtMFINALCLASS.Text, out Class_Performance_finalM);
                double.TryParse(txtLABMAXM.Text, out Lab_Ex_FinalM);
                double.TryParse(txtQuizMaxM.Text, out Quizzes_FinalM);
                double.TryParse(txtLABMAXM.Text, out Lab_examfinalM);
                if (mExam1 > 0)
                {

                    mFinalExamscore = (mExam1 / 100) * 60 + 40;
                    double FINALGRADE_PRELIMS = (Class_Performance_finalM * 0.10) + (Lab_Ex_FinalM * 0.10) + (Quizzes_FinalM * 0.20) + (Lab_examfinalM * 0.20) + (mFinalExamscore * 0.40);
                    txtMFinalScore.Text = FINALGRADE_PRELIMS.ToString("0.00");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"An error occurred while calculating the class performance, {error}");
            }
      
        }

        private void btnFMAX_Click(object sender, EventArgs e)
        {
            try
            {
                double fassign1, fassign2, frecit1, frecit2, fsw1, fsw2;
                double fmaxscore1, fmaxscore2, ftotalRecit1, ftotalRecit2, totalfSW1, totalfSW2;
                double.TryParse(txtFassign1.Text, out fassign1);
                double.TryParse(txtFassign2.Text, out fassign2);
                double.TryParse(txtFrecit1.Text, out frecit1);
                double.TryParse(txtFrecit2.Text, out frecit2);
                double.TryParse(txtFsw1.Text, out fsw1);
                double.TryParse(txtFsw2.Text, out fsw2);
                double.TryParse(txtFtotalscores1.Text, out fmaxscore1);
                double.TryParse(txtFtotalscores2.Text, out fmaxscore2);
                double.TryParse(txtFtotalRecit1.Text, out ftotalRecit1);
                double.TryParse(txtFtotalRecit2.Text, out ftotalRecit2);
                double.TryParse(txttotalfSW1.Text, out totalfSW1);
                double.TryParse(txttotalfSW2.Text, out totalfSW2);
                //variable for loop
                double FFINALCLASS = 0;
                double itemcount = 0;
                List<double> finalsList_ClassPerformance = new List<double> { fassign1, fassign2, frecit1, frecit2, fsw1, fsw2 };
                List<double> finalsList_ClassPerformanceMax = new List<double> { fmaxscore1, fmaxscore2, ftotalRecit1, ftotalRecit2, totalfSW1, totalfSW2 };
                //for looping
                for (int i = 0; i < finalsList_ClassPerformance.Count; i++)
                {
                    double score = finalsList_ClassPerformance[i];
                    double maxScore = finalsList_ClassPerformanceMax[i];
                    if (score > 0 && maxScore >= score)
                    {
                        double percentage = (score / maxScore) * 60 + 40;
                        FFINALCLASS += percentage;
                        itemcount++;
                    }
                }
                if (itemcount > 0)
                {
                    txtFFINALCLASS.Text = (FFINALCLASS / itemcount).ToString("0.00");
                    txtFFINALCLASS.BackColor = Color.LightGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating the class performance {ex}, Error");
            }
            try
            {
                double flab1, flab2, flab3, flab4;
                double.TryParse(txtFlab1.Text, out flab1);
                double.TryParse(txtFlab2.Text, out flab2);
                double.TryParse(txtFlab3.Text, out flab3);
                double.TryParse(txtFlab4.Text, out flab4);

                double totalLabScore = flab1 + flab2 + flab3 + flab4;
                //use variables for for loop and adding after the loop and count for the number of lab exercises with scores greater than 0
                double flabfinal = 0;
                int labCount = 0;
                List<double> FinalsList_Lab = new List<double> { flab1, flab2, flab3, flab4 };
                for (int i = 0; i < FinalsList_Lab.Count; i++)
                {
                    double midterm = FinalsList_Lab[i];
                    if (midterm > 0 && midterm <= 100)
                    {
                        double percentage = (midterm / 100) * 60 + 40;
                        flabfinal += percentage;
                        labCount++;
                    }
                }
                if (labCount > 0)
                {
                    double finalLabGrade = flabfinal / labCount;
                    txtLABMAXF.Text = finalLabGrade.ToString("0.00");
                    txtLABMAXF.BackColor = Color.LightGreen;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating the class performance {ex}, Error");
            }
            try
            {
                double fquiz1, fquiz2, fquiz3;
                double.TryParse(txtFquiz1.Text, out fquiz1);
                double.TryParse(txtFquiz2.Text, out fquiz2);
                double.TryParse(txtFquiz3.Text, out fquiz3);

                //use variables to show results
                double fquizfinal = 0;
                double itemcount = 0;
                List<double> FinalsList_Quiz = new List<double> { fquiz1, fquiz2, fquiz3 };
                //for loop
                for (int i = 0; i < FinalsList_Quiz.Count; i++)
                {
                    double Finals_quiz = FinalsList_Quiz[i];
                    if (Finals_quiz >= 0 && Finals_quiz <= 100)
                    {
                        double percentage = (Finals_quiz / 100) * 60 + 40;
                        fquizfinal += percentage;
                        itemcount++;
                    }
                }
                if (itemcount > 0)
                {
                    double quiz_final_text = fquizfinal / itemcount;
                    txtQuizMaxF.Text = quiz_final_text.ToString("0.00");
                    txtQuizMaxF.BackColor = Color.LightGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating the class performance");
            }
            try
            {
                double fmanuscipt, fpresentation;
                double.TryParse(txtManuscript.Text, out fmanuscipt);
                double.TryParse(txtpresentation.Text, out fpresentation);

                //use variables to show results
                double fproject = 0;
                double itemcount_lab = 0;
                List<double> Final_presentation = new List<double> { fmanuscipt, fpresentation };
                //for loop
                for (int i = 0; i < Final_presentation.Count; i++)
                {
                    double Project = Final_presentation[i];
                    if (Project > 0 && Project <= 100)
                    {
                        double percentage = (Project / 100) * 60 + 40;
                        fproject+= percentage;
                        itemcount_lab++;
                    }
                }
                if (itemcount_lab > 0)
                {
                    double labexam_final_text = fproject / itemcount_lab;
                    txtprojectMaxF.Text = labexam_final_text.ToString("0.00");
                    txtprojectMaxF.BackColor = Color.LightGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while calculating the class performance {ex}");
            }
            try
            {
                double fExam1, fFinalExamscore, Class_Performance_finalF, Lab_Ex_FinalF, Quizzes_FinalF, Project_Final_Finals;
                double.TryParse(txtfFexam.Text, out fExam1);
                double.TryParse(txtFFINALCLASS.Text, out Class_Performance_finalF);
                double.TryParse(txtLABMAXF.Text, out Lab_Ex_FinalF);
                double.TryParse(txtQuizMaxF.Text, out Quizzes_FinalF);
                double.TryParse(txtprojectMaxF.Text, out Project_Final_Finals);
                if (fExam1 > 0)
                {

                    fFinalExamscore = (fExam1 / 100) * 60 + 40;
                    double FINALGRADE_PRELIMS = (Class_Performance_finalF * 0.05) + (Lab_Ex_FinalF * 0.10) + (Quizzes_FinalF * 0.20) + (Project_Final_Finals * 0.25) + (fFinalExamscore * 0.40);
                    txtFfinalscore.Text = FINALGRADE_PRELIMS.ToString("0.00");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"An error occurred while calculating the class performance, {error}");
            }

        
        }
    }   
}
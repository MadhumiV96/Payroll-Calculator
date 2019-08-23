using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace PayrollApplication
{
    public partial class PayrollCalculator : Form
    {
        string fullName =string.Empty;
        double Mon1 = 0.00, Tues1=0.00, wed1=0.00, thurs1=0.00,fri1=0.00,sat1=0.00,sun1=0.00;
        double Mon2 = 0.00,Tues2=0.00, wed2=0.00, thurs2=0.00,fri2=0.00,sat2=0.00,sun2=0.00;
        double Mon3 = 0.00, Tues3 = 0.00, wed3 = 0.00, thurs3 = 0.00, fri3 = 0.00, sat3 = 0.00, sun3 = 0.00;
        double Mon4 = 0.00, Tues4 = 0.00, wed4 = 0.00, thurs4 = 0.00, fri4 = 0.00, sat4 = 0.00, sun4 = 0.00;

        

        private void savePayBtn_Click(object sender, EventArgs e)
        {
            String cs = ConfigurationManager.ConnectionStrings["PayrollSystemDBConnectionString"].ConnectionString;
            SqlConnection objSqlConnection = new SqlConnection(cs);
            string insertCommand ="INSERT INTO tblPayRecords" +
                                    "(EmployeeID, FullName, NINumber, PayDate, PayPeriod, PayMonth, HourlyRate, ContractualHours,OverTimeHours, TotalHours, ContractualEarnings, OverTimeEarnings, TotalEarnings, TaxCode, TaxAmount,NIContribution, UnionFee, SLC, TotalDeduction, NextPay)" +
                                    "VALUES (@EmployeeID, @FullName, @NINumber, @PayDate, @PayPeriod, @PayMonth, @HourlyRate,@ContractualHours, @OverTimeHours, @TotalHours, @ContractualEarnings, @OverTimeEarnings,@TotalEarnings, @TaxCode, @TaxAmount, @NIContribution, @UnionFee, @SLC, @TotalDeduction,@NextPay)";

            SqlCommand objInsertCommand = new SqlCommand(insertCommand, objSqlConnection);
            objInsertCommand.Parameters.AddWithValue("@EmployeeID", empIdtxt.Text);
            objInsertCommand.Parameters.AddWithValue("@FullName", fullNameLabel.Text);
            objInsertCommand.Parameters.AddWithValue("@NINumber", insuarnceNoTxt.Text);
            objInsertCommand.Parameters.AddWithValue("@PayDate", payDatePicker.Value.ToString("MM/dd/yyyy"));
            objInsertCommand.Parameters.AddWithValue("@PayPeriod", payPeriodList.SelectedItem.ToString());
            objInsertCommand.Parameters.AddWithValue("@PayMonth", monthCombo.SelectedItem.ToString());
            objInsertCommand.Parameters.AddWithValue("@HourlyRate", hourlyRateNumericUpDown.Value.ToString());
            objInsertCommand.Parameters.AddWithValue("@ContractualHours", contratualHoursTxt.Text);
            objInsertCommand.Parameters.AddWithValue("@OverTimeHours", overTimeHoursTxt.Text);
            objInsertCommand.Parameters.AddWithValue("@TotalHours", TotalHoursTxt.Text);
            objInsertCommand.Parameters.AddWithValue("@ContractualEarnings", ContEarningTxt.Text);
            objInsertCommand.Parameters.AddWithValue("@OverTimeEarnings", overTimeEarningTxt.Text);
            objInsertCommand.Parameters.AddWithValue("@TotalEarnings", totalEarningTxt.Text);
            objInsertCommand.Parameters.AddWithValue("@TaxCode", taxCodeTxt.Text);
            objInsertCommand.Parameters.AddWithValue("@TaxAmount", taxAmountTxt.Text);
            objInsertCommand.Parameters.AddWithValue("@NIContribution", NIContributionTxt.Text);
            objInsertCommand.Parameters.AddWithValue("@UnionFee", unionTxt.Text);
            objInsertCommand.Parameters.AddWithValue("@SLC", slcTxt.Text);
            objInsertCommand.Parameters.AddWithValue("@TotalDeduction", totalDeductionsTxt.Text);
            objInsertCommand.Parameters.AddWithValue("@NextPay", netPayTxt.Text);

            try
            {
                objSqlConnection.Open();
                objInsertCommand.ExecuteNonQuery();
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Following Error" + ex.Message, "Query Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            finally {
                objSqlConnection.Close();
            }
            ResetControls();
            this.tblPayRecordsTableAdapter.Fill(this.payrollSystemDBDataSet1.tblPayRecords);


        }




        private void ResetControls()
        {
            empIdtxt.Text ="";
            firstNameTxt.Text ="";
            lastNmTxt.Text ="";
            insuarnceNoTxt.Text ="";
            fullNameLabel.Text ="";
            payPeriodList.SelectedIndex = 0;
            monthCombo.SelectedIndex = 0;
            numMon1.Text ="0.00";
            numTues1.Text = "0.00";
            numWed1.Text = "0.00";
            numThurs1.Text = "0.00";
            numFri1.Text = "0.00";
            numSat1.Text = "0.00";
            numSund1.Text = "0.00";
            numMon2.Text = "0.00";
            numTues2.Text = "0.00";
            numWed2.Text = "0.00";
            numThurs2.Text = "0.00";
            numFri2.Text = "0.00";
            numSat2.Text = "0.00";
            numSund2.Text = "0.00";
            numMon3.Text = "0.00";
            numTues3.Text = "0.00";
            numWed3.Text = "0.00";
            numThurs3.Text = "0.00";
            numFri3.Text = "0.00";
            numSat3.Text = "0.00";
            numSund3.Text = "0.00";
            numMon4.Text = "0.00";
            numTues4.Text = "0.00";
            numWed4.Text = "0.00";
            numThurs4.Text = "0.00";
            numFri4.Text = "0.00";
            numSat4.Text = "0.00";
            numSund4.Text = "0.00";
            contratualHoursTxt.Text = "0.00";
            ContEarningTxt.Text = "0.00";
            overTimeHoursTxt.Text = "0.00";
            overTimeEarningTxt.Text = "0.00";
            hourlyRateNumericUpDown.Text = "0.00";
            NIContributionTxt.Text = "0.00";
            unionTxt.Text = "0.00";
            taxAmountTxt.Text = "0.00";
            slcTxt.Text = "0.00";
            totalDeductionsTxt.Text = "0.00";
            totalEarningTxt.Text = "0.00";
            TotalHoursTxt.Text = "0.00";
            netPayTxt.Text = "0.00";
            overTimeRateTxt.Text = "0.00";
            hoursTxt.Text = "0.00";
            minutesTxt.Text = "0.00";
            decimalTtx.Text = "0.00";
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double totalHoursWk1, totalHoursWk2, totalHoursWk3, totalHoursWk4;

        private void monthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void winCalcLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("calc.exe");
            
        }

        private void payrollTimer_Tick(object sender, EventArgs e)
        {
            DateTime dt =DateTime.Now;
            timeLabel.Text =dt.ToString("HH:mm:ss");
        }

        private void timeCalculateBtn_Click(object sender, EventArgs e)
        {
            decimal hours, minutes, decimalHours =0.00M;
            if (decimal.TryParse(hoursTxt.Text,out hours))
            {
                if (decimal.TryParse(minutesTxt.Text, out minutes))
                {
                    decimalHours =ConvertTimeToDecimal(hours,minutes);
                    decimalTtx.Text =decimalHours.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Please enter real number only for minutes");
                    minutesTxt.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter real number only for hours");
                hoursTxt.Focus();
            }
        }

        private decimal ConvertTimeToDecimal(decimal hh, decimal mm)
        {
            return (hh + (mm / 60));

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder searchStatement =new StringBuilder();
                if (paymentIDTxt.Text.Length>0)
                {
                    searchStatement.Append("Convert(PaymentID,'System.String') like'%"+paymentIDTxt.Text+"%'");
                }
                if (emloyeeIdTxt.Text.Length>0)
                {
                    if (searchStatement.Length>0)
                    {
                        searchStatement.Append("and");
                    }
                    searchStatement.Append("Convert(EmployeeID,'System.String') like'%" + emloyeeIdTxt.Text + "%'");
                }
                if (fNameTxt.Text.Length > 0)
                {
                    if (searchStatement.Length > 0)
                    {
                        searchStatement.Append("and");
                    }
                    searchStatement.Append("FullName like'%" + fNameTxt.Text + "%'");
                }
                if (NINumberTxt.Text.Length > 0)
                {
                    if (searchStatement.Length > 0)
                    {
                        searchStatement.Append("and");
                    }
                    searchStatement.Append("NINumber like'%" + NINumberTxt.Text + "%'");
                }
                if (payDTxt.Text.Length > 0)
                {
                    if (searchStatement.Length > 0)
                    {
                        searchStatement.Append("and");
                    }
                    searchStatement.Append("Convert(PayDate,'System.String') like'%" + payDTxt.Text + "%'");
                }
                if (payMCombo.SelectedIndex > 0)
                {
                    if (searchStatement.Length > 0)
                    {
                        searchStatement.Append("and");
                    }
                    searchStatement.Append("PayMonth like'%" + payMCombo.Text + "%'");
                }
                tblPayRecordsBindingSource.Filter =searchStatement.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Following error occured"+ex.Message,"Search Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            paymentIDTxt.Text = "";
            emloyeeIdTxt.Text = "";
            fNameTxt.Text = "";
            NINumberTxt.Text = "";
            payDTxt.Text = "";
            payMCombo.SelectedIndex = 0;

        }

        private void generatePaySlipBtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document =printDocument1;
            printPreviewDialog1.Show();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // e.Graphics.DrawString("Hello world",new Font ("Times New Roman",20,FontStyle.Bold),Brushes.Red,new Point (0,0));
            e.Graphics.DrawLine(new Pen(Color.Blue,2),90,90,750,90);
            Image objImage =Image.FromFile(@"C:\Users\user\source\repos\PayrollApplication\PayrollApplication\Resources\iconfinder_175_file_report_invoice_card_checklist_4308338.png");
            e.Graphics.DrawImage(objImage,60,100);
            e.Graphics.DrawString("Payroll Application Inc", new Font("Times New Roman", 24, FontStyle.Bold), Brushes.DarkBlue, new Point(300, 110));
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), 300, 170, 750, 170);
            e.Graphics.DrawString("Pay Date :"+ payDatePicker.Value.ToString("dd/MM/yyyy"), new Font("Times New Roman", 16, FontStyle.Regular), Brushes.DarkBlue, new Point(500, 180));
            e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), 100, 280, 700, 50);

            e.Graphics.DrawString("Employee Id :"+empIdtxt.Text+"           Name :"+fullNameLabel.Text+"         NI Number :"+ insuarnceNoTxt.Text,new Font("Times New Roman",16,FontStyle.Regular),Brushes.DarkBlue,new Point(110,300));

            
            e.Graphics.DrawString("Earnings", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.DarkBlue, new Point(100, 380));
            e.Graphics.DrawString("Hours", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.DarkBlue, new Point(250, 380));
            e.Graphics.DrawString("Rates", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.DarkBlue, new Point(350, 380));
            e.Graphics.DrawString("Amounts", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.DarkBlue, new Point(440, 380));
            e.Graphics.DrawString("Deductions", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.DarkBlue, new Point(550, 380));
            e.Graphics.DrawString("Amounts", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.DarkBlue, new Point(700, 380));

            e.Graphics.DrawLine(new Pen(Color.Blue, 2), 90, 405, 750, 405);

            e.Graphics.DrawString("Basic :", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.DarkBlue, new Point(100, 410));
            e.Graphics.DrawString(contratualHoursTxt.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(250, 410));
            e.Graphics.DrawString(hourlyRateNumericUpDown.Value.ToString("F"), new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(350, 410));
            e.Graphics.DrawString(ContEarningTxt.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(440, 410));
            e.Graphics.DrawString("Tax 110L :", new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(550, 410));
            e.Graphics.DrawString(taxAmountTxt.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(700, 410));

            e.Graphics.DrawString("Over Time :", new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(100, 430));
            e.Graphics.DrawString(overTimeHoursTxt.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(250, 430));
            e.Graphics.DrawString(overTimeRateTxt.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(350, 430));
            e.Graphics.DrawString(overTimeEarningTxt.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(440, 430));
            e.Graphics.DrawString("NIC :", new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(550, 430));
            e.Graphics.DrawString(NIContributionTxt.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(700, 430));

            e.Graphics.DrawString("Union :", new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(550, 460));
            e.Graphics.DrawString(NIContributionTxt.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(700, 460));

            e.Graphics.DrawString("SLC :", new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(550, 490));
            e.Graphics.DrawString(slcTxt.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(700, 490));

            e.Graphics.DrawLine(new Pen(Color.Blue, 1), 90, 510, 750, 510);

            e.Graphics.DrawString("Total Earnings :", new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(100, 540));
            e.Graphics.DrawString(totalEarningTxt.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(440, 540));

            e.Graphics.DrawString("Total Deductions :", new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(550, 540));
            e.Graphics.DrawString(totalDeductionsTxt.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(700, 540));

            e.Graphics.DrawLine(new Pen(Color.Blue, 1), 90, 560, 750, 560);

            e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), 90, 570, 700, 50);
            e.Graphics.DrawString("Net Pay :", new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(550, 580));
            e.Graphics.DrawString(netPayTxt.Text, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.DarkBlue, new Point(700, 580));


        }

        private void printPaySlipBtn_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            
        }

        double contractualHoursWk1, contractualHoursWk2, contractualHoursWk3, contractualHoursWk4;
        double overTimeHoursWk1, overTimeHoursWk2, overTimeHoursWk3, overTimeHoursWk4;
        double totalContractualHours;
        double totalOverTimeHours;
        double totalHoursWorked;

        double contarctualAmountWk1, contarctualAmountWk2, contarctualAmountWk3, contarctualAmountWk4;
        double overTimeAmountWk1, overTimeAmountWk2, overTimeAmountWk3, overTimeAmountWk4;
        double totalContractualAmount;
        double totalOverTimeAmount;
        double totalAmountEarned;

        double tax, NiContribution, taxRate, NiRate, SLC;
        double totalDeductions;

        const double union=10.00;
        const double SLCRate=.05;

        double hourlySalaryRate, overTimeSalaryRate;

        double netPay;

        public PayrollCalculator()
        {
            InitializeComponent();
        }

        private void getWeek1Values()
        {
            //Mon1
            try
            {
                Mon1 =double.Parse(numMon1.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured"+ex.Message,"Error") ;
                this.numMon1.Focus();
            }

            //Tues1
            try
            {
                Tues1= double.Parse(numTues1.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numTues1.Focus();
            }
            //wed1
            try
            {
                wed1 = double.Parse(numWed1.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numWed1.Focus();
            }
            //thurs1
            try
            {
                thurs1 = double.Parse(numThurs1.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numThurs1.Focus();
            }
            //fri1
            try
            {
                fri1 = double.Parse(numFri1.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numFri1.Focus();
            }
            //sat1
            try
            {
                sat1 = double.Parse(numSat1.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numSat1.Focus();
            }
            //sun1
            try
            {
                sun1 = double.Parse(numSund1.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numSund1.Focus();
            }

        }

        private void getWeek2Values() {
            //Mon2
            try
            {
                Mon2 = double.Parse(numMon2.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numMon2.Focus();
            }

            //Tues2
            try
            {
                Tues2 = double.Parse(numTues2.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numTues2.Focus();
            }
            //wed2
            try
            {
                wed2 = double.Parse(numWed2.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numWed2.Focus();
            }
            //thurs2
            try
            {
                thurs2 = double.Parse(numThurs2.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numThurs2.Focus();
            }
            //fri2
            try
            {
                fri2 = double.Parse(numFri2.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numFri2.Focus();
            }
            //sat2
            try
            {
                sat2 = double.Parse(numSat2.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numSat2.Focus();
            }
            //sun2
            try
            {
                sun2 = double.Parse(numSund2.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numSund2.Focus();
            }
        }

        private void getWeek3Values() {
            //Mon3
            try
            {
                Mon3 = double.Parse(numMon3.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numMon3.Focus();
            }

            //Tues3
            try
            {
                Tues3 = double.Parse(numTues3.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numTues3.Focus();
            }
            //wed3
            try
            {
                wed3 = double.Parse(numWed3.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numWed3.Focus();
            }
            //thurs3
            try
            {
                thurs3 = double.Parse(numThurs3.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numThurs3.Focus();
            }
            //fri3
            try
            {
                fri3 = double.Parse(numFri3.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numFri3.Focus();
            }
            //sat3
            try
            {
                sat3 = double.Parse(numSat3.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numSat3.Focus();
            }
            //sun3
            try
            {
                sun3 = double.Parse(numSund3.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numSund3.Focus();
            }
        }

        private void getWeek4Values() {
            //Mon4
            try
            {
                Mon4 = double.Parse(numMon4.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numMon4.Focus();
            }

            //Tues4
            try
            {
                Tues4 = double.Parse(numTues4.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numTues4.Focus();
            }
            //wed4
            try
            {
                wed4 = double.Parse(numWed4.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numWed4.Focus();
            }
            //thurs4
            try
            {
                thurs4 = double.Parse(numThurs4.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numThurs4.Focus();
            }
            //fri4
            try
            {
                fri4 = double.Parse(numFri4.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numFri4.Focus();
            }
            //sat4
            try
            {
                sat4 = double.Parse(numSat4.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numSat4.Focus();
            }
            //sun4
            try
            {
                sun4 = double.Parse(numSund4.Value.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show("The Following Error occured" + ex.Message, "Error");
                this.numSund4.Focus();
            }
        }

        private bool validateControls() {
            if (empIdtxt.Text=="")
            {
                MessageBox.Show("Please enter Employee Id","Data Entry Error");
                empIdtxt.Focus();
                return false;
            }
            if (payPeriodList.SelectedIndex==0)
            {
                MessageBox.Show("Please Select a Period", "Data Entry Error");
                payPeriodList.Focus();
                return false;
            }
            if (monthCombo.SelectedIndex==0)
            {
                MessageBox.Show("Please select a Month", "Data Entry Error");
                monthCombo.Focus();
                return false;
            }
            return true;

        }

        private void listOfMonths() {
            string[] months = { "Select A Month...","January","February","March","April","May","June","July"
            ,"August","September","October","November","December"};

            foreach (var month in months)
            {
                monthCombo.Items.Add(month);
                monthCombo.SelectedIndex =0;
            }
            foreach (var month in months)
            {
                payMCombo.Items.Add(month);
                payMCombo.SelectedIndex = 0;
            }
        }

        private void getBtn_Click(object sender, EventArgs e)
        {
            String cs = ConfigurationManager.ConnectionStrings["PayrollSystemDBConnectionString"].ConnectionString;
            SqlConnection objSqlConnection = new SqlConnection(cs);
            objSqlConnection.Open();

            string selectCommand = "SELECT FirstName , LastName , NINumber FROM tblEmployee WHERE EmployeeID=" + empIdtxt.Text+"";
            SqlCommand objSqlCommand =new SqlCommand(selectCommand,objSqlConnection);
            try
            {
                SqlDataReader dataReader = objSqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    firstNameTxt.Text = dataReader[0].ToString();
                    lastNmTxt.Text = dataReader[1].ToString();
                    insuarnceNoTxt.Text = dataReader[2].ToString();
                    fullName = lastNmTxt.Text + " " + firstNameTxt.Text;
                    fullNameLabel.Text = fullName;
                }
                else
                {
                    MessageBox.Show("No Records were found with" + empIdtxt.Text, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error :" + ex.Message, "Error Message");
            }
            finally {
                objSqlConnection.Close();
            }
        }

        private void PayrollCalculator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payrollSystemDBDataSet1.tblPayRecords' table. You can move, or remove it, as needed.
            this.tblPayRecordsTableAdapter.Fill(this.payrollSystemDBDataSet1.tblPayRecords);
            listOfMonths();
            ResetControls();
            payrollTimer.Start();
            
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if (validateControls())
            {
                getWeek1Values();
                getWeek2Values();
                getWeek3Values();
                getWeek4Values();
                
                totalHoursWk1 = Mon1 + Tues1 + wed1 + thurs1 + fri1 + sat1 + sun1;
                totalHoursWk2 = Mon2 + Tues2 + wed2 + thurs2 + fri2 + sat2 + sun2;
                totalHoursWk3 = Mon3 + Tues3 + wed3 + thurs3 + fri3 + sat3 + sun3;
                totalHoursWk4 = Mon4 + Tues4 + wed4 + thurs4 + fri4 + sat4 + sun4;

                try
                {
                    hourlySalaryRate =double.Parse(hourlyRateNumericUpDown.Value.ToString());

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Following Error occured"+ex.Message,"Error Message");
                }

                overTimeSalaryRate = hourlySalaryRate * 1.5;

                //Week 1 Computation
                if (totalHoursWk1<=36)
                {
                    contractualHoursWk1 =totalHoursWk1;
                    contarctualAmountWk1 =hourlySalaryRate*totalHoursWk1;
                    overTimeHoursWk1 = 0.00;
                    overTimeAmountWk1 =0.00;
                }
                else if (totalHoursWk1>36)
                {
                    contractualHoursWk1 =36;
                    contarctualAmountWk1 =hourlySalaryRate*contractualHoursWk1;
                    overTimeHoursWk1 = totalHoursWk1 - contractualHoursWk1;
                    overTimeAmountWk1 = overTimeHoursWk1*overTimeSalaryRate;
                }
                //Week 2 Computation
                if (totalHoursWk2 <= 36)
                {
                    contractualHoursWk2 = totalHoursWk2;
                    contarctualAmountWk2 = hourlySalaryRate * totalHoursWk2;
                    overTimeHoursWk2 = 0.00;
                    overTimeAmountWk2 = 0.00;
                }
                else if (totalHoursWk2 > 36)
                {
                    contractualHoursWk2 = 36;
                    contarctualAmountWk2 = hourlySalaryRate * contractualHoursWk2;
                    overTimeHoursWk2 = totalHoursWk2 - contractualHoursWk2;
                    overTimeAmountWk2 = overTimeHoursWk2 * overTimeSalaryRate;
                }
                //Week 3 Computation
                if (totalHoursWk3 <= 36)
                {
                    contractualHoursWk3 = totalHoursWk3;
                    contarctualAmountWk3 = hourlySalaryRate * totalHoursWk3;
                    overTimeHoursWk3 = 0.00;
                    overTimeAmountWk3 = 0.00;
                }
                else if (totalHoursWk3 > 36)
                {
                    contractualHoursWk3 = 36;
                    contarctualAmountWk3 = hourlySalaryRate * contractualHoursWk3;
                    overTimeHoursWk3 = totalHoursWk3 - contractualHoursWk3;
                    overTimeAmountWk3 = overTimeHoursWk3 * overTimeSalaryRate;
                }
                //Week 4 Computation
                if (totalHoursWk4 <= 36)
                {
                    contractualHoursWk4 = totalHoursWk4;
                    contarctualAmountWk4 = hourlySalaryRate * totalHoursWk4;
                    overTimeHoursWk4 = 0.00;
                    overTimeAmountWk4 = 0.00;
                }
                else if (totalHoursWk4 > 36)
                {
                    contractualHoursWk4 = 36;
                    contarctualAmountWk4 = hourlySalaryRate * contractualHoursWk4;
                    overTimeHoursWk4 = totalHoursWk4 - contractualHoursWk4;
                    overTimeAmountWk4 = overTimeHoursWk4 * overTimeSalaryRate;
                }

                totalContractualHours =contractualHoursWk1+contractualHoursWk2+contractualHoursWk3+contractualHoursWk4;
                totalOverTimeHours =overTimeHoursWk1+overTimeHoursWk2+overTimeHoursWk3+overTimeHoursWk4;
                totalContractualAmount = contarctualAmountWk1+ contarctualAmountWk2+ contarctualAmountWk3+ contarctualAmountWk4;
                totalOverTimeAmount =overTimeAmountWk1+overTimeAmountWk2+overTimeAmountWk3+overTimeAmountWk4;
                totalHoursWorked =totalContractualHours+totalOverTimeHours;
                totalAmountEarned =totalContractualAmount+totalOverTimeAmount;

                if (totalAmountEarned<=916.67)
                {
                    taxRate =.0;
                    tax =totalAmountEarned*taxRate;
                }
                else if (totalAmountEarned > 916.67 && totalAmountEarned<=3583.33)
                {
                    taxRate =.20;
                    tax =((916.67 * .0)+((totalAmountEarned- 916.67)*taxRate));
                }
                else if (totalAmountEarned > 3583.33 && totalAmountEarned <= 12500)
                {
                    taxRate = .40;
                    tax = ((916.67 * .0) + ((3583.33 - 916.67) * .20)+((totalAmountEarned- 3583.33)*taxRate));
                }
                else if (totalAmountEarned > 12500)
                {
                    taxRate = .45;
                    tax = ((916.67 * .0) + ((3583.33 - 916.67) * .20) + ((12500- 3583.33)*.40)+((totalAmountEarned - 12500) * taxRate));
                }


                // NI Computation

                if (totalAmountEarned<620)
                {
                    NiRate =.0;
                }
                else if (totalAmountEarned >= 620 && totalAmountEarned <= 3308)
                {
                    NiRate =.12;
                }
                else if (totalAmountEarned > 3308)
                {
                    NiContribution =.02;

                }

                NiContribution =totalAmountEarned*NiRate;
                SLC =totalAmountEarned*SLCRate;

                totalDeductions =tax+NiContribution+SLC+union;

                netPay =totalAmountEarned-totalDeductions;


                contratualHoursTxt.Text =totalContractualHours.ToString("F");
                overTimeHoursTxt.Text =totalOverTimeHours.ToString("F");
                TotalHoursTxt.Text =totalHoursWorked.ToString("F");
                ContEarningTxt.Text =totalContractualAmount.ToString("C");
                overTimeEarningTxt.Text =totalOverTimeAmount.ToString("C");
                totalEarningTxt.Text =totalAmountEarned.ToString("C");
                overTimeRateTxt.Text =overTimeSalaryRate.ToString("F");
                taxAmountTxt.Text =tax.ToString("C");
                NIContributionTxt.Text =NiContribution.ToString("C");
                slcTxt.Text =SLC.ToString("C");
                unionTxt.Text =union.ToString("C");
                totalDeductionsTxt.Text =totalDeductions.ToString("C");
                netPayTxt.Text =netPay.ToString("C");
            }
        }
    }
}

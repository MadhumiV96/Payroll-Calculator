using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Configuration;
using System.Data.SqlClient;

namespace PayrollApplication
{
    public partial class EmployeeForm : Form

    {
        string gender;
        string maritalStatus;
        bool isMember;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private bool isControlsDataValidation()
        {
            Regex objEmployeeID =new Regex("^[0-9]{3,4}$");
            Regex objFirstName = new Regex("^[A-Z][a-zA-Z]*$");
            Regex objLastName = new Regex("^[A-Z][a-zA-Z]*$");

            Regex ObjNI = new Regex(@"^[A-CEGHJ-PR-TW-Z]{1}[A-CEGHJ-NPR-TW-Z]{1}[0-9]{6}[A-D\s]$");
            Regex objEmail =new Regex("^[a-zA-Z0-9]{1,30}@[a-zA-Z0-9]{1,30}.[a-zA-Z]{2,3}$");


            //ID validation
            if (Convert.ToInt32(idText.Text.Length) < 1)
            {
                MessageBox.Show("Please enter EmployeeID", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idText.Focus();
                idText.BackColor = Color.Silver;
                return false;
            }
            else if(!objEmployeeID.IsMatch(idText.Text))
            {
                MessageBox.Show("Please enter a valid EmployeeID", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                idText.Focus();
                idText.BackColor = Color.Silver;
                return false;
            }
            else {
                idText.BackColor = Color.White;
            }
            //First Name Validation
            if (string.IsNullOrEmpty(FirstNameText.Text))
            {
                MessageBox.Show("Please enter First Name", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNameText.Focus();
                FirstNameText.BackColor = Color.Silver;
                return false;
            }
            else if (!objFirstName.IsMatch(FirstNameText.Text))
            {
                MessageBox.Show("Please enter a valid First Name", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNameText.Focus();
                FirstNameText.BackColor = Color.Silver;
                return false;
            }
            else
            {
                FirstNameText.BackColor = Color.White;
            }

            //last Name Validation
            if (string.IsNullOrEmpty(lastNameText.Text))
            {
                MessageBox.Show("Please enter Last Name", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNameText.Focus();
                lastNameText.BackColor = Color.Silver;
                return false;
            }
            else if (!objLastName.IsMatch(lastNameText.Text))
            {
                MessageBox.Show("Please enter a valid Last Name", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNameText.Focus();
                lastNameText.BackColor = Color.Silver;
                return false;
            }
            else
            {
                lastNameText.BackColor = Color.White;
            }

            //gender validation
            if (maleRadioBtn.Checked == false && femaleRadioBtn.Checked == false)
            {
                MessageBox.Show("Please enter Your Gender", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                genderGrp.Focus();
                maleRadioBtn.BackColor = Color.Silver;
                femaleRadioBtn.BackColor = Color.Silver;
                return false;
            }
            else
            {
                maleRadioBtn.BackColor = Color.CornflowerBlue;
                femaleRadioBtn.BackColor = Color.CornflowerBlue;
            }

            //national insuarance validation

            if (insuaranceText.Text == "")
            {
                MessageBox.Show("Please enter National Insuarance Number", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                insuaranceText.Focus();
                insuaranceText.BackColor = Color.Silver;
                return false;
            }
            else if (!ObjNI.IsMatch(insuaranceText.Text))
            {
                MessageBox.Show("Please enter a valid Insuarance No", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                insuaranceText.Focus();
                insuaranceText.BackColor = Color.Silver;
                return false;
            }
            else
            {
                insuaranceText.BackColor = Color.White;
            }
            //marital status validation
            if (marriedRadioBtn.Checked == false && singleRadioBtn.Checked == false)
            {
                MessageBox.Show("Please enter Your Marital Status", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maritalStatusGrp.Focus();
                marriedRadioBtn.BackColor = Color.Silver;
                singleRadioBtn.BackColor = Color.Silver;
                return false;
            }
            else
            {
                marriedRadioBtn.BackColor = Color.CornflowerBlue;
                singleRadioBtn.BackColor = Color.CornflowerBlue;
            }
            //adress Validation
            if (addressText.Text == "")
            {
                MessageBox.Show("Please enter Your Address", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addressText.Focus();
                addressText.BackColor = Color.Silver;
                return false;
            }
            else
            {
                addressText.BackColor = Color.White;
            }
            //city validation
            if (cityText.Text == "")
            {
                MessageBox.Show("Please enter CIty", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cityText.Focus();
                cityText.BackColor = Color.Silver;
                return false;
            }
            else
            {
                cityText.BackColor = Color.White;
            }

            //postCode validation
            if (postTeext.Text == "")
            {
                MessageBox.Show("Please enter your postal code", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                postTeext.Focus();
                postTeext.BackColor = Color.Silver;
                return false;
            }
            else
            {
                postTeext.BackColor = Color.White;
            }

            //country Validation
            if (countryCombo.SelectedIndex == 0 || countryCombo.SelectedIndex==-1 )
            {
                MessageBox.Show("Please Select Your Country", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                countryCombo.Focus();
                countryCombo.BackColor = Color.Silver;
                return false;
            }
            else
            {
                countryCombo.BackColor = Color.White;
            }
            //phoneNO validation
            if (phoneText.Text == "")
            {
                MessageBox.Show("Please enter your phone number", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneText.Focus();
                phoneText.BackColor = Color.Silver;
                return false;
            }
            else
            {
                phoneText.BackColor = Color.White;
            }

            //email validation
            if (emailText.Text == "")
            {
                MessageBox.Show("Please enter your email", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailText.Focus();
                emailText.BackColor = Color.Silver;
                return false;
            }

            else if(emailText.Text.Length>=1)
            {
                try
                {
                    MailAddress objMail = new MailAddress(emailText.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :"+ex.Message, "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailText.Focus();
                    emailText.BackColor = Color.Silver;
                    return false;
                    
                }
                
            }
            //else if (!objEmail.IsMatch(emailText.Text))
            //{
            //    MessageBox.Show("Please enter a valid Email", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    emailText.Focus();
            //    emailText.BackColor = Color.Silver;
            //    return false;
            //}
            else
            {
                emailText.BackColor = Color.White;
            }
            //Notes validation
            if (noteText.Text.Length >30)
            {
                MessageBox.Show("Too Much Text! Please reduce your length..", "Data entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                noteText.Focus();
                noteText.BackColor = Color.Silver;
                return false;
            }
            else
            {
                noteText.BackColor = Color.White;
            }

            return true;
        }

        private void checkedItems()
        {

            if (maleRadioBtn.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            

            if (marriedRadioBtn.Checked)
            {
                maritalStatus = "Married";
            }
            else
            {
                maritalStatus = "Single";
            }

            if (memberCheck.Checked)
            {
                isMember = true;
            }
            else
            {
                isMember = false;
            }
        }

        private void clearControls() {
            idText.Clear();
            FirstNameText.Clear();
            lastNameText.Text = null;
            maleRadioBtn.Checked = false;
            femaleRadioBtn.Checked = false;
            insuaranceText.Clear();
            marriedRadioBtn.Checked = false;
            singleRadioBtn.Checked = false;
            memberCheck.Checked = false;
            addressText.Text = "";
            cityText.Text = "";
            postTeext.Clear();
            countryCombo.SelectedIndex = 0;
            phoneText.Text = string.Empty;
            emailText.Clear();
            noteText.Text = "";

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (isControlsDataValidation())
            {
                checkedItems();
                String cs =ConfigurationManager.ConnectionStrings["PayrollSystemDBConnectionString"].ConnectionString;
                SqlConnection objSqlConnection =new SqlConnection(cs);
                try
                {
                    objSqlConnection.Open();
                    string insertCommand = "INSERT INTO tblEmployee VALUES(" + Convert.ToInt32(idText.Text) + ",'"
                        + FirstNameText.Text + "','" + lastNameText.Text + "','" + gender + "','" + insuaranceText.Text
                        + "','" + dateOfBirthPicker.Value.ToString("MM/dd/yyyy") + "','" + maritalStatus + "','" + isMember + "','"
                        + addressText.Text + "','" + cityText.Text + "','" + postTeext.Text
                        + "','" + countryCombo.SelectedItem.ToString() + "','"
                        + phoneText.Text + "','" + emailText.Text + "','"
                        + noteText.Text + "')";

                    SqlCommand objCommand = new SqlCommand(insertCommand, objSqlConnection);
                    objCommand.ExecuteNonQuery();
                    this.tblEmployeeTableAdapter.Fill(this.payrollSystemDBDataSet.tblEmployee);
                    MessageBox.Show("Employee added Successfully", "Insertion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Following error occured" + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ;
                }
                finally {
                    objSqlConnection.Close();
                }

            }
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (isControlsDataValidation())
            {
                checkedItems();
                String cs = ConfigurationManager.ConnectionStrings["PayrollSystemDBConnectionString"].ConnectionString;
                SqlConnection objSqlConnection = new SqlConnection(cs);
                try
                {
                    objSqlConnection.Open();
                    string updateCommand = "UPDATE tblEmployee SET FirstName='"
                        +this.FirstNameText.Text
                        + "',LastName='"+this.lastNameText.Text
                        + "',Gender='"+this.gender
                        + "',NINumber='"+this.insuaranceText.Text
                        + "',DateOfBirth='"+this.dateOfBirthPicker.Value.ToString("MM/dd/yyyy")
                        + "',MaritalStatus='" + this.maritalStatus
                        + "',IsMember='" + this.isMember
                        + "',Address='" + this.addressText.Text
                        + "',City='" + this.cityText.Text
                        + "',PostCode='" + this.postTeext.Text
                        + "',Country='" + this.countryCombo.SelectedItem.ToString()
                        + "',PhoneNumber='" + this.phoneText.Text
                        + "',Email='" + this.emailText.Text
                        + "',Notes='" + this.noteText.Text+ "'WHERE EmployeeID="+idText.Text+"";


                    SqlCommand objCommand = new SqlCommand(updateCommand, objSqlConnection);
                    objCommand.ExecuteNonQuery();
                    this.tblEmployeeTableAdapter.Fill(this.payrollSystemDBDataSet.tblEmployee);
                    MessageBox.Show("Employee Updated Successfully", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearControls();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Following error occured" + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ;
                }
                finally
                {
                    objSqlConnection.Close();
                }

            }


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult objDResult =MessageBox.Show("Are tou sure you want to delete all the records","Confirm Record Deletion",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (objDResult==DialogResult.Yes)
            {
                checkedItems();
                String cs = ConfigurationManager.ConnectionStrings["PayrollSystemDBConnectionString"].ConnectionString;
                SqlConnection objSqlConnection = new SqlConnection(cs);
                try
                {
                    objSqlConnection.Open();
                    string deleteCommand = "DELETE FROM tblEmployee WHERE EmployeeID="+idText.Text+"";


                    SqlCommand objCommand = new SqlCommand(deleteCommand, objSqlConnection);
                    objCommand.ExecuteNonQuery();
                    this.tblEmployeeTableAdapter.Fill(this.payrollSystemDBDataSet.tblEmployee);
                    MessageBox.Show("Employee Deleted Successfully", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearControls();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Following error occured" + ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ;
                }
                finally
                {
                    objSqlConnection.Close();
                }

            
        }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            idText.Clear();
            FirstNameText.Clear();
            lastNameText.Text=null;
            maleRadioBtn.Checked =false;
            femaleRadioBtn.Checked =false;
            insuaranceText.Clear();
            marriedRadioBtn.Checked =false;
            singleRadioBtn.Checked =false;
            memberCheck.Checked =false;
            addressText.Text ="";
            cityText.Text ="";
            postTeext.Clear();
            countryCombo.SelectedIndex =0;
            phoneText.Text=string.Empty;
            emailText.Clear();
            noteText.Text ="";

        }

        private void previewBtn_Click(object sender, EventArgs e)
        {

            PreviewForm newPreview = new PreviewForm();
            checkedItems();
            newPreview.PreviewEmployeeData(Convert.ToInt32(idText.Text), FirstNameText.Text, lastNameText.Text,
                gender, insuaranceText.Text, dateOfBirthPicker.Text, maritalStatus, isMember, addressText.Text,
                cityText.Text, postTeext.Text, countryCombo.SelectedItem.ToString(), phoneText.Text, emailText.Text,
                noteText.Text);
            newPreview.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region     //Validation
        bool isNumberOrBackSpace;
        private void idText_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumberOrBackSpace = false;

            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                isNumberOrBackSpace = true;
            }
            else {
                e.Handled =true;
            }
        }

        private void phoneText_KeyPress(object sender, KeyPressEventArgs e)
        {
            isNumberOrBackSpace = false;

            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                isNumberOrBackSpace = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payrollSystemDBDataSet.tblEmployee' table. You can move, or remove it, as needed.
            this.tblEmployeeTableAdapter.Fill(this.payrollSystemDBDataSet.tblEmployee);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idText.Text =dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            FirstNameText.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            lastNameText.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            gender = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            insuaranceText.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            dateOfBirthPicker.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            maritalStatus = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            isMember = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString());
            addressText.Text = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            cityText.Text = dataGridView1.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            postTeext.Text = dataGridView1.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
            countryCombo.Text = dataGridView1.Rows[e.RowIndex].Cells[11].FormattedValue.ToString();
            phoneText.Text = dataGridView1.Rows[e.RowIndex].Cells[12].FormattedValue.ToString();
            emailText.Text = dataGridView1.Rows[e.RowIndex].Cells[13].FormattedValue.ToString();
            noteText.Text = dataGridView1.Rows[e.RowIndex].Cells[14].FormattedValue.ToString();


            if (gender=="Male")
            {
                maleRadioBtn.Checked = true;
                femaleRadioBtn.Checked = false;
            }
            else
            {
                maleRadioBtn.Checked = false;
                femaleRadioBtn.Checked = true;
            }
            if (maritalStatus=="Married")
            {
                marriedRadioBtn.Checked =true;
                singleRadioBtn.Checked =false;
            }
            else
            {
                marriedRadioBtn.Checked = false;
                singleRadioBtn.Checked = true;
            }
            if (isMember==true)
            {
                memberCheck.Checked =true;
            }
            else
            {
                memberCheck.Checked = false;
            }
        }

        private void tblEmployeeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

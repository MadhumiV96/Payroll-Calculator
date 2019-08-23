using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollApplication
{
    public partial class PreviewForm : Form
    {
        public PreviewForm()
        {
            InitializeComponent();
        }

        public void PreviewEmployeeData(int employeeID,string firstName,string lastName,string gender,string NINumber
            ,string dateOfBirth,string maritalStatus,bool isMember,string address,string city,string postCode,
            string country,string phoneNo,string email,string notes)
        {
            labelID.Text =Convert.ToString(employeeID);
            labelFName.Text =firstName;
            labelLastName.Text =lastName;
            genderLbl.Text =gender;
            labelInsuarance.Text =NINumber;
            labelDateOfBirth.Text =dateOfBirth;
            maritalStatusLbl.Text =maritalStatus;
            memberLbl.Text =isMember.ToString();
            labelAddress.Text =address;
            labelCity.Text =city;
            labelPostCode.Text =postCode;
            labelCountry.Text =country;
            labelPhoneNo.Text =phoneNo;
            labelEmail.Text =email;
            labelNotes.Text =notes;



        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {

        }
    }
}

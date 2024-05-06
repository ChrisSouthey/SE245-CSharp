using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab4_Chris.Program;

namespace Midterm_Chris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person temp = new Person();
            temp.Feedback = "";

            //Name info
            temp.Fname = txtFName.Text;

            if (txtMName.Text != "")
            {
                temp.Mname = txtMName.Text;
            }
            else
            {
                temp.Mname = "";
            }

            temp.Lname = txtLName.Text;

            //Adress info
            temp.Street1 = txtStreet1.Text;
            temp.Street2 = txtStreet2.Text;
            temp.City = txtCity.Text;
            temp.State = txtState.Text;
            temp.Zip = txtZip.Text;

            //Other info
            temp.Phone = txtPhone.Text;
            temp.Email = txtEmail.Text;

            lblFeedback.Text = $"Person Added...\nName: {temp.Fname} {temp.Mname} {temp.Lname}\nStreet 1: {temp.Street1}\nStreet 2: {temp.Street2}\nCity: {temp.City}\nState: {temp.State}\nZipcode: {temp.Zip}\nPhone #: {temp.Phone}\nEmail: {temp.Email}";
        }

       
    }
}

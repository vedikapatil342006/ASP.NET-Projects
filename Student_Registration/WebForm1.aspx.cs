using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pract3C
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged1(object sender, EventArgs e)
        {

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string gender = " ";
            if (RadioButton1.Checked)
                gender = "Male";
            else if(RadioButton2.Checked)
                gender = "Female";

            if(CheckBox2.Checked)
            {
                Label5.Text="<br/>Name:"+TextBox1.Text+
                "<br/> Gender:" + gender +
                "<br/>Course:" + DropDownList1.SelectedItem.Text +
                "<br/>Date:" + Calendar1.SelectedDate.ToShortDateString();
            }
            else
            {
                Label5.Text = "Please accept terms and conditions.";
            }
        }
    }
}
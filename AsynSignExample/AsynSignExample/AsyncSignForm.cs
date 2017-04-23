using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynSignExample
{
    public partial class AsyncSignForm : Form
    {
        public AsyncSignForm()
        {
            InitializeComponent();
            calender.MinDate=DateTime.Today;
            calender.Visible = chkSignDealine.Checked;

        }

        private DateTime? SignDeadline
        {
            get { return chkSignDealine.Checked ? (DateTime?)calender.SelectionStart : null; }
        }

        

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Simple validation
            if(string.IsNullOrWhiteSpace(title.Text))
                return;
            if (string.IsNullOrWhiteSpace(description.Text))
                return;
            if (string.IsNullOrWhiteSpace(firstName.Text))
                return;
            if (string.IsNullOrWhiteSpace(lastName.Text))
                return;
            if (string.IsNullOrWhiteSpace(mobile.Text))
                return;
            if (string.IsNullOrWhiteSpace(email.Text))
                return;

            //Fix mobile
            if (!mobile.Text.StartsWith("+47"))
                mobile.Text = $"+47{mobile.Text}";

            //Send document to signing

            tabControl.SelectedTab = tabStep2;
        }

        private void chkSignDealine_CheckedChanged(object sender, EventArgs e)
        {
            calender.Visible = chkSignDealine.Checked;
        }

   
    }
}

using System;
using System.Configuration;
using System.Windows.Forms;

namespace AsynSignExample
{
    public partial class AsyncSignForm : Form
    {

        private Guid accountId = new Guid(ConfigurationManager.AppSettings["accountId"]);
        private string apiKey = ConfigurationManager.AppSettings["apiKey"];
        private string eventConnectionString = ConfigurationManager.AppSettings["eventConnectionString"];
        private Guid documentid;
        private string pdfFilePath;

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

        private void btnShowPDFbtnShowPDF_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(pdfFilePath);
        }
    }
}

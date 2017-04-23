using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unipluss.Sign.Client;
using Unipluss.Sign.Client.Models;
using Unipluss.Sign.Events.Client;
using Unipluss.Sign.Events.Entities;
using Unipluss.Sign.ExternalContract.Entities;

namespace AsynSignExample
{
    public partial class AsyncSignForm : Form
    {
        private Client signClient;
        private EventClient eventClient;

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
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            signClient =new Client("https://testapi.signere.no",accountId,apiKey,false,true,true);
            eventClient=EventClient.SetupWithPrimaryApiKey(eventConnectionString,accountId,apiKey)
                .UseTestEnvironment(true)
                .SubscribeToDocumentSignedEvent(signedEvent)
                .SubscribeToDocumentPadesSavedEvent(padesSavedEvent)
                .Start()
                ;

        }

        private async Task signedEvent(DocumentSignedEvent eventDetails)
        {
            if (eventDetails.DocumentId != documentid)
                return;
            MethodInvoker inv = () =>
            {
                this.btnCancelDocument.Enabled = false;
                this.btnChangeDeadline.Enabled = false;

                detailsLabel.Text = new StringBuilder()
               .AppendLine($"Signed time: {eventDetails.SignedTimeStamp.ToLocalTime().ToString("dd.MM.yyyy HH:mm:ss")}")
               .AppendLine($"Signed by : {eventDetails.Signees.FirstOrDefault().SignName} ({eventDetails.Signees.FirstOrDefault().DateOfBirth})")
               .ToString();

            };

            this.Invoke(inv);
        }

        private async Task padesSavedEvent(DocumentPadesSavedEvent eventDetails, byte[] padesBytes)
        {
            if (eventDetails.DocumentId != documentid)
                return;

            pdfFilePath = string.Format(@"d:\tmp\{0}.pdf", eventDetails.DocumentId);
            System.IO.File.WriteAllBytes(pdfFilePath,padesBytes);
            MessageBox.Show("Signed PDF ready to show");
            MethodInvoker inv = () =>
            {
                this.btnShowPDF.Enabled = true;
            };
            this.Invoke(inv);
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
            var documentResponse = signClient.CreateSingleDocument(new NewSingleDocument()
            {
                CreatedByApplication = "Hackaton",
                Description = description.Text,
                Title = title.Text,
                SignDeadline = SignDeadline,
                Language = NewSingleDocument.Languages.NO,
                Contact_Email = "kjelltech@synnevag.com",
                Contact_Phone = "55089004",
                TopicEmail = "Hackton sign demo",
                MessageEmail = new StringBuilder().
                AppendLine("Hei,")
                .AppendLine("Her kommer dokumentet til signering!")
                .AppendLine("[signlink]")
                .AppendLine("")
                .AppendLine("mvh")
                .AppendLine("Hackaton demo")
                .ToString(),
                SigneeRefs = new List<SigneeRef>()
                {
                    new SigneeRef()
                    {
                        FirstName = firstName.Text,
                        LastName = lastName.Text,
                        Mobile = mobile.Text,
                        Email = email.Text,
                    }
                }
            },File.ReadAllBytes("UnitTestDoc.pdf"), "UnitTestDoc.pdf");

            //Store response details
            documentid = documentResponse.Id;
            detailsLabel.Text=new StringBuilder()
                .AppendLine($"Document Id: {documentResponse.Id}")                
                .ToString();

            tabControl.SelectedTab = tabStep2;
        }

        private void chkSignDealine_CheckedChanged(object sender, EventArgs e)
        {
            calender.Visible = chkSignDealine.Checked;
        }

        private void btnShowPDF_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(pdfFilePath);
        }

        private void btnChangeDeadline_Click(object sender, EventArgs e)
        {
            signClient.ChangeDocumentDeadline(documentid,DateTime.Today.AddDays(1),true,true);
        }

        private void btnCancelDocument_Click(object sender, EventArgs e)
        {
            signClient.CancelDocument(documentid,"Hackaton demo","A nice explantion to the end user!");
        }
    }
}

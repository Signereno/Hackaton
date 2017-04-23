namespace AsynSignExample
{
    partial class AsyncSignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkSignDealine = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.calender = new System.Windows.Forms.MonthCalendar();
            this.description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabStep2 = new System.Windows.Forms.TabPage();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.btnCancelDocument = new System.Windows.Forms.Button();
            this.btnChangeDeadline = new System.Windows.Forms.Button();
            this.btnShowPDFbtnShowPDF = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabStep2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabStep2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(844, 520);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkSignDealine);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnSend);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.calender);
            this.tabPage1.Controls.Add(this.description);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.title);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Step 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkSignDealine
            // 
            this.chkSignDealine.AutoSize = true;
            this.chkSignDealine.Location = new System.Drawing.Point(135, 118);
            this.chkSignDealine.Name = "chkSignDealine";
            this.chkSignDealine.Size = new System.Drawing.Size(15, 14);
            this.chkSignDealine.TabIndex = 3;
            this.chkSignDealine.UseVisualStyleBackColor = true;
            this.chkSignDealine.CheckedChanged += new System.EventHandler(this.chkSignDealine_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mobile);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(35, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 185);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receipient";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(123, 56);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(449, 20);
            this.lastName.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lastname";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(123, 130);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(449, 20);
            this.email.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // mobile
            // 
            this.mobile.Location = new System.Drawing.Point(123, 95);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(449, 20);
            this.mobile.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mobile";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(123, 19);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(449, 20);
            this.firstName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Firstname";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(738, 463);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sign deadline";
            // 
            // calender
            // 
            this.calender.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.calender.Location = new System.Drawing.Point(343, 118);
            this.calender.MaxSelectionCount = 1;
            this.calender.Name = "calender";
            this.calender.TabIndex = 4;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(135, 60);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(449, 36);
            this.description.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(135, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(449, 20);
            this.title.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // tabStep2
            // 
            this.tabStep2.Controls.Add(this.detailsLabel);
            this.tabStep2.Controls.Add(this.btnCancelDocument);
            this.tabStep2.Controls.Add(this.btnChangeDeadline);
            this.tabStep2.Controls.Add(this.btnShowPDFbtnShowPDF);
            this.tabStep2.Location = new System.Drawing.Point(4, 22);
            this.tabStep2.Name = "tabStep2";
            this.tabStep2.Padding = new System.Windows.Forms.Padding(3);
            this.tabStep2.Size = new System.Drawing.Size(836, 494);
            this.tabStep2.TabIndex = 1;
            this.tabStep2.Text = "Step 2";
            this.tabStep2.UseVisualStyleBackColor = true;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsLabel.Location = new System.Drawing.Point(3, 3);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(155, 24);
            this.detailsLabel.TabIndex = 3;
            this.detailsLabel.Text = "Document details";
            this.detailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelDocument
            // 
            this.btnCancelDocument.Location = new System.Drawing.Point(368, 454);
            this.btnCancelDocument.Name = "btnCancelDocument";
            this.btnCancelDocument.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancelDocument.Size = new System.Drawing.Size(109, 23);
            this.btnCancelDocument.TabIndex = 2;
            this.btnCancelDocument.Text = "Cancel document";
            this.btnCancelDocument.UseVisualStyleBackColor = true;
            // 
            // btnChangeDeadline
            // 
            this.btnChangeDeadline.Location = new System.Drawing.Point(194, 454);
            this.btnChangeDeadline.Name = "btnChangeDeadline";
            this.btnChangeDeadline.Size = new System.Drawing.Size(109, 23);
            this.btnChangeDeadline.TabIndex = 1;
            this.btnChangeDeadline.Text = "Change deadline";
            this.btnChangeDeadline.UseVisualStyleBackColor = true;
            // 
            // btnShowPDFbtnShowPDF
            // 
            this.btnShowPDFbtnShowPDF.Enabled = false;
            this.btnShowPDFbtnShowPDF.Location = new System.Drawing.Point(28, 454);
            this.btnShowPDFbtnShowPDF.Name = "btnShowPDFbtnShowPDF";
            this.btnShowPDFbtnShowPDF.Size = new System.Drawing.Size(109, 23);
            this.btnShowPDFbtnShowPDF.TabIndex = 0;
            this.btnShowPDFbtnShowPDF.Text = "Show PDF";
            this.btnShowPDFbtnShowPDF.UseVisualStyleBackColor = true;
            this.btnShowPDFbtnShowPDF.Click += new System.EventHandler(this.btnShowPDFbtnShowPDF_Click);
            // 
            // AsyncSignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 520);
            this.Controls.Add(this.tabControl);
            this.Name = "AsyncSignForm";
            this.Text = "AsyncSign";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabStep2.ResumeLayout(false);
            this.tabStep2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabStep2;
        private System.Windows.Forms.MonthCalendar calender;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowPDFbtnShowPDF;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Button btnCancelDocument;
        private System.Windows.Forms.Button btnChangeDeadline;
        private System.Windows.Forms.CheckBox chkSignDealine;
    }
}



namespace KaingaRealEstate
{
    partial class RemoveOfferForm
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
            this.lstOfferDetails = new System.Windows.Forms.ListBox();
            this.lblRequired = new System.Windows.Forms.Label();
            this.lblPleaseSelectAnOption = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRemoveOffer = new System.Windows.Forms.Button();
            this.cboBuyer = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtBuyerID = new System.Windows.Forms.TextBox();
            this.lblOfferDetails = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBuyerID = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.lblRemoveOffer = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstOfferDetails
            // 
            this.lstOfferDetails.FormattingEnabled = true;
            this.lstOfferDetails.ItemHeight = 19;
            this.lstOfferDetails.Location = new System.Drawing.Point(158, 282);
            this.lstOfferDetails.Name = "lstOfferDetails";
            this.lstOfferDetails.ScrollAlwaysVisible = true;
            this.lstOfferDetails.Size = new System.Drawing.Size(490, 118);
            this.lstOfferDetails.TabIndex = 115;
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequired.Location = new System.Drawing.Point(137, 88);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(17, 19);
            this.lblRequired.TabIndex = 111;
            this.lblRequired.Text = "*";
            // 
            // lblPleaseSelectAnOption
            // 
            this.lblPleaseSelectAnOption.AutoSize = true;
            this.lblPleaseSelectAnOption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelectAnOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPleaseSelectAnOption.Location = new System.Drawing.Point(277, 47);
            this.lblPleaseSelectAnOption.Name = "lblPleaseSelectAnOption";
            this.lblPleaseSelectAnOption.Size = new System.Drawing.Size(166, 19);
            this.lblPleaseSelectAnOption.TabIndex = 110;
            this.lblPleaseSelectAnOption.Text = "*Please select an option";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(523, 437);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(125, 36);
            this.btnReturn.TabIndex = 109;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRemoveOffer
            // 
            this.btnRemoveOffer.Location = new System.Drawing.Point(43, 442);
            this.btnRemoveOffer.Name = "btnRemoveOffer";
            this.btnRemoveOffer.Size = new System.Drawing.Size(124, 36);
            this.btnRemoveOffer.TabIndex = 108;
            this.btnRemoveOffer.Text = "Remove Offer";
            this.btnRemoveOffer.UseVisualStyleBackColor = true;
            // 
            // cboBuyer
            // 
            this.cboBuyer.FormattingEnabled = true;
            this.cboBuyer.Location = new System.Drawing.Point(158, 85);
            this.cboBuyer.MaxLength = 57;
            this.cboBuyer.Name = "cboBuyer";
            this.cboBuyer.Size = new System.Drawing.Size(490, 27);
            this.cboBuyer.TabIndex = 107;
            this.cboBuyer.SelectedIndexChanged += new System.EventHandler(this.cboBuyer_SelectedIndexChanged_1);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(158, 185);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(217, 27);
            this.txtFirstName.TabIndex = 106;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(158, 136);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(217, 27);
            this.txtLastName.TabIndex = 105;
            // 
            // txtBuyerID
            // 
            this.txtBuyerID.Location = new System.Drawing.Point(559, 136);
            this.txtBuyerID.MaxLength = 7;
            this.txtBuyerID.Name = "txtBuyerID";
            this.txtBuyerID.ReadOnly = true;
            this.txtBuyerID.Size = new System.Drawing.Size(70, 27);
            this.txtBuyerID.TabIndex = 104;
            // 
            // lblOfferDetails
            // 
            this.lblOfferDetails.AutoSize = true;
            this.lblOfferDetails.Location = new System.Drawing.Point(41, 282);
            this.lblOfferDetails.Name = "lblOfferDetails";
            this.lblOfferDetails.Size = new System.Drawing.Size(96, 19);
            this.lblOfferDetails.TabIndex = 102;
            this.lblOfferDetails.Text = "Offer Details:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(54, 191);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 19);
            this.lblFirstName.TabIndex = 101;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(55, 141);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 19);
            this.lblLastName.TabIndex = 100;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblBuyerID
            // 
            this.lblBuyerID.AutoSize = true;
            this.lblBuyerID.Location = new System.Drawing.Point(479, 140);
            this.lblBuyerID.Name = "lblBuyerID";
            this.lblBuyerID.Size = new System.Drawing.Size(68, 19);
            this.lblBuyerID.TabIndex = 99;
            this.lblBuyerID.Text = "Buyer ID:";
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Location = new System.Drawing.Point(87, 88);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(50, 19);
            this.lblBuyer.TabIndex = 98;
            this.lblBuyer.Text = "Buyer:";
            // 
            // lblRemoveOffer
            // 
            this.lblRemoveOffer.AutoSize = true;
            this.lblRemoveOffer.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveOffer.Location = new System.Drawing.Point(291, 14);
            this.lblRemoveOffer.Name = "lblRemoveOffer";
            this.lblRemoveOffer.Size = new System.Drawing.Size(151, 29);
            this.lblRemoveOffer.TabIndex = 97;
            this.lblRemoveOffer.Text = "Remove Offer";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(559, 228);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(92, 27);
            this.txtPhoneNumber.TabIndex = 119;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(440, 235);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(108, 19);
            this.lblPhoneNumber.TabIndex = 118;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(158, 232);
            this.txtEmailAddress.MaxLength = 30;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.ReadOnly = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(251, 27);
            this.txtEmailAddress.TabIndex = 117;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(32, 238);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(105, 19);
            this.lblEmailAddress.TabIndex = 116;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // RemoveOfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 513);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lstOfferDetails);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblPleaseSelectAnOption);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveOffer);
            this.Controls.Add(this.cboBuyer);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtBuyerID);
            this.Controls.Add(this.lblOfferDetails);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblBuyerID);
            this.Controls.Add(this.lblBuyer);
            this.Controls.Add(this.lblRemoveOffer);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemoveOfferForm";
            this.Text = "Remove Offers";
            this.Load += new System.EventHandler(this.RemoveOfferForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOfferDetails;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblPleaseSelectAnOption;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRemoveOffer;
        private System.Windows.Forms.ComboBox cboBuyer;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtBuyerID;
        private System.Windows.Forms.Label lblOfferDetails;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBuyerID;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.Label lblRemoveOffer;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblEmailAddress;
    }
}
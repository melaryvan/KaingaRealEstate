
namespace KaingaRealEstate
{
    partial class DeleteAgentForm
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
            this.lblRequired = new System.Windows.Forms.Label();
            this.lblPleaseSelectAnOption = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteAgent = new System.Windows.Forms.Button();
            this.cboAgent = new System.Windows.Forms.ComboBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAgentID = new System.Windows.Forms.TextBox();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAgentID = new System.Windows.Forms.Label();
            this.lblAgent = new System.Windows.Forms.Label();
            this.lblDeleteAgent = new System.Windows.Forms.Label();
            this.txtCertification = new System.Windows.Forms.TextBox();
            this.lblCertification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequired.Location = new System.Drawing.Point(167, 93);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(17, 19);
            this.lblRequired.TabIndex = 50;
            this.lblRequired.Text = "*";
            // 
            // lblPleaseSelectAnOption
            // 
            this.lblPleaseSelectAnOption.AutoSize = true;
            this.lblPleaseSelectAnOption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelectAnOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPleaseSelectAnOption.Location = new System.Drawing.Point(307, 52);
            this.lblPleaseSelectAnOption.Name = "lblPleaseSelectAnOption";
            this.lblPleaseSelectAnOption.Size = new System.Drawing.Size(166, 19);
            this.lblPleaseSelectAnOption.TabIndex = 49;
            this.lblPleaseSelectAnOption.Text = "*Please select an option";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(555, 425);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(123, 36);
            this.btnReturn.TabIndex = 48;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteAgent
            // 
            this.btnDeleteAgent.Location = new System.Drawing.Point(66, 425);
            this.btnDeleteAgent.Name = "btnDeleteAgent";
            this.btnDeleteAgent.Size = new System.Drawing.Size(129, 36);
            this.btnDeleteAgent.TabIndex = 47;
            this.btnDeleteAgent.Text = "Delete Agent";
            this.btnDeleteAgent.UseVisualStyleBackColor = true;
            this.btnDeleteAgent.Click += new System.EventHandler(this.btnDeleteAgent_Click);
            // 
            // cboAgent
            // 
            this.cboAgent.FormattingEnabled = true;
            this.cboAgent.Location = new System.Drawing.Point(188, 90);
            this.cboAgent.MaxLength = 57;
            this.cboAgent.Name = "cboAgent";
            this.cboAgent.Size = new System.Drawing.Size(490, 27);
            this.cboAgent.TabIndex = 46;
            this.cboAgent.SelectedIndexChanged += new System.EventHandler(this.cboAgent_SelectedIndexChanged);
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(188, 333);
            this.txtSuburb.MaxLength = 20;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.ReadOnly = true;
            this.txtSuburb.Size = new System.Drawing.Size(170, 27);
            this.txtSuburb.TabIndex = 45;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(188, 286);
            this.txtStreetAddress.MaxLength = 50;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.ReadOnly = true;
            this.txtStreetAddress.Size = new System.Drawing.Size(407, 27);
            this.txtStreetAddress.TabIndex = 44;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(188, 237);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(217, 27);
            this.txtFirstName.TabIndex = 43;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(188, 188);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(217, 27);
            this.txtLastName.TabIndex = 42;
            // 
            // txtAgentID
            // 
            this.txtAgentID.Location = new System.Drawing.Point(188, 139);
            this.txtAgentID.MaxLength = 7;
            this.txtAgentID.Name = "txtAgentID";
            this.txtAgentID.ReadOnly = true;
            this.txtAgentID.Size = new System.Drawing.Size(70, 27);
            this.txtAgentID.TabIndex = 41;
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(112, 341);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(57, 19);
            this.lblSuburb.TabIndex = 40;
            this.lblSuburb.Text = "Suburb:";
            this.lblSuburb.Click += new System.EventHandler(this.lblSuburb_Click);
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(62, 293);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(107, 19);
            this.lblStreetAddress.TabIndex = 39;
            this.lblStreetAddress.Text = "Street Address:";
            this.lblStreetAddress.Click += new System.EventHandler(this.lblStreetAddress_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(86, 243);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 19);
            this.lblFirstName.TabIndex = 38;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(87, 193);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 19);
            this.lblLastName.TabIndex = 37;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // lblAgentID
            // 
            this.lblAgentID.AutoSize = true;
            this.lblAgentID.Location = new System.Drawing.Point(100, 143);
            this.lblAgentID.Name = "lblAgentID";
            this.lblAgentID.Size = new System.Drawing.Size(69, 19);
            this.lblAgentID.TabIndex = 36;
            this.lblAgentID.Text = "Agent ID:";
            this.lblAgentID.Click += new System.EventHandler(this.lblSellerID_Click);
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Location = new System.Drawing.Point(118, 93);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(51, 19);
            this.lblAgent.TabIndex = 35;
            this.lblAgent.Text = "Agent:";
            this.lblAgent.Click += new System.EventHandler(this.lblSeller_Click);
            // 
            // lblDeleteAgent
            // 
            this.lblDeleteAgent.AutoSize = true;
            this.lblDeleteAgent.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteAgent.Location = new System.Drawing.Point(321, 19);
            this.lblDeleteAgent.Name = "lblDeleteAgent";
            this.lblDeleteAgent.Size = new System.Drawing.Size(142, 29);
            this.lblDeleteAgent.TabIndex = 34;
            this.lblDeleteAgent.Text = "Delete Agent";
            this.lblDeleteAgent.Click += new System.EventHandler(this.lblDeleteSeller_Click);
            // 
            // txtCertification
            // 
            this.txtCertification.Location = new System.Drawing.Point(635, 139);
            this.txtCertification.MaxLength = 3;
            this.txtCertification.Name = "txtCertification";
            this.txtCertification.ReadOnly = true;
            this.txtCertification.Size = new System.Drawing.Size(43, 27);
            this.txtCertification.TabIndex = 52;
            // 
            // lblCertification
            // 
            this.lblCertification.AutoSize = true;
            this.lblCertification.Location = new System.Drawing.Point(524, 147);
            this.lblCertification.Name = "lblCertification";
            this.lblCertification.Size = new System.Drawing.Size(92, 19);
            this.lblCertification.TabIndex = 51;
            this.lblCertification.Text = "Certification:";
            this.lblCertification.Click += new System.EventHandler(this.lblCertification_Click);
            // 
            // DeleteAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 502);
            this.Controls.Add(this.txtCertification);
            this.Controls.Add(this.lblCertification);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblPleaseSelectAnOption);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteAgent);
            this.Controls.Add(this.cboAgent);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAgentID);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblAgentID);
            this.Controls.Add(this.lblAgent);
            this.Controls.Add(this.lblDeleteAgent);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteAgentForm";
            this.Text = "Delete Agents";
            this.Load += new System.EventHandler(this.DeleteAgentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblPleaseSelectAnOption;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteAgent;
        private System.Windows.Forms.ComboBox cboAgent;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAgentID;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAgentID;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.Label lblDeleteAgent;
        private System.Windows.Forms.TextBox txtCertification;
        private System.Windows.Forms.Label lblCertification;
    }
}
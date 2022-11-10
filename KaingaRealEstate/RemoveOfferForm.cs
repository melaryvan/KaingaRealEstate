﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaingaRealEstate
{
    public partial class RemoveOfferForm : Form
    {
        private DataController DC;
        private BuyerLiaisonClerkMainForm frmMenu;
        private int aBuyerID,aPropertyID;
        private CurrencyManager cmBuyer;
        public RemoveOfferForm(DataController dc, BuyerLiaisonClerkMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            cmBuyer = (CurrencyManager)this.BindingContext[DC.dsKainga, "BUYER"];
        }

        private void ClearFields()
        {
            txtBuyerID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtEmailAddress.Text = "";
            txtPhoneNumber.Text = "";
            cboBuyer.Text = "";
            cboBuyer.Items.Clear();
            lstOfferDetails.Items.Clear();
        }

        private void LoadBuyers()
        {
            foreach (DataRow drBuyer in DC.dtBuyer.Rows)
            {
                DataRow[] drOffer = drBuyer.GetChildRows(DC.dtBuyer.ChildRelations["BUYER_OFFER"]);
                if (drOffer.Length !=0)
                {
                    cboBuyer.Items.Add(drBuyer["buyerID"] + (" ") + drBuyer["lastName"] + (" ") + drBuyer["firstName"]);
                }
            }

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }

        private void RemoveOfferForm_Load(object sender, EventArgs e)
        {
            LoadBuyers();
        }

        private void cboBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOfferDetails.Items.Clear();
            string aRow = cboBuyer.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aBuyerID = Convert.ToInt32(subs[0]);
            cmBuyer.Position = DC.buyerView.Find(aBuyerID);
            DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
            txtBuyerID.Text = drBuyer["buyerID"].ToString();
            txtLastName.Text = drBuyer["lastName"].ToString();
            txtFirstName.Text = drBuyer["firstName"].ToString();
            txtEmailAddress.Text = drBuyer["emailAddress"].ToString();
            txtPhoneNumber.Text = drBuyer["phoneNumber"].ToString();
            LoadOffers();
        }

        private void cboBuyer_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void LoadOffers()
        {
            DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
            DataRow[] drOfferDetails = drBuyer.GetChildRows(DC.dtBuyer.ChildRelations["BUYER_OFFER"]);

            lstOfferDetails.Items.Add("Status\r\tOffer Amount\r\tPropertyID\r\tDescription\r\n");
            foreach (DataRow drOffer in drOfferDetails)
            {
                DataRow drProperty = drOffer.GetParentRow(DC.dtOffer.ParentRelations["PROPERTY_OFFER"]);

            }
        }
      
        }


    }


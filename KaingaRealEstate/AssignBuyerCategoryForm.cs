using System;
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
    public partial class AssignBuyerCategoryForm : Form
    {
        private DataController DC;
        private BuyerLiaisonClerkMainForm frmMenu;
        int aCategoryID, aBuyerID;
        private CurrencyManager cmBuyer;
        public AssignBuyerCategoryForm(DataController dc, BuyerLiaisonClerkMainForm mnu)
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
            txtCreditStatus.Text = "";
            cboBuyer.Text = "";
            cboBuyer.Items.Clear();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
            ClearFields();
        }

        private void AssignBuyerCategoryForm_Load(object sender, EventArgs e)
        {
            LoadBuyers();
        }
        private void LoadBuyers()
        {
            foreach (DataRow drBuyer in DC.dtBuyer.Rows)
            {
                cboBuyer.Items.Add(drBuyer["buyerID"] + (" ") + drBuyer["lastName"] + (" ") + drBuyer["firstName"]);
            }
        }

        private void LoadCategories()
        {
            foreach (DataRow drCategory in DC.dtCategory.Rows)
            {
                cboCategory.Items.Add(drCategory["categoryID"] + (": ") + drCategory["categoryDescription"]);
            }
        }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void cboBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aRow = cboBuyer.SelectedItem.ToString();
            string[] subs = aRow.Split(' ');
            aBuyerID = Convert.ToInt32(subs[0]);
            cmBuyer.Position = DC.buyerView.Find(aBuyerID);
            DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
            txtBuyerID.Text = drBuyer["buyerID"].ToString();
            txtLastName.Text = drBuyer["lastName"].ToString();
            txtFirstName.Text = drBuyer["firstName"].ToString();
            txtCreditStatus.Text = drBuyer["creditStatus"].ToString();
            LoadCategoriesAssigned();
            LoadCategories();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
                string aRow = cboCategory.SelectedItem.ToString();
                string[] subs = aRow.Split(':');
                aCategoryID = Convert.ToInt32(subs[0]);
                //MessageBox.Show("buyerID =" + aBuyerID + "\ncategoryID =" + aCategoryID); works
          
        }

        private void btnAssignBuyerCategory_Click(object sender, EventArgs e)
        {
            if ((cboImportance.Text == "") || (cboBuyer.Text == "") || (cboCategory.Text == ""))
            {
                MessageBox.Show("Please fill in all fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*object[] keys = new object[2];   // Create an array for the key values to find.
                keys[0] = aBuyerID; // Set the values of the keys to find.
                keys[1] = aCategoryID; // Set the values of the keys to find.
                DataRow findCategoryRow = DC.dtBuyerCategory.Rows.Find(keys);*/
                try
                {
                    DataRow newBuyerCategory = DC.dtBuyerCategory.NewRow();
                    newBuyerCategory["buyerID"] = aBuyerID;
                    newBuyerCategory["categoryID"] = aCategoryID;
                    newBuyerCategory["importance"] = cboImportance.Text;
                    DC.dtBuyerCategory.Rows.Add(newBuyerCategory);
                    DC.UpdateBuyerCategory();
                    MessageBox.Show("Category assigned to the buyer sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("The category is already assigned to the buyer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void LoadCategoriesAssigned()
        {
            DataRow drBuyer = DC.dtBuyer.Rows[cmBuyer.Position];
            DataRow[] drBuyerCategories = drBuyer.GetChildRows(DC.dtBuyer.ChildRelations["BUYER_BUYERCATEGORY"]);
            var space = new string(' ', 31);
            lstCategoryAssign.Items.Add("ID\r\tDescription" + space + "Importance\r\n");
            foreach (DataRow drBuyerCategory in drBuyerCategories)
            {
                DataRow drCategory = drBuyerCategory.GetParentRow(DC.dtBuyerCategory.ParentRelations["CATEGORY_BUYERCATEGORY"]);
                string aDescription = drCategory["categoryDescription"].ToString();
                space = new String(' ', (42 - aDescription.Length));
                lstCategoryAssign.Items.Add(drCategory["categoryID"] + "\r\t" + aDescription + space + drBuyerCategory["importance"] + "\r\n");
            }
        }
    }
}

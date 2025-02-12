using HMSData.DataStore.DrugStore;
using HMSData.Drug.Enum;
using HMSData.Drug;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMSData.Roles;
using HMSData.DataStore.PatientStore;

namespace HMSApplication.Pharmacist
{
    public partial class RegisterDrugs : Form
    {
        private Drugs _selectedDrug = default!;
        public RegisterDrugs()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void RegisterDrugs_Load(object sender, EventArgs e)
        {
            lblDrugStatus.Visible = false;
            txtStatus.Visible = false;

            updateDrugsBtn.Enabled = false;

            txtDrugName.Text = "Amoxicillin";
            genericNameTxt.Text = "Amoxicillin Tablets";
            ddlForm.SelectedIndex = 1;
            txtQuantityStock.Text = "100";
            txtPrice.Text = "500";
            txtReorderLevel.Text = "20";
            txtManufacturer.Text = "Amoxicillin Manufacturer";
            txtSupplierName.Text = "Mr. Ade";
            txtSupplierContact.Text = "08101462138";
        }

        private void registerDrugsBtn_Click(object sender, EventArgs e)
        {
            string error = "";
            var name = txtDrugName.Text.Trim();
            var genericName = genericNameTxt.Text.Trim();
            var drugForm = ddlForm.SelectedIndex + 1;
            decimal quantity = 0;
            if (string.IsNullOrEmpty(txtQuantityStock.Text.Trim()))
            {
                error += "Quantity Input should not be empty";
            }
            else
            {
                var check = decimal.TryParse(txtQuantityStock.Text.Trim(), out quantity);
                if (!check)
                {
                    error += "Invalid Quantity";
                }
            }
            decimal reorderLevel = 0;
            if (string.IsNullOrEmpty(txtReorderLevel.Text.Trim()))
            {
                error += "Reorder Input should not be empty";
            }
            else
            {
                var check = decimal.TryParse(txtReorderLevel.Text.Trim(), out reorderLevel);
                if (!check)
                {
                    error += "Invalid Reorder Level";
                }
            }
            decimal price = 0;
            if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                error += "Price Input should not be empty";
            }
            else
            {
                var check = decimal.TryParse(txtPrice.Text.Trim(), out price);
                if (!check)
                {
                    error += "Invalid Price";
                }
            }

            var manufacturer = txtManufacturer.Text.Trim();
            var supplierName = txtSupplierName.Text.Trim();
            var supplierContact = txtSupplierContact.Text.Trim();
            var expiryDat = expiryDate.Text;

            CheckString(name, "Name");
            CheckString(genericName, "Generic Name");
            CheckString(manufacturer, "Manufacturer");
            CheckString(supplierName, "Supplier Name");
            CheckString(supplierContact, "Supplier Name");

            CheckDD(drugForm, "Drug Form");

            if (error.Length > 0)
            {
                MessageBox.Show(error);
                return;
            }
            DrugForm drugFormEnum = (DrugForm)drugForm;

            Pharmacists pharmacist = new();
            var drugId = pharmacist.CreateDrug(name, genericName, expiryDat, drugFormEnum, quantity, reorderLevel, price, manufacturer, supplierName, supplierContact);

            if(drugId.Length > 0)
            {
                 MessageBox.Show($"{genericName} was added to the store successfully, current stock is {quantity} {(drugForm == 0 ? "Cartons" : "Bottles")}");
                dataGridView1.DataSource = DrugDataStore.Drugs;
                Reset();
            }
            else
            {
                MessageBox.Show("Error in adding drug");
            }
        }

        public void Reset()
        {
            txtDrugName.Text = "";
            genericNameTxt.Text = "";
            ddlForm.SelectedIndex = 0;
            txtQuantityStock.Text = "";
            txtPrice.Text = "";
            txtReorderLevel.Text = "";
            txtManufacturer.Text = "";
            txtSupplierName.Text = "";
            txtSupplierContact.Text = "";
        }

        private void CheckString(string input, string label)
        {
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show($"{label} should not be empty");
                return;
            }
            if (input.Length < 3)
            {
                MessageBox.Show($"{label} should be more than 3 characters");
                return;
            }

        }

        private void CheckDD(int input, string label)
        {
            if (input < 0)
            {
                MessageBox.Show($"A {label} should be selected");
                return;
            }
        }

        private void updateDrugsBtn_Click(object sender, EventArgs e)
        {
            var error = "";
            decimal quantity = 0;
            if (string.IsNullOrEmpty(txtQuantityStock.Text.Trim()))
            {
                error += "Age Input should not be empty";
            }
            else
            {
                var check = decimal.TryParse(txtQuantityStock.Text.Trim(), out quantity);
                if (!check)
                {
                    error += "Invalid Age";
                }
            }
            decimal reorderLevel = 0;
            if (string.IsNullOrEmpty(txtReorderLevel.Text.Trim()))
            {
                error += "Age Input should not be empty";
            }
            else
            {
                var check = decimal.TryParse(txtReorderLevel.Text.Trim(), out reorderLevel);
                if (!check)
                {
                    error += "Invalid Age";
                }
            }

            decimal price = 0;
            if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                error += "Age Input should not be empty";
            }
            else
            {
                var check = decimal.TryParse(txtPrice.Text.Trim(), out price);
                if (!check)
                {
                    error += "Invalid Age";
                }
            }


            if(_selectedDrug != null)
            {
                _selectedDrug.AddDrugs(quantity);
                MessageBox.Show("Drug has been updated");
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                var drugId = selectedRow.Cells["DrugId"].Value.ToString();
                txtDrugName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
                txtManufacturer.Text = selectedRow.Cells["Manufacturer"].Value.ToString();
                txtQuantityStock.Text = selectedRow.Cells["Quantity"].Value.ToString();
                txtReorderLevel.Text = selectedRow.Cells["ReorderLevel"].Value.ToString();
                txtStatus.Text = selectedRow.Cells["DrugStatus"].Value.ToString();
                txtSupplierContact.Text = selectedRow.Cells["SupplierContactInfo"].Value.ToString();
                txtSupplierName.Text = selectedRow.Cells["SupplierName"].Value.ToString();
                genericNameTxt.Text = selectedRow.Cells["GenericName"].Value.ToString();
                expiryDate.Text = selectedRow.Cells["ExpiryDate"].Value.ToString();
                ddlForm.Text = selectedRow.Cells["Form"].Value.ToString();

                txtDrugName.ReadOnly = true;
                genericNameTxt.ReadOnly = true;
                expiryDate.Enabled = false;
                txtManufacturer.ReadOnly = true;
                txtSupplierName.ReadOnly = true;
                txtSupplierContact.ReadOnly = true;
                ddlForm.Enabled = false;

                expiryDate.Enabled = false;

                lblDrugStatus.Visible = true;
                txtStatus.Visible = true;

                registerDrugsBtn.Enabled = false;
                updateDrugsBtn.Enabled = true;

                _selectedDrug = DrugDataStore.Drugs.FirstOrDefault(d => drugId == d.DrugID)!;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            txtDrugName.Text = "";
            genericNameTxt.Text = "";
            ddlForm.SelectedIndex = 0;
            txtQuantityStock.Text = "";
            txtPrice.Text = "";
            txtReorderLevel.Text = "";
            txtManufacturer.Text = "";
            txtSupplierName.Text = "";
            txtSupplierContact.Text = "";


            txtDrugName.ReadOnly = false;
            genericNameTxt.ReadOnly = false;
            txtManufacturer.ReadOnly = false;
            txtSupplierName.ReadOnly = false;
            txtSupplierContact.ReadOnly = false;
            ddlForm.Enabled = true;

            registerDrugsBtn.Enabled = true;
            updateDrugsBtn.Enabled = false;

            expiryDate.Enabled = true;

            lblDrugStatus.Visible = false;
            txtStatus.Visible = false;
        }
    }
}

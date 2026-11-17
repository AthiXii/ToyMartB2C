using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace ToyMartB2C
{
    public partial class DeliveryInfoForm : Form
    {
        public bool ProfileMode { get; set; } = false;

        public DeliveryInfoForm()
        {
            InitializeComponent();
            Theme.Apply(this);
        }

        private void DeliveryInfoForm_Load(object sender, EventArgs e)
        {
            CheckoutInfo.LoadFromProfile();
            btnContinue.Text = ProfileMode ? "Save Details" : "Review Order";
            btnBack.Text = ProfileMode ? "Cancel" : "Back to Cart";

            cboPayment.Items.Clear();
            cboPayment.Items.AddRange(new object[] {
                "Cash on Delivery", "GCash", "Maya", "Credit/Debit Card"
            });
            cboProvince.Items.Clear();
            cboProvince.Items.AddRange(new object[] {
                "Metro Manila", "Cavite", "Laguna", "Batangas", "Rizal", "Quezon",
                "Bulacan", "Pampanga", "Cebu", "Davao del Sur"
            });

            txtRecipient.Text = CheckoutInfo.Recipient;
            txtContact.Text = CheckoutInfo.Contact;
            cboProvince.Text = CheckoutInfo.Province;
            txtCity.Text = CheckoutInfo.City;
            txtBarangay.Text = CheckoutInfo.Barangay;
            txtStreet.Text = CheckoutInfo.Street;
            txtPostal.Text = CheckoutInfo.Postal;
            cboPayment.SelectedItem = CheckoutInfo.Payment;
            if (cboPayment.SelectedIndex < 0) cboPayment.SelectedIndex = 0;

            if (txtRecipient.Text == "")
            {
                var dt = Db.Query("SELECT full_name FROM users WHERE user_id = @id",
                    new SqlParameter("@id", Session.UserId));
                if (dt.Rows.Count > 0) txtRecipient.Text = dt.Rows[0][0].ToString();
            }
        }

        private bool ValidateDelivery()
        {
            if (txtRecipient.Text.Trim() == "" || cboProvince.Text.Trim() == "" ||
                txtCity.Text.Trim() == "" || txtBarangay.Text.Trim() == "" ||
                txtStreet.Text.Trim() == "" || txtPostal.Text.Trim() == "")
            {
                MessageBox.Show("Please complete all delivery details.", "Missing information");
                return false;
            }
            if (!Regex.IsMatch(txtContact.Text.Trim(), @"^09\d{9}$"))
            {
                MessageBox.Show("Contact number must be 11 digits starting with 09.", "Invalid contact number");
                return false;
            }
            if (!Regex.IsMatch(txtPostal.Text.Trim(), @"^\d{4}$"))
            {
                MessageBox.Show("Postal code must be 4 digits.", "Invalid postal code");
                return false;
            }
            return true;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnContinue_Click_1(object sender, EventArgs e)
        {
            if (!ValidateDelivery()) return;

            CheckoutInfo.Recipient = txtRecipient.Text.Trim();
            CheckoutInfo.Contact = txtContact.Text.Trim();
            CheckoutInfo.Province = cboProvince.Text.Trim();
            CheckoutInfo.City = txtCity.Text.Trim();
            CheckoutInfo.Barangay = txtBarangay.Text.Trim();
            CheckoutInfo.Street = txtStreet.Text.Trim();
            CheckoutInfo.Postal = txtPostal.Text.Trim();
            CheckoutInfo.Payment = cboPayment.Text;

            CheckoutInfo.SaveToProfile();
            this.DialogResult = DialogResult.OK;

        }
    }
}
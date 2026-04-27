using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCare_Pro
{
    public partial class Jobcard : UserControl
    {
        static double subTotal;
        static double taxAmount;
        public Jobcard()
        {
            InitializeComponent();
        }

        private void btnEditCusDetails_Click(object sender, EventArgs e)
        {
            CustomerDetails cs = new CustomerDetails();
            if (cs.ShowDialog() == DialogResult.OK)
            {
                this.lblCustomerName.Text = cs.CustomerName;
                this.lblPhoneNumber.Text = cs.PhoneNumber;
                this.lblLocationShow.Text = cs.CustomerLocation;
                this.lblEmailShow.Text = cs.Email;
            }
        }

        private void btnEditVehicleDetails_Click(object sender, EventArgs e)
        {
            VehicleInfo vi = new VehicleInfo();
            if (vi.ShowDialog() == DialogResult.OK)
            {
                this.lblModel.Text = vi.Model;
                this.lblVehicleYear.Text = vi.Year;
                this.lblPlateNumber.Text = vi.PlateNumber;
                this.lblColorShow.Text = vi.Color;
            }
        }

        private void btnAddLabour_Click(object sender, EventArgs e)
        {
            LabourLineForm lf = new LabourLineForm();
            if (lf.ShowDialog() == DialogResult.OK)
            {
                this.dgvService.Rows.Add(lf.LabourDescription, lf.Hours.ToString(), lf.Rate.ToString(), (lf.Hours*lf.Rate).ToString());
                subTotal += (lf.Hours * lf.Rate);
                this.lblSubTotalValue.Text ="$"+ subTotal.ToString();
                taxAmount = subTotal * .088;
                this.lblTaxValue.Text = "$"+ taxAmount.ToString();
                this.lblGrandTotalValue.Text ="$"+ (taxAmount+subTotal).ToString();
            }
        }

        private void btnAddinventory_Click(object sender, EventArgs e)
        {
            PartsForm pf = new PartsForm();
            if (pf.ShowDialog() == DialogResult.OK)
            {
                this.dgvParts.Rows.Add(pf.PartsName, pf.Quantity, pf.UnitPrice, (pf.UnitPrice * pf.Quantity).ToString());
                subTotal += (pf.UnitPrice * pf.Quantity);
                this.lblSubTotalValue.Text = "$" + subTotal.ToString();
                taxAmount = subTotal * .088;
                this.lblTaxValue.Text = "$" + taxAmount.ToString();
                this.lblGrandTotalValue.Text = "$" + (taxAmount + subTotal).ToString();
            }
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            string cusName = this.lblCustomerName.Text;
            string cusPhone = this.lblPhoneNumber.Text;
            string cusEmail = this.lblEmailShow.Text;
            string cusLocation = this.lblLocationShow.Text;
            string vehicleModel = this.lblModel.Text;
            string vehicleYear = this.lblVehicleYear.Text;
            string vehiclePlate = this.lblPlateNumber.Text;
            string technicalInstructions = this.richtextTechnote.Text.Trim() ==""? "No Insturctions provided." : this.richtextTechnote.Text;
            string vehicleColor = this.lblColorShow.Text;
            double subtotal = this.lblSubTotalValue.Text != "" ? double.Parse(this.lblSubTotalValue.Text.TrimStart('$')) : 0;
            double tax = this.lblTaxValue.Text != "" ? double.Parse(this.lblTaxValue.Text.TrimStart('$')) : 0;
            double grandTotal = this.lblGrandTotalValue.Text != "" ? double.Parse(this.lblGrandTotalValue.Text.TrimStart('$')) : 0;
            double taxRate = 8.8;
            string employeeId = userForm.EmpId;
            string cusId = "";

            DataSet dsCheck = DbHelper.GetData("SELECT Customer_Id FROM Customers WHERE Phone = '" + cusPhone + "';");

            

            if (dsCheck.Tables[0].Rows.Count > 0)
            {
                cusId = dsCheck.Tables[0].Rows[0]["Customer_Id"].ToString();
                MessageBox.Show("Existing customer found! Using existing record.");
            }
            else
            {
                cusId = DbHelper.ExecuteScalar("INSERT INTO Customers (Name, Phone, Email, Address, Vehicle_Model, Vehicle_Year, Vehicle_Plate, Vehicle_Color) VALUES ('" + cusName + "','" + cusPhone + "','" + cusEmail + "','" + cusLocation + "','" + vehicleModel + "','" + vehicleYear + "','" + vehiclePlate + "','" + vehicleColor + "'); SELECT SCOPE_IDENTITY();");
            }

            string invoiceId = "";

            string sqlQuery2 = "INSERT INTO Invoices (Customer_Id, Employe_Id, Tech_Notes, Sub_Total, Tax_Percent, Tax_Amount, Grand_Total) VALUES ('" + cusId + "','" + employeeId + "','" + technicalInstructions + "','" + subtotal + "','" + taxRate + "','" + tax + "','" + grandTotal + "'); SELECT SCOPE_IDENTITY();";
            
            invoiceId = DbHelper.ExecuteScalar(sqlQuery2);
            
            foreach (DataGridViewRow row in dgvService.Rows)
            {
                if (row.IsNewRow) continue;

                string description = row.Cells["clmnDescription"].Value?.ToString();
                string hours = row.Cells["clmnHours"].Value?.ToString();
                string rate = row.Cells["clmnRate"].Value?.ToString();
                string total = row.Cells["clmnTotal"].Value?.ToString();

                if (string.IsNullOrEmpty(description)) continue;

                string sqlQuery3 = "INSERT INTO Job_Services (Invoice_Id, Description, Hours, Rate, Total) VALUES ('" + invoiceId + "','" + description + "','" + hours + "','" + rate + "','" + total + "');";
                
                DbHelper.ExecuteQuery(sqlQuery3);
            }
            foreach (DataGridViewRow row in dgvParts.Rows)
            {
                if (row.IsNewRow) continue;

                string partName = row.Cells["clmnPartData"].Value?.ToString();
                string qty = row.Cells["clmnQty"].Value?.ToString();
                string price = row.Cells["clmnPrice"].Value?.ToString();
                string partTotal = row.Cells["clmnPartTotal"].Value?.ToString();

                if (string.IsNullOrEmpty(partName)) continue;

                string sqlQuery4 = "INSERT INTO Job_Parts (Invoice_Id, Part_Name, Qty, Unit_Price, Total) VALUES ('" + invoiceId + "','" + partName + "','" + qty + "','" + price + "','" + partTotal + "');";
                DbHelper.ExecuteQuery(sqlQuery4);
            }
            MessageBox.Show("Invoice #" + invoiceId + " Generated Successfully!", "Invoice Successfull!",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Jobcard_Load(object sender, EventArgs e)
        {
            this.lblEmployeeName.Text = userForm.EmpName;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phone = this.txtSearch.Text.Trim();

            if (phone == "")
            {
                MessageBox.Show("Please enter a phone number to search!");
                return;
            }

            string sqlQuery = "SELECT * FROM Customers WHERE Phone = '" + phone + "';";
            DataSet ds = DbHelper.GetData(sqlQuery);

            if (ds.Tables[0].Rows.Count > 0)
            {
                this.lblCustomerName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                this.lblPhoneNumber.Text = ds.Tables[0].Rows[0]["Phone"].ToString();
                this.lblEmailShow.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                this.lblLocationShow.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                this.lblModel.Text = ds.Tables[0].Rows[0]["Vehicle_Model"].ToString();
                this.lblVehicleYear.Text = ds.Tables[0].Rows[0]["Vehicle_Year"].ToString();
                this.lblPlateNumber.Text = ds.Tables[0].Rows[0]["Vehicle_Plate"].ToString();

                MessageBox.Show("Customer Found!","Search Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                this.lblCustomerName.Text = "";
                this.lblPhoneNumber.Text = "";
                this.lblEmailShow.Text = "";
                this.lblLocationShow.Text = "";
                this.lblModel.Text = "";
                this.lblVehicleYear.Text = "";
                this.lblPlateNumber.Text = "";

                MessageBox.Show("No customer found with this phone number!","Search Result",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

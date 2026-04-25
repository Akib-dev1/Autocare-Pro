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
            //dgvService.Rows.Add("asdda", "ssdaada", "sdawadasd", "sdwadsada");
            //this.lblCustomerName.Text=dgvService.Rows[0].Cells[1].Value.ToString();
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
            string technicalInstructions = this.richtextTechnote.Text;
            string vehicleColor = this.lblColorShow.Text;
            double subtotal = this.lblSubTotalValue.Text != "" ? double.Parse(this.lblSubTotalValue.Text.TrimStart('$')) : 0;
            double tax = this.lblTaxValue.Text != "" ? double.Parse(this.lblTaxValue.Text.TrimStart('$')) : 0;
            double grandTotal = this.lblGrandTotalValue.Text != "" ? double.Parse(this.lblGrandTotalValue.Text.TrimStart('$')) : 0;
            double taxRate = 8.8;
            string employeeId = userForm.EmpId;
            // STEP 1 — Save Customer
            string cusId = "";

            string sqlQuery = "INSERT INTO Customers (Name, Phone, Email, Address, Vehicle_Model, Vehicle_Year, Vehicle_Plate, Vehicle_Color) VALUES ('" + cusName + "','" + cusPhone + "','" + cusEmail + "','" + cusLocation + "','" + vehicleModel + "','" + vehicleYear + "','" + vehiclePlate + "','" + vehicleColor + "'); SELECT SCOPE_IDENTITY();";
            SqlConnection sqlCon = new SqlConnection("Data Source=AKIB\\SQLMAIN;Initial Catalog=AutoCarePro;Persist Security Info=True;User ID=sa;Password=password@Ak;Encrypt=False");
            sqlCon.Open();
            SqlCommand sql = new SqlCommand(sqlQuery, sqlCon);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataSet ds = new DataSet();
            sqlData.Fill(ds);
            cusId = ds.Tables[0].Rows[0][0].ToString();
            sqlCon.Close();
            // STEP 2 — Save Invoice and get Invoice_Id
            string invoiceId = "";

            string sqlQuery2 = "INSERT INTO Invoices (Customer_Id, Employe_Id, Tech_Notes, Sub_Total, Tax_Percent, Tax_Amount, Grand_Total) VALUES ('" + cusId + "','" + employeeId + "','" + technicalInstructions + "','" + subtotal + "','" + taxRate + "','" + tax + "','" + grandTotal + "'); SELECT SCOPE_IDENTITY();";
            SqlConnection sqlCon2 = new SqlConnection("Data Source=AKIB\\SQLMAIN;Initial Catalog=AutoCarePro;Persist Security Info=True;User ID=sa;Password=password@Ak;Encrypt=False");
            sqlCon2.Open();
            SqlCommand sql2 = new SqlCommand(sqlQuery2, sqlCon2);
            SqlDataAdapter sqlData2 = new SqlDataAdapter(sql2);
            DataSet ds2 = new DataSet();
            sqlData2.Fill(ds2);
            invoiceId = ds2.Tables[0].Rows[0][0].ToString();
            sqlCon2.Close();
            // STEP 3 — Save each row from dgvService
            foreach (DataGridViewRow row in dgvService.Rows)
            {
                if (row.IsNewRow) continue;

                string description = row.Cells["clmnDescription"].Value?.ToString();
                string hours = row.Cells["clmnHours"].Value?.ToString();
                string rate = row.Cells["clmnRate"].Value?.ToString();
                string total = row.Cells["clmnTotal"].Value?.ToString();

                if (string.IsNullOrEmpty(description)) continue;

                string sqlQuery3 = "INSERT INTO Job_Services (Invoice_Id, Description, Hours, Rate, Total) VALUES ('" + invoiceId + "','" + description + "','" + hours + "','" + rate + "','" + total + "');";
                SqlConnection sqlCon3 = new SqlConnection("Data Source=AKIB\\SQLMAIN;Initial Catalog=AutoCarePro;Persist Security Info=True;User ID=sa;Password=password@Ak;Encrypt=False");
                sqlCon3.Open();
                SqlCommand sql3 = new SqlCommand(sqlQuery3, sqlCon3);
                sql3.ExecuteNonQuery();
                sqlCon3.Close();
            }
            // STEP 4 — Save each row from dgvParts
            foreach (DataGridViewRow row in dgvParts.Rows)
            {
                if (row.IsNewRow) continue;

                string partName = row.Cells["clmnPartData"].Value?.ToString();
                string qty = row.Cells["clmnQty"].Value?.ToString();
                string price = row.Cells["clmnPrice"].Value?.ToString();
                string partTotal = row.Cells["clmnPartTotal"].Value?.ToString();

                if (string.IsNullOrEmpty(partName)) continue;

                string sqlQuery4 = "INSERT INTO Job_Parts (Invoice_Id, Part_Name, Qty, Unit_Price, Total) VALUES ('" + invoiceId + "','" + partName + "','" + qty + "','" + price + "','" + partTotal + "');";
                SqlConnection sqlCon4 = new SqlConnection("Data Source=AKIB\\SQLMAIN;Initial Catalog=AutoCarePro;Persist Security Info=True;User ID=sa;Password=password@Ak;Encrypt=False");
                sqlCon4.Open();
                SqlCommand sql4 = new SqlCommand(sqlQuery4, sqlCon4);
                sql4.ExecuteNonQuery();
                sqlCon4.Close();
            }
            // DONE
            MessageBox.Show("Invoice #" + invoiceId + " Generated Successfully!");
        }
    }
}

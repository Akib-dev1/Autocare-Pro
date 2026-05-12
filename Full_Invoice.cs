using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCare_Pro
{
    public partial class Full_Invoice : Form
    {
        int InvoiceID {  get; set; }
        DataTable InvoiceTable { get; set; }
        DataTable JobServicesTable {  get; set; }
        DataTable PartsTable { get; set; }
        DataTable CustomerTable { get; set; }
        public Full_Invoice()
        {
            InitializeComponent();
        }
        public Full_Invoice(int invoiceId) : this()
        {
            this.InvoiceID = invoiceId;
        }
        void LoadInvoiceDetails()
        {
            this.dgvService.DataSource = this.JobServicesTable;
            this.dgvParts.DataSource = this.PartsTable;
            this.lblInvoiceId.Text+=this.InvoiceTable.Rows[0][0].ToString();
            this.lblName.Text = this.CustomerTable.Rows[0][1].ToString();
            this.lblPhone.Text = this.CustomerTable.Rows[0][2].ToString();
            this.lblEmail.Text = this.CustomerTable.Rows[0][3].ToString();
            this.lblAddress.Text = this.CustomerTable.Rows[0][4].ToString();
            this.lblModel.Text=this.CustomerTable.Rows[0][5].ToString();
            this.lblVehicleYear.Text = this.CustomerTable.Rows[0][6].ToString();
            this.lblPlateNumber.Text = this.CustomerTable.Rows[0][7].ToString();
            this.lblColorShow.Text = this.CustomerTable.Rows[0][8].ToString();
            this.lblID.Text+= this.InvoiceTable.Rows[0][0].ToString();
            this.lblCustomerId.Text += this.InvoiceTable.Rows[0][1].ToString();
            this.lblCreatedAt.Text += Convert.ToDateTime(this.InvoiceTable.Rows[0][8]).ToString("yyyy-MM-dd");
            this.lblEmploye.Text+= this.InvoiceTable.Rows[0][2].ToString();
            this.lblSubTotalShow.Text += this.InvoiceTable.Rows[0][4].ToString();
            this.lblTaxShow.Text += this.InvoiceTable.Rows[0][6].ToString();
            this.lblGrandTotalShow.Text += this.InvoiceTable.Rows[0][7].ToString();
        }

        private void Full_Invoice_Load(object sender, EventArgs e)
        {
            string invoiceQuery = $"select * from invoices where invoice_id = {this.InvoiceID};";
            this.InvoiceTable=userForm.Da.GetDataTable(invoiceQuery);
            string jobServicesQuery = $"select * from job_services where invoice_id={this.InvoiceID};";
            this.JobServicesTable = userForm.Da.GetDataTable(jobServicesQuery);
            string partsQuery = $"select * from job_parts where invoice_id={this.InvoiceID};";
            this.PartsTable = userForm.Da.GetDataTable(partsQuery);
            string customerQuery = $"select * from customers where customer_id=(select customer_id from invoices where invoice_id={this.InvoiceID});";
            this.CustomerTable = userForm.Da.GetDataTable(customerQuery);
            LoadInvoiceDetails();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void Full_Invoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}

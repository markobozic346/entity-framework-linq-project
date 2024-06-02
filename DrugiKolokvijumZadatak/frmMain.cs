using BusinessLayer;
using BusinessLogic;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugiKolokvijumZadatak
{
    public partial class frmMain : Form
    {

        OrderBL orderBl;
        ProductBL productBl;
        CustomerBL customerBl;
        EmployeeBL employeeBl;
        public frmMain()
        {
            InitializeComponent();
            orderBl = new OrderBL();
            productBl = new ProductBL();
            customerBl = new CustomerBL();
            employeeBl = new EmployeeBL();
        }

        private void SearchOrders()
        {
            northwindEntities db = new northwindEntities();
          
                int? selectedEmployeeId = null;
                if (cmbEmployee.SelectedIndex != -1 && cmbEmployee.SelectedValue != null && cmbEmployee.SelectedValue is int)
                {
                    selectedEmployeeId = (int)cmbEmployee.SelectedValue;
                }

                string selectedCustomerId = cmbCustomer.SelectedIndex != -1 ? cmbCustomer.SelectedValue.ToString() : null;

                int? selectedProductId = null;
                if (cmbProduct.SelectedIndex != -1 && cmbProduct.SelectedValue != null && cmbProduct.SelectedValue is int)
                {
                    selectedProductId = (int)cmbProduct.SelectedValue;
                }

                var results = db.spSearchOrders(selectedEmployeeId, selectedCustomerId, selectedProductId).ToList();
                dataGrid.DataSource = results;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            frmNewOrder fo = new frmNewOrder();
            fo.ShowDialog();
            dataGrid.DataSource = orderBl.GetAllOrders();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            // Display preview button for order details
            DataGridViewButtonColumn btnColumnPreview = new DataGridViewButtonColumn();
            btnColumnPreview.HeaderText = "Order Details";
            btnColumnPreview.Text = "Preview";
            btnColumnPreview.UseColumnTextForButtonValue = true; // Display text on button
            btnColumnPreview.Name = "OrderDetails"; // Set the column name
            dataGrid.Columns.Add(btnColumnPreview);

            //Display edit button for order editing
            DataGridViewButtonColumn btnColumnEdit = new DataGridViewButtonColumn();
            btnColumnEdit.HeaderText = "Edit";
            btnColumnEdit.Text = "Edit";
            btnColumnEdit.UseColumnTextForButtonValue = true; // Display text on button
            btnColumnEdit.Name = "Edit"; // Set the column name
            dataGrid.Columns.Add(btnColumnEdit);

            // Populate grid with data
            dataGrid.DataSource = orderBl.GetAllOrders();

            //Populate combo boxes
            cmbEmployee.DataSource = employeeBl.GetAllEmployees();
            cmbEmployee.DisplayMember = "FirstName";
            cmbEmployee.ValueMember = "EmployeeID";
            cmbEmployee.SelectedIndex = -1;

            cmbCustomer.DataSource = customerBl.getAllCustomers();
            cmbCustomer.DisplayMember = "CompanyName";
            cmbCustomer.ValueMember = "CustomerID";
            cmbCustomer.SelectedIndex = -1;

            cmbProduct.DataSource = productBl.getAllProducts();
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";
            cmbProduct.SelectedIndex = -1;

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = (int)dataGrid.Rows[e.RowIndex].Cells["OrderID"].Value;
            // Handle preview order button click
            if (e.ColumnIndex == dataGrid.Columns["OrderDetails"].Index && e.RowIndex >= 0)
            {
                frmPreviewOrderDetail detailsForm = new frmPreviewOrderDetail(orderId);
                detailsForm.ShowDialog();
           
               
            }else if (e.ColumnIndex == dataGrid.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                frmEditOrder editOrderForm = new frmEditOrder(orderId);
                editOrderForm.ShowDialog();
                dataGrid.DataSource = orderBl.GetAllOrders();
            }
            else
            {
                frmEditOrder editOrderForm = new frmEditOrder(orderId);
                editOrderForm.ShowDialog();
                dataGrid.DataSource = orderBl.GetAllOrders();
            }

        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

            SearchOrders();
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchOrders();
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchOrders();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbEmployee.SelectedIndex = -1;
            cmbCustomer.SelectedIndex = -1;
            cmbProduct.SelectedIndex = -1;
        }

    }
}

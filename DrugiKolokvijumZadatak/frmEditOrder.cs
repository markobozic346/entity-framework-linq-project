using BusinessLayer;
using BusinessLogic;
using DataLayer;
using Domain;
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
    public partial class frmEditOrder : Form
    {
        int orderID;
        OrderDTO orderDTO;
        OrderDetailsDTO detailsDTO;
        OrderBL orderBl;
        ProductBL productBl;
        CustomerBL customerBl;
        EmployeeBL employeeBl;
        ShipperBL shipperBl;
        OrderDetailsBL orderDetailsBL;
        public frmEditOrder(int orderId)
        {
            InitializeComponent();
            orderID = orderId;

            orderDTO = new OrderBL().GetOrder(orderId);
            detailsDTO = new OrderDetailsBL().GetOrderDetail(orderId);
            orderBl = new OrderBL();
            productBl = new ProductBL();
            customerBl = new CustomerBL();
            employeeBl = new EmployeeBL();
            shipperBl = new ShipperBL();
            orderDetailsBL = new OrderDetailsBL();
        }

        private void RenderTable()
        {
            dataGrid.DataSource = orderDetailsBL.GetAllByOrder(orderID);
        }
        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            // Get the selected row
            if (dataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = dataGrid.SelectedRows[0];

                var productId = selectedRow.Cells["ProductID"].Value;
                var quantity = selectedRow.Cells["Quantity"].Value.ToString();
                var unitPrice = selectedRow.Cells["UnitPrice"].Value.ToString();
                var discount = selectedRow.Cells["Discount"].Value.ToString();

                txtDiscount.Text = discount;
                txtPrice.Text = unitPrice;
                txtQuantity.Text = quantity;
                cmbProduct.SelectedValue = productId;
            }
        }

        private void frmEditOrder_Load(object sender, EventArgs e)
        {

            cmbEmployee.DataSource = employeeBl.GetAllEmployees();
            cmbEmployee.DisplayMember = "FirstName";
            cmbEmployee.ValueMember = "EmployeeID";
            cmbEmployee.SelectedValue = orderDTO.EmployeeID;

            cmbShipper.DataSource = shipperBl.getAllShippers();
            cmbShipper.DisplayMember = "CompanyName";
            cmbShipper.ValueMember = "ShipperID";


            cmbCustomer.DataSource = customerBl.getAllCustomers();
            cmbCustomer.DisplayMember = "CompanyName";
            cmbCustomer.ValueMember = "CustomerID";

            cmbProduct.DataSource = productBl.getAllProducts();
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";
            cmbProduct.SelectedIndex = -1;

            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");


            RenderTable();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            
            var selectedRow = dataGrid.SelectedRows[0];
           
            var productId = selectedRow.Cells["ProductID"].Value.ToString();
            var quantity = selectedRow.Cells["Quantity"].Value.ToString();
            var unitPrice = selectedRow.Cells["UnitPrice"].Value.ToString();
            var discount = selectedRow.Cells["Discount"].Value.ToString();

            if (string.IsNullOrEmpty(productId) || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(unitPrice) || string.IsNullOrEmpty(discount))
            {
                MessageBox.Show("Sva polja su obavezna!!");
                return;
            }
            OrderDetailsBL orderDetailsBl = new OrderDetailsBL();
            try
            {
                detailsDTO.ProductID = int.Parse(cmbProduct.SelectedValue.ToString());
                detailsDTO.Quantity = short.Parse(txtQuantity.Text);
                detailsDTO.UnitPrice = decimal.Parse(txtPrice.Text);
                detailsDTO.Discount = float.Parse(txtDiscount.Text);
                orderDetailsBl.Save(detailsDTO);

                
                MessageBox.Show("Order item updated succesfully!");
                dataGrid.Refresh();
                RenderTable();
                
            }
            catch (Exception err)
            {
                MessageBox.Show("Something went wrong, Error: \r\n\r\n" + err.Message);
            }
            
        }

        private void btnUpdateOrder_Click_1(object sender, EventArgs e)
        {
            OrderBL orderBl = new OrderBL();
           
            try
            {
                orderDTO.CustomerID = cmbCustomer.SelectedValue.ToString();
                orderDTO.EmployeeID = int.Parse(cmbEmployee.SelectedValue.ToString());
                orderBl.Save(orderDTO);

              
                MessageBox.Show("Order updated succesfully!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Something went wrong, Error: \r\n\r\n" + err.Message);
            }
        }
    }
}

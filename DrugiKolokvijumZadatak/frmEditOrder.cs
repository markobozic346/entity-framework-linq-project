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

            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtDiscount.Text = detailsDTO.Discount.ToString();
            txtPrice.Text = detailsDTO.UnitPrice.ToString();
            txtQuantity.Text = detailsDTO.Quantity.ToString();

        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {

            OrderBL orderBl = new OrderBL();
            OrderDetailsBL orderDetailsBl = new OrderDetailsBL();
            try
            {
                orderDTO.CustomerID = cmbCustomer.SelectedValue.ToString();
                orderDTO.EmployeeID = int.Parse(cmbEmployee.SelectedValue.ToString());
                orderBl.Save(orderDTO);

                detailsDTO.ProductID = int.Parse(cmbProduct.SelectedValue.ToString());
                detailsDTO.Quantity = short.Parse(txtQuantity.Text);
                detailsDTO.UnitPrice = decimal.Parse(txtPrice.Text);
                detailsDTO.Discount = float.Parse(txtDiscount.Text);
                orderDetailsBl.Save(detailsDTO);

                MessageBox.Show("Order updated succesfully!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Something went wrong, Error: \r\n\r\n" + err.Message);
            }
        }
    }
}

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
    public partial class frmNewOrder : Form
    {
        OrderDTO oDTO = new OrderDTO();
        List<OrderDetailsDTO> odDTOList = new List<OrderDetailsDTO>();
        OrderBL orderBl;
        ProductBL productBl;
        CustomerBL customerBl;
        EmployeeBL employeeBl;
        ShipperBL shipperBl;
        public frmNewOrder()
        {
            InitializeComponent();
            orderBl = new OrderBL();
            productBl = new ProductBL();
            customerBl = new CustomerBL();
            employeeBl = new EmployeeBL();
            shipperBl = new ShipperBL();
        }

        private void frmNewOrder_Load(object sender, EventArgs e)
        {
            cmbEmployee.DataSource = employeeBl.GetAllEmployees();
            cmbEmployee.DisplayMember = "FirstName";
            cmbEmployee.ValueMember = "EmployeeID";

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

            txtDiscount.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            cmbProduct.Enabled = false;
            txtDiscount.Enabled = false;
            txtPrice.Enabled = false;
            txtQuantity.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            oDTO.OrderDate = DateTime.Parse(lblDate.Text);
            oDTO.EmployeeID = (Int32)cmbEmployee.SelectedValue;
            oDTO.ShipVia = (Int32)cmbShipper.SelectedValue;
            oDTO.CustomerID = cmbCustomer.SelectedValue.ToString();

            cmbProduct.Enabled = true;
            txtDiscount.Enabled = true;
            txtPrice.Enabled = true;
            txtQuantity.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            OrderDetailsDTO odDTO = new OrderDetailsDTO();
            odDTO.ProductID = (int)cmbProduct.SelectedValue;
            odDTO.UnitPrice = Convert.ToDecimal(txtPrice.Text);
            odDTO.Quantity = Convert.ToInt16(txtQuantity.Text);
            odDTO.Discount = Convert.ToSingle(txtDiscount.Text);

            odDTOList.Add(odDTO);

            dgvOrderDetails.DataSource = null;
            dgvOrderDetails.DataSource = odDTOList;

            txtDiscount.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OrderBL oBL = new OrderBL();
            OrderDetailsBL odBL = new OrderDetailsBL();

            try
            {
                int OrderID = oBL.Insert(oDTO);
                foreach (OrderDetailsDTO odDTP in odDTOList)
                {
                    odDTP.OrderID = OrderID;
                    odBL.Insert(odDTP);
                }

                oDTO = new OrderDTO();
                odDTOList = new List<OrderDetailsDTO>();
                dgvOrderDetails.DataSource = null;

                txtDiscount.Text = "";
                txtPrice.Text = "";
                txtQuantity.Text = "";
                cmbProduct.Enabled = false;
                txtDiscount.Enabled = false;
                txtPrice.Enabled = false;
                txtQuantity.Enabled = false;

                MessageBox.Show("Order created successfully!");
            }
            catch (Exception ex)
            {
                odBL.Delete(oDTO.OrderID);
                oBL.Delete(oDTO.OrderID);

                MessageBox.Show("Something went wrong, Errro:\r\n\r\n" + ex.Message);
            }
        }
    }
}

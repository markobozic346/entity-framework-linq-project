using BusinessLayer;
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
    public partial class frmPreviewOrderDetail : Form
    {

        int orderDetailID;
        OrderDetailsBL orderDetailsBl;

        public frmPreviewOrderDetail(int orderDetailId)
        {
            InitializeComponent();

            orderDetailID = orderDetailId;
            orderDetailsBl = new OrderDetailsBL();
        }

        private void frmPreviewOrderDetail_Load(object sender, EventArgs e)
        {
            OrderDetailsDTO orderDetail = new OrderDetailsBL().GetOrderDetail(orderDetailID);
            ProductDTO product = new ProductBL().getProduct(orderDetail.ProductID);

            lblProductName.Text = product.ProductName;

            dataGrid.DataSource = orderDetailsBl.GetAllByOrder(orderDetailID);
        }
    }
}

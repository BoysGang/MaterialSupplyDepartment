using MTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTO
{
    public partial class FormReceiptOrderView : Form
    {

        ReceiptOrder receiptOrder = null;

        public FormReceiptOrderView(ReceiptOrder receiptOrder)
        {
            InitializeComponent();

            this.receiptOrder = receiptOrder;

        }

        private void tsmi_editChange_Click(object sender, EventArgs e)
        {
            FormReceiptOrderAdd form = new FormReceiptOrderAdd(receiptOrder);
            form.ShowDialog();
        }

        private void FormReceiptOrderView_Activated(object sender, EventArgs e)
        {
            updateReceiptOrderTable();
            updateReceiptOrderLinesTable();
        }

        private void updateReceiptOrderTable()
        {
            dgv_receiptOrders.DataSource = new List<ReceiptOrder> { receiptOrder };

            dgv_receiptOrders.Columns[0].DataPropertyName = "PK_ReceiptOrder";
            dgv_receiptOrders.Columns[1].DataPropertyName = "DeliveryDate";
            dgv_receiptOrders.Columns[2].DataPropertyName = "Warehouse";
            dgv_receiptOrders.Columns[3].DataPropertyName = "Provider";
            dgv_receiptOrders.Columns[4].DataPropertyName = "Provider_INN";
            dgv_receiptOrders.Columns[5].DataPropertyName = "Contract";

            lbl_receiptOrderNumber.Text = "Приходной ордер № " + receiptOrder.ReceiptOrderNumber;
        }

        private void updateReceiptOrderLinesTable()
        {
            List<ReceiptOrderLine> lines = receiptOrder.getReceiptOrderLines();
            dgv_receiptOrderLines.DataSource = lines;

            dgv_receiptOrderLines.Columns[0].DataPropertyName = "PK_ReceiptOrderLine";
            dgv_receiptOrderLines.Columns[1].DataPropertyName = "Resource";
            dgv_receiptOrderLines.Columns[2].DataPropertyName = "Resource_Cipher";
            dgv_receiptOrderLines.Columns[3].DataPropertyName = "Resource_Unit";
            dgv_receiptOrderLines.Columns[4].DataPropertyName = "Resource_Unit_Cipher";
            dgv_receiptOrderLines.Columns[5].DataPropertyName = "AcceptedAmount";
            dgv_receiptOrderLines.Columns[6].DataPropertyName = "DocumentAmount";
            dgv_receiptOrderLines.Columns[7].DataPropertyName = "Price";
            dgv_receiptOrderLines.Columns[8].DataPropertyName = "TotalPrice";
        }

        private void FormReceiptOrderView_Load(object sender, EventArgs e)
        {
            dgv_receiptOrders.AutoGenerateColumns = false;
            dgv_receiptOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgv_receiptOrderLines.AutoGenerateColumns = false;
            dgv_receiptOrderLines.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_receiptOrders_SelectionChanged(object sender, EventArgs e)
        {
            dgv_receiptOrders.ClearSelection();
        }

        private void dgv_receiptOrderLines_SelectionChanged(object sender, EventArgs e)
        {
            dgv_receiptOrderLines.ClearSelection();
        }
    }
}

﻿using SGMOSOL.ADMIN;
using SGMOSOL.BAL;
using SGMOSOL.DAL;
using SGMOSOL.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SGMOSOL.SCREENS
{
    public partial class frmReqToAdmin : Form
    {
        BhojnalayPrintReceiptBAL obj = new BhojnalayPrintReceiptBAL();
        private DataTable tempItemTable;
        public frmReqToAdmin()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(frmReqToAdmin_KeyDown);
            this.KeyPreview = true;
            CenterToParent();
        }

        private void frmReqToAdmin_Load(object sender, EventArgs e)
        {
            int centerX = (ClientSize.Width - pnlMaster.Width) / 2;
            int centerY = (ClientSize.Height - pnlMaster.Height) / 2;
            pnlMaster.Location = new System.Drawing.Point(centerX, centerY);
            txtCounter.Text = UserInfo.Counter_Name;
            getRequirementber();
            txtUser.Text = UserInfo.UserName;
            fillItemCode();
            createItemTable();
            cboItemCode.Focus();
        }
        private void ClearRowSelection()
        {
            foreach (DataGridViewRow row in dgvItemDetails.Rows)
            {
                row.DefaultCellStyle.BackColor = dgvItemDetails.DefaultCellStyle.BackColor;
            }
        }
        public void getRequirementber()
        {
            int intRequiremenumber = Convert.ToInt32(obj.getReqNumber()) + 1;
            txtReqID.Text = intRequiremenumber.ToString();
        }
        public void fillItemCode()
        {
            DataTable dt = new DataTable();
            dt = obj.getItemCode();
            DataRow newRow = dt.NewRow();
            newRow["ITEM_CODE"] = "Select";
            newRow["ITEM_ID"] = 0;
            dt.Rows.InsertAt(newRow, 0);
            cboItemCode.DataSource = dt;
            cboItemCode.DisplayMember = "ITEM_CODE";
            cboItemCode.ValueMember = "ITEM_ID";
            cboItemCode.SelectedValue = 0;
        }
        public void clearControl()
        {
            txtQuantity.Text = "";
            txtItemName.Text = "";
            cboItemCode.SelectedValue = 0;
            createItemTable();
            getRequirementber();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void cboItemCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboItemCode.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)cboItemCode.SelectedItem;
                int itemId = Convert.ToInt32(selectedRow["ITEM_ID"]);
                getItemName(itemId);
            }
        }
        public void getItemName(int ItemId)
        {
            string strItemName = null;
            strItemName = obj.getItemName(ItemId);
            txtItemName.Text = strItemName;
        }
        private void createItemTable()
        {
            dgvItemDetails.Columns.Clear();
            tempItemTable = new DataTable("ItemTable");
            tempItemTable.Columns.Add("ID", typeof(int));
            tempItemTable.Columns.Add("Item Code", typeof(string));
            tempItemTable.Columns.Add("Item Name", typeof(string));
            // tempItemTable.Columns.Add("Price", typeof(decimal));
            tempItemTable.Columns.Add("Quantity", typeof(int));
            // tempItemTable.Columns.Add("Amount", typeof(decimal));

            tempItemTable.Columns["ID"].AutoIncrement = true;
            tempItemTable.Columns["ID"].AutoIncrementSeed = 1;
            tempItemTable.Columns["ID"].AutoIncrementStep = 1;
            dgvItemDetails.DataSource = tempItemTable;
            //DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            //editButtonColumn.Name = "EditButton";
            //editButtonColumn.HeaderText = "Edit";
            //editButtonColumn.Text = "Edit";
            //editButtonColumn.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            // dgvItemDetails.Columns.Add(editButtonColumn);
            dgvItemDetails.Columns.Add(deleteButtonColumn);
        }
        public void addItemIngrid()
        {
            if (txtQuantity.Text != "" && cboItemCode.Text != "Select")
            {
                // lblQuantity.Text = "";
                DataRow[] duplicateRow = tempItemTable.Select($"[Item Name] = '{txtItemName.Text}'");
                if (duplicateRow.Length > 0)
                {
                    foreach (DataRow row in duplicateRow)
                    {
                        int currentQuantity = Convert.ToInt32(row["Quantity"]);
                        //int currentAmount = Convert.ToInt32(row["Amount"]);
                        // row["Price"] = Convert.ToDecimal(txtPrice.Text);
                        row["Quantity"] = Convert.ToInt32(txtQuantity.Text) + currentQuantity;
                        // row["Amount"] = Convert.ToDecimal(txtAmount.Text) + currentAmount;
                    }
                }
                else
                {
                    DataRow newRow = tempItemTable.NewRow();
                    newRow["Item Code"] = cboItemCode.Text.ToString();
                    newRow["Item Name"] = txtItemName.Text.ToString();
                    // newRow["Price"] = Convert.ToDecimal(txtPrice.Text);
                    newRow["Quantity"] = Convert.ToInt32(txtQuantity.Text);
                    // newRow["Amount"] = Convert.ToDecimal(txtAmount.Text);
                    tempItemTable.Rows.Add(newRow);
                }
                txtQuantity.Text = "";
                cboItemCode.Focus();
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtQuantity.Text == "")
                {
                    lblQty.Text = "Please Enter Quantity";
                }
                else
                {
                    addItemIngrid();
                }
            }
        }

        private void dgvItemDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvItemDetails.Columns["DeleteButton"].Index)
            {
                ClearRowSelection();
                dgvItemDetails.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
                int id = Convert.ToInt32(dgvItemDetails.Rows[e.RowIndex].Cells["ID"].Value);
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the row with ID {id}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataRow[] rowsToDelete = tempItemTable.Select($"ID = {id}");
                    if (rowsToDelete.Length > 0)
                    {
                        rowsToDelete[0].Delete();
                        tempItemTable.AcceptChanges();
                        dgvItemDetails.Refresh();
                        MessageBox.Show($"Row with ID {id} deleted successfully!");
                    }
                }
            }
        }
        public string getSelectedItems()
        {
            StringBuilder itemNames = new StringBuilder();
            foreach (DataGridViewRow row in dgvItemDetails.Rows)
            {
                if (!row.IsNewRow)
                {
                    object cellValue = row.Cells["Item Name"].Value;
                    if (cellValue != null)
                    {
                        itemNames.Append(cellValue.ToString());
                        if (row.Index < dgvItemDetails.Rows.Count - 1)
                        {
                            itemNames.Append(",");
                        }
                    }
                }
            }
            return itemNames.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveRequirement();
            clearControl();
        }
        public void saveRequirement()
        {
            int Status = 0;
            bhojnalayPrintReceiptModel bhojnalayModel = new bhojnalayPrintReceiptModel();
            bhojnalayModel.SerialNo = txtReqID.Text;
            bhojnalayModel.ItemName = getSelectedItems().ToString();
            Status = obj.InsertReqToAdmin_MST(bhojnalayModel);
            if (Status != 0)
            {
                List<string> itemNameList = new List<string>(bhojnalayModel.ItemName.Split(','));
                List<int> itemIDs = new List<int>();
                foreach (var item in itemNameList)
                {
                    int ItemID = obj.getItemIdbyItemName(item.Trim());
                    bhojnalayModel.ItemId = ItemID;
                    foreach (DataGridViewRow row in dgvItemDetails.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string itemName = row.Cells["Item Name"].Value.ToString();

                            if (itemName == item)
                            {
                                bhojnalayModel.PRINT_MST_ID = Status;
                               // bhojnalayModel.Price = Convert.ToDecimal(row.Cells["Price"].Value);
                                bhojnalayModel.Quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                                //bhojnalayModel.Amount = Convert.ToDecimal(row.Cells["Amount"].Value);
                                int id = obj.InsertRquToAdmin_DET(bhojnalayModel);
                            }
                        }
                    }
                }
                MessageBox.Show("Record Saved Successully");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearControl();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlMaster_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReqToAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave.PerformClick();
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnNew.PerformClick();
            }
        }
    }
}
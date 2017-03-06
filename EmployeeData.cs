using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class frmEmpData : Form
    {
        DataSet dsEmp = null;
        Int32 intCurrRow = 0;
        public frmEmpData()
        {
            InitializeComponent();
        }

        private void frmEmpData_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            LoadEmployees();
            DisplayEmployeePayroll(Convert.ToInt32(txtEmpID.Text));
        }
        private void frmEmpData_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgResult;
            dlgResult = MessageBox.Show("Confirm Exit", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            if (dlgResult == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void ShowEmployee()
        {
            txtEmpID.Text = dsEmp.Tables[0].Rows[intCurrRow]["EmpID"].ToString();
            txtLName.Text = dsEmp.Tables[0].Rows[intCurrRow]["LName"].ToString();
            txtFName.Text = dsEmp.Tables[0].Rows[intCurrRow]["LName"].ToString();
            if (dsEmp.Tables[0].Rows[intCurrRow]["Minit"] == DBNull.Value)
            {
                txtMInit.Text = "";
            }
            else
            {
                txtMInit.Text = dsEmp.Tables[0].Rows[intCurrRow]["Minit"].ToString();
            }
        }
        private void Reset()
        {
            txtEmpID.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtMInit.Text = "";
        }

        private void DisableNav()
        {
            btnFirst.Enabled = false;
            btnNext.Enabled = false;
            btnPrev.Enabled = false;
            btnLast.Enabled = false;
        }

        private void EnableNav()
        {
            btnFirst.Enabled = true;
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            btnLast.Enabled = true;
        }

        private void LoadEmployees()
        {
            lblError.Text = "";

            /* Remove any existing dataset */
            if (dsEmp != null)
            {
                dsEmp.Dispose();
            }

            /* Initialize current row indicator */
            intCurrRow = 0;

            /* Disable navigation */
            DisableNav();

            dsEmp = clsDataBase.GetEmployees();
            if (dsEmp == null)
            {
                lblError.Text = "Error retrieving employee data";
            }
            else if (dsEmp.Tables.Count < 1)
            {
                lblError.Text = "Error retrieving employee data";
                dsEmp.Dispose();
                dsEmp = null;
            }
            else if (dsEmp.Tables[0].Rows.Count < 1)
            {
                lblError.Text = "No employee data";
                Reset();
                dsEmp.Dispose();
                dsEmp = null;
            }
            else
            {
                EnableNav();
                ShowEmployee();
            }
        }


        private void DisplayEmployeePayroll(Int32 intEmpID)
        {
            DataSet dsData;
            Decimal decPayRate;

            decPayRate = clsDataBase.GetEmployeePayrate(intEmpID);
            if (decPayRate < 0M)
            {
                lblError.Text = "Unable to retrieve payrate for specified employee";
            }

            dsData = clsDataBase.GetEmployeePayroll(intEmpID);
            if (dsData == null)
            {
                lblError.Text = "Error retrieving payroll info";
            }
            else if (dsData.Tables.Count < 1)
            {
                lblError.Text = "Error retrieving payroll info";
                dsData.Dispose();
            }
            else
            {
                dgvPayInfo.DataSource = dsData.Tables[0];
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            intCurrRow = 0;
            ShowEmployee();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            intCurrRow = dsEmp.Tables[0].Rows.Count - 1;
            ShowEmployee();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            intCurrRow -= 1;
            if (intCurrRow < 0)
            {
                intCurrRow = dsEmp.Tables[0].Rows.Count - 1;
            }
            else
            {
                ShowEmployee();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            intCurrRow += 1;
            if (intCurrRow >= dsEmp.Tables[0].Rows.Count)
            {
                intCurrRow = 0;
            }
            else
            {
                ShowEmployee();
            }
        }
    }
}

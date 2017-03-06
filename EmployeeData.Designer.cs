namespace Project2
{
    partial class frmEmpData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmpData = new System.Windows.Forms.Label();
            this.dgvPayInfo = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.grpEmpInfo = new System.Windows.Forms.GroupBox();
            this.grpPayroll = new System.Windows.Forms.GroupBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtMInit = new System.Windows.Forms.TextBox();
            this.txtSSAN = new System.Windows.Forms.TextBox();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblMInit = new System.Windows.Forms.Label();
            this.lblSSAN = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayInfo)).BeginInit();
            this.grpEmpInfo.SuspendLayout();
            this.grpPayroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpData
            // 
            this.lblEmpData.AutoSize = true;
            this.lblEmpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpData.Location = new System.Drawing.Point(304, 13);
            this.lblEmpData.Name = "lblEmpData";
            this.lblEmpData.Size = new System.Drawing.Size(234, 37);
            this.lblEmpData.TabIndex = 0;
            this.lblEmpData.Text = "Employee Data";
            // 
            // dgvPayInfo
            // 
            this.dgvPayInfo.AllowUserToAddRows = false;
            this.dgvPayInfo.AllowUserToDeleteRows = false;
            this.dgvPayInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayInfo.Location = new System.Drawing.Point(16, 45);
            this.dgvPayInfo.Name = "dgvPayInfo";
            this.dgvPayInfo.ReadOnly = true;
            this.dgvPayInfo.RowTemplate.Height = 28;
            this.dgvPayInfo.Size = new System.Drawing.Size(381, 367);
            this.dgvPayInfo.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(124, 418);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 2;
            // 
            // grpEmpInfo
            // 
            this.grpEmpInfo.Controls.Add(this.btnExit);
            this.grpEmpInfo.Controls.Add(this.btnNext);
            this.grpEmpInfo.Controls.Add(this.btnPrev);
            this.grpEmpInfo.Controls.Add(this.btnLast);
            this.grpEmpInfo.Controls.Add(this.btnFirst);
            this.grpEmpInfo.Controls.Add(this.lblPayRate);
            this.grpEmpInfo.Controls.Add(this.lblSSAN);
            this.grpEmpInfo.Controls.Add(this.lblMInit);
            this.grpEmpInfo.Controls.Add(this.lblFName);
            this.grpEmpInfo.Controls.Add(this.lblLName);
            this.grpEmpInfo.Controls.Add(this.lblEmpID);
            this.grpEmpInfo.Controls.Add(this.txtPayRate);
            this.grpEmpInfo.Controls.Add(this.txtSSAN);
            this.grpEmpInfo.Controls.Add(this.txtMInit);
            this.grpEmpInfo.Controls.Add(this.txtFName);
            this.grpEmpInfo.Controls.Add(this.txtLName);
            this.grpEmpInfo.Controls.Add(this.txtEmpID);
            this.grpEmpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmpInfo.Location = new System.Drawing.Point(12, 53);
            this.grpEmpInfo.Name = "grpEmpInfo";
            this.grpEmpInfo.Size = new System.Drawing.Size(397, 454);
            this.grpEmpInfo.TabIndex = 9;
            this.grpEmpInfo.TabStop = false;
            this.grpEmpInfo.Text = "Employee Info";
            // 
            // grpPayroll
            // 
            this.grpPayroll.Controls.Add(this.dgvPayInfo);
            this.grpPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPayroll.Location = new System.Drawing.Point(415, 53);
            this.grpPayroll.Name = "grpPayroll";
            this.grpPayroll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpPayroll.Size = new System.Drawing.Size(415, 448);
            this.grpPayroll.TabIndex = 10;
            this.grpPayroll.TabStop = false;
            this.grpPayroll.Text = "Payroll Info";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(153, 68);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(238, 30);
            this.txtEmpID.TabIndex = 0;
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(153, 121);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(238, 30);
            this.txtLName.TabIndex = 1;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(153, 174);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(238, 30);
            this.txtFName.TabIndex = 2;
            // 
            // txtMInit
            // 
            this.txtMInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMInit.Location = new System.Drawing.Point(153, 227);
            this.txtMInit.Name = "txtMInit";
            this.txtMInit.ReadOnly = true;
            this.txtMInit.Size = new System.Drawing.Size(238, 30);
            this.txtMInit.TabIndex = 3;
            // 
            // txtSSAN
            // 
            this.txtSSAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSAN.Location = new System.Drawing.Point(153, 278);
            this.txtSSAN.Name = "txtSSAN";
            this.txtSSAN.ReadOnly = true;
            this.txtSSAN.Size = new System.Drawing.Size(238, 30);
            this.txtSSAN.TabIndex = 4;
            // 
            // txtPayRate
            // 
            this.txtPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayRate.Location = new System.Drawing.Point(153, 329);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.ReadOnly = true;
            this.txtPayRate.Size = new System.Drawing.Size(238, 30);
            this.txtPayRate.TabIndex = 5;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(6, 68);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(36, 29);
            this.lblEmpID.TabIndex = 6;
            this.lblEmpID.Text = "ID";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(6, 121);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(128, 29);
            this.lblLName.TabIndex = 7;
            this.lblLName.Text = "Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(6, 174);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(131, 29);
            this.lblFName.TabIndex = 8;
            this.lblFName.Text = "First Name";
            // 
            // lblMInit
            // 
            this.lblMInit.AutoSize = true;
            this.lblMInit.Location = new System.Drawing.Point(6, 227);
            this.lblMInit.Name = "lblMInit";
            this.lblMInit.Size = new System.Drawing.Size(124, 29);
            this.lblMInit.TabIndex = 9;
            this.lblMInit.Text = "Middle Init";
            // 
            // lblSSAN
            // 
            this.lblSSAN.AutoSize = true;
            this.lblSSAN.Location = new System.Drawing.Point(6, 278);
            this.lblSSAN.Name = "lblSSAN";
            this.lblSSAN.Size = new System.Drawing.Size(78, 29);
            this.lblSSAN.TabIndex = 10;
            this.lblSSAN.Text = "SSAN";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(6, 329);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(109, 29);
            this.lblPayRate.TabIndex = 11;
            this.lblPayRate.Text = "Pay Rate";
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(11, 374);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(73, 38);
            this.btnFirst.TabIndex = 12;
            this.btnFirst.Text = "FIRST";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(116, 374);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(73, 38);
            this.btnLast.TabIndex = 13;
            this.btnLast.Text = "LAST";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(209, 374);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(73, 38);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = "PREV";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(308, 374);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(73, 38);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(164, 418);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 36);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEmpData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 513);
            this.Controls.Add(this.grpPayroll);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblEmpData);
            this.Controls.Add(this.grpEmpInfo);
            this.Name = "frmEmpData";
            this.Text = "Employee Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmpData_FormClosing);
            this.Load += new System.EventHandler(this.frmEmpData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayInfo)).EndInit();
            this.grpEmpInfo.ResumeLayout(false);
            this.grpEmpInfo.PerformLayout();
            this.grpPayroll.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpData;
        private System.Windows.Forms.DataGridView dgvPayInfo;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox grpEmpInfo;
        private System.Windows.Forms.GroupBox grpPayroll;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblSSAN;
        private System.Windows.Forms.Label lblMInit;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.TextBox txtSSAN;
        private System.Windows.Forms.TextBox txtMInit;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
    }
}
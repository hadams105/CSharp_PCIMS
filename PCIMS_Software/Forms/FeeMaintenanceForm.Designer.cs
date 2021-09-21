namespace PCIMS_Software.Forms
{
    partial class FeeMaintenanceForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.feemaintenance_testdesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.feemaintenance_fee_nud = new System.Windows.Forms.NumericUpDown();
            this.feemaintenance_astm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.feemaintenance_addedit_btn = new System.Windows.Forms.Button();
            this.feemaintenance_clear_btn = new System.Windows.Forms.Button();
            this.feemaintenance_datagridview = new System.Windows.Forms.DataGridView();
            this.testID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.astm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeMaintenance_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feemaintenance_delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.feemaintenance_fee_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feemaintenance_datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeeMaintenance_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Description";
            // 
            // feemaintenance_testdesc
            // 
            this.feemaintenance_testdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.feemaintenance_testdesc.Location = new System.Drawing.Point(158, 235);
            this.feemaintenance_testdesc.Name = "feemaintenance_testdesc";
            this.feemaintenance_testdesc.Size = new System.Drawing.Size(404, 24);
            this.feemaintenance_testdesc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(112, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fee";
            // 
            // feemaintenance_fee_nud
            // 
            this.feemaintenance_fee_nud.DecimalPlaces = 2;
            this.feemaintenance_fee_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.feemaintenance_fee_nud.Location = new System.Drawing.Point(158, 295);
            this.feemaintenance_fee_nud.Name = "feemaintenance_fee_nud";
            this.feemaintenance_fee_nud.Size = new System.Drawing.Size(120, 24);
            this.feemaintenance_fee_nud.TabIndex = 3;
            // 
            // feemaintenance_astm
            // 
            this.feemaintenance_astm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.feemaintenance_astm.Location = new System.Drawing.Point(158, 265);
            this.feemaintenance_astm.Name = "feemaintenance_astm";
            this.feemaintenance_astm.Size = new System.Drawing.Size(404, 24);
            this.feemaintenance_astm.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(95, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ASTM";
            // 
            // feemaintenance_addedit_btn
            // 
            this.feemaintenance_addedit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.feemaintenance_addedit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.feemaintenance_addedit_btn.Location = new System.Drawing.Point(289, 293);
            this.feemaintenance_addedit_btn.Name = "feemaintenance_addedit_btn";
            this.feemaintenance_addedit_btn.Size = new System.Drawing.Size(87, 26);
            this.feemaintenance_addedit_btn.TabIndex = 4;
            this.feemaintenance_addedit_btn.Text = "Add";
            this.feemaintenance_addedit_btn.UseVisualStyleBackColor = true;
            this.feemaintenance_addedit_btn.Click += new System.EventHandler(this.feemaintenance_addedit_btn_Click);
            // 
            // feemaintenance_clear_btn
            // 
            this.feemaintenance_clear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.feemaintenance_clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.feemaintenance_clear_btn.Location = new System.Drawing.Point(475, 293);
            this.feemaintenance_clear_btn.Name = "feemaintenance_clear_btn";
            this.feemaintenance_clear_btn.Size = new System.Drawing.Size(87, 26);
            this.feemaintenance_clear_btn.TabIndex = 6;
            this.feemaintenance_clear_btn.Text = "Clear";
            this.feemaintenance_clear_btn.UseVisualStyleBackColor = true;
            this.feemaintenance_clear_btn.Click += new System.EventHandler(this.feemaintenance_clear_btn_Click);
            // 
            // feemaintenance_datagridview
            // 
            this.feemaintenance_datagridview.AllowUserToAddRows = false;
            this.feemaintenance_datagridview.AllowUserToDeleteRows = false;
            this.feemaintenance_datagridview.AutoGenerateColumns = false;
            this.feemaintenance_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.feemaintenance_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feemaintenance_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testID,
            this.testDesc,
            this.fee,
            this.astm});
            this.feemaintenance_datagridview.DataSource = this.FeeMaintenance_BindingSource;
            this.feemaintenance_datagridview.Location = new System.Drawing.Point(12, 12);
            this.feemaintenance_datagridview.Name = "feemaintenance_datagridview";
            this.feemaintenance_datagridview.ReadOnly = true;
            this.feemaintenance_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.feemaintenance_datagridview.Size = new System.Drawing.Size(550, 217);
            this.feemaintenance_datagridview.TabIndex = 167;
            this.feemaintenance_datagridview.SelectionChanged += new System.EventHandler(this.feemaintenance_datagridview_SelectionChanged);
            // 
            // testID
            // 
            this.testID.DataPropertyName = "TestID";
            this.testID.FillWeight = 1F;
            this.testID.HeaderText = "TestID";
            this.testID.Name = "testID";
            this.testID.ReadOnly = true;
            this.testID.Visible = false;
            // 
            // testDesc
            // 
            this.testDesc.DataPropertyName = "TestDesc";
            this.testDesc.FillWeight = 350F;
            this.testDesc.HeaderText = "Test Description";
            this.testDesc.MinimumWidth = 350;
            this.testDesc.Name = "testDesc";
            this.testDesc.ReadOnly = true;
            // 
            // fee
            // 
            this.fee.DataPropertyName = "Fee";
            this.fee.FillWeight = 75F;
            this.fee.HeaderText = "Fee";
            this.fee.MinimumWidth = 75;
            this.fee.Name = "fee";
            this.fee.ReadOnly = true;
            // 
            // astm
            // 
            this.astm.DataPropertyName = "ASTM";
            this.astm.FillWeight = 75F;
            this.astm.HeaderText = "ASTM";
            this.astm.MinimumWidth = 75;
            this.astm.Name = "astm";
            this.astm.ReadOnly = true;
            // 
            // FeeMaintenance_BindingSource
            // 
            this.FeeMaintenance_BindingSource.DataSource = typeof(PCIMS_Software.SqlObjects.labfee);
            // 
            // feemaintenance_delete_btn
            // 
            this.feemaintenance_delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.feemaintenance_delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.feemaintenance_delete_btn.Location = new System.Drawing.Point(382, 293);
            this.feemaintenance_delete_btn.Name = "feemaintenance_delete_btn";
            this.feemaintenance_delete_btn.Size = new System.Drawing.Size(87, 26);
            this.feemaintenance_delete_btn.TabIndex = 5;
            this.feemaintenance_delete_btn.Text = "Delete";
            this.feemaintenance_delete_btn.UseVisualStyleBackColor = true;
            this.feemaintenance_delete_btn.Click += new System.EventHandler(this.feemaintenance_delete_btn_Click);
            // 
            // Fee_Maintenance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 324);
            this.Controls.Add(this.feemaintenance_delete_btn);
            this.Controls.Add(this.feemaintenance_datagridview);
            this.Controls.Add(this.feemaintenance_clear_btn);
            this.Controls.Add(this.feemaintenance_addedit_btn);
            this.Controls.Add(this.feemaintenance_astm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.feemaintenance_fee_nud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.feemaintenance_testdesc);
            this.Controls.Add(this.label1);
            this.Name = "Fee_Maintenance_Form";
            this.Text = "Fee Maintenance";
            this.Load += new System.EventHandler(this.Fee_Maintenance_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feemaintenance_fee_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feemaintenance_datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeeMaintenance_BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox feemaintenance_testdesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown feemaintenance_fee_nud;
        private System.Windows.Forms.TextBox feemaintenance_astm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button feemaintenance_addedit_btn;
        private System.Windows.Forms.Button feemaintenance_clear_btn;
        private System.Windows.Forms.DataGridView feemaintenance_datagridview;
        private System.Windows.Forms.BindingSource FeeMaintenance_BindingSource;
        private System.Windows.Forms.Button feemaintenance_delete_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testID;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn astm;
    }
}
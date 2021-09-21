namespace PCIMS_Software.ControlTemplates.Invoice
{
	partial class Invoice_UserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.invoice_update_btn = new System.Windows.Forms.Button();
            this.invoice_customerinfo_btn = new System.Windows.Forms.Button();
            this.btnFullBreakdown = new System.Windows.Forms.Button();
            this.invoice_notes = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.invoice_save_btn = new System.Windows.Forms.Button();
            this.invoice_delete_btn = new System.Windows.Forms.Button();
            this.invoice_add_btn = new System.Windows.Forms.Button();
            this.invoice_datagridview = new System.Windows.Forms.DataGridView();
            this.invoice_addnotes_btn = new System.Windows.Forms.Label();
            this.invoice_split = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.invoice_invoicedate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.invoice_number = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.invoice_jobdate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // invoice_update_btn
            // 
            this.invoice_update_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.invoice_update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.invoice_update_btn.Location = new System.Drawing.Point(4921, 2928);
            this.invoice_update_btn.Name = "invoice_update_btn";
            this.invoice_update_btn.Size = new System.Drawing.Size(127, 30);
            this.invoice_update_btn.TabIndex = 110;
            this.invoice_update_btn.Text = "Update";
            this.invoice_update_btn.UseVisualStyleBackColor = true;
            // 
            // invoice_customerinfo_btn
            // 
            this.invoice_customerinfo_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invoice_customerinfo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.invoice_customerinfo_btn.Location = new System.Drawing.Point(4921, 92);
            this.invoice_customerinfo_btn.Name = "invoice_customerinfo_btn";
            this.invoice_customerinfo_btn.Size = new System.Drawing.Size(127, 30);
            this.invoice_customerinfo_btn.TabIndex = 109;
            this.invoice_customerinfo_btn.Text = "Customer Info";
            this.invoice_customerinfo_btn.UseVisualStyleBackColor = true;
            // 
            // btnFullBreakdown
            // 
            this.btnFullBreakdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullBreakdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnFullBreakdown.Location = new System.Drawing.Point(4921, 127);
            this.btnFullBreakdown.Name = "btnFullBreakdown";
            this.btnFullBreakdown.Size = new System.Drawing.Size(127, 30);
            this.btnFullBreakdown.TabIndex = 108;
            this.btnFullBreakdown.Text = "Full Breakdown";
            this.btnFullBreakdown.UseVisualStyleBackColor = true;
            // 
            // invoice_notes
            // 
            this.invoice_notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoice_notes.Location = new System.Drawing.Point(10, 2748);
            this.invoice_notes.Name = "invoice_notes";
            this.invoice_notes.Size = new System.Drawing.Size(5037, 174);
            this.invoice_notes.TabIndex = 114;
            this.invoice_notes.Text = "";
            this.invoice_notes.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.invoice_jobdate);
            this.panel1.Controls.Add(this.invoice_save_btn);
            this.panel1.Controls.Add(this.invoice_delete_btn);
            this.panel1.Controls.Add(this.invoice_add_btn);
            this.panel1.Controls.Add(this.invoice_datagridview);
            this.panel1.Controls.Add(this.invoice_addnotes_btn);
            this.panel1.Controls.Add(this.invoice_split);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.invoice_invoicedate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.invoice_number);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 643);
            this.panel1.TabIndex = 115;
            // 
            // invoice_save_btn
            // 
            this.invoice_save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.invoice_save_btn.Enabled = false;
            this.invoice_save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.invoice_save_btn.Location = new System.Drawing.Point(647, 612);
            this.invoice_save_btn.Name = "invoice_save_btn";
            this.invoice_save_btn.Size = new System.Drawing.Size(72, 28);
            this.invoice_save_btn.TabIndex = 131;
            this.invoice_save_btn.Text = "Save";
            this.invoice_save_btn.UseVisualStyleBackColor = true;
            this.invoice_save_btn.Click += new System.EventHandler(this.invoice_save_btn_Click);
            // 
            // invoice_delete_btn
            // 
            this.invoice_delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.invoice_delete_btn.Enabled = false;
            this.invoice_delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.invoice_delete_btn.Location = new System.Drawing.Point(725, 612);
            this.invoice_delete_btn.Name = "invoice_delete_btn";
            this.invoice_delete_btn.Size = new System.Drawing.Size(72, 28);
            this.invoice_delete_btn.TabIndex = 130;
            this.invoice_delete_btn.Text = "Delete";
            this.invoice_delete_btn.UseVisualStyleBackColor = true;
            this.invoice_delete_btn.Click += new System.EventHandler(this.invoice_delete_btn_Click);
            // 
            // invoice_add_btn
            // 
            this.invoice_add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.invoice_add_btn.Enabled = false;
            this.invoice_add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.invoice_add_btn.Location = new System.Drawing.Point(569, 612);
            this.invoice_add_btn.Name = "invoice_add_btn";
            this.invoice_add_btn.Size = new System.Drawing.Size(72, 28);
            this.invoice_add_btn.TabIndex = 129;
            this.invoice_add_btn.Text = "Add";
            this.invoice_add_btn.UseVisualStyleBackColor = true;
            this.invoice_add_btn.Click += new System.EventHandler(this.invoice_add_btn_Click);
            // 
            // invoice_datagridview
            // 
            this.invoice_datagridview.AllowUserToAddRows = false;
            this.invoice_datagridview.AllowUserToDeleteRows = false;
            this.invoice_datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoice_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoice_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoice_datagridview.Location = new System.Drawing.Point(8, 146);
            this.invoice_datagridview.Name = "invoice_datagridview";
            this.invoice_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoice_datagridview.Size = new System.Drawing.Size(789, 460);
            this.invoice_datagridview.TabIndex = 121;
            this.invoice_datagridview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoice_datagridview_CellValueChanged);
            // 
            // invoice_addnotes_btn
            // 
            this.invoice_addnotes_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.invoice_addnotes_btn.AutoSize = true;
            this.invoice_addnotes_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);
            this.invoice_addnotes_btn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.invoice_addnotes_btn.Location = new System.Drawing.Point(4, 612);
            this.invoice_addnotes_btn.Name = "invoice_addnotes_btn";
            this.invoice_addnotes_btn.Size = new System.Drawing.Size(64, 20);
            this.invoice_addnotes_btn.TabIndex = 128;
            this.invoice_addnotes_btn.Text = "+ Notes";
            this.invoice_addnotes_btn.Visible = false;
            // 
            // invoice_split
            // 
            this.invoice_split.AutoSize = true;
            this.invoice_split.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.invoice_split.Location = new System.Drawing.Point(54, 115);
            this.invoice_split.Name = "invoice_split";
            this.invoice_split.Size = new System.Drawing.Size(32, 18);
            this.invoice_split.TabIndex = 127;
            this.invoice_split.Text = "N/A";
            this.invoice_split.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(4, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 126;
            this.label8.Text = "Split:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(3, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 124;
            this.label9.Text = "Job Date:";
            // 
            // invoice_invoicedate
            // 
            this.invoice_invoicedate.Enabled = false;
            this.invoice_invoicedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.invoice_invoicedate.Location = new System.Drawing.Point(111, 57);
            this.invoice_invoicedate.Name = "invoice_invoicedate";
            this.invoice_invoicedate.Size = new System.Drawing.Size(160, 20);
            this.invoice_invoicedate.TabIndex = 123;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(3, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 122;
            this.label10.Text = "Invoice Date:";
            // 
            // invoice_number
            // 
            this.invoice_number.AutoSize = true;
            this.invoice_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.invoice_number.Location = new System.Drawing.Point(103, 19);
            this.invoice_number.Name = "invoice_number";
            this.invoice_number.Size = new System.Drawing.Size(171, 24);
            this.invoice_number.TabIndex = 120;
            this.invoice_number.Text = "Please Open a Job";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 119;
            this.label1.Text = "Invoice #";
            // 
            // invoice_jobdate
            // 
            this.invoice_jobdate.Enabled = false;
            this.invoice_jobdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.invoice_jobdate.Location = new System.Drawing.Point(111, 87);
            this.invoice_jobdate.Name = "invoice_jobdate";
            this.invoice_jobdate.Size = new System.Drawing.Size(160, 20);
            this.invoice_jobdate.TabIndex = 132;
            // 
            // Invoice_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.invoice_notes);
            this.Controls.Add(this.invoice_update_btn);
            this.Controls.Add(this.invoice_customerinfo_btn);
            this.Controls.Add(this.btnFullBreakdown);
            this.Name = "Invoice_UserControl";
            this.Size = new System.Drawing.Size(806, 649);
            this.Load += new System.EventHandler(this.Invoice_UserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoice_datagridview)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button invoice_update_btn;
		private System.Windows.Forms.Button invoice_customerinfo_btn;
		private System.Windows.Forms.Button btnFullBreakdown;
		private System.Windows.Forms.RichTextBox invoice_notes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button invoice_save_btn;
        private System.Windows.Forms.Button invoice_delete_btn;
        private System.Windows.Forms.Button invoice_add_btn;
        private System.Windows.Forms.DataGridView invoice_datagridview;
        private System.Windows.Forms.Label invoice_addnotes_btn;
        private System.Windows.Forms.Label invoice_split;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker invoice_invoicedate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label invoice_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker invoice_jobdate;
    }
}

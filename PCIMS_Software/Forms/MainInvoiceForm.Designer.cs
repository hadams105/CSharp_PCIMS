namespace PCIMS_Software
{
	partial class MainInvoiceForm
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
            this.nav_menu_panel = new System.Windows.Forms.Panel();
            this.nav_menu_inventory_btn = new System.Windows.Forms.Button();
            this.nav_menu_splits_btn = new System.Windows.Forms.Button();
            this.nav_menu_labspecs_btn = new System.Windows.Forms.Button();
            this.nav_menu_labrpts_btn = new System.Windows.Forms.Button();
            this.nav_menu_invoice = new System.Windows.Forms.Button();
            this.nav_menu_labwkshts_btn = new System.Windows.Forms.Button();
            this.nav_menu_assigntests_btn = new System.Windows.Forms.Button();
            this.nav_menu_labtemps_btn = new System.Windows.Forms.Button();
            this.nav_menu_clientmaintenance_btn = new System.Windows.Forms.Button();
            this.nav_menu_addedit_btn = new System.Windows.Forms.Button();
            this.nav_menu_openclose_btn = new System.Windows.Forms.Button();
            this.nav_menu_companyname = new System.Windows.Forms.Label();
            this.nav_menu_job_panel = new System.Windows.Forms.Panel();
            this.nav_menu_location = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nav_menu_terminal = new System.Windows.Forms.Label();
            this.nav_menu_orderdate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nav_menu_jobtype = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nav_menu_jobnumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invoice_panel = new System.Windows.Forms.Panel();
            this.Invoice_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nav_menu_pricemaintenance_btn = new System.Windows.Forms.Button();
            this.nav_menu_panel.SuspendLayout();
            this.nav_menu_job_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nav_menu_panel
            // 
            this.nav_menu_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nav_menu_panel.AutoScroll = true;
            this.nav_menu_panel.BackColor = System.Drawing.SystemColors.Control;
            this.nav_menu_panel.Controls.Add(this.nav_menu_inventory_btn);
            this.nav_menu_panel.Controls.Add(this.nav_menu_splits_btn);
            this.nav_menu_panel.Controls.Add(this.nav_menu_labspecs_btn);
            this.nav_menu_panel.Controls.Add(this.nav_menu_labrpts_btn);
            this.nav_menu_panel.Controls.Add(this.nav_menu_invoice);
            this.nav_menu_panel.Controls.Add(this.nav_menu_labwkshts_btn);
            this.nav_menu_panel.Controls.Add(this.nav_menu_assigntests_btn);
            this.nav_menu_panel.Controls.Add(this.nav_menu_labtemps_btn);
            this.nav_menu_panel.Controls.Add(this.nav_menu_clientmaintenance_btn);
            this.nav_menu_panel.Controls.Add(this.nav_menu_addedit_btn);
            this.nav_menu_panel.Controls.Add(this.nav_menu_openclose_btn);
            this.nav_menu_panel.Controls.Add(this.nav_menu_companyname);
            this.nav_menu_panel.Controls.Add(this.nav_menu_job_panel);
            this.nav_menu_panel.Location = new System.Drawing.Point(10, 10);
            this.nav_menu_panel.Margin = new System.Windows.Forms.Padding(2);
            this.nav_menu_panel.Name = "nav_menu_panel";
            this.nav_menu_panel.Size = new System.Drawing.Size(227, 649);
            this.nav_menu_panel.TabIndex = 0;
            // 
            // nav_menu_inventory_btn
            // 
            this.nav_menu_inventory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nav_menu_inventory_btn.Location = new System.Drawing.Point(17, 604);
            this.nav_menu_inventory_btn.Name = "nav_menu_inventory_btn";
            this.nav_menu_inventory_btn.Size = new System.Drawing.Size(181, 28);
            this.nav_menu_inventory_btn.TabIndex = 11;
            this.nav_menu_inventory_btn.Text = "Inventory";
            this.nav_menu_inventory_btn.UseVisualStyleBackColor = true;
            this.nav_menu_inventory_btn.Visible = false;
            // 
            // nav_menu_splits_btn
            // 
            this.nav_menu_splits_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nav_menu_splits_btn.Location = new System.Drawing.Point(17, 638);
            this.nav_menu_splits_btn.Name = "nav_menu_splits_btn";
            this.nav_menu_splits_btn.Size = new System.Drawing.Size(181, 28);
            this.nav_menu_splits_btn.TabIndex = 12;
            this.nav_menu_splits_btn.Text = "Split Payments";
            this.nav_menu_splits_btn.UseVisualStyleBackColor = true;
            this.nav_menu_splits_btn.Visible = false;
            // 
            // nav_menu_labspecs_btn
            // 
            this.nav_menu_labspecs_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nav_menu_labspecs_btn.Location = new System.Drawing.Point(17, 468);
            this.nav_menu_labspecs_btn.Name = "nav_menu_labspecs_btn";
            this.nav_menu_labspecs_btn.Size = new System.Drawing.Size(181, 28);
            this.nav_menu_labspecs_btn.TabIndex = 14;
            this.nav_menu_labspecs_btn.Text = "Assign Specs";
            this.nav_menu_labspecs_btn.UseVisualStyleBackColor = true;
            this.nav_menu_labspecs_btn.Click += new System.EventHandler(this.nav_menu_labspecs_btn_Click);
            // 
            // nav_menu_labrpts_btn
            // 
            this.nav_menu_labrpts_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nav_menu_labrpts_btn.Location = new System.Drawing.Point(17, 536);
            this.nav_menu_labrpts_btn.Name = "nav_menu_labrpts_btn";
            this.nav_menu_labrpts_btn.Size = new System.Drawing.Size(181, 28);
            this.nav_menu_labrpts_btn.TabIndex = 9;
            this.nav_menu_labrpts_btn.Text = "Laboratory Report";
            this.nav_menu_labrpts_btn.UseVisualStyleBackColor = true;
            this.nav_menu_labrpts_btn.Click += new System.EventHandler(this.nav_menu_labrpts_btn_Click);
            // 
            // nav_menu_invoice
            // 
            this.nav_menu_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nav_menu_invoice.Location = new System.Drawing.Point(17, 570);
            this.nav_menu_invoice.Name = "nav_menu_invoice";
            this.nav_menu_invoice.Size = new System.Drawing.Size(181, 28);
            this.nav_menu_invoice.TabIndex = 13;
            this.nav_menu_invoice.Text = "Invoice Summary";
            this.nav_menu_invoice.UseVisualStyleBackColor = true;
            this.nav_menu_invoice.Click += new System.EventHandler(this.nav_menu_invoice_Click);
            // 
            // nav_menu_labwkshts_btn
            // 
            this.nav_menu_labwkshts_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nav_menu_labwkshts_btn.Location = new System.Drawing.Point(17, 502);
            this.nav_menu_labwkshts_btn.Name = "nav_menu_labwkshts_btn";
            this.nav_menu_labwkshts_btn.Size = new System.Drawing.Size(181, 28);
            this.nav_menu_labwkshts_btn.TabIndex = 10;
            this.nav_menu_labwkshts_btn.Text = "Laboratory Worksheets";
            this.nav_menu_labwkshts_btn.UseVisualStyleBackColor = true;
            this.nav_menu_labwkshts_btn.Click += new System.EventHandler(this.nav_menu_labwkshts_btn_Click);
            // 
            // nav_menu_assigntests_btn
            // 
            this.nav_menu_assigntests_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nav_menu_assigntests_btn.Location = new System.Drawing.Point(17, 434);
            this.nav_menu_assigntests_btn.Name = "nav_menu_assigntests_btn";
            this.nav_menu_assigntests_btn.Size = new System.Drawing.Size(181, 28);
            this.nav_menu_assigntests_btn.TabIndex = 8;
            this.nav_menu_assigntests_btn.Text = "Assign Templates";
            this.nav_menu_assigntests_btn.UseVisualStyleBackColor = true;
            this.nav_menu_assigntests_btn.Click += new System.EventHandler(this.nav_menu_assigntests_btn_Click);
            // 
            // nav_menu_labtemps_btn
            // 
            this.nav_menu_labtemps_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nav_menu_labtemps_btn.Location = new System.Drawing.Point(17, 359);
            this.nav_menu_labtemps_btn.Name = "nav_menu_labtemps_btn";
            this.nav_menu_labtemps_btn.Size = new System.Drawing.Size(181, 28);
            this.nav_menu_labtemps_btn.TabIndex = 7;
            this.nav_menu_labtemps_btn.Text = "Laboratory Templates";
            this.nav_menu_labtemps_btn.UseVisualStyleBackColor = true;
            this.nav_menu_labtemps_btn.Click += new System.EventHandler(this.nav_menu_labtemps_btn_Click);
            // 
            // nav_menu_clientmaintenance_btn
            // 
            this.nav_menu_clientmaintenance_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nav_menu_clientmaintenance_btn.Location = new System.Drawing.Point(17, 325);
            this.nav_menu_clientmaintenance_btn.Name = "nav_menu_clientmaintenance_btn";
            this.nav_menu_clientmaintenance_btn.Size = new System.Drawing.Size(181, 28);
            this.nav_menu_clientmaintenance_btn.TabIndex = 6;
            this.nav_menu_clientmaintenance_btn.Text = "Client Maintenance";
            this.nav_menu_clientmaintenance_btn.UseVisualStyleBackColor = true;
            this.nav_menu_clientmaintenance_btn.Click += new System.EventHandler(this.nav_menu_clientmaintenance_btn_Click);
            // 
            // nav_menu_addedit_btn
            // 
            this.nav_menu_addedit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nav_menu_addedit_btn.Location = new System.Drawing.Point(17, 291);
            this.nav_menu_addedit_btn.Name = "nav_menu_addedit_btn";
            this.nav_menu_addedit_btn.Size = new System.Drawing.Size(181, 28);
            this.nav_menu_addedit_btn.TabIndex = 5;
            this.nav_menu_addedit_btn.Text = "Add Job";
            this.nav_menu_addedit_btn.UseVisualStyleBackColor = true;
            this.nav_menu_addedit_btn.Click += new System.EventHandler(this.nav_menu_addeditjob_btn_Click);
            // 
            // nav_menu_openclose_btn
            // 
            this.nav_menu_openclose_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nav_menu_openclose_btn.Location = new System.Drawing.Point(17, 257);
            this.nav_menu_openclose_btn.Name = "nav_menu_openclose_btn";
            this.nav_menu_openclose_btn.Size = new System.Drawing.Size(181, 28);
            this.nav_menu_openclose_btn.TabIndex = 4;
            this.nav_menu_openclose_btn.Text = "Open Job";
            this.nav_menu_openclose_btn.UseVisualStyleBackColor = true;
            this.nav_menu_openclose_btn.Click += new System.EventHandler(this.nav_menu_openclose_btn_Click);
            // 
            // nav_menu_companyname
            // 
            this.nav_menu_companyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.nav_menu_companyname.Location = new System.Drawing.Point(5, 5);
            this.nav_menu_companyname.Name = "nav_menu_companyname";
            this.nav_menu_companyname.Size = new System.Drawing.Size(206, 60);
            this.nav_menu_companyname.TabIndex = 2;
            this.nav_menu_companyname.Text = "Nobil Petroleum Testing";
            this.nav_menu_companyname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nav_menu_job_panel
            // 
            this.nav_menu_job_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nav_menu_job_panel.Controls.Add(this.nav_menu_pricemaintenance_btn);
            this.nav_menu_job_panel.Controls.Add(this.nav_menu_location);
            this.nav_menu_job_panel.Controls.Add(this.label7);
            this.nav_menu_job_panel.Controls.Add(this.nav_menu_terminal);
            this.nav_menu_job_panel.Controls.Add(this.nav_menu_orderdate);
            this.nav_menu_job_panel.Controls.Add(this.label6);
            this.nav_menu_job_panel.Controls.Add(this.label5);
            this.nav_menu_job_panel.Controls.Add(this.nav_menu_jobtype);
            this.nav_menu_job_panel.Controls.Add(this.label4);
            this.nav_menu_job_panel.Controls.Add(this.nav_menu_jobnumber);
            this.nav_menu_job_panel.Controls.Add(this.label2);
            this.nav_menu_job_panel.Location = new System.Drawing.Point(8, 67);
            this.nav_menu_job_panel.Name = "nav_menu_job_panel";
            this.nav_menu_job_panel.Size = new System.Drawing.Size(200, 361);
            this.nav_menu_job_panel.TabIndex = 3;
            // 
            // nav_menu_location
            // 
            this.nav_menu_location.AutoSize = true;
            this.nav_menu_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_menu_location.Location = new System.Drawing.Point(21, 125);
            this.nav_menu_location.Name = "nav_menu_location";
            this.nav_menu_location.Size = new System.Drawing.Size(44, 17);
            this.nav_menu_location.TabIndex = 7;
            this.nav_menu_location.Text = "NULL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Location";
            // 
            // nav_menu_terminal
            // 
            this.nav_menu_terminal.AutoSize = true;
            this.nav_menu_terminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_menu_terminal.Location = new System.Drawing.Point(21, 160);
            this.nav_menu_terminal.Name = "nav_menu_terminal";
            this.nav_menu_terminal.Size = new System.Drawing.Size(44, 17);
            this.nav_menu_terminal.TabIndex = 5;
            this.nav_menu_terminal.Text = "NULL";
            // 
            // nav_menu_orderdate
            // 
            this.nav_menu_orderdate.AutoSize = true;
            this.nav_menu_orderdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_menu_orderdate.Location = new System.Drawing.Point(21, 90);
            this.nav_menu_orderdate.Name = "nav_menu_orderdate";
            this.nav_menu_orderdate.Size = new System.Drawing.Size(44, 17);
            this.nav_menu_orderdate.TabIndex = 5;
            this.nav_menu_orderdate.Text = "NULL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Terminal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Order Date";
            // 
            // nav_menu_jobtype
            // 
            this.nav_menu_jobtype.AutoSize = true;
            this.nav_menu_jobtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_menu_jobtype.Location = new System.Drawing.Point(21, 55);
            this.nav_menu_jobtype.Name = "nav_menu_jobtype";
            this.nav_menu_jobtype.Size = new System.Drawing.Size(44, 17);
            this.nav_menu_jobtype.TabIndex = 3;
            this.nav_menu_jobtype.Text = "NULL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Job Type";
            // 
            // nav_menu_jobnumber
            // 
            this.nav_menu_jobnumber.AutoSize = true;
            this.nav_menu_jobnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nav_menu_jobnumber.Location = new System.Drawing.Point(21, 20);
            this.nav_menu_jobnumber.Name = "nav_menu_jobnumber";
            this.nav_menu_jobnumber.Size = new System.Drawing.Size(44, 17);
            this.nav_menu_jobnumber.TabIndex = 1;
            this.nav_menu_jobnumber.Text = "NULL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Job Number";
            // 
            // invoice_panel
            // 
            this.invoice_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoice_panel.AutoScroll = true;
            this.invoice_panel.BackColor = System.Drawing.SystemColors.Control;
            this.invoice_panel.Location = new System.Drawing.Point(242, 10);
            this.invoice_panel.Name = "invoice_panel";
            this.invoice_panel.Size = new System.Drawing.Size(806, 649);
            this.invoice_panel.TabIndex = 1;
            // 
            // Invoice_BindingSource
            // 
            this.Invoice_BindingSource.DataSource = typeof(PCIMS_Software.SqlObjects.InvoiceDetail);
            // 
            // nav_menu_pricemaintenance_btn
            // 
            this.nav_menu_pricemaintenance_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nav_menu_pricemaintenance_btn.Location = new System.Drawing.Point(7, 324);
            this.nav_menu_pricemaintenance_btn.Name = "nav_menu_pricemaintenance_btn";
            this.nav_menu_pricemaintenance_btn.Size = new System.Drawing.Size(181, 28);
            this.nav_menu_pricemaintenance_btn.TabIndex = 15;
            this.nav_menu_pricemaintenance_btn.Text = "Price Maintenance";
            this.nav_menu_pricemaintenance_btn.UseVisualStyleBackColor = true;
            this.nav_menu_pricemaintenance_btn.Click += new System.EventHandler(this.nav_menu_pricemaintenance_btn_Click);
            // 
            // MainInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 671);
            this.Controls.Add(this.invoice_panel);
            this.Controls.Add(this.nav_menu_panel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainInvoiceForm";
            this.Load += new System.EventHandler(this.MainInvoiceForm_Load);
            this.nav_menu_panel.ResumeLayout(false);
            this.nav_menu_job_panel.ResumeLayout(false);
            this.nav_menu_job_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Invoice_BindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel nav_menu_panel;
		private System.Windows.Forms.Label nav_menu_companyname;
		private System.Windows.Forms.Panel nav_menu_job_panel;
		private System.Windows.Forms.Label nav_menu_jobnumber;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label nav_menu_location;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label nav_menu_terminal;
		private System.Windows.Forms.Label nav_menu_orderdate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label nav_menu_jobtype;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button nav_menu_splits_btn;
		private System.Windows.Forms.Button nav_menu_inventory_btn;
		private System.Windows.Forms.Button nav_menu_labwkshts_btn;
		private System.Windows.Forms.Button nav_menu_labrpts_btn;
		private System.Windows.Forms.Button nav_menu_assigntests_btn;
		private System.Windows.Forms.Button nav_menu_labtemps_btn;
		private System.Windows.Forms.Button nav_menu_clientmaintenance_btn;
		private System.Windows.Forms.Button nav_menu_addedit_btn;
		private System.Windows.Forms.Button nav_menu_openclose_btn;
		private System.Windows.Forms.Panel invoice_panel;
		private System.Windows.Forms.BindingSource Invoice_BindingSource;
		private System.Windows.Forms.Button nav_menu_invoice;
        private System.Windows.Forms.Button nav_menu_labspecs_btn;
        private System.Windows.Forms.Button nav_menu_pricemaintenance_btn;
    }
}


namespace PCIMS_Software.Forms
{
    partial class PriceMaintenanceForm
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
            this.pricemaintenance_delete_btn = new System.Windows.Forms.Button();
            this.pricemaintenance_datagridview = new System.Windows.Forms.DataGridView();
            this.pricemaintenance_clear_btn = new System.Windows.Forms.Button();
            this.pricemaintenance_addedit_btn = new System.Windows.Forms.Button();
            this.pricemaintenance_mincost_nud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pricemaintenance_servicedesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pricemaintenance_actualcost_nud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pricemaintenance_servicecode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pricemaintenance_datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricemaintenance_mincost_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricemaintenance_actualcost_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // pricemaintenance_delete_btn
            // 
            this.pricemaintenance_delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pricemaintenance_delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pricemaintenance_delete_btn.Location = new System.Drawing.Point(392, 427);
            this.pricemaintenance_delete_btn.Name = "pricemaintenance_delete_btn";
            this.pricemaintenance_delete_btn.Size = new System.Drawing.Size(87, 26);
            this.pricemaintenance_delete_btn.TabIndex = 175;
            this.pricemaintenance_delete_btn.Text = "Delete";
            this.pricemaintenance_delete_btn.UseVisualStyleBackColor = true;
            this.pricemaintenance_delete_btn.Click += new System.EventHandler(this.pricemaintenance_delete_btn_Click);
            // 
            // pricemaintenance_datagridview
            // 
            this.pricemaintenance_datagridview.AllowUserToAddRows = false;
            this.pricemaintenance_datagridview.AllowUserToDeleteRows = false;
            this.pricemaintenance_datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pricemaintenance_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pricemaintenance_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pricemaintenance_datagridview.Location = new System.Drawing.Point(12, 9);
            this.pricemaintenance_datagridview.MultiSelect = false;
            this.pricemaintenance_datagridview.Name = "pricemaintenance_datagridview";
            this.pricemaintenance_datagridview.ReadOnly = true;
            this.pricemaintenance_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pricemaintenance_datagridview.Size = new System.Drawing.Size(560, 324);
            this.pricemaintenance_datagridview.TabIndex = 177;
            this.pricemaintenance_datagridview.SelectionChanged += new System.EventHandler(this.pricemaintenance_datagridview_SelectionChanged);
            // 
            // pricemaintenance_clear_btn
            // 
            this.pricemaintenance_clear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pricemaintenance_clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pricemaintenance_clear_btn.Location = new System.Drawing.Point(485, 427);
            this.pricemaintenance_clear_btn.Name = "pricemaintenance_clear_btn";
            this.pricemaintenance_clear_btn.Size = new System.Drawing.Size(87, 26);
            this.pricemaintenance_clear_btn.TabIndex = 176;
            this.pricemaintenance_clear_btn.Text = "Clear";
            this.pricemaintenance_clear_btn.UseVisualStyleBackColor = true;
            this.pricemaintenance_clear_btn.Click += new System.EventHandler(this.pricemaintenance_clear_btn_Click);
            // 
            // pricemaintenance_addedit_btn
            // 
            this.pricemaintenance_addedit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pricemaintenance_addedit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pricemaintenance_addedit_btn.Location = new System.Drawing.Point(299, 427);
            this.pricemaintenance_addedit_btn.Name = "pricemaintenance_addedit_btn";
            this.pricemaintenance_addedit_btn.Size = new System.Drawing.Size(87, 26);
            this.pricemaintenance_addedit_btn.TabIndex = 173;
            this.pricemaintenance_addedit_btn.Text = "Add";
            this.pricemaintenance_addedit_btn.UseVisualStyleBackColor = true;
            this.pricemaintenance_addedit_btn.Click += new System.EventHandler(this.pricemaintenance_addedit_btn_Click);
            // 
            // pricemaintenance_mincost_nud
            // 
            this.pricemaintenance_mincost_nud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pricemaintenance_mincost_nud.DecimalPlaces = 2;
            this.pricemaintenance_mincost_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pricemaintenance_mincost_nud.Location = new System.Drawing.Point(139, 429);
            this.pricemaintenance_mincost_nud.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.pricemaintenance_mincost_nud.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pricemaintenance_mincost_nud.Name = "pricemaintenance_mincost_nud";
            this.pricemaintenance_mincost_nud.Size = new System.Drawing.Size(130, 24);
            this.pricemaintenance_mincost_nud.TabIndex = 172;
            this.pricemaintenance_mincost_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 171;
            this.label2.Text = "Minimum Cost";
            // 
            // pricemaintenance_servicedesc
            // 
            this.pricemaintenance_servicedesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pricemaintenance_servicedesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pricemaintenance_servicedesc.Location = new System.Drawing.Point(139, 369);
            this.pricemaintenance_servicedesc.Name = "pricemaintenance_servicedesc";
            this.pricemaintenance_servicedesc.Size = new System.Drawing.Size(433, 24);
            this.pricemaintenance_servicedesc.TabIndex = 169;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(33, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 168;
            this.label1.Text = "Description";
            // 
            // pricemaintenance_actualcost_nud
            // 
            this.pricemaintenance_actualcost_nud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pricemaintenance_actualcost_nud.DecimalPlaces = 2;
            this.pricemaintenance_actualcost_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pricemaintenance_actualcost_nud.Location = new System.Drawing.Point(139, 399);
            this.pricemaintenance_actualcost_nud.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.pricemaintenance_actualcost_nud.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pricemaintenance_actualcost_nud.Name = "pricemaintenance_actualcost_nud";
            this.pricemaintenance_actualcost_nud.Size = new System.Drawing.Size(130, 24);
            this.pricemaintenance_actualcost_nud.TabIndex = 179;
            this.pricemaintenance_actualcost_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 178;
            this.label3.Text = "Actual Cost";
            // 
            // pricemaintenance_servicecode
            // 
            this.pricemaintenance_servicecode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pricemaintenance_servicecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pricemaintenance_servicecode.Location = new System.Drawing.Point(139, 339);
            this.pricemaintenance_servicecode.MaxLength = 4;
            this.pricemaintenance_servicecode.Name = "pricemaintenance_servicecode";
            this.pricemaintenance_servicecode.Size = new System.Drawing.Size(433, 24);
            this.pricemaintenance_servicecode.TabIndex = 181;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(18, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 180;
            this.label4.Text = "Service Code";
            // 
            // PriceMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.pricemaintenance_servicecode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pricemaintenance_actualcost_nud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pricemaintenance_delete_btn);
            this.Controls.Add(this.pricemaintenance_datagridview);
            this.Controls.Add(this.pricemaintenance_clear_btn);
            this.Controls.Add(this.pricemaintenance_addedit_btn);
            this.Controls.Add(this.pricemaintenance_mincost_nud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pricemaintenance_servicedesc);
            this.Controls.Add(this.label1);
            this.Name = "PriceMaintenanceForm";
            this.Text = "Prices Maintenance";
            this.Load += new System.EventHandler(this.PricesMaintenanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pricemaintenance_datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricemaintenance_mincost_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricemaintenance_actualcost_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pricemaintenance_delete_btn;
        private System.Windows.Forms.DataGridView pricemaintenance_datagridview;
        private System.Windows.Forms.Button pricemaintenance_clear_btn;
        private System.Windows.Forms.Button pricemaintenance_addedit_btn;
        private System.Windows.Forms.NumericUpDown pricemaintenance_mincost_nud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pricemaintenance_servicedesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown pricemaintenance_actualcost_nud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pricemaintenance_servicecode;
        private System.Windows.Forms.Label label4;
    }
}
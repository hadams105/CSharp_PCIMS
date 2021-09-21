namespace PCIMS_Software.Forms
{
    partial class PriceSelectForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.priceselect_datagridview = new System.Windows.Forms.DataGridView();
            this.priceselect_add_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceselect_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.priceselect_add_btn);
            this.panel1.Controls.Add(this.priceselect_datagridview);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 376);
            this.panel1.TabIndex = 0;
            // 
            // priceselect_datagridview
            // 
            this.priceselect_datagridview.AllowUserToAddRows = false;
            this.priceselect_datagridview.AllowUserToDeleteRows = false;
            this.priceselect_datagridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceselect_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.priceselect_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceselect_datagridview.Location = new System.Drawing.Point(3, 3);
            this.priceselect_datagridview.Name = "priceselect_datagridview";
            this.priceselect_datagridview.ReadOnly = true;
            this.priceselect_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.priceselect_datagridview.Size = new System.Drawing.Size(659, 336);
            this.priceselect_datagridview.TabIndex = 179;
            // 
            // priceselect_add_btn
            // 
            this.priceselect_add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.priceselect_add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.priceselect_add_btn.Location = new System.Drawing.Point(565, 345);
            this.priceselect_add_btn.Name = "priceselect_add_btn";
            this.priceselect_add_btn.Size = new System.Drawing.Size(97, 28);
            this.priceselect_add_btn.TabIndex = 180;
            this.priceselect_add_btn.Text = "Add To Job";
            this.priceselect_add_btn.UseVisualStyleBackColor = true;
            this.priceselect_add_btn.Click += new System.EventHandler(this.priceselect_add_btn_Click);
            // 
            // PriceSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 400);
            this.Controls.Add(this.panel1);
            this.Name = "PriceSelectForm";
            this.Text = "PriceSelectForm";
            this.Load += new System.EventHandler(this.PriceSelectForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priceselect_datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView priceselect_datagridview;
        private System.Windows.Forms.Button priceselect_add_btn;
    }
}
namespace PCIMS_Software.ControlTemplates.Lab.LabSpecs
{
    partial class AssignTestSpecs_UserControl
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
            this.labspecs_datagridview = new System.Windows.Forms.DataGridView();
            this.labspecs_save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.labspecs_datagridview)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labspecs_datagridview
            // 
            this.labspecs_datagridview.AllowUserToAddRows = false;
            this.labspecs_datagridview.AllowUserToDeleteRows = false;
            this.labspecs_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.labspecs_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labspecs_datagridview.Location = new System.Drawing.Point(11, 31);
            this.labspecs_datagridview.MultiSelect = false;
            this.labspecs_datagridview.Name = "labspecs_datagridview";
            this.labspecs_datagridview.Size = new System.Drawing.Size(786, 577);
            this.labspecs_datagridview.TabIndex = 172;
            // 
            // labspecs_save_btn
            // 
            this.labspecs_save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labspecs_save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labspecs_save_btn.Location = new System.Drawing.Point(710, 614);
            this.labspecs_save_btn.Name = "labspecs_save_btn";
            this.labspecs_save_btn.Size = new System.Drawing.Size(87, 26);
            this.labspecs_save_btn.TabIndex = 166;
            this.labspecs_save_btn.Text = "Save";
            this.labspecs_save_btn.UseVisualStyleBackColor = true;
            this.labspecs_save_btn.Click += new System.EventHandler(this.labspecs_save_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 159;
            this.label1.Text = "Lab Specifications";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labspecs_datagridview);
            this.panel1.Controls.Add(this.labspecs_save_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 643);
            this.panel1.TabIndex = 1;
            // 
            // AssignTestSpecs_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AssignTestSpecs_UserControl";
            this.Size = new System.Drawing.Size(806, 649);
            this.Load += new System.EventHandler(this.FillTestSpecs_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labspecs_datagridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView labspecs_datagridview;
        private System.Windows.Forms.Button labspecs_save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

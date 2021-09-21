namespace PCIMS_Software.ControlTemplates.Lab.Worksheet
{
    partial class LabWorksheet_UserControl
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
            this.labreports_panel = new System.Windows.Forms.Panel();
            this.labworksheet_changeworksheetbtn = new System.Windows.Forms.Button();
            this.labworksheet_currentworksheet = new System.Windows.Forms.TextBox();
            this.labworksheet_clearinput_btn = new System.Windows.Forms.Button();
            this.labworksheet_current_template = new System.Windows.Forms.Label();
            this.labworksheet_loadtemplate_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.labworksheet_worksheettotalnbr = new System.Windows.Forms.Label();
            this.lapworksheet_labNbr = new System.Windows.Forms.Label();
            this.labworksheet_save_btn = new System.Windows.Forms.Button();
            this.labworksheet_clearall_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labworksheet_datagridview = new System.Windows.Forms.DataGridView();
            this.labreports_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labworksheet_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // labreports_panel
            // 
            this.labreports_panel.Controls.Add(this.labworksheet_changeworksheetbtn);
            this.labreports_panel.Controls.Add(this.labworksheet_currentworksheet);
            this.labreports_panel.Controls.Add(this.labworksheet_clearinput_btn);
            this.labreports_panel.Controls.Add(this.labworksheet_current_template);
            this.labreports_panel.Controls.Add(this.labworksheet_loadtemplate_panel);
            this.labreports_panel.Controls.Add(this.labworksheet_worksheettotalnbr);
            this.labreports_panel.Controls.Add(this.lapworksheet_labNbr);
            this.labreports_panel.Controls.Add(this.labworksheet_save_btn);
            this.labreports_panel.Controls.Add(this.labworksheet_clearall_btn);
            this.labreports_panel.Controls.Add(this.label4);
            this.labreports_panel.Controls.Add(this.label3);
            this.labreports_panel.Controls.Add(this.label1);
            this.labreports_panel.Controls.Add(this.labworksheet_datagridview);
            this.labreports_panel.Location = new System.Drawing.Point(4, 3);
            this.labreports_panel.Name = "labreports_panel";
            this.labreports_panel.Size = new System.Drawing.Size(799, 642);
            this.labreports_panel.TabIndex = 1;
            // 
            // labworksheet_changeworksheetbtn
            // 
            this.labworksheet_changeworksheetbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labworksheet_changeworksheetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labworksheet_changeworksheetbtn.Location = new System.Drawing.Point(246, 76);
            this.labworksheet_changeworksheetbtn.Name = "labworksheet_changeworksheetbtn";
            this.labworksheet_changeworksheetbtn.Size = new System.Drawing.Size(76, 25);
            this.labworksheet_changeworksheetbtn.TabIndex = 196;
            this.labworksheet_changeworksheetbtn.Text = "Change";
            this.labworksheet_changeworksheetbtn.UseVisualStyleBackColor = true;
            this.labworksheet_changeworksheetbtn.Click += new System.EventHandler(this.labworksheet_changeworksheetbtn_Click);
            // 
            // labworksheet_currentworksheet
            // 
            this.labworksheet_currentworksheet.Location = new System.Drawing.Point(162, 78);
            this.labworksheet_currentworksheet.Name = "labworksheet_currentworksheet";
            this.labworksheet_currentworksheet.Size = new System.Drawing.Size(38, 20);
            this.labworksheet_currentworksheet.TabIndex = 195;
            // 
            // labworksheet_clearinput_btn
            // 
            this.labworksheet_clearinput_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labworksheet_clearinput_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labworksheet_clearinput_btn.Location = new System.Drawing.Point(657, 583);
            this.labworksheet_clearinput_btn.Name = "labworksheet_clearinput_btn";
            this.labworksheet_clearinput_btn.Size = new System.Drawing.Size(124, 25);
            this.labworksheet_clearinput_btn.TabIndex = 194;
            this.labworksheet_clearinput_btn.Text = "Clear Input";
            this.labworksheet_clearinput_btn.UseVisualStyleBackColor = true;
            this.labworksheet_clearinput_btn.Visible = false;
            this.labworksheet_clearinput_btn.Click += new System.EventHandler(this.labworksheet_clearinput_btn_Click);
            // 
            // labworksheet_current_template
            // 
            this.labworksheet_current_template.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labworksheet_current_template.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labworksheet_current_template.Location = new System.Drawing.Point(285, 84);
            this.labworksheet_current_template.Name = "labworksheet_current_template";
            this.labworksheet_current_template.Size = new System.Drawing.Size(496, 20);
            this.labworksheet_current_template.TabIndex = 186;
            this.labworksheet_current_template.Text = "Please Load a Template";
            this.labworksheet_current_template.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labworksheet_loadtemplate_panel
            // 
            this.labworksheet_loadtemplate_panel.BackColor = System.Drawing.SystemColors.Control;
            this.labworksheet_loadtemplate_panel.Location = new System.Drawing.Point(7, 551);
            this.labworksheet_loadtemplate_panel.Name = "labworksheet_loadtemplate_panel";
            this.labworksheet_loadtemplate_panel.Size = new System.Drawing.Size(643, 88);
            this.labworksheet_loadtemplate_panel.TabIndex = 185;
            // 
            // labworksheet_worksheettotalnbr
            // 
            this.labworksheet_worksheettotalnbr.AutoSize = true;
            this.labworksheet_worksheettotalnbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labworksheet_worksheettotalnbr.Location = new System.Drawing.Point(200, 78);
            this.labworksheet_worksheettotalnbr.Name = "labworksheet_worksheettotalnbr";
            this.labworksheet_worksheettotalnbr.Size = new System.Drawing.Size(36, 20);
            this.labworksheet_worksheettotalnbr.TabIndex = 184;
            this.labworksheet_worksheettotalnbr.Text = "001";
            // 
            // lapworksheet_labNbr
            // 
            this.lapworksheet_labNbr.AutoSize = true;
            this.lapworksheet_labNbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lapworksheet_labNbr.Location = new System.Drawing.Point(158, 51);
            this.lapworksheet_labNbr.Name = "lapworksheet_labNbr";
            this.lapworksheet_labNbr.Size = new System.Drawing.Size(36, 20);
            this.lapworksheet_labNbr.TabIndex = 183;
            this.lapworksheet_labNbr.Text = "840";
            // 
            // labworksheet_save_btn
            // 
            this.labworksheet_save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labworksheet_save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labworksheet_save_btn.Location = new System.Drawing.Point(657, 551);
            this.labworksheet_save_btn.Name = "labworksheet_save_btn";
            this.labworksheet_save_btn.Size = new System.Drawing.Size(125, 25);
            this.labworksheet_save_btn.TabIndex = 182;
            this.labworksheet_save_btn.Text = "Save";
            this.labworksheet_save_btn.UseVisualStyleBackColor = true;
            this.labworksheet_save_btn.Click += new System.EventHandler(this.labworksheet_save_btn_Click);
            // 
            // labworksheet_clearall_btn
            // 
            this.labworksheet_clearall_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labworksheet_clearall_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labworksheet_clearall_btn.Location = new System.Drawing.Point(657, 614);
            this.labworksheet_clearall_btn.Name = "labworksheet_clearall_btn";
            this.labworksheet_clearall_btn.Size = new System.Drawing.Size(124, 25);
            this.labworksheet_clearall_btn.TabIndex = 181;
            this.labworksheet_clearall_btn.Text = "Clear All";
            this.labworksheet_clearall_btn.UseVisualStyleBackColor = true;
            this.labworksheet_clearall_btn.Visible = false;
            this.labworksheet_clearall_btn.Click += new System.EventHandler(this.labworksheet_clearall_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 167;
            this.label4.Text = "Worksheet Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(53, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 166;
            this.label3.Text = "Lab Number";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 163;
            this.label1.Text = "Laboratory Worksheet";
            // 
            // labworksheet_datagridview
            // 
            this.labworksheet_datagridview.AllowUserToAddRows = false;
            this.labworksheet_datagridview.AllowUserToDeleteRows = false;
            this.labworksheet_datagridview.AllowUserToResizeRows = false;
            this.labworksheet_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.labworksheet_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labworksheet_datagridview.Location = new System.Drawing.Point(7, 107);
            this.labworksheet_datagridview.MultiSelect = false;
            this.labworksheet_datagridview.Name = "labworksheet_datagridview";
            this.labworksheet_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.labworksheet_datagridview.Size = new System.Drawing.Size(774, 438);
            this.labworksheet_datagridview.TabIndex = 162;
            this.labworksheet_datagridview.Click += new System.EventHandler(this.labworksheet_datagridview_Click);
            // 
            // LabWorksheet_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labreports_panel);
            this.Name = "LabWorksheet_UserControl";
            this.Size = new System.Drawing.Size(806, 649);
            this.Load += new System.EventHandler(this.LabWorksheet_UserControl_Load);
            this.labreports_panel.ResumeLayout(false);
            this.labreports_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labworksheet_datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel labreports_panel;
        private System.Windows.Forms.Button labworksheet_save_btn;
        private System.Windows.Forms.Button labworksheet_clearall_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView labworksheet_datagridview;
        private System.Windows.Forms.Label lapworksheet_labNbr;
        private System.Windows.Forms.FlowLayoutPanel labworksheet_loadtemplate_panel;
        private System.Windows.Forms.Label labworksheet_current_template;
        private System.Windows.Forms.Button labworksheet_clearinput_btn;
        private System.Windows.Forms.TextBox labworksheet_currentworksheet;
        private System.Windows.Forms.Label labworksheet_worksheettotalnbr;
        private System.Windows.Forms.Button labworksheet_changeworksheetbtn;
    }
}

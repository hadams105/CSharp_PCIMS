namespace PCIMS_Software.ControlTemplates.Lab
{
    partial class LabTemplateSelect_UserControl
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labtemplateselect_edit_btn = new System.Windows.Forms.Button();
            this.labfees_feemaintenance_btn = new System.Windows.Forms.Button();
            this.labtemplateselect_delete_btn = new System.Windows.Forms.Button();
            this.labtemplateselect_newselect_btn = new System.Windows.Forms.Button();
            this.labtemplateselect_datagridview = new System.Windows.Forms.DataGridView();
            this.templateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.re = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabTemplateSelect_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labtemplateselect_datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabTemplateSelect_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labtemplateselect_edit_btn);
            this.panel1.Controls.Add(this.labfees_feemaintenance_btn);
            this.panel1.Controls.Add(this.labtemplateselect_delete_btn);
            this.panel1.Controls.Add(this.labtemplateselect_newselect_btn);
            this.panel1.Controls.Add(this.labtemplateselect_datagridview);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 643);
            this.panel1.TabIndex = 0;
            // 
            // labtemplateselect_edit_btn
            // 
            this.labtemplateselect_edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labtemplateselect_edit_btn.Enabled = false;
            this.labtemplateselect_edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labtemplateselect_edit_btn.Location = new System.Drawing.Point(436, 53);
            this.labtemplateselect_edit_btn.Name = "labtemplateselect_edit_btn";
            this.labtemplateselect_edit_btn.Size = new System.Drawing.Size(87, 26);
            this.labtemplateselect_edit_btn.TabIndex = 168;
            this.labtemplateselect_edit_btn.Text = "Edit";
            this.labtemplateselect_edit_btn.UseVisualStyleBackColor = true;
            this.labtemplateselect_edit_btn.Click += new System.EventHandler(this.labtemplateselect_edit_btn_Click);
            // 
            // labfees_feemaintenance_btn
            // 
            this.labfees_feemaintenance_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labfees_feemaintenance_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labfees_feemaintenance_btn.Location = new System.Drawing.Point(436, 614);
            this.labfees_feemaintenance_btn.Name = "labfees_feemaintenance_btn";
            this.labfees_feemaintenance_btn.Size = new System.Drawing.Size(143, 26);
            this.labfees_feemaintenance_btn.TabIndex = 167;
            this.labfees_feemaintenance_btn.Text = "Fee Maintenance";
            this.labfees_feemaintenance_btn.UseVisualStyleBackColor = true;
            this.labfees_feemaintenance_btn.Click += new System.EventHandler(this.labfees_feemaintenance_btn_Click);
            // 
            // labtemplateselect_delete_btn
            // 
            this.labtemplateselect_delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labtemplateselect_delete_btn.Enabled = false;
            this.labtemplateselect_delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labtemplateselect_delete_btn.Location = new System.Drawing.Point(436, 85);
            this.labtemplateselect_delete_btn.Name = "labtemplateselect_delete_btn";
            this.labtemplateselect_delete_btn.Size = new System.Drawing.Size(87, 26);
            this.labtemplateselect_delete_btn.TabIndex = 164;
            this.labtemplateselect_delete_btn.Text = "Delete";
            this.labtemplateselect_delete_btn.UseVisualStyleBackColor = true;
            this.labtemplateselect_delete_btn.Click += new System.EventHandler(this.labtemplateselect_delete_btn_Click);
            // 
            // labtemplateselect_newselect_btn
            // 
            this.labtemplateselect_newselect_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labtemplateselect_newselect_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labtemplateselect_newselect_btn.Location = new System.Drawing.Point(436, 21);
            this.labtemplateselect_newselect_btn.Name = "labtemplateselect_newselect_btn";
            this.labtemplateselect_newselect_btn.Size = new System.Drawing.Size(87, 26);
            this.labtemplateselect_newselect_btn.TabIndex = 163;
            this.labtemplateselect_newselect_btn.Text = "New";
            this.labtemplateselect_newselect_btn.UseVisualStyleBackColor = true;
            this.labtemplateselect_newselect_btn.Click += new System.EventHandler(this.labtemplateselect_new_btn_Click);
            // 
            // labtemplateselect_datagridview
            // 
            this.labtemplateselect_datagridview.AllowUserToAddRows = false;
            this.labtemplateselect_datagridview.AllowUserToDeleteRows = false;
            this.labtemplateselect_datagridview.AllowUserToResizeRows = false;
            this.labtemplateselect_datagridview.AutoGenerateColumns = false;
            this.labtemplateselect_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.labtemplateselect_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labtemplateselect_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.templateID,
            this.templateName,
            this.re});
            this.labtemplateselect_datagridview.DataSource = this.LabTemplateSelect_BindingSource;
            this.labtemplateselect_datagridview.Location = new System.Drawing.Point(0, 0);
            this.labtemplateselect_datagridview.Name = "labtemplateselect_datagridview";
            this.labtemplateselect_datagridview.ReadOnly = true;
            this.labtemplateselect_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.labtemplateselect_datagridview.Size = new System.Drawing.Size(430, 640);
            this.labtemplateselect_datagridview.TabIndex = 0;
            this.labtemplateselect_datagridview.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.labtemplateselect_datagridview_DataBindingComplete);
            this.labtemplateselect_datagridview.SelectionChanged += new System.EventHandler(this.labtemplateselect_datagridview_SelectionChanged);
            // 
            // templateID
            // 
            this.templateID.DataPropertyName = "TemplateID";
            this.templateID.HeaderText = "TemplateID";
            this.templateID.Name = "templateID";
            this.templateID.ReadOnly = true;
            this.templateID.Visible = false;
            // 
            // templateName
            // 
            this.templateName.DataPropertyName = "TemplateName";
            this.templateName.FillWeight = 123.8579F;
            this.templateName.HeaderText = "Template Name";
            this.templateName.Name = "templateName";
            this.templateName.ReadOnly = true;
            // 
            // re
            // 
            this.re.DataPropertyName = "Re";
            this.re.FillWeight = 76.14214F;
            this.re.HeaderText = "Re";
            this.re.Name = "re";
            this.re.ReadOnly = true;
            // 
            // LabTemplateSelect_BindingSource
            // 
            this.LabTemplateSelect_BindingSource.DataSource = typeof(PCIMS_Software.SqlObjects.labtemplate);
            // 
            // LabTemplateSelect_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "LabTemplateSelect_UserControl";
            this.Size = new System.Drawing.Size(806, 649);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.labtemplateselect_datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabTemplateSelect_BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView labtemplateselect_datagridview;
        private System.Windows.Forms.BindingSource LabTemplateSelect_BindingSource;
        private System.Windows.Forms.Button labtemplateselect_newselect_btn;
        private System.Windows.Forms.Button labtemplateselect_delete_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn re;
        private System.Windows.Forms.Button labfees_feemaintenance_btn;
        private System.Windows.Forms.Button labtemplateselect_edit_btn;
    }
}

namespace FedEx_Cargo
{
    partial class BillingFedExHev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingFedExHev));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtAWB = new System.Windows.Forms.TextBox();
            this.lblAWB = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.CbOption = new System.Windows.Forms.ComboBox();
            this.PanelB1 = new System.Windows.Forms.Panel();
            this.ucWrite1 = new FedEx_Cargo.UcWrite();
            this.ucRead1 = new FedEx_Cargo.UcRead();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ucWrite1);
            this.groupBox1.Controls.Add(this.ucRead1);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.BtnSearch);
            this.groupBox2.Controls.Add(this.txtAWB);
            this.groupBox2.Controls.Add(this.lblAWB);
            this.groupBox2.Controls.Add(this.lblTarget);
            this.groupBox2.Controls.Add(this.CbOption);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackgroundImage = global::FedEx_Cargo.Properties.Resources.search;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearch.Location = new System.Drawing.Point(759, 11);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(35, 35);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // txtAWB
            // 
            this.txtAWB.Location = new System.Drawing.Point(561, 17);
            this.txtAWB.Name = "txtAWB";
            this.txtAWB.Size = new System.Drawing.Size(192, 22);
            this.txtAWB.TabIndex = 3;
            this.txtAWB.Text = "Please Enter AWB Number";
            this.txtAWB.Click += new System.EventHandler(this.txtAWB_Click);
            // 
            // lblAWB
            // 
            this.lblAWB.AutoSize = true;
            this.lblAWB.Location = new System.Drawing.Point(493, 20);
            this.lblAWB.Name = "lblAWB";
            this.lblAWB.Size = new System.Drawing.Size(62, 16);
            this.lblAWB.TabIndex = 2;
            this.lblAWB.Text = "AWB No.";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(6, 20);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(46, 16);
            this.lblTarget.TabIndex = 1;
            this.lblTarget.Text = "Option";
            // 
            // CbOption
            // 
            this.CbOption.FormattingEnabled = true;
            this.CbOption.Items.AddRange(new object[] {
            "Read",
            "Write"});
            this.CbOption.Location = new System.Drawing.Point(58, 16);
            this.CbOption.Name = "CbOption";
            this.CbOption.Size = new System.Drawing.Size(176, 24);
            this.CbOption.TabIndex = 0;
            this.CbOption.Text = "Read";
            this.CbOption.SelectedIndexChanged += new System.EventHandler(this.CbOption_SelectedIndexChanged);
            // 
            // PanelB1
            // 
            this.PanelB1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelB1.BackColor = System.Drawing.SystemColors.Highlight;
            this.PanelB1.Location = new System.Drawing.Point(12, 62);
            this.PanelB1.Name = "PanelB1";
            this.PanelB1.Size = new System.Drawing.Size(800, 3);
            this.PanelB1.TabIndex = 0;
            // 
            // ucWrite1
            // 
            this.ucWrite1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucWrite1.Location = new System.Drawing.Point(6, 10);
            this.ucWrite1.Name = "ucWrite1";
            this.ucWrite1.Size = new System.Drawing.Size(790, 470);
            this.ucWrite1.TabIndex = 1;
            // 
            // ucRead1
            // 
            this.ucRead1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucRead1.Location = new System.Drawing.Point(4, 10);
            this.ucRead1.Name = "ucRead1";
            this.ucRead1.Size = new System.Drawing.Size(790, 470);
            this.ucRead1.TabIndex = 0;
            // 
            // BillingFedExHev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 553);
            this.Controls.Add(this.PanelB1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillingFedExHev";
            this.Text = "Manage Billing FDX Heavy Weight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BillingFedExHev_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.ComboBox CbOption;
        private System.Windows.Forms.Panel PanelB1;
        private System.Windows.Forms.TextBox txtAWB;
        private System.Windows.Forms.Label lblAWB;
        private System.Windows.Forms.Button BtnSearch;
        private UcRead ucRead1;
        private UcWrite ucWrite1;
    }
}
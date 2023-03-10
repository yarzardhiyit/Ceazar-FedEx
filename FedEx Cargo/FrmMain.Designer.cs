namespace FedEx_Cargo
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fedExHeavyWeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fDXLightWeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diamensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spotRatePricingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fedExExpressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastMinuteRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fedExLightweightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dHLExpressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPSExpressSaverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disputeInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainUI = new System.Windows.Forms.GroupBox();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.light_weight1 = new FedEx_Cargo.Light_weight();
            this.ucDiam2 = new FedEx_Cargo.UcDiam();
            this.ucIntro3 = new FedEx_Cargo.UcIntro();
            this.fdxHappy2 = new FedEx_Cargo.FdxHappy();
            this.fdxGround3 = new FedEx_Cargo.FdxGround();
            this.fdxIP2 = new FedEx_Cargo.FdxIP();
            this.ucSpotRate2 = new FedEx_Cargo.UcSpotRate();
            this.menuStrip1.SuspendLayout();
            this.MainUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageBillingToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.exitToolStripMenuItem.Text = "Home";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // manageBillingToolStripMenuItem
            // 
            this.manageBillingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fedExHeavyWeightToolStripMenuItem,
            this.fDXLightWeightToolStripMenuItem});
            this.manageBillingToolStripMenuItem.Name = "manageBillingToolStripMenuItem";
            this.manageBillingToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.manageBillingToolStripMenuItem.Text = "Manage Billing";
            // 
            // fedExHeavyWeightToolStripMenuItem
            // 
            this.fedExHeavyWeightToolStripMenuItem.Name = "fedExHeavyWeightToolStripMenuItem";
            this.fedExHeavyWeightToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.fedExHeavyWeightToolStripMenuItem.Text = "FDX Heavy Weight";
            this.fedExHeavyWeightToolStripMenuItem.Click += new System.EventHandler(this.fedExHeavyWeightToolStripMenuItem_Click);
            // 
            // fDXLightWeightToolStripMenuItem
            // 
            this.fDXLightWeightToolStripMenuItem.Name = "fDXLightWeightToolStripMenuItem";
            this.fDXLightWeightToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.fDXLightWeightToolStripMenuItem.Text = "FDX Light Weight";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diamensionToolStripMenuItem,
            this.spotRatePricingToolStripMenuItem,
            this.fedExExpressToolStripMenuItem,
            this.dHLExpressToolStripMenuItem,
            this.uPSExpressSaverToolStripMenuItem,
            this.disputeInvoiceToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // diamensionToolStripMenuItem
            // 
            this.diamensionToolStripMenuItem.Name = "diamensionToolStripMenuItem";
            this.diamensionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.diamensionToolStripMenuItem.Text = "Diamension";
            this.diamensionToolStripMenuItem.Click += new System.EventHandler(this.diamensionToolStripMenuItem_Click);
            // 
            // spotRatePricingToolStripMenuItem
            // 
            this.spotRatePricingToolStripMenuItem.Name = "spotRatePricingToolStripMenuItem";
            this.spotRatePricingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.spotRatePricingToolStripMenuItem.Text = "Spot Rate Pricing";
            this.spotRatePricingToolStripMenuItem.Click += new System.EventHandler(this.spotRatePricingToolStripMenuItem_Click);
            // 
            // fedExExpressToolStripMenuItem
            // 
            this.fedExExpressToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regularRateToolStripMenuItem,
            this.lastMinuteRateToolStripMenuItem,
            this.fedExLightweightToolStripMenuItem});
            this.fedExExpressToolStripMenuItem.Name = "fedExExpressToolStripMenuItem";
            this.fedExExpressToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fedExExpressToolStripMenuItem.Text = "FedEx Express";
            // 
            // regularRateToolStripMenuItem
            // 
            this.regularRateToolStripMenuItem.Name = "regularRateToolStripMenuItem";
            this.regularRateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.regularRateToolStripMenuItem.Text = "Regular Rate";
            this.regularRateToolStripMenuItem.Click += new System.EventHandler(this.regularRateToolStripMenuItem_Click);
            // 
            // lastMinuteRateToolStripMenuItem
            // 
            this.lastMinuteRateToolStripMenuItem.Name = "lastMinuteRateToolStripMenuItem";
            this.lastMinuteRateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lastMinuteRateToolStripMenuItem.Text = "Last-Minute Rate";
            this.lastMinuteRateToolStripMenuItem.Click += new System.EventHandler(this.lastMinuteRateToolStripMenuItem_Click);
            // 
            // fedExLightweightToolStripMenuItem
            // 
            this.fedExLightweightToolStripMenuItem.Name = "fedExLightweightToolStripMenuItem";
            this.fedExLightweightToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fedExLightweightToolStripMenuItem.Text = "FDX Light_weight";
            this.fedExLightweightToolStripMenuItem.Click += new System.EventHandler(this.fedExLightweightToolStripMenuItem_Click);
            // 
            // dHLExpressToolStripMenuItem
            // 
            this.dHLExpressToolStripMenuItem.Name = "dHLExpressToolStripMenuItem";
            this.dHLExpressToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dHLExpressToolStripMenuItem.Text = "DHL Express";
            // 
            // uPSExpressSaverToolStripMenuItem
            // 
            this.uPSExpressSaverToolStripMenuItem.Name = "uPSExpressSaverToolStripMenuItem";
            this.uPSExpressSaverToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.uPSExpressSaverToolStripMenuItem.Text = "UPS Express Saver";
            // 
            // disputeInvoiceToolStripMenuItem
            // 
            this.disputeInvoiceToolStripMenuItem.Name = "disputeInvoiceToolStripMenuItem";
            this.disputeInvoiceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.disputeInvoiceToolStripMenuItem.Text = "FDX Ground";
            this.disputeInvoiceToolStripMenuItem.Click += new System.EventHandler(this.disputeInvoiceToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUSToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUSToolStripMenuItem
            // 
            this.aboutUSToolStripMenuItem.Name = "aboutUSToolStripMenuItem";
            this.aboutUSToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.aboutUSToolStripMenuItem.Text = "About us";
            this.aboutUSToolStripMenuItem.Click += new System.EventHandler(this.aboutUSToolStripMenuItem_Click);
            // 
            // MainUI
            // 
            this.MainUI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainUI.Controls.Add(this.light_weight1);
            this.MainUI.Controls.Add(this.ucDiam2);
            this.MainUI.Controls.Add(this.ucIntro3);
            this.MainUI.Controls.Add(this.fdxHappy2);
            this.MainUI.Controls.Add(this.fdxGround3);
            this.MainUI.Controls.Add(this.fdxIP2);
            this.MainUI.Controls.Add(this.ucSpotRate2);
            this.MainUI.Location = new System.Drawing.Point(12, 31);
            this.MainUI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainUI.Name = "MainUI";
            this.MainUI.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainUI.Size = new System.Drawing.Size(776, 407);
            this.MainUI.TabIndex = 1;
            this.MainUI.TabStop = false;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRight.Location = new System.Drawing.Point(472, 368);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(264, 30);
            this.lblCopyRight.TabIndex = 2;
            this.lblCopyRight.Text = "Ceazar Calculator\r\n© 2022 Ceazar Millenium | All rights reserved.";
            // 
            // light_weight1
            // 
            this.light_weight1.BackColor = System.Drawing.Color.Transparent;
            this.light_weight1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("light_weight1.BackgroundImage")));
            this.light_weight1.Location = new System.Drawing.Point(0, 2);
            this.light_weight1.Name = "light_weight1";
            this.light_weight1.Size = new System.Drawing.Size(773, 405);
            this.light_weight1.TabIndex = 9;
            // 
            // ucDiam2
            // 
            this.ucDiam2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucDiam2.Location = new System.Drawing.Point(0, 2);
            this.ucDiam2.Name = "ucDiam2";
            this.ucDiam2.Size = new System.Drawing.Size(774, 405);
            this.ucDiam2.TabIndex = 2;
            // 
            // ucIntro3
            // 
            this.ucIntro3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucIntro3.Location = new System.Drawing.Point(0, 2);
            this.ucIntro3.Name = "ucIntro3";
            this.ucIntro3.Size = new System.Drawing.Size(774, 405);
            this.ucIntro3.TabIndex = 8;
            // 
            // fdxHappy2
            // 
            this.fdxHappy2.BackColor = System.Drawing.Color.Transparent;
            this.fdxHappy2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fdxHappy2.BackgroundImage")));
            this.fdxHappy2.Location = new System.Drawing.Point(0, 2);
            this.fdxHappy2.Name = "fdxHappy2";
            this.fdxHappy2.Size = new System.Drawing.Size(773, 405);
            this.fdxHappy2.TabIndex = 7;
            // 
            // fdxGround3
            // 
            this.fdxGround3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fdxGround3.Location = new System.Drawing.Point(1, 2);
            this.fdxGround3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fdxGround3.Name = "fdxGround3";
            this.fdxGround3.Size = new System.Drawing.Size(773, 405);
            this.fdxGround3.TabIndex = 5;
            // 
            // fdxIP2
            // 
            this.fdxIP2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fdxIP2.Location = new System.Drawing.Point(0, -1);
            this.fdxIP2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fdxIP2.Name = "fdxIP2";
            this.fdxIP2.Size = new System.Drawing.Size(773, 405);
            this.fdxIP2.TabIndex = 6;
            // 
            // ucSpotRate2
            // 
            this.ucSpotRate2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucSpotRate2.Location = new System.Drawing.Point(0, 2);
            this.ucSpotRate2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucSpotRate2.Name = "ucSpotRate2";
            this.ucSpotRate2.Size = new System.Drawing.Size(773, 405);
            this.ucSpotRate2.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.MainUI);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 495);
            this.MinimumSize = new System.Drawing.Size(818, 495);
            this.Name = "FrmMain";
            this.Text = "CeazarPay v1.0.0.34";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainUI.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diamensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spotRatePricingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fedExExpressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dHLExpressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPSExpressSaverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUSToolStripMenuItem;
        private System.Windows.Forms.GroupBox MainUI;
        private UcIntro ucIntro1;
        private UcDiam ucDiam1;
        private System.Windows.Forms.Label lblCopyRight;
        private UcSpotRate ucSpotRate1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disputeInvoiceToolStripMenuItem;
        private FdxGround FdxGround1;
        private System.Windows.Forms.ToolStripMenuItem manageBillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fedExHeavyWeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fDXLightWeightToolStripMenuItem;
        private FdxIP fdxIP1;
        private System.Windows.Forms.ToolStripMenuItem regularRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastMinuteRateToolStripMenuItem;
        private UcDiam ucDiam2;
        private UcSpotRate ucSpotRate2;
        private FdxGround fdxGround3;
        private FdxIP fdxIP2;
        private FdxHappy fdxHappy2;
        private UcIntro ucIntro3;
        private System.Windows.Forms.ToolStripMenuItem fedExLightweightToolStripMenuItem;
        private Light_weight light_weight1;
    }
}


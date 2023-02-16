namespace FedEx_Cargo
{
    partial class UcIntro
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblThanks = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(90, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 100);
            this.label2.TabIndex = 2;
            this.label2.Text = "ณตอนนี้ ทุกท่าน ที่กำลังใช้โปรแกรมนี้ อยู่ในระหว่างการตรวจสอบและ \r\nถ้ามีข้อผิดพลา" +
    "ดใดๆ ต้องอภัยทุกท่าน...\r\nแอปนี่ เป็นการตรวจสอบตั้งแต่แรก \r\nที่มีใน Menu bar แล้ว" +
    "กดเลือก Tools แล้วสามารถใช้งานได้เลย";
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(90, 14);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(120, 29);
            this.lblHead.TabIndex = 3;
            this.lblHead.Text = "สวัสดีทุกคน";
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.Location = new System.Drawing.Point(90, 222);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(147, 25);
            this.lblThanks.TabIndex = 4;
            this.lblThanks.Text = "ขอบพระคุณอย่างสูง";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(3, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 4);
            this.panel1.TabIndex = 5;
            // 
            // UcIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.label2);
            this.Name = "UcIntro";
            this.Size = new System.Drawing.Size(774, 405);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Panel panel1;
    }
}

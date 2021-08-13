namespace WorkshopAssignment
{
    partial class AvailableWorkshops
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbxStartedWorkshopss = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbxAvailableWorkshops = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Started workshops:";
            // 
            // lbxStartedWorkshopss
            // 
            this.lbxStartedWorkshopss.FormattingEnabled = true;
            this.lbxStartedWorkshopss.ItemHeight = 20;
            this.lbxStartedWorkshopss.Location = new System.Drawing.Point(8, 48);
            this.lbxStartedWorkshopss.Name = "lbxStartedWorkshopss";
            this.lbxStartedWorkshopss.Size = new System.Drawing.Size(968, 104);
            this.lbxStartedWorkshopss.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 20);
            this.panel1.TabIndex = 2;
            // 
            // lbxAvailableWorkshops
            // 
            this.lbxAvailableWorkshops.FormattingEnabled = true;
            this.lbxAvailableWorkshops.ItemHeight = 20;
            this.lbxAvailableWorkshops.Location = new System.Drawing.Point(8, 194);
            this.lbxAvailableWorkshops.Name = "lbxAvailableWorkshops";
            this.lbxAvailableWorkshops.Size = new System.Drawing.Size(968, 124);
            this.lbxAvailableWorkshops.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available workshops:";
            // 
            // AvailableWorkshops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 538);
            this.Controls.Add(this.lbxAvailableWorkshops);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbxStartedWorkshopss);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AvailableWorkshops";
            this.Text = "AvailableWorkshops";
            this.Load += new System.EventHandler(this.AvailableWorkshops_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxStartedWorkshopss;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbxAvailableWorkshops;
        private System.Windows.Forms.Label label2;
    }
}
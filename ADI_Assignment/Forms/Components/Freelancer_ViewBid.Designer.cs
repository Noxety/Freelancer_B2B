namespace Freelancer_client.Forms.Components
{
    partial class Freelancer_ViewBid
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
            this.flow_panel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flow_panel11
            // 
            this.flow_panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_panel11.Location = new System.Drawing.Point(0, 0);
            this.flow_panel11.Name = "flow_panel11";
            this.flow_panel11.Size = new System.Drawing.Size(920, 561);
            this.flow_panel11.TabIndex = 0;
            // 
            // Freelancer_ViewBid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flow_panel11);
            this.Name = "Freelancer_ViewBid";
            this.Size = new System.Drawing.Size(920, 561);
            this.Load += new System.EventHandler(this.Freelancer_ViewBid_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flow_panel11;
    }
}
